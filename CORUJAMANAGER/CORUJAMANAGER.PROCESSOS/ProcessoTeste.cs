using System.Diagnostics;
using CORUJAMANAGER.ENTIDADESDENEGOCIO;
using CORUJAMANAGER.MAPEADORES;

namespace CORUJAMANAGER.PROCESSOS
{
    public class ProcessoTeste
    {
        public void TesteDeMetodo(Aluno aluno)
        {
            Debug.WriteLine("Passamos Pelo Mapeador");
            new MapeadorTeste().MetodoTesteMapeador(aluno);
        }
    }
}
