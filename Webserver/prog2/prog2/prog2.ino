// Baseado no arduino IDE Example
// Acendimento de LED em ESP32

#include <WiFi.h>

const char* ssid     = "REDETESTE";
const char* password = "REDETESTE";

#define pinLed 25

WiFiServer server(80);

void setup()
{
    Serial.begin(115200);
    pinMode(pinLed, OUTPUT);      // Pino de acendimento do LED

    delay(10);

    // Conexao com a rede WiFi

    Serial.println();
    Serial.println();
    Serial.print("Conectando a ");
    Serial.println(ssid);

    WiFi.begin(ssid, password);

    while (WiFi.status() != WL_CONNECTED) {
        delay(500);
        Serial.print(".");
    }

    Serial.println("");
    Serial.println("WiFi Conectado.");
    Serial.println("Endereco IP: ");
    Serial.println(WiFi.localIP());
    
    server.begin();

}

int value = 0;

void loop(){
 WiFiClient client = server.available();   // Ouvindo clientes recebidos

  if (client) {                             // Se houver um cliente,
    Serial.println("Novo cliente.");        // Imprima a mensagem no serial port
    String currentLine = "";                // faca uma String para manter os dados recebidos do cliente
    while (client.connected()) {            // loop enquanto o cliente está conectado
      if (client.available()) {             // se houver bytes para ler do cliente,
        char c = client.read();             // ler um byte, então
        Serial.write(c);                    // imprima no monitor serial
        if (c == '\n') {                    // se o byte for um caractere de nova linha

          // se a linha atual estiver em branco, você terá dois caracteres de nova linha seguidos.
          // esse é o fim da solicitação HTTP do cliente, então envie uma resposta:
          if (currentLine.length() == 0) {
            // Os cabeçalhos HTTP sempre começam com um código de resposta (e.g. HTTP/1.1 200 OK)
            // e um tipo de conteúdo para que o cliente saiba o que está por vir e uma linha em branco:
            client.println("HTTP/1.1 200 OK");
            client.println("Content-type:text/html");
            client.println();

            // o conteúdo da resposta HTTP segue o cabeçalho:
            client.print("Clique <a href=\"/H\">Aqui</a> para ligar o LED.<br>");
            client.print("Clique <a href=\"/L\">Aqui</a> para desligar o LED.<br>");

            // A resposta HTTP termina com outra linha em branco:
            client.println();
            // sair do loop while:
            break;
          } else {    // se você tiver uma nova linha, limpe currentLine:
            currentLine = "";
          }
        } else if (c != '\r') {  // se você tiver qualquer outra coisa além de um caractere de retorno de carro,
          currentLine += c;      // adicione-o ao final da currentLine
        }

        // Verifique se a solicitação do cliente foi "GET /H" ou "GET /L":
        if (currentLine.endsWith("GET /H")) {
          digitalWrite(pinLed, HIGH);               // GET /H acende o LED
        }
        if (currentLine.endsWith("GET /L")) {
          digitalWrite(pinLed, LOW);                // GET /L desliga o LED
        }
      }
    }
    // fechando a conexao:
    client.stop();
    Serial.println("Cliente Desconectado.");
  }
}
