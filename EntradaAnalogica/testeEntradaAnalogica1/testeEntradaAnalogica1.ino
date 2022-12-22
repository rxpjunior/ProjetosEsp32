/*Testando duas entradas analogicas simultaneas no ESP32
 * Usando os pinos VP(GPIO36) e VN(GPIO39)
 */

#define SENSOR_LUMINOSIDADE1 36 // ESP32 pino GPIO36 (ADC1)
#define SENSOR_LUMINOSIDADE2 39 // ESP32 pino GPIO39 (ADC3)

void setup() {
  // Inicializando a comunicacao:
  Serial.begin(115200);
  // Declarando os pinos como entrada
  pinMode(SENSOR_LUMINOSIDADE1, INPUT);
  pinMode(SENSOR_LUMINOSIDADE2, INPUT);
}

void loop() {
  //Le o valor de entrada (valor entre 0 e 4095)
  int valorAnalogico1 = analogRead(SENSOR_LUMINOSIDADE1);
  int valorAnalogico2 = analogRead(SENSOR_LUMINOSIDADE2);

  // Leitura dos valores no Pino 36
  Serial.print("Valor Analogico pino VP(36)  = ");
  Serial.println(valorAnalogico1); 
  
  if (valorAnalogico1 < 40) {
    Serial.println("Sensor Luminosidade 1 => Escuro");
  } else if (valorAnalogico1 < 800) {
    Serial.println("Sensor Luminosidade 1 => Meio escuro");
  } else if (valorAnalogico1 < 2000) {
    Serial.println("Sensor Luminosidade 1 => Claro");
  } else if (valorAnalogico1 < 3200) {
    Serial.println("Sensor Luminosidade 1 => Bem claro");
  } else {
    Serial.println("Sensor Luminosidade 1 => Claríssimo");
  }
  
  Serial.println("\n");

  //Leitura dos valores do Pino 39
  Serial.print("Valor Analogico pino UN(39)  = ");
  Serial.println(valorAnalogico2);    

  if (valorAnalogico1 < 40) {
    Serial.println("Sensor Luminosidade 2 => Escuro");
  } else if (valorAnalogico2 < 800) {
    Serial.println("Sensor Luminosidade 2 => Meio escuro");
  } else if (valorAnalogico2 < 2000) {
    Serial.println("Sensor Luminosidade 2 => Claro");
  } else if (valorAnalogico2 < 3200) {
    Serial.println("Sensor Luminosidade 2 => Bem claro");
  } else {
    Serial.println("Sensor Luminosidade 2 => Claríssimo");
  }

  Serial.println("\n");

  delay(10000);
}
