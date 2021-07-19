using eAgenda.Controladores.CompromissoModule;
using eAgenda.Controladores.ContatoModule;
using eAgenda.Controladores.Shared;
using eAgenda.Dominio.CompromissoModule;
using eAgenda.Dominio.ContatoModule;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace eAgenda.Forms.CompromissoModule
{
    public partial class TelaAdicionarCompromisso : Form
    {
        Controlador<Compromisso> controlador = new ControladorCompromisso();
        Controlador<Contato> controladorContato = new ControladorContato();
        Compromisso compromisso;
        Contato contato;
        public TelaAdicionarCompromisso()
        {
            InitializeComponent();
            CarregarContatos();
        }

        private void CarregarContatos()
        {
            List<Contato> Contatos = controladorContato.SelecionarTodos();
            cbContatos.Items.Clear();
            foreach (var contato in Contatos)
            {
                cbContatos.Items.Add(contato);
            }
            cbContatos.Equals(Contatos);
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            string link = "";
            string localizacao = "";
            TimeSpan horaInicio = TimeSpan.Parse(txthorainicio.Text);
            TimeSpan horaFim = TimeSpan.Parse(txthorafim.Text);
            if (rBtnPresencial.Checked == true)
                localizacao = tBoxLinkLocalizacao.Text;
            else
                link = tBoxLinkLocalizacao.Text;
            if (cbContatos.SelectedItem != null)
            compromisso = new Compromisso(tBoxAssunto.Text, localizacao, link, dataInicio.Value, horaInicio, horaFim, (Contato)cbContatos.SelectedItem);
            else 
                compromisso = new Compromisso(tBoxAssunto.Text, localizacao, link, dataInicio.Value, horaInicio, horaFim, (Contato)null);

            string resultado = controlador.InserirNovo(compromisso);

            if (resultado.Equals("ESTA_VALIDO"))
            {
                MessageBox.Show("Compromisso Inserido com sucesso.");
               
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            tBoxAssunto.Text = "";
            tBoxLinkLocalizacao.Text = "";
            dataInicio.Value = DateTime.Now;
            txthorafim.Text = "";
            txthorainicio.Text = "";
            
        }

        private void rBtnPresencial_CheckedChanged(object sender, EventArgs e)
        {
            if(rBtnPresencial.Checked == true)
                lblLinkLocalizacao.Text = "Local";
            else
                lblLinkLocalizacao.Text = "Link";
        }

        private void cbContatos_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }
 
    }
}
