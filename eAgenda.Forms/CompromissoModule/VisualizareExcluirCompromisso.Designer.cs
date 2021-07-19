
namespace eAgenda.Forms.CompromissoModule
{
    partial class VisualizareExcluirCompromisso
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
            this.lblAdicionarTarefa = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvPassados = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assuntoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horainicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaFimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contatoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataSet1 = new System.Data.DataSet();
            this.tbcompasados = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.dataColumn5 = new System.Data.DataColumn();
            this.dataColumn6 = new System.Data.DataColumn();
            this.dataColumn7 = new System.Data.DataColumn();
            this.dataColumn8 = new System.Data.DataColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dvgFuturos = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assuntoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linkDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaInicioDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaFimDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contatoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataSet2 = new System.Data.DataSet();
            this.CpFutros = new System.Data.DataTable();
            this.dataColumn9 = new System.Data.DataColumn();
            this.dataColumn10 = new System.Data.DataColumn();
            this.dataColumn11 = new System.Data.DataColumn();
            this.dataColumn12 = new System.Data.DataColumn();
            this.dataColumn13 = new System.Data.DataColumn();
            this.dataColumn14 = new System.Data.DataColumn();
            this.dataColumn15 = new System.Data.DataColumn();
            this.dataColumn16 = new System.Data.DataColumn();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPassados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbcompasados)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgFuturos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CpFutros)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAdicionarTarefa
            // 
            this.lblAdicionarTarefa.AutoSize = true;
            this.lblAdicionarTarefa.Font = new System.Drawing.Font("Gadugi", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdicionarTarefa.Location = new System.Drawing.Point(12, 9);
            this.lblAdicionarTarefa.Name = "lblAdicionarTarefa";
            this.lblAdicionarTarefa.Size = new System.Drawing.Size(770, 57);
            this.lblAdicionarTarefa.TabIndex = 30;
            this.lblAdicionarTarefa.Text = "Visualizar e Excluir Compromisso";
            this.lblAdicionarTarefa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(22, 92);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(760, 246);
            this.tabControl1.TabIndex = 31;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvPassados);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(752, 220);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Compromissos Passados";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvPassados
            // 
            this.dgvPassados.AutoGenerateColumns = false;
            this.dgvPassados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPassados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.assuntoDataGridViewTextBoxColumn,
            this.localDataGridViewTextBoxColumn,
            this.linkDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.horainicioDataGridViewTextBoxColumn,
            this.horaFimDataGridViewTextBoxColumn,
            this.contatoDataGridViewTextBoxColumn});
            this.dgvPassados.DataMember = "Compromissos Passados";
            this.dgvPassados.DataSource = this.dataSet1;
            this.dgvPassados.Location = new System.Drawing.Point(3, 3);
            this.dgvPassados.Name = "dgvPassados";
            this.dgvPassados.Size = new System.Drawing.Size(740, 211);
            this.dgvPassados.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // assuntoDataGridViewTextBoxColumn
            // 
            this.assuntoDataGridViewTextBoxColumn.DataPropertyName = "Assunto";
            this.assuntoDataGridViewTextBoxColumn.HeaderText = "Assunto";
            this.assuntoDataGridViewTextBoxColumn.Name = "assuntoDataGridViewTextBoxColumn";
            // 
            // localDataGridViewTextBoxColumn
            // 
            this.localDataGridViewTextBoxColumn.DataPropertyName = "Local";
            this.localDataGridViewTextBoxColumn.HeaderText = "Local";
            this.localDataGridViewTextBoxColumn.Name = "localDataGridViewTextBoxColumn";
            // 
            // linkDataGridViewTextBoxColumn
            // 
            this.linkDataGridViewTextBoxColumn.DataPropertyName = "Link";
            this.linkDataGridViewTextBoxColumn.HeaderText = "Link";
            this.linkDataGridViewTextBoxColumn.Name = "linkDataGridViewTextBoxColumn";
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            // 
            // horainicioDataGridViewTextBoxColumn
            // 
            this.horainicioDataGridViewTextBoxColumn.DataPropertyName = "Horainicio";
            this.horainicioDataGridViewTextBoxColumn.HeaderText = "Horainicio";
            this.horainicioDataGridViewTextBoxColumn.Name = "horainicioDataGridViewTextBoxColumn";
            // 
            // horaFimDataGridViewTextBoxColumn
            // 
            this.horaFimDataGridViewTextBoxColumn.DataPropertyName = "HoraFim";
            this.horaFimDataGridViewTextBoxColumn.HeaderText = "HoraFim";
            this.horaFimDataGridViewTextBoxColumn.Name = "horaFimDataGridViewTextBoxColumn";
            // 
            // contatoDataGridViewTextBoxColumn
            // 
            this.contatoDataGridViewTextBoxColumn.DataPropertyName = "Contato";
            this.contatoDataGridViewTextBoxColumn.HeaderText = "Contato";
            this.contatoDataGridViewTextBoxColumn.Name = "contatoDataGridViewTextBoxColumn";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            this.dataSet1.Tables.AddRange(new System.Data.DataTable[] {
            this.tbcompasados});
            // 
            // tbcompasados
            // 
            this.tbcompasados.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3,
            this.dataColumn4,
            this.dataColumn5,
            this.dataColumn6,
            this.dataColumn7,
            this.dataColumn8});
            this.tbcompasados.TableName = "Compromissos Passados";
            // 
            // dataColumn1
            // 
            this.dataColumn1.Caption = "Id";
            this.dataColumn1.ColumnName = "Id";
            // 
            // dataColumn2
            // 
            this.dataColumn2.Caption = "Assunto";
            this.dataColumn2.ColumnName = "Assunto";
            // 
            // dataColumn3
            // 
            this.dataColumn3.Caption = "Local";
            this.dataColumn3.ColumnName = "Local";
            // 
            // dataColumn4
            // 
            this.dataColumn4.Caption = "Link";
            this.dataColumn4.ColumnName = "Link";
            // 
            // dataColumn5
            // 
            this.dataColumn5.Caption = "Data";
            this.dataColumn5.ColumnName = "Data";
            this.dataColumn5.DataType = typeof(System.DateTime);
            // 
            // dataColumn6
            // 
            this.dataColumn6.Caption = "HoraInicio";
            this.dataColumn6.ColumnName = "Horainicio";
            this.dataColumn6.DataType = typeof(System.TimeSpan);
            // 
            // dataColumn7
            // 
            this.dataColumn7.Caption = "horaFim";
            this.dataColumn7.ColumnName = "HoraFim";
            this.dataColumn7.DataType = typeof(System.TimeSpan);
            // 
            // dataColumn8
            // 
            this.dataColumn8.Caption = "Contato";
            this.dataColumn8.ColumnName = "Contato";
            this.dataColumn8.DataType = typeof(object);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dvgFuturos);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(752, 220);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Compromissos Futuros";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dvgFuturos
            // 
            this.dvgFuturos.AutoGenerateColumns = false;
            this.dvgFuturos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgFuturos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.assuntoDataGridViewTextBoxColumn1,
            this.localDataGridViewTextBoxColumn1,
            this.linkDataGridViewTextBoxColumn1,
            this.dataDataGridViewTextBoxColumn1,
            this.horaInicioDataGridViewTextBoxColumn1,
            this.horaFimDataGridViewTextBoxColumn1,
            this.contatoDataGridViewTextBoxColumn1});
            this.dvgFuturos.DataMember = "CpFuturos";
            this.dvgFuturos.DataSource = this.dataSet2;
            this.dvgFuturos.Location = new System.Drawing.Point(6, 3);
            this.dvgFuturos.Name = "dvgFuturos";
            this.dvgFuturos.Size = new System.Drawing.Size(740, 214);
            this.dvgFuturos.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            // 
            // assuntoDataGridViewTextBoxColumn1
            // 
            this.assuntoDataGridViewTextBoxColumn1.DataPropertyName = "Assunto";
            this.assuntoDataGridViewTextBoxColumn1.HeaderText = "Assunto";
            this.assuntoDataGridViewTextBoxColumn1.Name = "assuntoDataGridViewTextBoxColumn1";
            // 
            // localDataGridViewTextBoxColumn1
            // 
            this.localDataGridViewTextBoxColumn1.DataPropertyName = "Local";
            this.localDataGridViewTextBoxColumn1.HeaderText = "Local";
            this.localDataGridViewTextBoxColumn1.Name = "localDataGridViewTextBoxColumn1";
            // 
            // linkDataGridViewTextBoxColumn1
            // 
            this.linkDataGridViewTextBoxColumn1.DataPropertyName = "Link";
            this.linkDataGridViewTextBoxColumn1.HeaderText = "Link";
            this.linkDataGridViewTextBoxColumn1.Name = "linkDataGridViewTextBoxColumn1";
            // 
            // dataDataGridViewTextBoxColumn1
            // 
            this.dataDataGridViewTextBoxColumn1.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn1.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn1.Name = "dataDataGridViewTextBoxColumn1";
            // 
            // horaInicioDataGridViewTextBoxColumn1
            // 
            this.horaInicioDataGridViewTextBoxColumn1.DataPropertyName = "HoraInicio";
            this.horaInicioDataGridViewTextBoxColumn1.HeaderText = "HoraInicio";
            this.horaInicioDataGridViewTextBoxColumn1.Name = "horaInicioDataGridViewTextBoxColumn1";
            // 
            // horaFimDataGridViewTextBoxColumn1
            // 
            this.horaFimDataGridViewTextBoxColumn1.DataPropertyName = "HoraFim";
            this.horaFimDataGridViewTextBoxColumn1.HeaderText = "HoraFim";
            this.horaFimDataGridViewTextBoxColumn1.Name = "horaFimDataGridViewTextBoxColumn1";
            // 
            // contatoDataGridViewTextBoxColumn1
            // 
            this.contatoDataGridViewTextBoxColumn1.DataPropertyName = "Contato";
            this.contatoDataGridViewTextBoxColumn1.HeaderText = "Contato";
            this.contatoDataGridViewTextBoxColumn1.Name = "contatoDataGridViewTextBoxColumn1";
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "NewDataSet";
            this.dataSet2.Tables.AddRange(new System.Data.DataTable[] {
            this.CpFutros});
            // 
            // CpFutros
            // 
            this.CpFutros.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn9,
            this.dataColumn10,
            this.dataColumn11,
            this.dataColumn12,
            this.dataColumn13,
            this.dataColumn14,
            this.dataColumn15,
            this.dataColumn16});
            this.CpFutros.TableName = "CpFuturos";
            // 
            // dataColumn9
            // 
            this.dataColumn9.Caption = "Id";
            this.dataColumn9.ColumnName = "Id";
            // 
            // dataColumn10
            // 
            this.dataColumn10.Caption = "Assunto";
            this.dataColumn10.ColumnName = "Assunto";
            // 
            // dataColumn11
            // 
            this.dataColumn11.Caption = "Local";
            this.dataColumn11.ColumnName = "Local";
            // 
            // dataColumn12
            // 
            this.dataColumn12.Caption = "Link";
            this.dataColumn12.ColumnName = "Link";
            // 
            // dataColumn13
            // 
            this.dataColumn13.Caption = "Data";
            this.dataColumn13.ColumnName = "Data";
            this.dataColumn13.DataType = typeof(System.DateTime);
            // 
            // dataColumn14
            // 
            this.dataColumn14.Caption = "HoraInicio";
            this.dataColumn14.ColumnName = "HoraInicio";
            this.dataColumn14.DataType = typeof(System.TimeSpan);
            // 
            // dataColumn15
            // 
            this.dataColumn15.Caption = "HoraFim";
            this.dataColumn15.ColumnName = "HoraFim";
            this.dataColumn15.DataType = typeof(System.TimeSpan);
            // 
            // dataColumn16
            // 
            this.dataColumn16.Caption = "Contato";
            this.dataColumn16.ColumnName = "Contato";
            this.dataColumn16.DataType = typeof(object);
            // 
            // btnexcluir
            // 
            this.btnexcluir.BackColor = System.Drawing.Color.Red;
            this.btnexcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexcluir.Location = new System.Drawing.Point(252, 354);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(238, 74);
            this.btnexcluir.TabIndex = 32;
            this.btnexcluir.Text = "Excluir Compromisso";
            this.btnexcluir.UseVisualStyleBackColor = false;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // VisualizareExcluirCompromisso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnexcluir);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblAdicionarTarefa);
            this.Name = "VisualizareExcluirCompromisso";
            this.Text = "VizualizareExcluirCompromisso";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPassados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbcompasados)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgFuturos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CpFutros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdicionarTarefa;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvPassados;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dvgFuturos;
        private System.Windows.Forms.Button btnexcluir;
        private System.Data.DataSet dataSet1;
        private System.Data.DataSet dataSet2;
        private System.Data.DataTable tbcompasados;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataColumn dataColumn4;
        private System.Data.DataColumn dataColumn5;
        private System.Data.DataColumn dataColumn6;
        private System.Data.DataColumn dataColumn7;
        private System.Data.DataColumn dataColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn assuntoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn localDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn linkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horainicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaFimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contatoDataGridViewTextBoxColumn;
        private System.Data.DataTable CpFutros;
        private System.Data.DataColumn dataColumn9;
        private System.Data.DataColumn dataColumn10;
        private System.Data.DataColumn dataColumn11;
        private System.Data.DataColumn dataColumn12;
        private System.Data.DataColumn dataColumn13;
        private System.Data.DataColumn dataColumn14;
        private System.Data.DataColumn dataColumn15;
        private System.Data.DataColumn dataColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn assuntoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn localDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn linkDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaInicioDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaFimDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn contatoDataGridViewTextBoxColumn1;
    }
}