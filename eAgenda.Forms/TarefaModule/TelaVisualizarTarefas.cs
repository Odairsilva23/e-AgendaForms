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
    public partial class TelaVisualizarTarefas : Form
    {
        Tarefa tarefa;
        ControladorTarefa controlador = new ControladorTarefa();
        public TelaVisualizarTarefas()
        {
            InitializeComponent();
            ListadeTarefasConcluidas();
            ListadeTarefasPendentes();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int indiceColuna = dgvConcluidas.SelectedCells[0].RowIndex;
            DataGridViewRow linhaSelecionada = dgvConcluidas.Rows[indiceColuna];
            int idSelecionado = Convert.ToInt32(linhaSelecionada.Cells[0].Value);
            controlador.Excluir(idSelecionado);

            int indiceColuna2 = dgvtarefaspendentes.SelectedCells[0].RowIndex;
            DataGridViewRow linhaSelecionada2 = dgvtarefaspendentes.Rows[indiceColuna2];
            int idSelecionado2 = Convert.ToInt32(linhaSelecionada2.Cells[0].Value);
            controlador.Excluir(idSelecionado2);

            ListadeTarefasConcluidas();
            ListadeTarefasPendentes();

        }
        private void ListadeTarefasPendentes()
        {
            List<Tarefa> tarefas = controlador.SelecionarTodasTarefasPendentes();

            foreach (var tarefa in tarefas)
            {
                var linha = dtPendentes.NewRow();

                linha["Id"] = tarefa.Id;
                linha["Titulo"] = tarefa.Titulo;
                linha["Prioridade"] = tarefa.Prioridade;
                linha["DataCriacao"] = tarefa.DataCriacao;
                linha["Percentual"] = tarefa.Percentual;


                dtPendentes.Rows.Add(linha);
            }

        }
        private void ListadeTarefasConcluidas()
        {
            List<Tarefa> tarefas = controlador.SelecionarTodasTarefasConcluidas();

            foreach (var tarefa in tarefas)
            {
                var linha = dtConcluidas.NewRow();

                linha["Id"] = tarefa.Id;
                linha["Titulo"] = tarefa.Titulo;
                linha["Prioridade"] = tarefa.Prioridade;
                linha["Data Conclusao"] = tarefa.DataConclusao;

                dtConcluidas.Rows.Add(linha);
            }

        }

        private void TelaVisualizarTarefas_Load(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
