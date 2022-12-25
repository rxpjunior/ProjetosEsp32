/*Exemplo de Leitura de um Json usando uma API que retona um conselho a cada acesso 
 * Link da API - https://api.adviceslip.com/#endpoint-random
 * Link do projeto no qual me baseei - https://www.dobitaobyte.com.br/como-ler-json-no-esp32/
 * 
 */
//Bibliotecas necessarias 
#include <Arduino.h>
#include <WiFi.h>
#include <HTTPClient.h>
#include "ArduinoJson.h"

//Dados de acesso a rede Wifi
#define SSID "REDETESTE"
#define PASSWD "REDETESTE"

//0 - Criamos o objeto de comunicação HTTP
HTTPClient http;
char json[400] = {0};

//1 - acesse arduinojson.org/v6/assistant e passe uma amostra pra calcular a capacidade
/*Objeto que armazenara o Json na memoria
 *Para mais informacoes consultar https://arduinojson.org/v6/how-to/determine-the-capacity-of-the-jsondocument/
 */
  const size_t capacity = JSON_OBJECT_SIZE(1) + JSON_ARRAY_SIZE(8) + 146;
  DynamicJsonDocument doc(capacity);

//Funcao que retornará o resultado Json consultado e ira desmembra-lo para uso
void resultadoGet(String msg){
    memset(json,0,sizeof(json)); //Limpa o objeto jso antes de usar
    msg.toCharArray(json, 400); //Converte o resultado em um Array
    deserializeJson(doc, json); 
    JsonObject conselho = doc["slip"]; // Objeto que recebera o Json desmembrado
    int slip_id = doc["slip"]["id"];
    const char* conselho_advice = doc["slip"]["advice"]; 
    Serial.println(conselho_advice); //Desejo imprimir apenas esta parte
}

void setup(){
  //2 - Para testar, vamos usar a serial
  Serial.begin(115200);

  //3 - iniciamos a conexão WiFi...
  WiFi.begin(SSID,PASSWD);
  Serial.print("Conectando a ");
  Serial.println(SSID);
  //4...e aguardamos até que esteja concluída.
  while (WiFi.status() != WL_CONNECTED) {
    delay(1000);
    Serial.print("*");
  }
  Serial.println("*");
  Serial.println("Conectado!");
}

void loop() {
    //5 - iniciamos a URL alvo, pega a resposta e finaliza a conexão
    http.begin("https://api.adviceslip.com/advice");
    int httpCode = http.GET();
    if (httpCode > 0) { //Maior que 0, tem resposta a ser lida
        String payload = http.getString();
        //Serial.println(httpCode);
        //Serial.println(payload);
        resultadoGet(payload);
    }
    else {
        Serial.println("Falha na requisição");
    }
    http.end();
    //Tempo de aguardo para novo processamento
    //Mais informacoes em https://www.dobitaobyte.com.br/esp32-delay-vtaskdelay-vtaskdelayuntil-millis/
    vTaskDelay(pdMS_TO_TICKS(60000));
}
