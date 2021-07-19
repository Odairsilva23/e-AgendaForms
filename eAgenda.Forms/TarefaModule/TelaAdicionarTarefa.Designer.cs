
namespace eAgenda.Forms.TarefaModule
{
    partial class TelaAdicionarTarefa
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
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.cBoxPrioridade = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tBoxTitulo = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAdicionarTarefa
            // 
            this.lblAdicionarTarefa.AutoSize = true;
            this.lblAdicionarTarefa.Font = new System.Drawing.Font("Gadugi", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdicionarTarefa.Location = new System.Drawing.Point(274, 50);
            this.lblAdicionarTarefa.Name = "lblAdicionarTarefa";
            this.lblAdicionarTarefa.Size = new System.Drawing.Size(131, 44);
            this.lblAdicionarTarefa.TabIndex = 2;
            this.lblAdicionarTarefa.Text = "Tarefa";
            this.lblAdicionarTarefa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(460, 324);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(95, 31);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(568, 324);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(88, 31);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.Location = new System.Drawing.Point(359, 324);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(88, 31);
            this.btnAdicionar.TabIndex = 4;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // cBoxPrioridade
            // 
            this.cBoxPrioridade.FormattingEnabled = true;
            this.cBoxPrioridade.Items.AddRange(new object[] {
            "Baixa",
            "Média",
            "Alta"});
            this.cBoxPrioridade.Location = new System.Drawing.Point(27, 243);
            this.cBoxPrioridade.Name = "cBoxPrioridade";
            this.cBoxPrioridade.Size = new System.Drawing.Size(155, 21);
            this.cBoxPrioridade.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Prioridade";
            // 
            // tBoxTitulo
            // 
            this.tBoxTitulo.Location = new System.Drawing.Point(27, 160);
            this.tBoxTitulo.Name = "tBoxTitulo";
            this.tBoxTitulo.Size = new System.Drawing.Size(670, 20);
            this.tBoxTitulo.TabIndex = 1;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(30, 133);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(56, 24);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Título";
            // 
            // TelaAdicionarTarefa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(709, 399);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lblAdicionarTarefa);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.tBoxTitulo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.cBoxPrioridade);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "TelaAdicionarTarefa";
            this.Text = "eAgenda - Adicionar Tarefa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdicionarTarefa;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.ComboBox cBoxPrioridade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBoxTitulo;
        private System.Windows.Forms.Label lblTitulo;
    }
}