// See https://aka.ms/new-console-template for more information
// Importando o pacote/biblioteca

using System.IO.Ports;

// Cria uma nova instância do objeto SerialPort

SerialPort portaSerial = new SerialPort();



// Define a porta de comunicação onde o ESP32 está conectado

portaSerial.PortName = "COM3"; // Substitua "COM11" pela porta correta



// Define a taxa de transmissão serial (baud rate)

portaSerial.BaudRate = 115200;



// Abre a comunicação serial

portaSerial.Open();



// Exibe uma mensagem de confirmação no console

Console.WriteLine("CONECTADO COM SUCESSO!");



// Envia uma sequência de caracteres (string) para o ESP32

portaSerial.Write("12345");



// Fecha a comunicação serial

portaSerial.Close();
