namespace PrevisaoDoTempo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.previsaobdDataSet = new PrevisaoDoTempo.PrevisaobdDataSet();
            this.dadosMeteorologicosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dadosMeteorologicosTableAdapter = new PrevisaoDoTempo.PrevisaobdDataSetTableAdapters.dadosMeteorologicosTableAdapter();
            this.tableAdapterManager = new PrevisaoDoTempo.PrevisaobdDataSetTableAdapters.TableAdapterManager();
            this.dadosMeteorologicosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.dadosMeteorologicosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dadosMeteorologicosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnConectar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIp = new System.Windows.Forms.TextBox();
            this.lblDadosRecebidos = new System.Windows.Forms.Label();
            this.txtDadosRecebidos = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.previsaobdDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dadosMeteorologicosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dadosMeteorologicosBindingNavigator)).BeginInit();
            this.dadosMeteorologicosBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dadosMeteorologicosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // previsaobdDataSet
            // 
            this.previsaobdDataSet.DataSetName = "PrevisaobdDataSet";
            this.previsaobdDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dadosMeteorologicosBindingSource
            // 
            this.dadosMeteorologicosBindingSource.DataMember = "dadosMeteorologicos";
            this.dadosMeteorologicosBindingSource.DataSource = this.previsaobdDataSet;
            // 
            // dadosMeteorologicosTableAdapter
            // 
            this.dadosMeteorologicosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.dadosMeteorologicosTableAdapter = this.dadosMeteorologicosTableAdapter;
            this.tableAdapterManager.UpdateOrder = PrevisaoDoTempo.PrevisaobdDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dadosMeteorologicosBindingNavigator
            // 
            this.dadosMeteorologicosBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.dadosMeteorologicosBindingNavigator.BindingSource = this.dadosMeteorologicosBindingSource;
            this.dadosMeteorologicosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.dadosMeteorologicosBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.dadosMeteorologicosBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.dadosMeteorologicosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.dadosMeteorologicosBindingNavigatorSaveItem});
            this.dadosMeteorologicosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.dadosMeteorologicosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.dadosMeteorologicosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.dadosMeteorologicosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.dadosMeteorologicosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.dadosMeteorologicosBindingNavigator.Name = "dadosMeteorologicosBindingNavigator";
            this.dadosMeteorologicosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.dadosMeteorologicosBindingNavigator.Size = new System.Drawing.Size(1231, 27);
            this.dadosMeteorologicosBindingNavigator.TabIndex = 0;
            this.dadosMeteorologicosBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 24);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // dadosMeteorologicosBindingNavigatorSaveItem
            // 
            this.dadosMeteorologicosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.dadosMeteorologicosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("dadosMeteorologicosBindingNavigatorSaveItem.Image")));
            this.dadosMeteorologicosBindingNavigatorSaveItem.Name = "dadosMeteorologicosBindingNavigatorSaveItem";
            this.dadosMeteorologicosBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.dadosMeteorologicosBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.dadosMeteorologicosBindingNavigatorSaveItem.Click += new System.EventHandler(this.dadosMeteorologicosBindingNavigatorSaveItem_Click);
            // 
            // dadosMeteorologicosDataGridView
            // 
            this.dadosMeteorologicosDataGridView.AutoGenerateColumns = false;
            this.dadosMeteorologicosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dadosMeteorologicosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dadosMeteorologicosDataGridView.DataSource = this.dadosMeteorologicosBindingSource;
            this.dadosMeteorologicosDataGridView.Location = new System.Drawing.Point(12, 184);
            this.dadosMeteorologicosDataGridView.Name = "dadosMeteorologicosDataGridView";
            this.dadosMeteorologicosDataGridView.RowHeadersWidth = 51;
            this.dadosMeteorologicosDataGridView.RowTemplate.Height = 24;
            this.dadosMeteorologicosDataGridView.Size = new System.Drawing.Size(871, 231);
            this.dadosMeteorologicosDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Data";
            this.dataGridViewTextBoxColumn2.HeaderText = "Data";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ProbChuva";
            this.dataGridViewTextBoxColumn3.HeaderText = "ProbChuva";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TempMin";
            this.dataGridViewTextBoxColumn4.HeaderText = "TempMin";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "TempMax";
            this.dataGridViewTextBoxColumn5.HeaderText = "TempMax";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(44, 89);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(90, 23);
            this.btnConectar.TabIndex = 2;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "IP do Esp32";
            // 
            // txtIp
            // 
            this.txtIp.Location = new System.Drawing.Point(22, 61);
            this.txtIp.Name = "txtIp";
            this.txtIp.Size = new System.Drawing.Size(146, 22);
            this.txtIp.TabIndex = 4;
            // 
            // lblDadosRecebidos
            // 
            this.lblDadosRecebidos.AutoSize = true;
            this.lblDadosRecebidos.Location = new System.Drawing.Point(194, 142);
            this.lblDadosRecebidos.Name = "lblDadosRecebidos";
            this.lblDadosRecebidos.Size = new System.Drawing.Size(0, 16);
            this.lblDadosRecebidos.TabIndex = 6;
            // 
            // txtDadosRecebidos
            // 
            this.txtDadosRecebidos.Location = new System.Drawing.Point(889, 71);
            this.txtDadosRecebidos.Multiline = true;
            this.txtDadosRecebidos.Name = "txtDadosRecebidos";
            this.txtDadosRecebidos.Size = new System.Drawing.Size(185, 344);
            this.txtDadosRecebidos.TabIndex = 7;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.Color.Red;
            this.lblStatus.Location = new System.Drawing.Point(41, 125);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(96, 16);
            this.lblStatus.TabIndex = 8;
            this.lblStatus.Text = "Desconectado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(898, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Dados recebidos do ESP";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtDadosRecebidos);
            this.Controls.Add(this.lblDadosRecebidos);
            this.Controls.Add(this.txtIp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.dadosMeteorologicosDataGridView);
            this.Controls.Add(this.dadosMeteorologicosBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.previsaobdDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dadosMeteorologicosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dadosMeteorologicosBindingNavigator)).EndInit();
            this.dadosMeteorologicosBindingNavigator.ResumeLayout(false);
            this.dadosMeteorologicosBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dadosMeteorologicosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PrevisaobdDataSet previsaobdDataSet;
        private System.Windows.Forms.BindingSource dadosMeteorologicosBindingSource;
        private PrevisaobdDataSetTableAdapters.dadosMeteorologicosTableAdapter dadosMeteorologicosTableAdapter;
        private PrevisaobdDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator dadosMeteorologicosBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton dadosMeteorologicosBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView dadosMeteorologicosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIp;
        private System.Windows.Forms.Label lblDadosRecebidos;
        private System.Windows.Forms.TextBox txtDadosRecebidos;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label2;
    }
}

