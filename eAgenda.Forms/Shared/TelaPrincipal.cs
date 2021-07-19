using eAgenda.Forms.CompromissoModule;
using eAgenda.Forms.ContatoModule;
using eAgenda.Forms.TarefaModule;
using System;
using System.Windows.Forms;

namespace eAgenda.Forms.Shared
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        #region Tarefa
        private void btnAdicionarTarefa_Click(object sender, EventArgs e)
        {
            TelaAdicionarTarefa tela = new TelaAdicionarTarefa();
            tela.Visible = true;
        }
        private void btnVisualizarTarefa_Click(object sender, EventArgs e)
        {
            TelaVisualizarTarefas telavisu = new TelaVisualizarTarefas();
            telavisu.Visible = true;
        }
        private void btnEditarTarefa_Click(object sender, EventArgs e)
        {
            TelaEditarTarefas tela = new TelaEditarTarefas();
            tela.Visible = true;

        }
        private void btnExcluirTarefa_Click(object sender, EventArgs e)
        {
            TelaVisualizarTarefas telavisu = new TelaVisualizarTarefas();
            telavisu.Visible = true;
        }
        #endregion

        #region Contato
        private void btnAdicionarContato_Click(object sender, EventArgs e)
        {
            TelaAdicionarContato tela = new TelaAdicionarContato();
            tela.Visible = true;
        }
        private void btnVisualizarContato_Click(object sender, EventArgs e)
        {
            TelaAdicionarContato tela = new TelaAdicionarContato();
            tela.Visible = true;
        }
        private void btnEditarContato_Click(object sender, EventArgs e)
        {
            TelaAdicionarContato tela = new TelaAdicionarContato();
            tela.Visible = true;
        }
        private void btnExcluirContato_Click(object sender, EventArgs e)
        {
            TelaAdicionarContato tela = new TelaAdicionarContato();
            tela.Visible = true;
        }
        #endregion

        #region Compromisso
        private void btnAdicionarCompromisso_Click(object sender, EventArgs e)
        {
            TelaAdicionarCompromisso tela = new TelaAdicionarCompromisso();
            tela.Visible = true;
        }
        private void btnVisualizarCompromisso_Click(object sender, EventArgs e)
        {
            VisualizareExcluirCompromisso tela = new VisualizareExcluirCompromisso();
            tela.Visible = true;
        }
        private void btnEditarCompromisso_Click(object sender, EventArgs e)
        {
            EditarCompromisso tela = new EditarCompromisso();
            tela.Visible = true;
        }
        private void btnExcluirCompromisso_Click(object sender, EventArgs e)
        {
            VisualizareExcluirCompromisso tela = new VisualizareExcluirCompromisso();
            tela.Visible = true;
        }

        #endregion

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();    
        }
    }
}
