using System;

namespace CORUJAMANAGER.ENTIDADESDENEGOCIO
{
    public class SessaoDoUsuario
    {
        public Aluno Aluno { get; set; }

        public SessaoDoUsuario()
        {
            Aluno = new Aluno();
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            return ((SessaoDoUsuario)obj).Aluno.Nome == Aluno.Nome 
                   && ((SessaoDoUsuario)obj).Aluno.SenhaDeAcesso == Aluno.SenhaDeAcesso;
        }
    }
}