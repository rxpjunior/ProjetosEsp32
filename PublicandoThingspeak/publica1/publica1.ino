/*Leitura de valor analógico e publicação em canal do Thingspeak
*/

#include <WiFi.h> 
const char* WIFI_SSID     = "REDETESTE";
const char* WIFI_PASSWORD = "REDETESTE";
const char* host = "api.thingspeak.com";
const char* writeAPIKey = "MEUCANAL";

#define LDR     36

void setup() 
{
  Serial.begin(115200);
  delay(10);
  pinMode(LDR, INPUT);
  WiFi.begin(WIFI_SSID, WIFI_PASSWORD);
  delay(20);
  Serial.print("Conectando à ");
  Serial.println(WIFI_SSID);
  while (WiFi.status() != WL_CONNECTED) {
    delay(500);
    Serial.print(".");
  }
  Serial.println("");
  Serial.println("WiFi conectado!");
  Serial.println();
}

void loop()
{
  //Verifica se passou um minuto
  if ((millis() % (60 * 1000)) == 0) { 
  // Cria a conexão TCP
  WiFiClient client;
  const int httpPort = 80;
  // tenta conectar ao HOST, senão retorna
  if (!client.connect(host, httpPort)) {
    return;
  }

  String url = "/update?key=";
  url+=writeAPIKey;
  url+="&field1=";
  url+=String(analogRead(LDR));
  url+="\r\n";
  Serial.println(url);
  // Requisição ao servidor
  Serial.println(analogRead(LDR));
  client.print(String("GET ") + url + " HTTP/1.1\r\n" +
               "Host: " + host + "\r\n" + 
               "Connection: close\r\n\r\n");
  }
  
}
