using System;
using System.Diagnostics;
using CORUJAMANAGER.ENTIDADESDENEGOCIO;

namespace CORUJAMANAGER.MAPEADORES
{
    public class MapeadorTeste
    {
        public void MetodoTesteMapeador(Aluno aluno)
        {
            Debug.WriteLine("Chegamos ao mapeador");
            Debug.WriteLine(aluno.Nome);
        }
    }
}
