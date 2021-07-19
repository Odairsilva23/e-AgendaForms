
namespace eAgenda.Forms.CompromissoModule
{
    partial class EditarCompromisso
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
            this.cbContatos = new System.Windows.Forms.ComboBox();
            this.rBtnRemoto = new System.Windows.Forms.RadioButton();
            this.lblIdContato = new System.Windows.Forms.Label();
            this.rBtnPresencial = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAdicionarTarefa = new System.Windows.Forms.Label();
            this.lblHoraInicio = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.dataInicio = new System.Windows.Forms.DateTimePicker();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblDataCompromisso = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.tBoxAssunto = new System.Windows.Forms.TextBox();
            this.tBoxLinkLocalizacao = new System.Windows.Forms.TextBox();
            this.lblAssunto = new System.Windows.Forms.Label();
            this.lblLinkLocalizacao = new System.Windows.Forms.Label();
            this.dgvCompromissos = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assuntoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaInicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaFimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contatoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataSet1 = new System.Data.DataSet();
            this.TdsCompromissos = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.dataColumn5 = new System.Data.DataColumn();
            this.dataColumn6 = new System.Data.DataColumn();
            this.dataColumn7 = new System.Data.DataColumn();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txthorafim = new System.Windows.Forms.MaskedTextBox();
            this.txthorainicio = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompromissos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TdsCompromissos)).BeginInit();
            this.SuspendLayout();
            // 
            // cbContatos
            // 
            this.cbContatos.FormattingEnabled = true;
            this.cbContatos.Location = new System.Drawing.Point(67, 273);
            this.cbContatos.Name = "cbContatos";
            this.cbContatos.Size = new System.Drawing.Size(298, 21);
            this.cbContatos.TabIndex = 44;
            this.cbContatos.TabStop = false;
            // 
            // rBtnRemoto
            // 
            this.rBtnRemoto.AutoSize = true;
            this.rBtnRemoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtnRemoto.Location = new System.Drawing.Point(658, 166);
            this.rBtnRemoto.Name = "rBtnRemoto";
            this.rBtnRemoto.Size = new System.Drawing.Size(80, 22);
            this.rBtnRemoto.TabIndex = 42;
            this.rBtnRemoto.Text = "Remoto";
            this.rBtnRemoto.UseVisualStyleBackColor = true;
            // 
            // lblIdContato
            // 
            this.lblIdContato.AutoSize = true;
            this.lblIdContato.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdContato.Location = new System.Drawing.Point(64, 250);
            this.lblIdContato.Name = "lblIdContato";
            this.lblIdContato.Size = new System.Drawing.Size(301, 20);
            this.lblIdContato.TabIndex = 43;
            this.lblIdContato.Text = "Selecione o Contato da Sua Agenda";
            // 
            // rBtnPresencial
            // 
            this.rBtnPresencial.AutoSize = true;
            this.rBtnPresencial.Checked = true;
            this.rBtnPresencial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtnPresencial.Location = new System.Drawing.Point(523, 166);
            this.rBtnPresencial.Name = "rBtnPresencial";
            this.rBtnPresencial.Size = new System.Drawing.Size(95, 22);
            this.rBtnPresencial.TabIndex = 41;
            this.rBtnPresencial.TabStop = true;
            this.rBtnPresencial.Text = "Presencial";
            this.rBtnPresencial.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(400, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 39;
            this.label1.Text = "Hora Final";
            // 
            // lblAdicionarTarefa
            // 
            this.lblAdicionarTarefa.AutoSize = true;
            this.lblAdicionarTarefa.Font = new System.Drawing.Font("Gadugi", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdicionarTarefa.Location = new System.Drawing.Point(167, 9);
            this.lblAdicionarTarefa.Name = "lblAdicionarTarefa";
            this.lblAdicionarTarefa.Size = new System.Drawing.Size(482, 57);
            this.lblAdicionarTarefa.TabIndex = 29;
            this.lblAdicionarTarefa.Text = "Editar Compromisso";
            this.lblAdicionarTarefa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHoraInicio
            // 
            this.lblHoraInicio.AutoSize = true;
            this.lblHoraInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraInicio.Location = new System.Drawing.Point(286, 145);
            this.lblHoraInicio.Name = "lblHoraInicio";
            this.lblHoraInicio.Size = new System.Drawing.Size(108, 16);
            this.lblHoraInicio.TabIndex = 37;
            this.lblHoraInicio.Text = "Hora de inicio";
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(402, 262);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(114, 38);
            this.btnEditar.TabIndex = 30;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // dataInicio
            // 
            this.dataInicio.CustomFormat = "";
            this.dataInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataInicio.Location = new System.Drawing.Point(67, 168);
            this.dataInicio.Name = "dataInicio";
            this.dataInicio.Size = new System.Drawing.Size(216, 20);
            this.dataInicio.TabIndex = 36;
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(629, 262);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(108, 38);
            this.btnSair.TabIndex = 31;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblDataCompromisso
            // 
            this.lblDataCompromisso.AutoSize = true;
            this.lblDataCompromisso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataCompromisso.Location = new System.Drawing.Point(67, 145);
            this.lblDataCompromisso.Name = "lblDataCompromisso";
            this.lblDataCompromisso.Size = new System.Drawing.Size(183, 20);
            this.lblDataCompromisso.TabIndex = 35;
            this.lblDataCompromisso.Text = "Data do compromisso";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(522, 262);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(101, 38);
            this.btnLimpar.TabIndex = 32;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // tBoxAssunto
            // 
            this.tBoxAssunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxAssunto.Location = new System.Drawing.Point(68, 99);
            this.tBoxAssunto.Name = "tBoxAssunto";
            this.tBoxAssunto.Size = new System.Drawing.Size(539, 24);
            this.tBoxAssunto.TabIndex = 28;
            // 
            // tBoxLinkLocalizacao
            // 
            this.tBoxLinkLocalizacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxLinkLocalizacao.Location = new System.Drawing.Point(67, 223);
            this.tBoxLinkLocalizacao.Name = "tBoxLinkLocalizacao";
            this.tBoxLinkLocalizacao.Size = new System.Drawing.Size(670, 24);
            this.tBoxLinkLocalizacao.TabIndex = 34;
            // 
            // lblAssunto
            // 
            this.lblAssunto.AutoSize = true;
            this.lblAssunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssunto.Location = new System.Drawing.Point(66, 72);
            this.lblAssunto.Name = "lblAssunto";
            this.lblAssunto.Size = new System.Drawing.Size(75, 20);
            this.lblAssunto.TabIndex = 27;
            this.lblAssunto.Text = "Assunto";
            // 
            // lblLinkLocalizacao
            // 
            this.lblLinkLocalizacao.AutoSize = true;
            this.lblLinkLocalizacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLinkLocalizacao.Location = new System.Drawing.Point(68, 200);
            this.lblLinkLocalizacao.Name = "lblLinkLocalizacao";
            this.lblLinkLocalizacao.Size = new System.Drawing.Size(57, 20);
            this.lblLinkLocalizacao.TabIndex = 33;
            this.lblLinkLocalizacao.Text = "Local ";
            // 
            // dgvCompromissos
            // 
            this.dgvCompromissos.AllowUserToAddRows = false;
            this.dgvCompromissos.AllowUserToDeleteRows = false;
            this.dgvCompromissos.AutoGenerateColumns = false;
            this.dgvCompromissos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompromissos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.assuntoDataGridViewTextBoxColumn,
            this.localDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.horaInicioDataGridViewTextBoxColumn,
            this.horaFimDataGridViewTextBoxColumn,
            this.contatoDataGridViewTextBoxColumn});
            this.dgvCompromissos.DataMember = "TdsCompromissos";
            this.dgvCompromissos.DataSource = this.dataSet1;
            this.dgvCompromissos.Location = new System.Drawing.Point(37, 314);
            this.dgvCompromissos.Name = "dgvCompromissos";
            this.dgvCompromissos.ReadOnly = true;
            this.dgvCompromissos.Size = new System.Drawing.Size(751, 124);
            this.dgvCompromissos.TabIndex = 45;
            this.dgvCompromissos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dcgCompromissos_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // assuntoDataGridViewTextBoxColumn
            // 
            this.assuntoDataGridViewTextBoxColumn.DataPropertyName = "Assunto";
            this.assuntoDataGridViewTextBoxColumn.HeaderText = "Assunto";
            this.assuntoDataGridViewTextBoxColumn.Name = "assuntoDataGridViewTextBoxColumn";
            this.assuntoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // localDataGridViewTextBoxColumn
            // 
            this.localDataGridViewTextBoxColumn.DataPropertyName = "Local";
            this.localDataGridViewTextBoxColumn.HeaderText = "Local";
            this.localDataGridViewTextBoxColumn.Name = "localDataGridViewTextBoxColumn";
            this.localDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            this.dataDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // horaInicioDataGridViewTextBoxColumn
            // 
            this.horaInicioDataGridViewTextBoxColumn.DataPropertyName = "HoraInicio";
            this.horaInicioDataGridViewTextBoxColumn.HeaderText = "HoraInicio";
            this.horaInicioDataGridViewTextBoxColumn.Name = "horaInicioDataGridViewTextBoxColumn";
            this.horaInicioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // horaFimDataGridViewTextBoxColumn
            // 
            this.horaFimDataGridViewTextBoxColumn.DataPropertyName = "HoraFim";
            this.horaFimDataGridViewTextBoxColumn.HeaderText = "HoraFim";
            this.horaFimDataGridViewTextBoxColumn.Name = "horaFimDataGridViewTextBoxColumn";
            this.horaFimDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contatoDataGridViewTextBoxColumn
            // 
            this.contatoDataGridViewTextBoxColumn.DataPropertyName = "Contato";
            this.contatoDataGridViewTextBoxColumn.HeaderText = "Contato";
            this.contatoDataGridViewTextBoxColumn.Name = "contatoDataGridViewTextBoxColumn";
            this.contatoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            this.dataSet1.Tables.AddRange(new System.Data.DataTable[] {
            this.TdsCompromissos});
            // 
            // TdsCompromissos
            // 
            this.TdsCompromissos.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3,
            this.dataColumn4,
            this.dataColumn5,
            this.dataColumn6,
            this.dataColumn7});
            this.TdsCompromissos.TableName = "TdsCompromissos";
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
            this.dataColumn4.Caption = "Data";
            this.dataColumn4.ColumnName = "Data";
            this.dataColumn4.DataType = typeof(System.DateTime);
            // 
            // dataColumn5
            // 
            this.dataColumn5.Caption = "HoraInicio";
            this.dataColumn5.ColumnName = "HoraInicio";
            this.dataColumn5.DataType = typeof(System.TimeSpan);
            // 
            // dataColumn6
            // 
            this.dataColumn6.Caption = "HoraFim";
            this.dataColumn6.ColumnName = "HoraFim";
            this.dataColumn6.DataType = typeof(System.TimeSpan);
            // 
            // dataColumn7
            // 
            this.dataColumn7.Caption = "Contato";
            this.dataColumn7.ColumnName = "Contato";
            this.dataColumn7.DataType = typeof(object);
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(681, 99);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(56, 24);
            this.txtId.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(650, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 20);
            this.label2.TabIndex = 47;
            this.label2.Text = "Id";
            // 
            // txthorafim
            // 
            this.txthorafim.Location = new System.Drawing.Point(403, 171);
            this.txthorafim.Mask = "90:00";
            this.txthorafim.Name = "txthorafim";
            this.txthorafim.Size = new System.Drawing.Size(100, 20);
            this.txthorafim.TabIndex = 49;
            this.txthorafim.ValidatingType = typeof(System.DateTime);
            // 
            // txthorainicio
            // 
            this.txthorainicio.Location = new System.Drawing.Point(289, 171);
            this.txthorainicio.Mask = "90:00";
            this.txthorainicio.Name = "txthorainicio";
            this.txthorainicio.Size = new System.Drawing.Size(100, 20);
            this.txthorainicio.TabIndex = 48;
            this.txthorainicio.ValidatingType = typeof(System.DateTime);
            // 
            // EditarCompromisso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txthorafim);
            this.Controls.Add(this.txthorainicio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.dgvCompromissos);
            this.Controls.Add(this.cbContatos);
            this.Controls.Add(this.rBtnRemoto);
            this.Controls.Add(this.lblIdContato);
            this.Controls.Add(this.rBtnPresencial);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAdicionarTarefa);
            this.Controls.Add(this.lblHoraInicio);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.dataInicio);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lblDataCompromisso);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.tBoxAssunto);
            this.Controls.Add(this.tBoxLinkLocalizacao);
            this.Controls.Add(this.lblAssunto);
            this.Controls.Add(this.lblLinkLocalizacao);
            this.Name = "EditarCompromisso";
            this.Text = "EditarCompromisso";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompromissos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TdsCompromissos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbContatos;
        private System.Windows.Forms.RadioButton rBtnRemoto;
        private System.Windows.Forms.Label lblIdContato;
        private System.Windows.Forms.RadioButton rBtnPresencial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAdicionarTarefa;
        private System.Windows.Forms.Label lblHoraInicio;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.DateTimePicker dataInicio;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblDataCompromisso;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TextBox tBoxAssunto;
        private System.Windows.Forms.TextBox tBoxLinkLocalizacao;
        private System.Windows.Forms.Label lblAssunto;
        private System.Windows.Forms.Label lblLinkLocalizacao;
        private System.Windows.Forms.DataGridView dgvCompromissos;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn assuntoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn localDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaInicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaFimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contatoDataGridViewTextBoxColumn;
        private System.Data.DataSet dataSet1;
        private System.Data.DataTable TdsCompromissos;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataColumn dataColumn4;
        private System.Data.DataColumn dataColumn5;
        private System.Data.DataColumn dataColumn6;
        private System.Data.DataColumn dataColumn7;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txthorafim;
        private System.Windows.Forms.MaskedTextBox txthorainicio;
    }
}