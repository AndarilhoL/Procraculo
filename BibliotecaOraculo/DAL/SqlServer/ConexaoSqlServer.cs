using BibliotecaOraculo.Entidades;
using System.Data.SqlClient;

namespace BibliotecaOraculo
{
    public class ConexaoSqlServer : ConexaoAbstract
    {        
        public ConexaoSqlServer(string stringConexao)
        {
            connection = new SqlConnection(stringConexao);

        }
    }
}