using eAgenda.Controladores.ContatoModule;
using eAgenda.Controladores.Shared;
using eAgenda.Dominio.ContatoModule;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace eAgenda.Forms.ContatoModule
{
    public partial class TelaAdicionarContato : Form
    {
        Contato contato;
        Controlador<Contato> controlador = new ControladorContato();

        public TelaAdicionarContato()
        {
            InitializeComponent();
            ListadeContatos();

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            tBoxNome.Text = "";
            tBoxEmail.Text = "";
            mskTBoxTelefone.Text = "";
            tBoxEmpresa.Text = "";
            tBoxCargo.Text = "";
        }



        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtId.Text))
            {
                EditarContato();
                return;
            }

            InserirContato();
        }
        private void InserirContato()
        {
            contato = new Contato(tBoxNome.Text, tBoxEmail.Text, mskTBoxTelefone.Text, tBoxEmpresa.Text, tBoxCargo.Text);

            string resultadoValidacao = controlador.InserirNovo(contato);
            if (resultadoValidacao == "ESTA_VALIDO")
            {
                MessageBox.Show("Contato inserido com sucesso");
                Dispose();
            }
            else
                MessageBox.Show(resultadoValidacao);
        }
        private void EditarContato()
        {
            int id = Convert.ToInt32(txtId.Text);

            contato = new Contato(tBoxNome.Text, tBoxEmail.Text, mskTBoxTelefone.Text, tBoxEmpresa.Text, tBoxCargo.Text);

            string resultadoValidacao = controlador.Editar(id, contato);
            if (resultadoValidacao == "ESTA_VALIDO")
            {
                MessageBox.Show("Contato Editado com sucesso");
                Dispose();
            }
            else
                MessageBox.Show(resultadoValidacao);
        }
        private void ListadeContatos()
        {
            List<Contato> contatos = controlador.SelecionarTodos();

            foreach (Contato contato in contatos)
            {
                var linha = TabelaContatos.NewRow();

                linha["Id"] = contato.Id;
                linha["Nome"] = contato.Nome;
                linha["Email"] = contato.Email;
                linha["Telefone"] = contato.Telefone;
                linha["Empresa"] = contato.Empresa;
                linha["Cargo"] = contato.Cargo;

                TabelaContatos.Rows.Add(linha);
            }

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int indiceColuna = dgvContatos.SelectedCells[0].RowIndex;
            DataGridViewRow linhaSelecionada = dgvContatos.Rows[indiceColuna];
            int idSelecionado = Convert.ToInt32(linhaSelecionada.Cells[0].Value);
            controlador.Excluir(idSelecionado);
        }

 
        private void dgvContatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int Id = Convert.ToInt32(dgvContatos.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtId.Text = Id.ToString();
            tBoxNome.Text = dgvContatos.Rows[e.RowIndex].Cells[1].Value.ToString();
            tBoxEmail.Text = dgvContatos.Rows[e.RowIndex].Cells[2].Value.ToString();
            mskTBoxTelefone.Text = dgvContatos.Rows[e.RowIndex].Cells[3].Value.ToString();
            tBoxEmpresa.Text = dgvContatos.Rows[e.RowIndex].Cells[4].Value.ToString();
            tBoxCargo.Text = dgvContatos.Rows[e.RowIndex].Cells[5].Value.ToString();

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
