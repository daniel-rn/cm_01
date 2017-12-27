using System.Data.Common;
using FirebirdSql.Data.FirebirdClient;

namespace CORUJAMANAGER.MAPEADORES
{
    public static class Connection
    {
        public static FbConnection Conexao { get; private set; }

        public static FbCommandBuilder CommandBuilder { get; } = new FbCommandBuilder();

        public static bool Active(bool bActive)
        {
            if (bActive)
            {
                Conexao = new FbConnection(ObtenhaConfiguracoesBanco());
                Conexao.Open();
                return true;
            }
            Conexao.Close();
            return false;
        }

        private static string ObtenhaConfiguracoesBanco()
        {
            var configuracoesBanco = "User=SYSDBA;Password=masterkey";
            configuracoesBanco += ";Database = C:\\WorkNascimento\\BASEDEDADOS\\CADASTRO";
            configuracoesBanco += ";Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;";
            configuracoesBanco += "Connection timeout=7;Pooling=True;Packet Size=8192;Server Type=0";
            return configuracoesBanco;
        }

        public static FbTransaction ObtenhaFbTransaction()
        {
            Active(true);
            return Conexao.BeginTransaction();
        }

        public static DbCommand ObtenhaDbComando(string sql)
        {
            Active(true);
            return new FbCommand(sql,Conexao);
        }
    }
}
