using eAgenda.Dominio.CompromissoModule;
using eAgenda.Dominio.ContatoModule;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace eAgenda.Tests.CompromissoModule
{
    [TestClass]
    public class CompromissoTest
    {
        [TestMethod]
        public void DeveValidar_Assunto()
        {
            //arrange
            DateTime dataCompromisso = new DateTime(2021, 12, 12);
            TimeSpan dataInicio = new TimeSpan(12, 12, 12);
            TimeSpan dataTermino = new TimeSpan(12, 12, 13);

            var contato = new Contato("JP", "jp@gmail.com", "3251-8000", "JP Ltda.", "Dev");
            var compromisso = new Compromisso("", "MidiLages", "Presencial", dataCompromisso, dataInicio, dataTermino, contato);

            //action
            var resultadoValidacao = compromisso.Validar();

            //assert
            resultadoValidacao.Should().Be("O campo Assunto é obrigatório");
        }

        [TestMethod]
        public void DeveValidar_DataObrigatorio()
        {
            //arrange
            DateTime dataCompromisso = new DateTime();
            TimeSpan dataInicio = new TimeSpan(12, 12, 12);
            TimeSpan dataTermino = new TimeSpan(12, 12, 13);

            var contato = new Contato("JP", "jp@gmail.com", "3251-8000", "JP Ltda.", "Dev");
            var compromisso = new Compromisso("Reunião", "MidiLages", "Presencial", dataCompromisso, dataInicio, dataTermino, contato);

            //action
            var resultadoValidacao = compromisso.Validar();

            //assert
            resultadoValidacao.Should().Be("O campo Data é obrigatório");
        }

        [TestMethod]
        public void DeveValidar_DataInicio()
        {
            //arrange
            DateTime dataCompromisso = new DateTime(2021, 12, 12);
            TimeSpan dataInicio = TimeSpan.MinValue;
            TimeSpan dataTermino = new TimeSpan(12, 12, 13);

            var contato = new Contato("JP", "jp@gmail.com", "3251-8000", "JP Ltda.", "Dev");
            var compromisso = new Compromisso("Reunião", "MidiLages", "Presencial", dataCompromisso, dataInicio, dataTermino, contato);

            //action
            var resultadoValidacao = compromisso.Validar();

            //assert
            resultadoValidacao.Should().Be("O campo Hora Início é obrigatório");
        }

        [TestMethod]
        public void DeveValidar_DataTermino()
        {
            //arrange
            DateTime dataCompromisso = new DateTime(2021, 12, 12);
            TimeSpan dataInicio = new TimeSpan(12, 12, 12);
            TimeSpan dataTermino = TimeSpan.MinValue;

            var contato = new Contato("JP", "jp@gmail.com", "3251-8000", "JP Ltda.", "Dev");
            var compromisso = new Compromisso("Reunião", "MidiLages", "Presencial", dataCompromisso, dataInicio, dataTermino, contato);

            //action
            var resultadoValidacao = compromisso.Validar();

            //assert
            resultadoValidacao.Should().Be("O campo Hora Término é obrigatório");
        }
    }
}
