using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace WFA_ACCESS_ESP32
{
    public partial class Form1 : Form
    {
        SerialPort portaSerial = new SerialPort(); //adicionar esta linha
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //laço de repetição responsável por buscar as portas COM

            // e carregar o ComboBox

            foreach (string porta in SerialPort.GetPortNames())

            {

                cbxPorta.Items.Add(porta);

            }
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            if (checarESP32())

            {

                //Sendo verdadeira a condição

                btnConectar.Enabled = false;  //Desabilita botão CONECTAR

                btnDesconectar.Enabled = true;  //Habilita botão DESCONECTAR

                cbxPorta.Enabled = false;  //Desabilita botão comboBox das Portas

                trcLuminosidade.Enabled = true;  //Habilita o checkBox do controle do LED

                lblStatus.Text = "Conectado";

            }

            else

            {

                //Sendo falsa a condição



                btnDesconectar.Enabled = false;  //Desabilita botão DESCONECTAR
                lblStatus.Text = "Desconectado";

            }
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            btnConectar.Enabled = true;  //Habilita o botão CONECTAR

            btnDesconectar.Enabled = false;  //Desabilita o botão DESCONECTAR

            cbxPorta.SelectedIndex = -1;

            cbxPorta.Enabled = true;

            trcLuminosidade.Enabled = false;
            
            lblStatus.Text = "Desconectado";

            lblStatus.ForeColor = Color.Red;

            portaSerial.Close();
        }

        private bool checarESP32()

        {

            try

            {

                //Caso algum erro inesperado ocorra neste bloco, as instruções do catch são executadas

                portaSerial.PortName = cbxPorta.SelectedItem.ToString(); //atribuição da porta selecionada

                portaSerial.BaudRate = 115200;  //definição da taxa de transmissão

                portaSerial.Open();  //Abertura da conexão com a porta serial

                portaSerial.Write("TESTE");  //Envia uma string para o Arduino



                Thread.Sleep(1500);  //Tempo em milessegundos para aguardar o Arduino receber, processar

                //e devolver a string esperada

                string msgRecebida = portaSerial.ReadExisting(); //armezenando a resposta do Arduino



                //Condição para verificar se a string enviada pelo arduino é a esperada

                if (msgRecebida.Equals("TESTE"))

                {

                    //Sendo a condição verdadeira, retorna true

                    return true;
                   

                }

                else

                {

                    //Sendo a condição falsa

                    //Verifica se a conexão com a porta serial está aberta

                    if (portaSerial.IsOpen)

                        portaSerial.Close(); //sendo a condição verdadeira, fecha a conexão



                    return false; //retorna false

                }

            }

            catch (Exception e)

            {

                //Caso ocorra algm erro no bloco do try, uma mensagem com o erro será apresentada

                //E a conexão será fechada, caso esteja aberta

                MessageBox.Show(e.Message.ToString());

                if (portaSerial.IsOpen)

                    portaSerial.Close();



                return false; //retorna false

            }

        }

        private void trcLuminosidade_Scroll(object sender, EventArgs e)
        {
            int valor = trcLuminosidade.Value;
            portaSerial.Write("L");
            portaSerial.Write(valor.ToString());
            lblLuminosidade.Text = "Luminosidade = " + valor.ToString();
        }
    }
}
