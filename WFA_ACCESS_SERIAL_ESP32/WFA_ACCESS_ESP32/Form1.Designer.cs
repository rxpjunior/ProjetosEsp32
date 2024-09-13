namespace WFA_ACCESS_ESP32
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.trcLuminosidade = new System.Windows.Forms.TrackBar();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnConectar = new System.Windows.Forms.Button();
            this.lblLuminosidade = new System.Windows.Forms.Label();
            this.cbxPorta = new System.Windows.Forms.ComboBox();
            this.btnDesconectar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trcLuminosidade)).BeginInit();
            this.SuspendLayout();
            // 
            // trcLuminosidade
            // 
            this.trcLuminosidade.Enabled = false;
            this.trcLuminosidade.Location = new System.Drawing.Point(210, 220);
            this.trcLuminosidade.Maximum = 7;
            this.trcLuminosidade.Name = "trcLuminosidade";
            this.trcLuminosidade.Size = new System.Drawing.Size(405, 56);
            this.trcLuminosidade.TabIndex = 0;
            this.trcLuminosidade.Scroll += new System.EventHandler(this.trcLuminosidade_Scroll);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.Color.Red;
            this.lblStatus.Location = new System.Drawing.Point(638, 391);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(96, 16);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Desconectado";
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(585, 345);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(92, 23);
            this.btnConectar.TabIndex = 2;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // lblLuminosidade
            // 
            this.lblLuminosidade.AutoSize = true;
            this.lblLuminosidade.Location = new System.Drawing.Point(354, 192);
            this.lblLuminosidade.Name = "lblLuminosidade";
            this.lblLuminosidade.Size = new System.Drawing.Size(92, 16);
            this.lblLuminosidade.TabIndex = 8;
            this.lblLuminosidade.Text = "Luminosidade";
            // 
            // cbxPorta
            // 
            this.cbxPorta.FormattingEnabled = true;
            this.cbxPorta.Location = new System.Drawing.Point(613, 293);
            this.cbxPorta.Name = "cbxPorta";
            this.cbxPorta.Size = new System.Drawing.Size(121, 24);
            this.cbxPorta.TabIndex = 9;
            // 
            // btnDesconectar
            // 
            this.btnDesconectar.Enabled = false;
            this.btnDesconectar.Location = new System.Drawing.Point(691, 345);
            this.btnDesconectar.Name = "btnDesconectar";
            this.btnDesconectar.Size = new System.Drawing.Size(97, 23);
            this.btnDesconectar.TabIndex = 10;
            this.btnDesconectar.Text = "Desconectar";
            this.btnDesconectar.UseVisualStyleBackColor = true;
            this.btnDesconectar.Click += new System.EventHandler(this.btnDesconectar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDesconectar);
            this.Controls.Add(this.cbxPorta);
            this.Controls.Add(this.lblLuminosidade);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.trcLuminosidade);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trcLuminosidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trcLuminosidade;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Label lblLuminosidade;
        private System.Windows.Forms.ComboBox cbxPorta;
        private System.Windows.Forms.Button btnDesconectar;
    }
}

