
namespace eAgenda.Forms.TarefaModule
{
    partial class TelaVisualizarTarefas
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
            this.btnExcluir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataSet1 = new System.Data.DataSet();
            this.dtPendentes = new System.Data.DataTable();
            this.dataColumn6 = new System.Data.DataColumn();
            this.dataColumn7 = new System.Data.DataColumn();
            this.dataColumn8 = new System.Data.DataColumn();
            this.dataColumn9 = new System.Data.DataColumn();
            this.dataColumn10 = new System.Data.DataColumn();
            this.dtConcluidas = new System.Data.DataTable();
            this.dataColumn11 = new System.Data.DataColumn();
            this.dataColumn12 = new System.Data.DataColumn();
            this.dataColumn13 = new System.Data.DataColumn();
            this.dataColumn14 = new System.Data.DataColumn();
            this.tabTodas = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvConcluidas = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataConclusaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvtarefaspendentes = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tituloDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prioridadeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataCriacaoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.percentualDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPendentes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtConcluidas)).BeginInit();
            this.tabTodas.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConcluidas)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtarefaspendentes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Red;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(292, 407);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(207, 40);
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(211, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 41);
            this.label1.TabIndex = 3;
            this.label1.Text = "Visualizando Tarefas...";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            this.dataSet1.Tables.AddRange(new System.Data.DataTable[] {
            this.dtPendentes,
            this.dtConcluidas});
            // 
            // dtPendentes
            // 
            this.dtPendentes.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn6,
            this.dataColumn7,
            this.dataColumn8,
            this.dataColumn9,
            this.dataColumn10});
            this.dtPendentes.TableName = "Tarefas Pendentes";
            // 
            // dataColumn6
            // 
            this.dataColumn6.Caption = "Id";
            this.dataColumn6.ColumnName = "Id";
            // 
            // dataColumn7
            // 
            this.dataColumn7.Caption = "Titulo";
            this.dataColumn7.ColumnName = "Titulo";
            // 
            // dataColumn8
            // 
            this.dataColumn8.Caption = "Prioridade";
            this.dataColumn8.ColumnName = "Prioridade";
            // 
            // dataColumn9
            // 
            this.dataColumn9.Caption = "DataCriacao";
            this.dataColumn9.ColumnName = "DataCriacao";
            this.dataColumn9.DataType = typeof(System.DateTime);
            // 
            // dataColumn10
            // 
            this.dataColumn10.Caption = "Percentual";
            this.dataColumn10.ColumnName = "Percentual";
            // 
            // dtConcluidas
            // 
            this.dtConcluidas.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn11,
            this.dataColumn12,
            this.dataColumn13,
            this.dataColumn14});
            this.dtConcluidas.TableName = "Tarefas Concluidas";
            // 
            // dataColumn11
            // 
            this.dataColumn11.Caption = "Id";
            this.dataColumn11.ColumnName = "Id";
            // 
            // dataColumn12
            // 
            this.dataColumn12.Caption = "Titulo";
            this.dataColumn12.ColumnName = "Titulo";
            // 
            // dataColumn13
            // 
            this.dataColumn13.Caption = "Prioridade";
            this.dataColumn13.ColumnName = "Prioridade";
            // 
            // dataColumn14
            // 
            this.dataColumn14.Caption = "Data Conclusao";
            this.dataColumn14.ColumnName = "Data Conclusao";
            this.dataColumn14.DataType = typeof(System.DateTime);
            // 
            // tabTodas
            // 
            this.tabTodas.Controls.Add(this.tabPage1);
            this.tabTodas.Controls.Add(this.tabPage2);
            this.tabTodas.Location = new System.Drawing.Point(45, 85);
            this.tabTodas.Name = "tabTodas";
            this.tabTodas.SelectedIndex = 0;
            this.tabTodas.Size = new System.Drawing.Size(712, 288);
            this.tabTodas.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvConcluidas);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(704, 262);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tarefas Concluidas";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvConcluidas
            // 
            this.dgvConcluidas.AllowUserToAddRows = false;
            this.dgvConcluidas.AllowUserToDeleteRows = false;
            this.dgvConcluidas.AutoGenerateColumns = false;
            this.dgvConcluidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConcluidas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataConclusaoDataGridViewTextBoxColumn});
            this.dgvConcluidas.DataMember = "Tarefas Concluidas";
            this.dgvConcluidas.DataSource = this.dataSet1;
            this.dgvConcluidas.Location = new System.Drawing.Point(6, 6);
            this.dgvConcluidas.Name = "dgvConcluidas";
            this.dgvConcluidas.ReadOnly = true;
            this.dgvConcluidas.Size = new System.Drawing.Size(692, 253);
            this.dgvConcluidas.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Titulo";
            this.dataGridViewTextBoxColumn2.HeaderText = "Titulo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Prioridade";
            this.dataGridViewTextBoxColumn3.HeaderText = "Prioridade";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataConclusaoDataGridViewTextBoxColumn
            // 
            this.dataConclusaoDataGridViewTextBoxColumn.DataPropertyName = "Data Conclusao";
            this.dataConclusaoDataGridViewTextBoxColumn.HeaderText = "Data Conclusao";
            this.dataConclusaoDataGridViewTextBoxColumn.Name = "dataConclusaoDataGridViewTextBoxColumn";
            this.dataConclusaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvtarefaspendentes);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(704, 262);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tarefas Pendentes";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvtarefaspendentes
            // 
            this.dgvtarefaspendentes.AllowDrop = true;
            this.dgvtarefaspendentes.AllowUserToAddRows = false;
            this.dgvtarefaspendentes.AllowUserToDeleteRows = false;
            this.dgvtarefaspendentes.AllowUserToOrderColumns = true;
            this.dgvtarefaspendentes.AutoGenerateColumns = false;
            this.dgvtarefaspendentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtarefaspendentes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.tituloDataGridViewTextBoxColumn1,
            this.prioridadeDataGridViewTextBoxColumn1,
            this.dataCriacaoDataGridViewTextBoxColumn1,
            this.percentualDataGridViewTextBoxColumn});
            this.dgvtarefaspendentes.DataMember = "Tarefas Pendentes";
            this.dgvtarefaspendentes.DataSource = this.dataSet1;
            this.dgvtarefaspendentes.Location = new System.Drawing.Point(6, 6);
            this.dgvtarefaspendentes.Name = "dgvtarefaspendentes";
            this.dgvtarefaspendentes.ReadOnly = true;
            this.dgvtarefaspendentes.Size = new System.Drawing.Size(698, 250);
            this.dgvtarefaspendentes.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // tituloDataGridViewTextBoxColumn1
            // 
            this.tituloDataGridViewTextBoxColumn1.DataPropertyName = "Titulo";
            this.tituloDataGridViewTextBoxColumn1.HeaderText = "Titulo";
            this.tituloDataGridViewTextBoxColumn1.Name = "tituloDataGridViewTextBoxColumn1";
            this.tituloDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // prioridadeDataGridViewTextBoxColumn1
            // 
            this.prioridadeDataGridViewTextBoxColumn1.DataPropertyName = "Prioridade";
            this.prioridadeDataGridViewTextBoxColumn1.HeaderText = "Prioridade";
            this.prioridadeDataGridViewTextBoxColumn1.Name = "prioridadeDataGridViewTextBoxColumn1";
            this.prioridadeDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataCriacaoDataGridViewTextBoxColumn1
            // 
            this.dataCriacaoDataGridViewTextBoxColumn1.DataPropertyName = "DataCriacao";
            this.dataCriacaoDataGridViewTextBoxColumn1.HeaderText = "DataCriacao";
            this.dataCriacaoDataGridViewTextBoxColumn1.Name = "dataCriacaoDataGridViewTextBoxColumn1";
            this.dataCriacaoDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // percentualDataGridViewTextBoxColumn
            // 
            this.percentualDataGridViewTextBoxColumn.DataPropertyName = "Percentual";
            this.percentualDataGridViewTextBoxColumn.HeaderText = "Percentual";
            this.percentualDataGridViewTextBoxColumn.Name = "percentualDataGridViewTextBoxColumn";
            this.percentualDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(645, 407);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(111, 31);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // TelaVisualizarTarefas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.tabTodas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExcluir);
            this.Name = "TelaVisualizarTarefas";
            this.Text = "TelaVisualizarTarefas";
            this.Load += new System.EventHandler(this.TelaVisualizarTarefas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPendentes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtConcluidas)).EndInit();
            this.tabTodas.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConcluidas)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvtarefaspendentes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label label1;
        private System.Data.DataSet dataSet1;
        private System.Data.DataTable dtPendentes;
        private System.Data.DataColumn dataColumn6;
        private System.Data.DataColumn dataColumn7;
        private System.Data.DataColumn dataColumn8;
        private System.Data.DataColumn dataColumn9;
        private System.Data.DataColumn dataColumn10;
        private System.Data.DataTable dtConcluidas;
        private System.Data.DataColumn dataColumn11;
        private System.Data.DataColumn dataColumn12;
        private System.Data.DataColumn dataColumn13;
        private System.Data.DataColumn dataColumn14;
        private System.Windows.Forms.TabControl tabTodas;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvConcluidas;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataCriacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataConclusãoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prioridadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dgvtarefaspendentes;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn prioridadeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataCriacaoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn percentualDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataConclusaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnSair;
    }
}