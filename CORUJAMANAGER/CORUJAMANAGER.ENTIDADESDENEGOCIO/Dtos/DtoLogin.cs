using System;

namespace CORUJAMANAGER.ENTIDADESDENEGOCIO
{
    public class DtoLogin
    {
        public Aluno Aluno { get; set; }

        public DtoLogin()
        {
            Aluno = new Aluno();
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            return ((DtoLogin)obj).Aluno.Nome == Aluno.Nome && ((DtoLogin)obj).Aluno.SenhaDeAcesso == Aluno.SenhaDeAcesso;
        }
    }
}