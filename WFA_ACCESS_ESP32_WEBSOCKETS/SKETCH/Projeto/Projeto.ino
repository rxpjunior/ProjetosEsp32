#include <WiFi.h> // Inclui a biblioteca WiFi para conectar o ESP32 à rede WiFi
#include <WebSocketsServer.h> // Inclui a biblioteca WebSocketsServer paracriar um servidor WebSocket
//#include <ESP32Servo.h> // Inclui a biblioteca Servo para controlar o servo motor
const char* ssid = "REDETESTE"; // Define o SSID (nome) da rede WiFi
const char* senhaWiFi = "Tatanka*20000"; // Define a senha da rede WiFi
const int pinoLED = 2; // Define o pino do LED embarcado, geralmente o pino 2
const int pinoLDR = 36; // Define o pino analógico para o LDR (use um pino analógico adequado no seu ESP32)
//const int pinoServo = 17; // Define o pino digital para o servo motor
WebSocketsServer webSocket = WebSocketsServer(81); // Cria uma instância do servidor WebSocket na porta 81
//Servo servo; // Cria uma instância do objeto Servo
unsigned long ultimoTempoEnvio = 0; // Armazena o último tempo em que a leitura foi enviada
const unsigned long intervaloEnvio = 10000; // Intervalo de 10 segundos que pode ser alterado
void setup() {
  Serial.begin(115200); // Inicializa a comunicação serial a 115200 bps para debug
  pinMode(pinoLED, OUTPUT); // Configura o pino do LED como saída
  digitalWrite(pinoLED, LOW); // Inicializa o LED como desligado
 //servo.attach(pinoServo, 800, 3000); // Anexa o servo ao pino definido
  WiFi.begin(ssid, senhaWiFi); // Conecta-se à rede WiFi usando o SSID e a senha fornecidos
  while (WiFi.status() != WL_CONNECTED) { // Loop até que a conexão WiFi seja estabelecida
    delay(1000); // Espera 1 segundo
    Serial.println("Conectando no WiFi..."); // Imprime mensagem de conexão ao WiFi
 }
 Serial.println("Conectou no WiFi"); // Imprime mensagem de conexão bemsucedida ao WiFi
 // Exibe o endereço IP do ESP32
 Serial.print("IP do ESP32 na Rede Conectada: "); // Imprime rótulo para o endereço IP
 Serial.println(WiFi.localIP()); // Imprime o endereço IP local do ESP32
 webSocket.begin(); // Inicia o servidor WebSocket
 webSocket.onEvent(webSocketEvent); // Define a função de callback para eventos do WebSocket
}
void loop() {
 webSocket.loop(); // Mantém o servidor WebSocket em execução, verificando por novas conexões e mensagens
 unsigned long tempoAtual = millis();
 if (tempoAtual - ultimoTempoEnvio >= intervaloEnvio) {
    ultimoTempoEnvio = tempoAtual;
 //*******************************************************************************************************************************
 // ----------------------------------- Atenção escolha uma das duas opções abaixo -------------------------------------
 // Linha que sorteia o valor, usada para teste sem ligar o LDR a placa do ESP32
 //int leituraLDR = random(0, 4095); // sorteia um valor qualquer entre 0 e 4095
 // Descomente esta linha abaixo para realizar a leitura do LDR ligado a placa do ESP32 e comente a linha acima para remover o sorteio
 int leituraLDR = analogRead(pinoLDR); // Lê o valor do LDR
 Serial.print("LDR Valor: "); // Imprime o valor do LDR no Serial Monitor
 Serial.println(leituraLDR);
 String leituraString = String(leituraLDR); // Cria uma variável String com a leitura do LDR
 webSocket.broadcastTXT(leituraString); // Envia o valor do LDR para todos os clientes conectados via WebSocket
 // Piscada dupla rápida do LED
 piscarLED();
 }
}
void piscarLED() {
 for (int i = 0; i < 2; i++) {
 digitalWrite(pinoLED, HIGH);
 delay(100); // Atraso de 100 milissegundos
 digitalWrite(pinoLED, LOW);
 delay(100); // Atraso de 100 milissegundos
 }
}
// Função de callback para eventos do WebSocket
void webSocketEvent(uint8_t numero_msg, WStype_t type, uint8_t *conteudo_recebido, size_t tamanho_conteudo) {
 switch(type) { // Verifica o tipo de evento
  case WStype_DISCONNECTED: // Caso a conexão seja desconectada
  Serial.printf("[%u] Desconectou!\n", numero_msg); // Imprime no serial que o cliente numero_msg foi desconectado
  break;
  case WStype_CONNECTED: // Caso uma nova conexão seja estabelecida 
  Serial.printf("[%u] Conectou!\n", numero_msg); // Imprime no serial que o cliente numero_msg foi conectado
  webSocket.sendTXT(numero_msg, "Conectou"); // Envia mensagem de confirmação de conexão ao cliente
  break;
  case WStype_TEXT: // Caso uma mensagem de texto seja recebida
  Serial.printf("[%u] Recebeu pelo Socket o texto: %s\n", numero_msg, conteudo_recebido); // Imprime no serial a mensagem recebida do cliente numero_msg
  int valorServo = atoi((char *)conteudo_recebido); // Converte a mensagem recebida para um número inteiro
  if (valorServo >= 0 && valorServo <= 180) { // Verifica se o valor está no intervalo de 0 a 180
  Serial.println("Acinou o Servo!");
  //servo.write(valorServo); // Ajusta a posição do servo motor
  analogWrite(pinoLED, valorServo);
 }
 break;
 }
}
	