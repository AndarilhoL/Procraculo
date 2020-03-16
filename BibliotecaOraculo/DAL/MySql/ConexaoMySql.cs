using BibliotecaOraculo.Entidades;
using MySql.Data.MySqlClient;

namespace BibliotecaOraculo.DAL
{
    public class ConexaoMySql : ConexaoAbstract
    {
        public ConexaoMySql(string stringConexao)
        {
            connection = new MySqlConnection(stringConexao);
        }
    }
}
