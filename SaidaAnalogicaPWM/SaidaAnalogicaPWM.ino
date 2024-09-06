/*
PWM COM ESCRITA ANALOGICA (ANALOGWRITE)
 Baseado em https://RandomNerdTutorials.com/esp32-pwm-arduino-ide/
*/

// O NUMERO DO PINO DO LED
const int ledPin = 2;  // 2 CORRESPONDE AO LED INTERNO

void setup() {
  // CONFIGURANDO PINO COMO SAIDA
  pinMode(ledPin, OUTPUT);
}

void loop(){
  // MEUMENTANDO O BRILHO DO LED
  for(int dutyCycle = 0; dutyCycle <= 255; dutyCycle++){   
    // AUMENTANDO COM PWM
    analogWrite(ledPin, dutyCycle);
    delay(15);
  }

  // DIMINUINDO O BRILHO DO LED
  for(int dutyCycle = 255; dutyCycle >= 0; dutyCycle--){
    // DIMINUINDO COM PWM
    analogWrite(ledPin, dutyCycle);
    delay(15);
  }
}
