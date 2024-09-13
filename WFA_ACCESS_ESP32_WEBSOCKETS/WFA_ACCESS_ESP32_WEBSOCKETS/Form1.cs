using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace WFA_ACCESS_ESP32_WEBSOCKETS
{
    public partial class Form1 : Form
    {
        ClientWebSocket webSocket; //adicione esta linha
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'projetoLDRServoDataSet.Tb_dados'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_dadosTableAdapter.Fill(this.projetoLDRServoDataSet.Tb_dados);

        }

        private async void btnconectar_Click(object sender, EventArgs e)
        {
            webSocket = new ClientWebSocket(); // Inicializa uma nova instância de ClientWebSocket
             Uri serverUri = new Uri("ws://192.168.18.166:81"); // Define o URI do servidor WebSocket, substitua pelo IP do seu ESP32
         try
            {
                await webSocket.ConnectAsync(serverUri, CancellationToken.None); // Tenta conectar ao servidor WebSocket de forma assíncrona
                labelStatus.Invoke((MethodInvoker)(() => labelStatus.Text = "Conectado")); // Atualiza o lblStatus para mostrar "Conectado" na UI 
                await ReceiveMessages(); // Chama o método para receber mensagens do servidor WebSocket
         }
          catch (Exception ex) // Bloco de captura para exceções
            {
                labelStatus.Invoke((MethodInvoker)(() => labelStatus.Text = "Desconectado")); // Atualiza o lblStatus para mostrar "Desconectado" na UI
                MessageBox.Show("Erro ao conectar: " + ex.Message); // Exibe uma mensagem de erro ao usuário
            }
        }

        private async Task ReceiveMessages() // Método assíncrono para receber mensagens do WebSocket
        {
            var buffer = new byte[1024]; // Cria um buffer de bytes para armazenar os dados recebidos
            while (webSocket.State == WebSocketState.Open) // Loop enquanto a conexão WebSocket estiver aberta
            {
                try
                {
                    var result = await webSocket.ReceiveAsync(new ArraySegment<byte>(buffer), CancellationToken.None); // Recebe uma mensagem do WebSocket de forma assíncrona
                    var message = Encoding.UTF8.GetString(buffer, 0, result.Count); // Converte os bytes recebidos em uma string usando UTF-8
                    textBox1.Invoke((MethodInvoker)(() => textBox1.AppendText($"Received: {message}\n\r"))); // Atualiza textBoxRecebidas na UI para mostrar a mensagem recebida
                    int numeroLDR;
                    // Tenta converter a string para um número inteiro
                    bool ehNumeroInteiro = int.TryParse(message.ToString(), out numeroLDR);
                    //se for número grava no Banco de dados
                    if (ehNumeroInteiro)
                        {
                            Grava_Dados_Recebidos_do_LDR(message.ToString());
                        }
                }
                catch (Exception ex) // Bloco de captura para exceções (erros)
                    {
                        labelStatus.Invoke((MethodInvoker)(() => labelStatus.Text ="Desconectado")); // Atualiza o lblStatus para mostrar "Desconectado" na UI
                        MessageBox.Show("Erro ao receber mensagem: " + ex.Message);
                        // Exibe uma mensagem de erro ao usuário
                    }
                }
        }  
 void Grava_Dados_Recebidos_do_LDR(string valorLDR)
    {
        if (valorLDR != "")
            {
                //cria o comando INSERT para adicionar uma nova linha no Banco de dados
                tb_dadosTableAdapter.Adapter.InsertCommand.CommandText = "INSERT INTO tb_Dados (dataHOra, valorLDR) VALUES ('" + DateTime.Now + "',"+ valorLDR + ")";
                //conectar com o banco
                 tb_dadosTableAdapter.Connection.Open();
                //executar o comando INSERT
                int deuCerto = tb_dadosTableAdapter.Adapter.InsertCommand.ExecuteNonQuery();
                //fechar o conexão
                tb_dadosTableAdapter.Connection.Close();
                //testar se inseriu
                if (deuCerto > 0)
                    {
                    label2.Text = "Recebeu dados do ESP32, com valor: " + valorLDR + ", em: " + DateTime.Now;
                    // TODO: esta linha de código carrega dados na tabela 'meuBancodeDadosDataSet.LeituraLDR'.Você pode movê-la ou removê-la conforme necessário.
                    this.tb_dadosTableAdapter.Fill(this.projetoLDRServoDataSet.Tb_dados);
        }
    }
}


    }
}
