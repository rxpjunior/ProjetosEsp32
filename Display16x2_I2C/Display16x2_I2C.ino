/*********
Exibir texto em display 16X2 com I2C
 Fonte: https://randomnerdtutorials.com/esp32-esp8266-i2c-lcd-arduino-ide/ 
 obs: a biblioteca do tutorial pode não funcionar para todos os dispositivos
*********/

#include <LiquidCrystal_I2C.h>

// Configurar o numero de colunas e linhas do display
int lcdColunas = 16;
int lcdLinhas = 2;

// Instanciar o display com seu endereço, linhas e colunas
// No link acima é possível ver como encontrar este endereço
LiquidCrystal_I2C lcd(0x27, lcdColunas, lcdLinhas);  

void setup(){
  // Inicializa o LCD
  lcd.init();
  // Liga a luz de fundo do display                      
  lcd.backlight();
}

void loop(){
  // Configurar o display na primeira coluna e primeira linha
  lcd.setCursor(0, 0);
  // Imprime a mensagem
  lcd.print("Hello, World!");
  delay(1000);
  // Limpa do display
  lcd.clear();
  // Configurar o display para primeira coluna e segunda linha
  lcd.setCursor(0,1);
  // Imprime a mensagem
  lcd.print("Hello, World!");
  delay(1000);
  // limpa do display
  lcd.clear(); 
}