using System.Data.Common;
using CORUJAMANAGER.ENTIDADESDENEGOCIO;
using FirebirdSql.Data.FirebirdClient;

namespace CORUJAMANAGER.MAPEADORES
{
    public class MapeadorDeLogin
    {
        public DtoLogin ExecutaConsultaUsuarioLogin(DtoLogin dtoLogin)
        {
            Connection.Active(true);
            var comando = (FbCommand)Connection.ObtehaComando("select * from usuario");

            var dataReader = comando.ExecuteReader();

            var dto = new DtoLogin();

            while (dataReader.Read())
            {
                dto.Aluno.Nome = dataReader.GetString(1);
                //dataReader.GetString(2);
                dto.Aluno.SenhaDeAcesso= dataReader.GetString(3);
            }

            return dto;
        }
    }
}
