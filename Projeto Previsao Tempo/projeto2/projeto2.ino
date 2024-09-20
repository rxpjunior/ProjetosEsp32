/*
Projeto2 Operacional:
WiFi Manager
Consulta HTTP API
Escrita na tela
*/

//Bibliotecas
//WIFI
#include <DNSServer.h>
#include <WiFiManager.h>
#include <WiFi.h>
#include <WebServer.h>
//HTTP
#include <HTTPClient.h>
#include <Arduino_JSON.h>
//Display
#include <LiquidCrystal_I2C.h>
//WebSockets
#include <WebSocketsServer.h>

//Define o pino para reset das definicoes de wifi
int pino_reset = 4;

//URL da API
const char* serverName = "http://api.hgbrasil.com/weather?woeid=455871&array_limit=1&fields=only_results,temp,city_name,forecast,max,min,date,rain_probability&key=416dac31";

//Intervalos do Disparador 
unsigned long ultimoDisparo = 0;
// Timer para 60 minutos (3600000)
// Timer para 10 minutos (600000)
// Timer para 1 minuto (60000)
// Timer para 5 seconds (5000)
unsigned long tempoDecorrido = 60000;

// Controle para carregamento da API na inicializacao
int controle = 1;

//String que recebe o resultado da consulta a API
String retornoConsulta;

//Variaveis para salvar os resultados da pesquisa
String data;
String tempAtual;
String probChuva;
String tempMin;
String tempMax;

//Variaveis para armazenar as mensagens que serao exibidas no display
String msg1;
String msg2;

// Configurar o numero de colunas e linhas do display
int lcdColunas = 16;
int lcdLinhas = 2;

// Instanciar o display com seu endereço, linhas e colunas
// No link acima é possível ver como encontrar este endereço
LiquidCrystal_I2C lcd(0x27, lcdColunas, lcdLinhas);  

//Cria uma instancia do WebSocket na porta 81
WebSocketsServer webSocket = WebSocketsServer(81);

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
//Funcao com a Requisicao HTTP
String httpGETRequest(const char* serverName) {
  WiFiClient client;
  HTTPClient http;
    
  // Seu nome de domínio com caminho URL ou endereço IP com caminho
  http.begin(client, serverName);
    
  // Enviando requisição HTTP GET
  int httpResponseCode = http.GET();
  
  String payload = "{}"; 
  
  if (httpResponseCode>0) {
    Serial.print("Código de resposta HTTP: ");
    Serial.println(httpResponseCode);
    payload = http.getString();
  }
  else {
    Serial.print("Código de erro: ");
    Serial.println(httpResponseCode);
  }
  // Liberando recursos
  http.end();

  return payload;
}
//Funcao para escrever dados na tela
void escreveNaTela(String msg1, String msg2){
  lcd.clear();
  delay(1000);
  lcd.setCursor(0, 0);
  lcd.print(msg1);
  lcd.setCursor(0, 1);
  lcd.print(msg2);
}

//Funcao para buscar os dados na API
void buscaDadosApi(){
retornoConsulta = httpGETRequest(serverName);
      Serial.printf("Exibindo o retorno da consulta no formato String: ");
      Serial.println(retornoConsulta);
      //Convertendo o retorno para o formato Json
	    JSONVar meuObjeto = JSON.parse(retornoConsulta);
  
      // JSON.typeof(jsonVar) pode ser usado para pegar o tipo de uma variável
      if (JSON.typeof(meuObjeto) == "undefined") {
        Serial.println("A conversão falhou!");
        return;
      }

      Serial.print("Exibindo o retorno convertido em Json: ");
      Serial.println(meuObjeto);
    
      // meuObjeto.keys() pode ser usado para obter uma matriz de todas as chaves no objeto
      JSONVar keys = meuObjeto.keys();
      //Salvando os dados necessários em variaveis
      data = JSON.stringify(meuObjeto["date"]);
      tempAtual = JSON.stringify(meuObjeto["temp"]);
      probChuva = JSON.stringify(meuObjeto["forecast"][0]["rain_probability"]);
      tempMin = JSON.stringify(meuObjeto["forecast"][0]["min"]);
      tempMax = JSON.stringify(meuObjeto["forecast"][0]["max"]);

      //Montando a String para exibicao no display
      msg1 = "Prob Chuva: "+probChuva+"%";
      msg2 = "MIN "+tempMin+"C"+" MAX "+tempMax+"C";

      //Chamando a funcao para escrever na tela
      escreveNaTela(msg1, msg2);
      
      Serial.print("Chaves do Json: ");
      Serial.println(keys);
      Serial.print("Data: ");
      Serial.println(data); //pegando o valor com a chave date
      Serial.print("Temperatura atual: "); 
      Serial.println(tempAtual);//pegando o valor com a chave Temperatura atual
      Serial.print("Probabilidade de Chuva: ");
      Serial.println(probChuva); //O retorno é uma lista, 0 indica o indice do objeto
      Serial.print("Temperatura Minima: ");
      Serial.println(tempMin); //O retorno é uma lista, 0 indica o indice do objeto
      Serial.print("Temperatura Maxima: ");
      Serial.println(tempMax); //O retorno é uma lista, 0 indica o indice do objeto
}

void exibeMsgConfWifi(){
  lcd.clear();
  lcd.setCursor(0, 0);
  lcd.print("Configure");
  lcd.setCursor(0, 1);
  lcd.print("WIFI");
}

void setup() {
  //Geral
  Serial.begin(115200);
  pinMode(pino_reset, INPUT);
  //Wifi
  setupWiFi(); 
  delay(10);
  //Inicializa o LCD
  lcd.init();
  // Liga a luz de fundo do display                      
  lcd.backlight();
  //WebSocket
  webSocket.begin(); // Inicia o servidor WebSocket
}

void loop() {
 //Mantém o servidor WebSocket em execução, verificando por novas conexões e mensagens
  webSocket.loop();

  //Verifica se o botao foi pressionado e se sim reseta o Wifi para reconfiguracao
  int valor = digitalRead(pino_reset);
  if (valor == 1) {
    exibeMsgConfWifi();
    configWiFi();
  }

  //Buscar os dados da API imediatamente ao ligar e depois bloco eh desabilitado
  if (controle){
    buscaDadosApi();
    controle=0;
  }

  //Faz a consulta HTTP de acordo com o tempo indicado na variável tempo decorrido
  if ((millis() - ultimoDisparo) > tempoDecorrido) {
    //Verifica a conexão WiFi
    if(WiFi.status()== WL_CONNECTED){
      buscaDadosApi();
      webSocket.broadcastTXT(retornoConsulta);         
    }
    else {
      exibeMsgConfWifi();
      Serial.println("WiFi Desconectado");
    }
    ultimoDisparo = millis();
  }
}