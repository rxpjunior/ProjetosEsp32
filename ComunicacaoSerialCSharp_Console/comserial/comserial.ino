void setup() {

  Serial.begin(115200); // Inicializa a porta serial

  pinMode(2, OUTPUT); // Configura o pino 2 como saída (LED acoplado no ESP32)

}

void loop() {

  char mensagem[10]; // Cria um array de caracteres para armazenar a mensagem recebida

  int i = 0; // Inicializa um índice para o array

  // Verifica se há dados disponíveis na porta serial

  if (Serial.available()) {

    // Lê o próximo byte recebido na porta serial

    char c = Serial.read();

    // Armazena o byte lido no array de mensagem

    mensagem[i] = c;

    // Incrementa o índice do array

    i++;

    // Acende o LED conectado ao pino 2

    digitalWrite(2, HIGH);

    delay(500); // Espera 500 milissegundos

    // Apaga o LED conectado ao pino 2

    digitalWrite(2, LOW);

    delay(500); // Espera 500 milissegundos

  }

  // Adiciona o caractere nulo ao final do array para marcar o fim da string

  mensagem[i] = '\0';

  // Envia a mensagem de volta pela porta serial

  Serial.write(mensagem);
}