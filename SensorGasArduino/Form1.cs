using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace SensorGasArduino{
    public partial class Form1 : Form {
        List<int> lecturas = new List<int>() { 1 };
        SerialPort Arduino = new SerialPort("COM4", 9600);
        bool abierto = true;
        bool aviso = false;
        int numero, numMaximoGraf = 10, umbralAdv = 300, umbralPel = 500;

        public Form1(){
            InitializeComponent();
            cboUmbralAdvertencia.SelectedIndex = 1;
            cboUmbralPeligro.SelectedIndex = 1;
            Arduino.ReadTimeout = 1000;
            grafica.ChartAreas["ChartArea1"].AxisX.Minimum = 0;
            grafica.ChartAreas["ChartArea1"].AxisX.Maximum = 10;
            grafica.Series["Lecturas"].BorderWidth = 4;
            grafica.Series["Lecturas"].Color = Color.Red;
            grafica.Series["Lecturas"].Legend = "Legend1";
            grafica.Series["Lecturas"].ChartArea = "ChartArea1";
            grafica.Series["Lecturas"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
        }

        private void Form1_Load(object sender, EventArgs e){
            Thread Hilo = new Thread(EscucharSerial);
            Hilo.Start();
            Arduino.Open();
            Arduino.Write("E");
            Arduino.Write("e");
        }
        
        private void EscucharSerial(){
            while (abierto){
                try{
                    numero = int.Parse(Arduino.ReadLine());
                    lblLectura.Invoke(new MethodInvoker(delegate{
                        refrescarEstado();
                        refrescarInterfaz();
                    }));
                }
                catch (Exception) { }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e){
            abierto = false;
            if (Arduino.IsOpen)
                Arduino.Close();
            timer.Stop();
        }

        private void refrescarInterfaz(){
            int maximo = lecturas.Max(item => item);
            grafica.ChartAreas["ChartArea1"].AxisY.Maximum = (maximo + 100);
            if (lecturas.Count <= numMaximoGraf)
                lecturas.Add(numero);
            else{
                lecturas.RemoveAt(0);
                lecturas.Add(numero);
            }
            grafica.Series["Lecturas"].Points.Clear();
            int inicio;
            if (numMaximoGraf >= lecturas.Count) inicio = 0;
            else inicio = lecturas.Count - numMaximoGraf;
            int contador = 0;
            for (int i = inicio; i <= lecturas.Count; i++) {
                grafica.Series["Lecturas"].Points.AddXY(contador, lecturas[i]);
                contador++;
            }
        }

        private void refrescarEstado() {
            Color fondo, letras;
            if (numero > umbralPel){
                fondo = Color.Red;
                letras = Color.White;
                picEstado.Image = Properties.Resources.Mal;
                if (!aviso){
                    notificacion.ShowBalloonTip(100);
                    aviso = true;
                    timer.Start();
                }
            }
            else if (numero > umbralAdv){
                fondo = Color.Gold;
                letras = Color.Black;
                picEstado.Image = Properties.Resources.Cuidado;
            }
            else{
                fondo = SystemColors.Control;
                letras = Color.Black;
                picEstado.Image = Properties.Resources.Bien;
            }
            pnlLectura.BackColor = fondo;
            lblLectura.ForeColor = letras;
            lblUnidades.ForeColor = letras;
            lblLectura.Text = numero.ToString();
        }

        private void timer_Tick(object sender, EventArgs e){
            timer.Stop();
            aviso = false;
        }

        private void numMaximoGrafica_ValueChanged(object sender, EventArgs e) {
            try {
                numMaximoGraf = int.Parse(numMaximoGrafica.Value.ToString());
                grafica.ChartAreas["ChartArea1"].AxisX.Maximum = numMaximoGraf;
            }
            catch (Exception) { }
        }

        private void chkMostrarEncima_CheckedChanged(object sender, EventArgs e) {
            this.TopMost = chkMostrarEncima.Checked;
        }

        private void umbralAdvertencia_SelectedIndexChanged(object sender, EventArgs e) {
            if (int.Parse(cboUmbralAdvertencia.Text) < umbralPel)
                umbralAdv = int.Parse(cboUmbralAdvertencia.Text);
            else {
                cboUmbralAdvertencia.Text = umbralAdv.ToString();
                MessageBox.Show("El umbral de advertencia debe ser menor al umbral de peligro.", "Error al modificar el umbral", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }                
            string mandar = "";
            switch (cboUmbralAdvertencia.Text) {
                case "200":
                    mandar = "a";
                break;
                case "300":
                    mandar = "e";
                    break;
                case "400":
                    mandar = "i";
                    break;
                case "500":
                    mandar = "o";
                    break;
            }
            try {
                Arduino.WriteLine(mandar);
            }catch(Exception) { }
        }

        private void umbralPeligro_SelectedIndexChanged(object sender, EventArgs e) {
            if (int.Parse(cboUmbralPeligro.Text) > umbralAdv)
                umbralPel = int.Parse(cboUmbralPeligro.Text);
            else {
                cboUmbralPeligro.Text = umbralPel.ToString();
                MessageBox.Show("El umbral de peligro debe ser mayor al umbral de advertencia.", "Error al modificar el umbral", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            umbralPel = int.Parse(cboUmbralPeligro.Text); 
            string mandar = "";
            switch (cboUmbralPeligro.Text) {
                case "400":
                    mandar = "A";
                    break;
                case "500":
                    mandar = "E";
                    break;
                case "600":
                    mandar = "I";
                    break;
                case "700":
                    mandar = "O";
                    break;
                case "900":
                    mandar = "U";
                    break;
            }
            try {
                Arduino.WriteLine(mandar);
            }
            catch (Exception) { }
        }
    }
}
