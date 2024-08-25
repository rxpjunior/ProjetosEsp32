//Bibliotecas
//WIFI
#include <DNSServer.h>
#include <WiFiManager.h>
#include <WiFi.h>
#include <WebServer.h>

//Define o pino para reset das definicoes de wifi
int pino_reset = 4;

//Setup WiFi Manager
void setupWiFi(){
  WiFiManager wifiManager;
  wifiManager.setConfigPortalTimeout(240);
  //Cria um AP (Access Point) com: ("nome da rede", "senha da rede")
  if (!wifiManager.autoConnect("InformaChuva", "chuva prev")) {
    Serial.println(F("Falha na conexao. Resetar e tentar novamente..."));
    delay(3000);
    ESP.restart();
    delay(5000);
  }
  //Mensagem caso conexao Ok
  Serial.println(F("Conectado na rede Wifi."));
  Serial.print(F("Endereco IP: "));
  Serial.println(WiFi.localIP());
}

//Funcao para configurar o Wi-Fi
void configWiFi(){
  //Apaga os dados da rede wifi gravados na memoria e reinicia o ESP
    WiFiManager wifiManager;
    wifiManager.resetSettings();
    Serial.println("Configuracoes zeradas!");
    ESP.restart();
}

void setup() {
  Serial.begin(115200);
  delay(10);
  pinMode(pino_reset, INPUT);
  setupWiFi(); 
}

void loop() {
  //Verifica se o botao foi pressionado
  int valor = digitalRead(pino_reset);
  if (valor == 1) {
    configWiFi();
  }
}