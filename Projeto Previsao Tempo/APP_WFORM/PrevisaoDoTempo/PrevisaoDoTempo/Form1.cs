using PrevisaoDoTempo.PrevisaobdDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PrevisaoDoTempo
{
    public partial class Form1 : Form
    {
        ClientWebSocket webSocket; //adicione esta linha

       
        public Form1()
        {
            InitializeComponent();
        }

        private void dadosMeteorologicosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dadosMeteorologicosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.previsaobdDataSet);

        }

        private async void btnConectar_Click(object sender, EventArgs e)
        {
            webSocket = new ClientWebSocket(); // Inicializa uma nova instância de ClientWebSocket
            Uri serverUri = new Uri("ws://" + txtIp.Text + ":81"); // Define o URI do servidor WebSocket, pegando o IP cadastrado no textbox
            try
            {
                await webSocket.ConnectAsync(serverUri, CancellationToken.None); // Tenta conectar ao servidor WebSocket de forma assíncrona
                lblStatus.Invoke((MethodInvoker)(() => lblStatus.Text = "Conectado")); // Atualiza o lblStatus para mostrar "Conectado" na UI 
                lblStatus.ForeColor = Color.Green; // Cor verde
                await ReceiveMessages(); // Chama o método para receber mensagens do servidor WebSocket
            }
            catch (Exception ex) // Bloco de captura para exceções 
            {
                lblStatus.Invoke((MethodInvoker)(() => lblStatus.Text = "Desconectado")); // Atualiza o lblStatus para mostrar "Desconectado" na UI 
                lblStatus.ForeColor = Color.Red; //Cor vermelha
                MessageBox.Show("Erro ao conectar: " + ex.Message); // Exibe uma mensagem de erro ao usuário
            }
        }

        private async Task ReceiveMessages() // Método assíncrono para receber  mensagens do WebSocket 
        {
            var buffer = new byte[1024]; // Cria um buffer de bytes para  armazenar os dados recebidos 
            while (webSocket.State == WebSocketState.Open) // Loop enquanto a  conexão WebSocket estiver aberta
            {
                try
                {
                    var result = await webSocket.ReceiveAsync(new ArraySegment<byte>(buffer), CancellationToken.None); // Recebe uma mensagem do WebSocket de forma assíncrona
                    var message = Encoding.UTF8.GetString(buffer, 0, result.Count); // Converte os bytes recebidos em uma string usando UTF-8 
                    String aux1 = message.ToString(); // Variavel auxiliar para conversao dos dados recebibos em String
                    txtDadosRecebidos.Invoke((MethodInvoker)(() => txtDadosRecebidos.AppendText($"Received: {aux1}\n\r"))); // Atualiza textBoxRecebidas na UI para mostrar a mensagem recebida
                    String[] valoresObtidos = aux1.Split(','); // Separando a String atraves da virgula
                    int aux2;

                    // Tenta converter a string para um número inteiro 
                   bool ehNumeroInteiro = (int.TryParse(valoresObtidos[0], out aux2) && int.TryParse(valoresObtidos[1], out aux2) && int.TryParse(valoresObtidos[2], out aux2)); 
                    //se for número grava no Banco de dados 
                    if (ehNumeroInteiro) //ehNumeroInteiro 
                    {
                        Grava_Dados_Recebidos(valoresObtidos);
                    }

                }
                catch (Exception ex) // Bloco de captura para exceções (erros) 
                {
                    lblStatus.Invoke((MethodInvoker)(() => lblStatus.Text = "Desconectado")); // Atualiza o lblStatus para mostrar "Desconectado" na UI 
                    MessageBox.Show("Erro ao receber mensagem: " + ex.Message);  // Exibe uma mensagem de erro ao usuário 

                }
            }
        }
        void Grava_Dados_Recebidos(String[] valoresObtidos)
        {
            if (valoresObtidos[0] != "")
            {
                //cria o comando INSERT para adicionar uma nova linha no Banco de dados
                dadosMeteorologicosTableAdapter.Adapter.InsertCommand.CommandText = "INSERT INTO dadosMeteorologicos (Data, ProbChuva, TempMin, TempMax) VALUES ('" + DateTime.Now + "', '"+ valoresObtidos[0] + "','" + valoresObtidos[1] + "','" + valoresObtidos[2] + "')";
                //conectar com o banco 
                dadosMeteorologicosTableAdapter.Connection.Open();
                //executar o comando INSERT 
                int deuCerto = dadosMeteorologicosTableAdapter.Adapter.InsertCommand.ExecuteNonQuery();
                //fechar o conexão 
                dadosMeteorologicosTableAdapter.Connection.Close();
                //testar se inseriu 
                if (deuCerto > 0)
                {
                    lblDadosRecebidos.Text = "Recebeu dados do ESP32, com valor: " + valoresObtidos + ", em: " + DateTime.Now;
                    // TODO: esta linha de código carrega dados na tabela.
                    this.dadosMeteorologicosTableAdapter.Fill(this.previsaobdDataSet.dadosMeteorologicos);
                }
                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.dadosMeteorologicosTableAdapter.Fill(this.previsaobdDataSet.dadosMeteorologicos);
        }
    }
}
    
