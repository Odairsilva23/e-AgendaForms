using eAgenda.Controladores.CompromissoModule;
using eAgenda.Controladores.ContatoModule;
using eAgenda.Dominio.CompromissoModule;
using eAgenda.Dominio.ContatoModule;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eAgenda.Forms.CompromissoModule
{
    public partial class EditarCompromisso : Form
    {
        ControladorCompromisso controlador = new ControladorCompromisso();
        ControladorContato controladorContato = new ControladorContato();
        Compromisso compromisso1;
        private List<Contato> contatos;
        public EditarCompromisso()
        {
            InitializeComponent();
            CarregarCompromissos();
            CarregarContatos();
        }

      
        private void CarregarCompromissos()
        {
            dgvCompromissos.ClearSelection();

            List<Compromisso> compromissos = controlador.SelecionarTodos();

            foreach (Compromisso compromisso in compromissos)
            {
                var camposBanco = TdsCompromissos.NewRow();

                camposBanco["Id"] = compromisso.Id;
                camposBanco["Assunto"] = compromisso.Assunto;
                camposBanco["Local"] = compromisso.Local;
                camposBanco["Data"] = compromisso.Data.ToShortDateString();
                camposBanco["HoraInicio"] = compromisso.HoraInicio;
                camposBanco["HoraFim"] = compromisso.HoraTermino;
                camposBanco["Contato"] = (compromisso.Contato != null) ? compromisso.Contato.Nome : null;

                TdsCompromissos.Rows.Add(camposBanco);

            }

        }
        private void EditarCompromissos()
        {
            int id = Convert.ToInt32(txtId.Text);

            string assunto = tBoxAssunto.Text;
            string local = tBoxLinkLocalizacao.Text;
            string link = tBoxLinkLocalizacao.Text;
           DateTime data = dataInicio.Value;
            TimeSpan horaInicio = TimeSpan.Parse(txthorainicio.Text);
            TimeSpan horaTermino = TimeSpan.Parse(txthorafim.Text);
            Contato contato = contatos.Find(contatoSelect => contatoSelect.Nome == (string)cbContatos.SelectedItem);
            Compromisso compromissoEdit = new Compromisso(assunto, local, link, data, horaInicio, horaTermino, contato);
            string resultado = controlador.Editar(id, compromisso1);

            if (resultado.Equals("ESTA_VALIDO"))
            {
                MessageBox.Show("Compromisso Editado com sucesso.");

            }
            CarregarCompromissos();

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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EditarCompromissos();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            tBoxAssunto.ReadOnly = false;
            tBoxLinkLocalizacao.ReadOnly = false;
            dataInicio.Enabled = true;
            txthorainicio.Text = "";
            txthorafim.Text = "";
        
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dcgCompromissos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dgvCompromissos.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtId.Text = id.ToString();
            tBoxAssunto.Text = dgvCompromissos.Rows[e.RowIndex].Cells[1].Value.ToString();
            tBoxLinkLocalizacao.Text = dgvCompromissos.Rows[e.RowIndex].Cells[2].Value.ToString();
            tBoxLinkLocalizacao.Text = dgvCompromissos.Rows[e.RowIndex].Cells[3].Value.ToString();
            dataInicio.Text = dgvCompromissos.Rows[e.RowIndex].Cells[4].Value.ToString();
            txthorainicio.Text = dgvCompromissos.Rows[e.RowIndex].Cells[5].Value.ToString();
            txthorafim.Text = dgvCompromissos.Rows[e.RowIndex].Cells[6].Value.ToString();

        }
    }
}
