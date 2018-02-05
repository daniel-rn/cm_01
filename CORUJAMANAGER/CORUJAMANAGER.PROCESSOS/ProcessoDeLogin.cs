using CORUJAMANAGER.ENTIDADESDENEGOCIO;
using CORUJAMANAGER.MAPEADORES;

namespace CORUJAMANAGER.PROCESSOS
{
    public class ProcessoDeLogin
    {
        public bool ConsultaUsuarioLogin(SessaoDoUsuario sessaoDoUsuario)
        {
            var dtoComparacao = new MapeadorDeLogin().ExecutaConsultaUsuarioLogin(sessaoDoUsuario);

            return dtoComparacao.Equals(sessaoDoUsuario);
        }
    }
}
