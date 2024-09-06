// FUNCAO LEDC MUDOU NA VERSAO 3. ESTE ESBOÇO FUNCIONA APENAS EM VERSOES ANTIGAS

// O numero do pino do Led
const int ledPin = 25;  // D25 - GPIO25

// configurando propriedades do PWM
const int frequencia = 5000;
const int canalLed = 0;
const int resolucao = 8;
 
void setup(){
  // configurando as funcionalidades do Led PWM
  ledcSetup(canalLed, frequencia, resolucao);
  
  // atachar o canal 
  ledcAttachPin(ledPin, canalLed);
}
 
void loop(){
  // incrementando o brilho do Led
  for(int dutyCycle = 0; dutyCycle <= 255; dutyCycle++){   
    // Alterando o brilho com PWM
    ledcWrite(canalLed, dutyCycle);
    delay(15);
  }

  // decementando o briho do Led
  for(int dutyCycle = 255; dutyCycle >= 0; dutyCycle--){
    // Alterando o brilho com PWM
    ledcWrite(canalLed, dutyCycle);   
    delay(15);
  }
}
