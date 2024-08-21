//Configurações iniciais

void setup() {

  Serial.begin(115200);  //Taxa de transmissão

  pinMode(2, OUTPUT);  //Definição da Porta 2 do ESP32 como saída

}

 

//Função principal

void loop() {

  //declaração da variável (vetor) que armazenará os

  //dados recebidos via porta serial

  char mensagem[10];

   

  //declaração da variável que auxiliará em indicar a

  //posição no vetor para armazenar cada caractere lido

  int i=0;  

 

  //Condição para verificar se exite informação sendo

  //recebida pela porta serial

  if (Serial.available())

  {

    //Sendo verdadeira a condição

   

    //realiza a leitura do caractere e atribui no vetor

    mensagem[i] = Serial.read();

   

    //incrementa 1 na variável i, para que o próximo

    //caractere lido, seja armazenado na próxima posição do vetor

    i++;  

   

    digitalWrite(2, HIGH); //Acende o Led

    delay(100);  //Temo de espera de 100 milessegundos

    digitalWrite(2, LOW);  //Apaga o Led

    delay(100);

  }

 

  //adiciona o caractere que representa o final da string válida

  mensagem[i] = '\0';  

  Serial.write(mensagem);  //Envia a string recebida para a porta Serial

 

  //Se a mensagem recebida na primeira posição do vetor

  //for a letra L

  if (mensagem[0] == 'L')

    digitalWrite(2, HIGH);  //Liga o Led

 

  //for a letra D

  if (mensagem[0] == 'D')

    digitalWrite(2, LOW);  //Apaga o led

}