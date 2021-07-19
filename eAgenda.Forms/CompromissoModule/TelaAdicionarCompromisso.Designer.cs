
namespace eAgenda.Forms.CompromissoModule
{
    partial class TelaAdicionarCompromisso
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
            this.lblIdContato = new System.Windows.Forms.Label();
            this.rBtnRemoto = new System.Windows.Forms.RadioButton();
            this.rBtnPresencial = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHoraInicio = new System.Windows.Forms.Label();
            this.dataInicio = new System.Windows.Forms.DateTimePicker();
            this.lblDataCompromisso = new System.Windows.Forms.Label();
            this.tBoxLinkLocalizacao = new System.Windows.Forms.TextBox();
            this.lblLinkLocalizacao = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.tBoxAssunto = new System.Windows.Forms.TextBox();
            this.lblAssunto = new System.Windows.Forms.Label();
            this.cbContatos = new System.Windows.Forms.ComboBox();
            this.dataSet1 = new System.Data.DataSet();
            this.txthorainicio = new System.Windows.Forms.MaskedTextBox();
            this.txthorafim = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAdicionarTarefa
            // 
            this.lblAdicionarTarefa.AutoSize = true;
            this.lblAdicionarTarefa.Font = new System.Drawing.Font("Gadugi", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdicionarTarefa.Location = new System.Drawing.Point(251, 26);
            this.lblAdicionarTarefa.Name = "lblAdicionarTarefa";
            this.lblAdicionarTarefa.Size = new System.Drawing.Size(335, 57);
            this.lblAdicionarTarefa.TabIndex = 4;
            this.lblAdicionarTarefa.Text = "Compromisso";
            this.lblAdicionarTarefa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIdContato
            // 
            this.lblIdContato.AutoSize = true;
            this.lblIdContato.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdContato.Location = new System.Drawing.Point(33, 276);
            this.lblIdContato.Name = "lblIdContato";
            this.lblIdContato.Size = new System.Drawing.Size(301, 20);
            this.lblIdContato.TabIndex = 25;
            this.lblIdContato.Text = "Selecione o Contato da Sua Agenda";
            // 
            // rBtnRemoto
            // 
            this.rBtnRemoto.AutoSize = true;
            this.rBtnRemoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtnRemoto.Location = new System.Drawing.Point(627, 192);
            this.rBtnRemoto.Name = "rBtnRemoto";
            this.rBtnRemoto.Size = new System.Drawing.Size(80, 22);
            this.rBtnRemoto.TabIndex = 22;
            this.rBtnRemoto.Text = "Remoto";
            this.rBtnRemoto.UseVisualStyleBackColor = true;
            // 
            // rBtnPresencial
            // 
            this.rBtnPresencial.AutoSize = true;
            this.rBtnPresencial.Checked = true;
            this.rBtnPresencial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtnPresencial.Location = new System.Drawing.Point(492, 192);
            this.rBtnPresencial.Name = "rBtnPresencial";
            this.rBtnPresencial.Size = new System.Drawing.Size(95, 22);
            this.rBtnPresencial.TabIndex = 21;
            this.rBtnPresencial.TabStop = true;
            this.rBtnPresencial.Text = "Presencial";
            this.rBtnPresencial.UseVisualStyleBackColor = true;
            this.rBtnPresencial.CheckedChanged += new System.EventHandler(this.rBtnPresencial_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(369, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Hora Final";
            // 
            // lblHoraInicio
            // 
            this.lblHoraInicio.AutoSize = true;
            this.lblHoraInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraInicio.Location = new System.Drawing.Point(255, 171);
            this.lblHoraInicio.Name = "lblHoraInicio";
            this.lblHoraInicio.Size = new System.Drawing.Size(108, 16);
            this.lblHoraInicio.TabIndex = 17;
            this.lblHoraInicio.Text = "Hora de inicio";
            // 
            // dataInicio
            // 
            this.dataInicio.CustomFormat = "";
            this.dataInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataInicio.Location = new System.Drawing.Point(36, 194);
            this.dataInicio.Name = "dataInicio";
            this.dataInicio.Size = new System.Drawing.Size(216, 20);
            this.dataInicio.TabIndex = 16;
            // 
            // lblDataCompromisso
            // 
            this.lblDataCompromisso.AutoSize = true;
            this.lblDataCompromisso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataCompromisso.Location = new System.Drawing.Point(36, 171);
            this.lblDataCompromisso.Name = "lblDataCompromisso";
            this.lblDataCompromisso.Size = new System.Drawing.Size(183, 20);
            this.lblDataCompromisso.TabIndex = 12;
            this.lblDataCompromisso.Text = "Data do compromisso";
            // 
            // tBoxLinkLocalizacao
            // 
            this.tBoxLinkLocalizacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxLinkLocalizacao.Location = new System.Drawing.Point(36, 249);
            this.tBoxLinkLocalizacao.Name = "tBoxLinkLocalizacao";
            this.tBoxLinkLocalizacao.Size = new System.Drawing.Size(670, 24);
            this.tBoxLinkLocalizacao.TabIndex = 8;
            // 
            // lblLinkLocalizacao
            // 
            this.lblLinkLocalizacao.AutoSize = true;
            this.lblLinkLocalizacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLinkLocalizacao.Location = new System.Drawing.Point(37, 226);
            this.lblLinkLocalizacao.Name = "lblLinkLocalizacao";
            this.lblLinkLocalizacao.Size = new System.Drawing.Size(57, 20);
            this.lblLinkLocalizacao.TabIndex = 7;
            this.lblLinkLocalizacao.Text = "Local ";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(492, 353);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(101, 38);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(599, 353);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(108, 38);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.Location = new System.Drawing.Point(372, 353);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(114, 38);
            this.btnAdicionar.TabIndex = 4;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // tBoxAssunto
            // 
            this.tBoxAssunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxAssunto.Location = new System.Drawing.Point(37, 125);
            this.tBoxAssunto.Name = "tBoxAssunto";
            this.tBoxAssunto.Size = new System.Drawing.Size(670, 24);
            this.tBoxAssunto.TabIndex = 1;
            // 
            // lblAssunto
            // 
            this.lblAssunto.AutoSize = true;
            this.lblAssunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssunto.Location = new System.Drawing.Point(35, 98);
            this.lblAssunto.Name = "lblAssunto";
            this.lblAssunto.Size = new System.Drawing.Size(75, 20);
            this.lblAssunto.TabIndex = 0;
            this.lblAssunto.Text = "Assunto";
            // 
            // cbContatos
            // 
            this.cbContatos.FormattingEnabled = true;
            this.cbContatos.Location = new System.Drawing.Point(36, 299);
            this.cbContatos.Name = "cbContatos";
            this.cbContatos.Size = new System.Drawing.Size(298, 21);
            this.cbContatos.TabIndex = 26;
            this.cbContatos.TabStop = false;
            this.cbContatos.SelectedIndexChanged += new System.EventHandler(this.cbContatos_SelectedIndexChanged);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // txthorainicio
            // 
            this.txthorainicio.Location = new System.Drawing.Point(258, 194);
            this.txthorainicio.Mask = "90:00";
            this.txthorainicio.Name = "txthorainicio";
            this.txthorainicio.Size = new System.Drawing.Size(100, 20);
            this.txthorainicio.TabIndex = 27;
            this.txthorainicio.ValidatingType = typeof(System.DateTime);
            // 
            // txthorafim
            // 
            this.txthorafim.Location = new System.Drawing.Point(372, 194);
            this.txthorafim.Mask = "90:00";
            this.txthorafim.Name = "txthorafim";
            this.txthorafim.Size = new System.Drawing.Size(100, 20);
            this.txthorafim.TabIndex = 28;
            this.txthorafim.ValidatingType = typeof(System.DateTime);
            // 
            // TelaAdicionarCompromisso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(819, 417);
            this.Controls.Add(this.txthorafim);
            this.Controls.Add(this.txthorainicio);
            this.Controls.Add(this.cbContatos);
            this.Controls.Add(this.rBtnRemoto);
            this.Controls.Add(this.lblIdContato);
            this.Controls.Add(this.rBtnPresencial);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAdicionarTarefa);
            this.Controls.Add(this.lblHoraInicio);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.dataInicio);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblDataCompromisso);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.tBoxAssunto);
            this.Controls.Add(this.tBoxLinkLocalizacao);
            this.Controls.Add(this.lblAssunto);
            this.Controls.Add(this.lblLinkLocalizacao);
            this.MaximizeBox = false;
            this.Name = "TelaAdicionarCompromisso";
            this.Text = "eAgenda - Adicionar Compromisso";
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblAdicionarTarefa;
        private System.Windows.Forms.Label lblHoraInicio;
        private System.Windows.Forms.DateTimePicker dataInicio;
        private System.Windows.Forms.Label lblDataCompromisso;
        private System.Windows.Forms.TextBox tBoxLinkLocalizacao;
        private System.Windows.Forms.Label lblLinkLocalizacao;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.TextBox tBoxAssunto;
        private System.Windows.Forms.Label lblAssunto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rBtnRemoto;
        private System.Windows.Forms.RadioButton rBtnPresencial;
        private System.Windows.Forms.Label lblIdContato;
        private System.Windows.Forms.ComboBox cbContatos;
        private System.Data.DataSet dataSet1;
        private System.Windows.Forms.MaskedTextBox txthorainicio;
        private System.Windows.Forms.MaskedTextBox txthorafim;
    }
}