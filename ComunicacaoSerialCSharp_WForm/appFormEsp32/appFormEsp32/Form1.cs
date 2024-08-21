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

namespace appFormEsp32
{
    public partial class Form1 : Form
    {
        SerialPort portaSerial = new SerialPort();//adicionar esta linha



        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //laço de repetição responsável por buscar as portas COM

            // e carregar o ComboBox

            foreach (string porta in SerialPort.GetPortNames())

            {

                comboBox1.Items.Add(porta);

            }



            //Propriedade para desabilitar o botão

            button2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checarESP32())

            {

                //Sendo verdadeira a condição

                button1.Enabled = false;  //Desabilita botão CONECTAR

                button2.Enabled = true;  //Habilita botão DESCONECTAR

                comboBox1.Enabled = false;  //Desabilita botão comboBox das Portas

                checkBox1.Enabled = true;  //Habilita o checkBox do controle do LED

            }

            else

            {

                //Sendo falsa a condição



                button2.Enabled = false;  //Desabilita botão DESCONECTAR

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;  //Habilita o botão CONECTAR

            button2.Enabled = false;  //Desabilita o botão DESCONECTAR

            comboBox1.SelectedIndex = -1;

            comboBox1.Enabled = true;

            checkBox1.Checked = false;

            checkBox1.Enabled = false;

            portaSerial.Write("D");

            portaSerial.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)

            {



                portaSerial.Write("L");

                checkBox1.Text = "Desligar Led";

            }

            else

            {



                portaSerial.Write("D");

                checkBox1.Text = "Ligar Led";

            }
        }
        private bool checarESP32()

        {

            try

            {

                //Caso algum erro inesperado ocorra neste bloco, as instruções do catch são executadas

                portaSerial.PortName = comboBox1.SelectedItem.ToString(); //atribuição da porta selecionada

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
    }

}
