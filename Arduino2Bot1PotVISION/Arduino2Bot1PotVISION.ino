//Inicio los potenciómetros en los pines analógicos A2 A3 A4 y el botón en el pin digital 7
int PotenciometroAnalog1 = A0;
const int BotonDigital1 = 6;
const int BotonDigital2 = 7;

//Variable donde se almacenan los datos recibidos
int dato1 = 0;
int dato2 = 0;
int dato3 = 0;

//Variable donde se almacenan los datos ya mapeados
int Mapeado1;

void setup() {
  //Inicialización de los potenciómetros
  Serial.begin(9600);
  pinMode(PotenciometroAnalog1, INPUT);
  pinMode(BotonDigital1, INPUT);
  pinMode(BotonDigital2, INPUT);

  digitalWrite(BotonDigital1, HIGH);
  digitalWrite(BotonDigital2, HIGH);

}

void loop() {
  //Almacenar los datos de los potenciómetros en la variable
  dato1 = analogRead(PotenciometroAnalog1);

  //Mapeo de los datos almacenados en la linea anterior
//  Mapeado1 = map(dato1, 0, 1024, 0, 1024);

  if (digitalRead(BotonDigital1) == HIGH) // if the switch is pressed
  {
    dato2 = 1;
  }
  else if (digitalRead(BotonDigital1) == LOW) {
    dato2 = 0;
  }


  if (digitalRead(BotonDigital2) == HIGH) // if the switch is pressed
  {
    dato3 = 1;
  }
  else if (digitalRead(BotonDigital2) == LOW) {
    dato3 = 0;
  }
  Serial.print(dato1);
  Serial.print(",");
  Serial.print(dato2);
  Serial.print(",");
  Serial.println(dato3);
  Serial.flush();
  delay(20);
}







//Fin del código
