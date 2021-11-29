int GAS;
int LED = 2;
int BUZZER = 3;
int advertencia = 300;
int peligro = 500;
int configuracion;

void setup(){
  Serial.begin(9600);
  pinMode(A0, INPUT);
  pinMode(LED, OUTPUT);
  pinMode(BUZZER, OUTPUT);
}

void loop(){
  GAS = analogRead(A0);
  Serial.println(GAS);
  if(Serial.available()>0){
    configuracion = Serial.read();
    if(configuracion == 'A'){
      peligro = 400;
    }
    else if(configuracion == 'a'){
      advertencia = 200;
    }
    else if(configuracion == 'E'){
      peligro = 500;
    }
    else if(configuracion == 'e'){
      advertencia = 300;
    }
    else if(configuracion == 'I'){
      peligro = 600;
    }
    else if(configuracion == 'i'){
      advertencia = 400;
    }
    else if(configuracion == 'O'){
      peligro = 700;
    }
    else if(configuracion == 'o'){
      advertencia = 500;
    }
  }
  if(GAS > peligro){
    digitalWrite(LED, HIGH);
    digitalWrite(BUZZER, HIGH);
    delay(500);
    digitalWrite(LED, LOW);
    digitalWrite(BUZZER, LOW);
  }
  else if(GAS > advertencia){
    digitalWrite(LED, HIGH);
    delay(250);
    digitalWrite(LED, LOW);
    delay(250);
  }
  else{
    delay(500);
  }
}
