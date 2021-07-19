
namespace eAgenda.Forms.TarefaModule
{
    partial class TelaEditarTarefas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblAdicionarTarefa = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.tBoxTitulo = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.cBoxPrioridade = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelPorcentagem = new System.Windows.Forms.Label();
            this.mskconcluuido = new System.Windows.Forms.MaskedTextBox();
            this.dataSet1 = new System.Data.DataSet();
            this.dataTarefasPendentes = new System.Data.DataTable();
            this.Id = new System.Data.DataColumn();
            this.titulo = new System.Data.DataColumn();
            this.Porcentagem = new System.Data.DataColumn();
            this.DataCriacao = new System.Data.DataColumn();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dgvTarefasPendentes = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tituloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.porcentagemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataCriacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prioridadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTarefasPendentes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarefasPendentes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(581, 407);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(95, 31);
            this.btnLimpar.TabIndex = 14;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // lblAdicionarTarefa
            // 
            this.lblAdicionarTarefa.AutoSize = true;
            this.lblAdicionarTarefa.Font = new System.Drawing.Font("Gadugi", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdicionarTarefa.Location = new System.Drawing.Point(197, 9);
            this.lblAdicionarTarefa.Name = "lblAdicionarTarefa";
            this.lblAdicionarTarefa.Size = new System.Drawing.Size(418, 44);
            this.lblAdicionarTarefa.TabIndex = 9;
            this.lblAdicionarTarefa.Text = "Editando Uma Tarefa...";
            this.lblAdicionarTarefa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(689, 407);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(88, 31);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Sair";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.Location = new System.Drawing.Point(480, 407);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(88, 31);
            this.btnAdicionar.TabIndex = 12;
            this.btnAdicionar.Text = "Editar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // tBoxTitulo
            // 
            this.tBoxTitulo.Location = new System.Drawing.Point(33, 68);
            this.tBoxTitulo.Name = "tBoxTitulo";
            this.tBoxTitulo.Size = new System.Drawing.Size(670, 20);
            this.tBoxTitulo.TabIndex = 8;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(29, 41);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(56, 24);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "Título";
            // 
            // cBoxPrioridade
            // 
            this.cBoxPrioridade.FormattingEnabled = true;
            this.cBoxPrioridade.Items.AddRange(new object[] {
            "1-Baixa",
            "2-Média",
            "3-Alta"});
            this.cBoxPrioridade.Location = new System.Drawing.Point(33, 126);
            this.cBoxPrioridade.Name = "cBoxPrioridade";
            this.cBoxPrioridade.Size = new System.Drawing.Size(155, 21);
            this.cBoxPrioridade.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Prioridade";
            // 
            // labelPorcentagem
            // 
            this.labelPorcentagem.AutoSize = true;
            this.labelPorcentagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPorcentagem.Location = new System.Drawing.Point(213, 99);
            this.labelPorcentagem.Name = "labelPorcentagem";
            this.labelPorcentagem.Size = new System.Drawing.Size(136, 24);
            this.labelPorcentagem.TabIndex = 15;
            this.labelPorcentagem.Text = "% de Conclsão";
            // 
            // mskconcluuido
            // 
            this.mskconcluuido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskconcluuido.Location = new System.Drawing.Point(217, 126);
            this.mskconcluuido.Mask = "000";
            this.mskconcluuido.Name = "mskconcluuido";
            this.mskconcluuido.Size = new System.Drawing.Size(72, 24);
            this.mskconcluuido.TabIndex = 18;
            this.mskconcluuido.ValidatingType = typeof(int);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "TarafeasPendentes";
            this.dataSet1.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTarefasPendentes});
            // 
            // dataTarefasPendentes
            // 
            this.dataTarefasPendentes.CaseSensitive = false;
            this.dataTarefasPendentes.Columns.AddRange(new System.Data.DataColumn[] {
            this.Id,
            this.titulo,
            this.Porcentagem,
            this.DataCriacao,
            this.dataColumn1});
            this.dataTarefasPendentes.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "Id"}, false)});
            this.dataTarefasPendentes.TableName = "TarefasPendente";
            // 
            // Id
            // 
            this.Id.Caption = "Id";
            this.Id.ColumnName = "Id";
            this.Id.DataType = typeof(int);
            // 
            // titulo
            // 
            this.titulo.Caption = "Titulo";
            this.titulo.ColumnName = "Titulo";
            // 
            // Porcentagem
            // 
            this.Porcentagem.Caption = "Porcentagem";
            this.Porcentagem.ColumnName = "Porcentagem";
            // 
            // DataCriacao
            // 
            this.DataCriacao.Caption = "DataCriacao";
            this.DataCriacao.ColumnName = "DataCriacao";
            this.DataCriacao.DataType = typeof(System.DateTime);
            // 
            // dataColumn1
            // 
            this.dataColumn1.Caption = "Prioridade";
            this.dataColumn1.ColumnName = "Prioridade";
            // 
            // dgvTarefasPendentes
            // 
            this.dgvTarefasPendentes.AllowUserToAddRows = false;
            this.dgvTarefasPendentes.AllowUserToDeleteRows = false;
            this.dgvTarefasPendentes.AutoGenerateColumns = false;
            this.dgvTarefasPendentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTarefasPendentes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.tituloDataGridViewTextBoxColumn,
            this.porcentagemDataGridViewTextBoxColumn,
            this.dataCriacaoDataGridViewTextBoxColumn,
            this.prioridadeDataGridViewTextBoxColumn});
            this.dgvTarefasPendentes.DataMember = "TarefasPendente";
            this.dgvTarefasPendentes.DataSource = this.dataSet1;
            this.dgvTarefasPendentes.Location = new System.Drawing.Point(84, 184);
            this.dgvTarefasPendentes.Name = "dgvTarefasPendentes";
            this.dgvTarefasPendentes.ReadOnly = true;
            this.dgvTarefasPendentes.Size = new System.Drawing.Size(546, 150);
            this.dgvTarefasPendentes.TabIndex = 19;
            this.dgvTarefasPendentes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTarefasPendentes_CellContentClick_1);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tituloDataGridViewTextBoxColumn
            // 
            this.tituloDataGridViewTextBoxColumn.DataPropertyName = "Titulo";
            this.tituloDataGridViewTextBoxColumn.HeaderText = "Titulo";
            this.tituloDataGridViewTextBoxColumn.Name = "tituloDataGridViewTextBoxColumn";
            this.tituloDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // porcentagemDataGridViewTextBoxColumn
            // 
            this.porcentagemDataGridViewTextBoxColumn.DataPropertyName = "Porcentagem";
            this.porcentagemDataGridViewTextBoxColumn.HeaderText = "Porcentagem";
            this.porcentagemDataGridViewTextBoxColumn.Name = "porcentagemDataGridViewTextBoxColumn";
            this.porcentagemDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataCriacaoDataGridViewTextBoxColumn
            // 
            this.dataCriacaoDataGridViewTextBoxColumn.DataPropertyName = "DataCriacao";
            this.dataCriacaoDataGridViewTextBoxColumn.HeaderText = "DataCriacao";
            this.dataCriacaoDataGridViewTextBoxColumn.Name = "dataCriacaoDataGridViewTextBoxColumn";
            this.dataCriacaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prioridadeDataGridViewTextBoxColumn
            // 
            this.prioridadeDataGridViewTextBoxColumn.DataPropertyName = "Prioridade";
            this.prioridadeDataGridViewTextBoxColumn.HeaderText = "Prioridade";
            this.prioridadeDataGridViewTextBoxColumn.Name = "prioridadeDataGridViewTextBoxColumn";
            this.prioridadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(606, 104);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(97, 20);
            this.txtId.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(524, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 24);
            this.label2.TabIndex = 21;
            this.label2.Text = "Id tarefa";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TelaEditarTarefas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.dgvTarefasPendentes);
            this.Controls.Add(this.mskconcluuido);
            this.Controls.Add(this.labelPorcentagem);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lblAdicionarTarefa);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.tBoxTitulo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.cBoxPrioridade);
            this.Controls.Add(this.label1);
            this.Name = "TelaEditarTarefas";
            this.Text = "TelaEditarTarefas";
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTarefasPendentes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarefasPendentes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblAdicionarTarefa;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.TextBox tBoxTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ComboBox cBoxPrioridade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPorcentagem;
        private System.Windows.Forms.MaskedTextBox mskconcluuido;
        private System.Data.DataColumn Id;
        private System.Data.DataColumn titulo;
        private System.Data.DataColumn Porcentagem;
        private System.Data.DataColumn DataCriacao;
        private System.Windows.Forms.DataGridView dgvTarefasPendentes;
        public System.Data.DataSet dataSet1;
        public System.Data.DataTable dataTarefasPendentes;
        private System.Data.DataColumn dataColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn porcentagemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataCriacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prioridadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label2;
    }
}