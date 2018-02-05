using CORUJAMANAGER.ENTIDADESDENEGOCIO;

namespace CORUJAMANAGER.MAPEADORES
{
    public class MapeadorDeLogin
    {
        public SessaoDoUsuario ExecutaConsultaUsuarioLogin(SessaoDoUsuario sessaoUsuario)
        {
            var sessaoDoUsuario = new SessaoDoUsuario();
            using (Connection.ObtenhaFbTransaction())
            {
                var comando = Connection.ObtenhaDbComando("select * from usuario");
                var dataReader = comando.ExecuteReader();
                
                while (dataReader.Read())
                {
                    sessaoDoUsuario.Aluno.Nome = dataReader.GetString(1);
                    sessaoDoUsuario.Aluno.SenhaDeAcesso = dataReader.GetString(3);
                }
            }
            
            return sessaoDoUsuario;
        }
    }
}
