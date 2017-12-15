using System;
using CORUJAMANAGER.ENTIDADESDENEGOCIO;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace CORUJAMANAGER.TESTES.TESTE
{
    [Binding]
    public class CadastroDeAlunoSteps
    {
        private readonly Aluno _aluno = new Aluno();

        [Given(@"que eu informo o nome do aluno ""(.*)""")]
        public void DadoQueEuInformoONomeDoAluno(string nomedoAluno)
        {
            _aluno.Nome = nomedoAluno;
            Assert.AreEqual(_aluno.Nome, nomedoAluno);
        }

        [Given(@"que eu informo a senha do aluno ""(.*)""")]
        public void DadoQueEuInformoASenhaDoAluno(int senhaDoAluno)
        {
            _aluno.SenhaDeAcesso = senhaDoAluno.ToString();
        }

        [Then(@"vejo que o aluno tem a seguintes informacoes ""(.*)""")]
        public void EntaoVejoQueOAlunoTemASeguintesInformacoes(string informacoes)
        {
            var info = _aluno.Nome + _aluno.SenhaDeAcesso;
            Assert.AreEqual(info,informacoes);
        }
    }
}
