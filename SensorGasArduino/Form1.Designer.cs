namespace SensorGasArduino
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlBarraLateral = new System.Windows.Forms.Panel();
            this.pnlImagen = new System.Windows.Forms.Panel();
            this.picEstado = new System.Windows.Forms.PictureBox();
            this.pnlLimiteCuidado = new System.Windows.Forms.Panel();
            this.cboUmbralAdvertencia = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlLimitePeligro = new System.Windows.Forms.Panel();
            this.cboUmbralPeligro = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkMostrarEncima = new System.Windows.Forms.CheckBox();
            this.pnlLectura = new System.Windows.Forms.Panel();
            this.lblUnidades = new System.Windows.Forms.Label();
            this.lblLectura = new System.Windows.Forms.Label();
            this.lblNivelLectura = new System.Windows.Forms.Label();
            this.Separador = new System.Windows.Forms.Panel();
            this.pnlTituloGrafica = new System.Windows.Forms.Panel();
            this.lblTituloGrafica = new System.Windows.Forms.Label();
            this.pnlGrafica = new System.Windows.Forms.Panel();
            this.grafica = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.notificacion = new System.Windows.Forms.NotifyIcon(this.components);
            this.lblInformacionSensor = new System.Windows.Forms.Label();
            this.numMaximoGrafica = new System.Windows.Forms.NumericUpDown();
            this.lblMaximo = new System.Windows.Forms.Label();
            this.pnlBarraLateral.SuspendLayout();
            this.pnlImagen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEstado)).BeginInit();
            this.pnlLimiteCuidado.SuspendLayout();
            this.pnlLimitePeligro.SuspendLayout();
            this.pnlLectura.SuspendLayout();
            this.pnlTituloGrafica.SuspendLayout();
            this.pnlGrafica.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grafica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaximoGrafica)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBarraLateral
            // 
            this.pnlBarraLateral.Controls.Add(this.pnlImagen);
            this.pnlBarraLateral.Controls.Add(this.pnlLectura);
            this.pnlBarraLateral.Controls.Add(this.lblNivelLectura);
            this.pnlBarraLateral.Controls.Add(this.Separador);
            this.pnlBarraLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlBarraLateral.Location = new System.Drawing.Point(0, 0);
            this.pnlBarraLateral.Name = "pnlBarraLateral";
            this.pnlBarraLateral.Size = new System.Drawing.Size(160, 341);
            this.pnlBarraLateral.TabIndex = 1;
            // 
            // pnlImagen
            // 
            this.pnlImagen.Controls.Add(this.picEstado);
            this.pnlImagen.Controls.Add(this.pnlLimiteCuidado);
            this.pnlImagen.Controls.Add(this.pnlLimitePeligro);
            this.pnlImagen.Controls.Add(this.chkMostrarEncima);
            this.pnlImagen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlImagen.Location = new System.Drawing.Point(0, 143);
            this.pnlImagen.Name = "pnlImagen";
            this.pnlImagen.Size = new System.Drawing.Size(159, 198);
            this.pnlImagen.TabIndex = 5;
            // 
            // picEstado
            // 
            this.picEstado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picEstado.Image = global::SensorGasArduino.Properties.Resources.Bien;
            this.picEstado.Location = new System.Drawing.Point(0, 0);
            this.picEstado.Name = "picEstado";
            this.picEstado.Size = new System.Drawing.Size(159, 130);
            this.picEstado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEstado.TabIndex = 0;
            this.picEstado.TabStop = false;
            // 
            // pnlLimiteCuidado
            // 
            this.pnlLimiteCuidado.Controls.Add(this.cboUmbralAdvertencia);
            this.pnlLimiteCuidado.Controls.Add(this.label1);
            this.pnlLimiteCuidado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlLimiteCuidado.Location = new System.Drawing.Point(0, 130);
            this.pnlLimiteCuidado.Name = "pnlLimiteCuidado";
            this.pnlLimiteCuidado.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.pnlLimiteCuidado.Size = new System.Drawing.Size(159, 22);
            this.pnlLimiteCuidado.TabIndex = 3;
            // 
            // cboUmbralAdvertencia
            // 
            this.cboUmbralAdvertencia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboUmbralAdvertencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUmbralAdvertencia.FormattingEnabled = true;
            this.cboUmbralAdvertencia.Items.AddRange(new object[] {
            "200",
            "300",
            "400",
            "500"});
            this.cboUmbralAdvertencia.Location = new System.Drawing.Point(108, 0);
            this.cboUmbralAdvertencia.Name = "cboUmbralAdvertencia";
            this.cboUmbralAdvertencia.Size = new System.Drawing.Size(51, 21);
            this.cboUmbralAdvertencia.TabIndex = 1;
            this.cboUmbralAdvertencia.SelectedIndexChanged += new System.EventHandler(this.umbralAdvertencia_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Umbral Advertencia:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlLimitePeligro
            // 
            this.pnlLimitePeligro.Controls.Add(this.cboUmbralPeligro);
            this.pnlLimitePeligro.Controls.Add(this.label2);
            this.pnlLimitePeligro.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlLimitePeligro.Location = new System.Drawing.Point(0, 152);
            this.pnlLimitePeligro.Name = "pnlLimitePeligro";
            this.pnlLimitePeligro.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.pnlLimitePeligro.Size = new System.Drawing.Size(159, 22);
            this.pnlLimitePeligro.TabIndex = 2;
            // 
            // cboUmbralPeligro
            // 
            this.cboUmbralPeligro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboUmbralPeligro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUmbralPeligro.FormattingEnabled = true;
            this.cboUmbralPeligro.Items.AddRange(new object[] {
            "400",
            "500",
            "600",
            "700"});
            this.cboUmbralPeligro.Location = new System.Drawing.Point(108, 0);
            this.cboUmbralPeligro.Name = "cboUmbralPeligro";
            this.cboUmbralPeligro.Size = new System.Drawing.Size(51, 21);
            this.cboUmbralPeligro.TabIndex = 2;
            this.cboUmbralPeligro.SelectedIndexChanged += new System.EventHandler(this.umbralPeligro_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Location = new System.Drawing.Point(5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Umbral Peligro:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkMostrarEncima
            // 
            this.chkMostrarEncima.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.chkMostrarEncima.Location = new System.Drawing.Point(0, 174);
            this.chkMostrarEncima.Name = "chkMostrarEncima";
            this.chkMostrarEncima.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.chkMostrarEncima.Size = new System.Drawing.Size(159, 24);
            this.chkMostrarEncima.TabIndex = 1;
            this.chkMostrarEncima.Text = "Mostrar encima";
            this.chkMostrarEncima.UseVisualStyleBackColor = true;
            this.chkMostrarEncima.CheckedChanged += new System.EventHandler(this.chkMostrarEncima_CheckedChanged);
            // 
            // pnlLectura
            // 
            this.pnlLectura.Controls.Add(this.lblUnidades);
            this.pnlLectura.Controls.Add(this.lblLectura);
            this.pnlLectura.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLectura.Location = new System.Drawing.Point(0, 73);
            this.pnlLectura.Name = "pnlLectura";
            this.pnlLectura.Padding = new System.Windows.Forms.Padding(0, 10, 25, 10);
            this.pnlLectura.Size = new System.Drawing.Size(159, 70);
            this.pnlLectura.TabIndex = 4;
            // 
            // lblUnidades
            // 
            this.lblUnidades.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUnidades.AutoSize = true;
            this.lblUnidades.BackColor = System.Drawing.Color.Transparent;
            this.lblUnidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnidades.Location = new System.Drawing.Point(120, 41);
            this.lblUnidades.Name = "lblUnidades";
            this.lblUnidades.Size = new System.Drawing.Size(41, 20);
            this.lblUnidades.TabIndex = 1;
            this.lblUnidades.Text = "ppm";
            // 
            // lblLectura
            // 
            this.lblLectura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLectura.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLectura.Location = new System.Drawing.Point(0, 10);
            this.lblLectura.Margin = new System.Windows.Forms.Padding(0);
            this.lblLectura.Name = "lblLectura";
            this.lblLectura.Size = new System.Drawing.Size(134, 50);
            this.lblLectura.TabIndex = 0;
            this.lblLectura.Text = "1000";
            this.lblLectura.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNivelLectura
            // 
            this.lblNivelLectura.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNivelLectura.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNivelLectura.Location = new System.Drawing.Point(0, 0);
            this.lblNivelLectura.Name = "lblNivelLectura";
            this.lblNivelLectura.Size = new System.Drawing.Size(159, 73);
            this.lblNivelLectura.TabIndex = 1;
            this.lblNivelLectura.Text = "Niveles de Lectura";
            this.lblNivelLectura.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Separador
            // 
            this.Separador.BackColor = System.Drawing.Color.Black;
            this.Separador.Dock = System.Windows.Forms.DockStyle.Right;
            this.Separador.Location = new System.Drawing.Point(159, 0);
            this.Separador.Name = "Separador";
            this.Separador.Size = new System.Drawing.Size(1, 341);
            this.Separador.TabIndex = 3;
            // 
            // pnlTituloGrafica
            // 
            this.pnlTituloGrafica.Controls.Add(this.lblTituloGrafica);
            this.pnlTituloGrafica.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTituloGrafica.Location = new System.Drawing.Point(160, 0);
            this.pnlTituloGrafica.Name = "pnlTituloGrafica";
            this.pnlTituloGrafica.Size = new System.Drawing.Size(524, 50);
            this.pnlTituloGrafica.TabIndex = 2;
            // 
            // lblTituloGrafica
            // 
            this.lblTituloGrafica.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTituloGrafica.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloGrafica.Location = new System.Drawing.Point(0, 0);
            this.lblTituloGrafica.Name = "lblTituloGrafica";
            this.lblTituloGrafica.Size = new System.Drawing.Size(524, 50);
            this.lblTituloGrafica.TabIndex = 0;
            this.lblTituloGrafica.Text = "Gráfica en Tiempo Real";
            this.lblTituloGrafica.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlGrafica
            // 
            this.pnlGrafica.Controls.Add(this.grafica);
            this.pnlGrafica.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrafica.Location = new System.Drawing.Point(160, 50);
            this.pnlGrafica.Name = "pnlGrafica";
            this.pnlGrafica.Size = new System.Drawing.Size(524, 291);
            this.pnlGrafica.TabIndex = 3;
            // 
            // grafica
            // 
            this.grafica.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.grafica.ChartAreas.Add(chartArea1);
            this.grafica.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.grafica.Legends.Add(legend1);
            this.grafica.Location = new System.Drawing.Point(0, 0);
            this.grafica.Name = "grafica";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Red;
            series1.Legend = "Legend1";
            series1.Name = "Lecturas";
            this.grafica.Series.Add(series1);
            this.grafica.Size = new System.Drawing.Size(524, 291);
            this.grafica.TabIndex = 0;
            this.grafica.Text = "chart1";
            // 
            // timer
            // 
            this.timer.Interval = 40000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // notificacion
            // 
            this.notificacion.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Error;
            this.notificacion.BalloonTipText = "Se ha detectado un nivel alto de gases.";
            this.notificacion.BalloonTipTitle = "Nivel Alto";
            this.notificacion.Icon = ((System.Drawing.Icon)(resources.GetObject("notificacion.Icon")));
            this.notificacion.Text = "Sensor de Gas";
            this.notificacion.Visible = true;
            // 
            // lblInformacionSensor
            // 
            this.lblInformacionSensor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInformacionSensor.BackColor = System.Drawing.Color.Transparent;
            this.lblInformacionSensor.Location = new System.Drawing.Point(561, 121);
            this.lblInformacionSensor.Name = "lblInformacionSensor";
            this.lblInformacionSensor.Size = new System.Drawing.Size(112, 172);
            this.lblInformacionSensor.TabIndex = 1;
            this.lblInformacionSensor.Text = "Alta Sensibilidad\r\n==============\r\n• Gas Natural\r\n• Gas Licuado de Petróleo (GLP)" +
    "\r\n\r\nMenor Sensibilidad\r\n==============\r\n• Gases combustibles (Propano, Butano)\r\n" +
    "• Vapor de Alcohol\r\n• Humo";
            this.lblInformacionSensor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numMaximoGrafica
            // 
            this.numMaximoGrafica.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.numMaximoGrafica.Location = new System.Drawing.Point(615, 300);
            this.numMaximoGrafica.Name = "numMaximoGrafica";
            this.numMaximoGrafica.Size = new System.Drawing.Size(50, 20);
            this.numMaximoGrafica.TabIndex = 4;
            this.numMaximoGrafica.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numMaximoGrafica.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numMaximoGrafica.ValueChanged += new System.EventHandler(this.numMaximoGrafica_ValueChanged);
            // 
            // lblMaximo
            // 
            this.lblMaximo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMaximo.AutoSize = true;
            this.lblMaximo.Location = new System.Drawing.Point(561, 302);
            this.lblMaximo.Name = "lblMaximo";
            this.lblMaximo.Size = new System.Drawing.Size(46, 13);
            this.lblMaximo.TabIndex = 6;
            this.lblMaximo.Text = "Máximo:\r\n";
            this.lblMaximo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(684, 341);
            this.Controls.Add(this.lblInformacionSensor);
            this.Controls.Add(this.lblMaximo);
            this.Controls.Add(this.numMaximoGrafica);
            this.Controls.Add(this.pnlGrafica);
            this.Controls.Add(this.pnlTituloGrafica);
            this.Controls.Add(this.pnlBarraLateral);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(595, 350);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sensor de Gas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlBarraLateral.ResumeLayout(false);
            this.pnlImagen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picEstado)).EndInit();
            this.pnlLimiteCuidado.ResumeLayout(false);
            this.pnlLimitePeligro.ResumeLayout(false);
            this.pnlLectura.ResumeLayout(false);
            this.pnlLectura.PerformLayout();
            this.pnlTituloGrafica.ResumeLayout(false);
            this.pnlGrafica.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grafica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaximoGrafica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlBarraLateral;
        private System.Windows.Forms.Label lblNivelLectura;
        private System.Windows.Forms.Panel Separador;
        private System.Windows.Forms.Panel pnlTituloGrafica;
        private System.Windows.Forms.Panel pnlGrafica;
        private System.Windows.Forms.Label lblTituloGrafica;
        private System.Windows.Forms.Panel pnlImagen;
        private System.Windows.Forms.Panel pnlLectura;
        private System.Windows.Forms.Label lblLectura;
        private System.Windows.Forms.PictureBox picEstado;
        private System.Windows.Forms.Label lblUnidades;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.NotifyIcon notificacion;
        private System.Windows.Forms.DataVisualization.Charting.Chart grafica;
        private System.Windows.Forms.Label lblInformacionSensor;
        private System.Windows.Forms.NumericUpDown numMaximoGrafica;
        private System.Windows.Forms.Label lblMaximo;
        private System.Windows.Forms.CheckBox chkMostrarEncima;
        private System.Windows.Forms.Panel pnlLimiteCuidado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlLimitePeligro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboUmbralAdvertencia;
        private System.Windows.Forms.ComboBox cboUmbralPeligro;
    }
}

