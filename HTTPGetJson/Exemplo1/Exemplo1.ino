/*
Fontes de pesquisa
https://randomnerdtutorials.com/esp32-http-get-post-arduino/
https://forum.arduino.cc/t/esp32-forecast-fail-to-get-object/1008486
https://forum.arduino.cc/t/parsing-with-the-arduino_json-h-library/686791
*/

#include <WiFi.h>
#include <HTTPClient.h>
#include <Arduino_JSON.h>

//Dados da rede
const char* ssid = "REDETESTE";
const char* password = "Tatanka*20000";

//URL da API
const char* serverName = "http://api.hgbrasil.com/weather?woeid=455871&array_limit=1&fields=only_results,temp,city_name,forecast,max,min,date,rain_probability&key=416dac31";

unsigned long ultimoDisparo = 0;
// Timer para 60 minutos (3600000)
// Timer para 10 minutos (600000)
// Timer para 5 seconds (5000)
unsigned long tempoDecorrido = 5000;

//String que recebe o resultado da consulta a API
String retornoConsulta;


void setup() {
  Serial.begin(115200);

  WiFi.begin(ssid, password);
  Serial.println("Conectando");
  while(WiFi.status() != WL_CONNECTED) {
    delay(500);
    Serial.print(".");
  }
  Serial.println("");
  Serial.print("Conectado a rede com o seguinte IP: ");
  Serial.println(WiFi.localIP());
 
  Serial.println("A primeira consulta será feita de acordo com o tempo configurado para que elas se repitam");
}

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

void loop() {
  //Faz a consulta de acordo com o tempo indicado na variável tempo decorrido
  if ((millis() - ultimoDisparo) > tempoDecorrido) {
    //Verifica a conexão WiFi
    if(WiFi.status()== WL_CONNECTED){
              
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
    
      Serial.print("Chaves do Json: ");
      Serial.println(keys);
      Serial.print("Data: ");
      Serial.println(meuObjeto["date"]); //pegando o valor com a chave date
      Serial.print("Temperatura atual: "); 
      Serial.println(meuObjeto["temp"]);//pegando o valor com a chave Temperatura atual
      Serial.print("Probabilidade de Chuva: ");
      Serial.println(meuObjeto["forecast"][0]["rain_probability"]); //O retorno é uma lista, 0 indica o indice do objeto
      Serial.print("Temperatura Minima: ");
      Serial.println(meuObjeto["forecast"][0]["min"]); //O retorno é uma lista, 0 indica o indice do objeto
      Serial.print("Temperatura Maxima: ");
      Serial.println(meuObjeto["forecast"][0]["max"]); //O retorno é uma lista, 0 indica o indice do objeto

    }
    
    else {
      Serial.println("WiFi Desconectado");
    }
    ultimoDisparo = millis();
  }
}