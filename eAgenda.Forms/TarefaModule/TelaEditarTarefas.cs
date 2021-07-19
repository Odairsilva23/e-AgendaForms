using eAgenda.Controladores.Shared;
using eAgenda.Controladores.TarefaModule;
using eAgenda.Dominio.TarefaModule;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eAgenda.Forms.TarefaModule
{
    public partial class TelaEditarTarefas : Form
    {
        Tarefa tarefa;
        ControladorTarefa controlador = new ControladorTarefa();
        public TelaEditarTarefas()
        {
            InitializeComponent();
            ListadeTarefasPendentes();
        }
        private void ListadeTarefasPendentes()
        {
            List<Tarefa> tarefas = controlador.SelecionarTodasTarefasPendentes();

            foreach (var tarefa in tarefas)
            {
                var linha = dataTarefasPendentes.NewRow();

                linha["Id"] = tarefa.Id;
                linha["Titulo"] = tarefa.Titulo;
                linha["Porcentagem"] = tarefa.Percentual;
                linha["DataCriacao"] = tarefa.DataCriacao;
                linha["Prioridade"] = tarefa.Prioridade;

                dataTarefasPendentes.Rows.Add(linha);
            }
            
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text); 

            Tarefa tarefaSelecionada = controlador.SelecionarPorId(id);

            Tarefa tarefa = new Tarefa(tBoxTitulo.Text, tarefaSelecionada.DataCriacao, (PrioridadeEnum)cBoxPrioridade.SelectedIndex);

            tarefa.AtualizarPercentual(Convert.ToInt32(mskconcluuido.Text), DateTime.Now);

            string resultado = controlador.Editar(id, tarefa);

            if (resultado.Equals("ESTA_VALIDO"))
            {
                MessageBox.Show("Compromisso Editado com sucesso.");

            }

            ListadeTarefasPendentes();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            tBoxTitulo.Text = "";
            cBoxPrioridade.SelectedItem = null;
            mskconcluuido.Text = "";
        }
      
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvTarefasPendentes_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dgvTarefasPendentes.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtId.Text = id.ToString();
            tBoxTitulo.Text = dgvTarefasPendentes.Rows[e.RowIndex].Cells[1].Value.ToString();
            cBoxPrioridade.Text = dgvTarefasPendentes.Rows[e.RowIndex].Cells[2].Value.ToString();
            mskconcluuido.Text = dgvTarefasPendentes.Rows[e.RowIndex].Cells[3].Value.ToString();
        }
    }
}
