namespace WFA_ACCESS_ESP32_WEBSOCKETS
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
            this.components = new System.ComponentModel.Container();
            this.btnconectar = new System.Windows.Forms.Button();
            this.labelStatus = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.projetoLDRServoDataSet = new WFA_ACCESS_ESP32_WEBSOCKETS.projetoLDRServoDataSet();
            this.projetoLDRServoDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbdadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_dadosTableAdapter = new WFA_ACCESS_ESP32_WEBSOCKETS.projetoLDRServoDataSetTableAdapters.Tb_dadosTableAdapter();
            this.tb_dadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new WFA_ACCESS_ESP32_WEBSOCKETS.projetoLDRServoDataSetTableAdapters.TableAdapterManager();
            this.tb_dadosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.projetoLDRServoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetoLDRServoDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbdadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_dadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_dadosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnconectar
            // 
            this.btnconectar.Location = new System.Drawing.Point(64, 58);
            this.btnconectar.Name = "btnconectar";
            this.btnconectar.Size = new System.Drawing.Size(122, 50);
            this.btnconectar.TabIndex = 0;
            this.btnconectar.Text = "Conectar";
            this.btnconectar.UseVisualStyleBackColor = true;
            this.btnconectar.Click += new System.EventHandler(this.btnconectar_Click);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(244, 75);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(74, 16);
            this.labelStatus.TabIndex = 1;
            this.labelStatus.Text = "labelStatus";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dados recebidos do ESP";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(64, 168);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(158, 201);
            this.textBox1.TabIndex = 3;
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.tbdadosBindingSource;
            this.listBox1.DisplayMember = "valorLDR";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(257, 168);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 84);
            this.listBox1.TabIndex = 4;
            this.listBox1.ValueMember = "id";
            // 
            // projetoLDRServoDataSet
            // 
            this.projetoLDRServoDataSet.DataSetName = "projetoLDRServoDataSet";
            this.projetoLDRServoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // projetoLDRServoDataSetBindingSource
            // 
            this.projetoLDRServoDataSetBindingSource.DataSource = this.projetoLDRServoDataSet;
            this.projetoLDRServoDataSetBindingSource.Position = 0;
            // 
            // tbdadosBindingSource
            // 
            this.tbdadosBindingSource.DataMember = "Tb_dados";
            this.tbdadosBindingSource.DataSource = this.projetoLDRServoDataSetBindingSource;
            // 
            // tb_dadosTableAdapter
            // 
            this.tb_dadosTableAdapter.ClearBeforeFill = true;
            // 
            // tb_dadosBindingSource
            // 
            this.tb_dadosBindingSource.DataMember = "Tb_dados";
            this.tb_dadosBindingSource.DataSource = this.projetoLDRServoDataSet;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Tb_dadosTableAdapter = this.tb_dadosTableAdapter;
            this.tableAdapterManager.UpdateOrder = WFA_ACCESS_ESP32_WEBSOCKETS.projetoLDRServoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tb_dadosDataGridView
            // 
            this.tb_dadosDataGridView.AutoGenerateColumns = false;
            this.tb_dadosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tb_dadosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.tb_dadosDataGridView.DataSource = this.tb_dadosBindingSource;
            this.tb_dadosDataGridView.Location = new System.Drawing.Point(546, 151);
            this.tb_dadosDataGridView.Name = "tb_dadosDataGridView";
            this.tb_dadosDataGridView.RowHeadersWidth = 51;
            this.tb_dadosDataGridView.RowTemplate.Height = 24;
            this.tb_dadosDataGridView.Size = new System.Drawing.Size(300, 220);
            this.tb_dadosDataGridView.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "dataHora";
            this.dataGridViewTextBoxColumn2.HeaderText = "dataHora";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "valorLDR";
            this.dataGridViewTextBoxColumn3.HeaderText = "valorLDR";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "valorServo";
            this.dataGridViewTextBoxColumn4.HeaderText = "valorServo";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 450);
            this.Controls.Add(this.tb_dadosDataGridView);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.btnconectar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.projetoLDRServoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetoLDRServoDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbdadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_dadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_dadosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnconectar;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.BindingSource projetoLDRServoDataSetBindingSource;
        private projetoLDRServoDataSet projetoLDRServoDataSet;
        private System.Windows.Forms.BindingSource tbdadosBindingSource;
        private projetoLDRServoDataSetTableAdapters.Tb_dadosTableAdapter tb_dadosTableAdapter;
        private System.Windows.Forms.BindingSource tb_dadosBindingSource;
        private projetoLDRServoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView tb_dadosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}

