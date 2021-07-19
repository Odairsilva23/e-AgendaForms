using eAgenda.Controladores.CompromissoModule;
using eAgenda.Dominio.CompromissoModule;
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
    public partial class VisualizareExcluirCompromisso : Form
    {
        ControladorCompromisso Ctcompromisso = new ControladorCompromisso();
        Compromisso compromissos;
        public VisualizareExcluirCompromisso()
        {
            InitializeComponent();
            CarregarCompromissosFuturos();
            CarregarCompromissosPassados();
        }

        private void CarregarCompromissosPassados()
        {
            List<Compromisso> compromissos = Ctcompromisso.SelecionarCompromissosPassados(DateTime.Now);

            foreach (var compromisso in compromissos)
            {
                var linha = tbcompasados.NewRow();

                linha["Id"] = compromisso.Id;
                linha["Assunto"] = compromisso.Assunto;
                linha["Local"] = compromisso.Local;
                linha["Data"] = compromisso.Data;
                linha["HoraInicio"] = compromisso.HoraInicio;
                linha["Horafim"] = compromisso.HoraTermino;
                linha["Contato"] = (compromisso.Contato != null) ? compromisso.Contato.Nome : null;

                tbcompasados.Rows.Add(linha);
            }
        }

        private void CarregarCompromissosFuturos()
        {
            var dataInicio = DateTime.Now;
            var dataFim = DateTime.MaxValue;
            List<Compromisso> compromissos = Ctcompromisso.SelecionarCompromissosFuturos(dataInicio,dataFim);

            foreach (var compromisso in compromissos)
            {
                var linha = CpFutros.NewRow();

                linha["Id"] = compromisso.Id;
                linha["Assunto"] = compromisso.Assunto;
                linha["Local"] = compromisso.Local;
                linha["Data"] = compromisso.Data;
                linha["HoraInicio"] = compromisso.HoraInicio;
                linha["Horafim"] = compromisso.HoraTermino;
                linha["Contato"] = (compromisso.Contato != null) ? compromisso.Contato.Nome : null;

                CpFutros.Rows.Add(linha);
            }
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            int indiceColuna = dgvPassados.SelectedCells[0].RowIndex;
            DataGridViewRow linhaSelecionada = dgvPassados.Rows[indiceColuna];
            int idSelecionado = Convert.ToInt32(linhaSelecionada.Cells[0].Value);
            Ctcompromisso.Excluir(idSelecionado);

            int indiceColuna2 = dvgFuturos.SelectedCells[0].RowIndex;
            DataGridViewRow linhaSelecionada2 = dvgFuturos.Rows[indiceColuna2];
            int idSelecionado2 = Convert.ToInt32(linhaSelecionada2.Cells[0].Value);
            Ctcompromisso.Excluir(idSelecionado2);

            CarregarCompromissosFuturos();
            CarregarCompromissosPassados();
        }
    }
}
