using CORUJAMANAGER.ENTIDADESDENEGOCIO;
using CORUJAMANAGER.MAPEADORES;

namespace CORUJAMANAGER.PROCESSOS
{
    public class ProcessoDeLogin
    {
        public bool ConsultaUsuarioLogin(DtoLogin dtoLogin)
        {
            var dtoComparacao = new MapeadorDeLogin().ExecutaConsultaUsuarioLogin(dtoLogin);

            return dtoComparacao.Equals(dtoLogin);
        }
    }
}
