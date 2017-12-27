using CORUJAMANAGER.ENTIDADESDENEGOCIO;

namespace CORUJAMANAGER.MAPEADORES
{
    public class MapeadorDeLogin
    {
        public DtoLogin ExecutaConsultaUsuarioLogin(DtoLogin dtoLogin)
        {
            var dto = new DtoLogin();
            using (Connection.ObtenhaFbTransaction())
            {
                var comando = Connection.ObtenhaDbComando("select * from usuario");
                var dataReader = comando.ExecuteReader();
                
                while (dataReader.Read())
                {
                    dto.Aluno.Nome = dataReader.GetString(1);
                    dto.Aluno.SenhaDeAcesso = dataReader.GetString(3);
                }
            }
            
            return dto;
        }
    }
}
