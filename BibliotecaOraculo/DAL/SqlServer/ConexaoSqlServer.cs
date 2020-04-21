using BibliotecaOraculo.Entidades;
using System.Data.SqlClient;

namespace BibliotecaOraculo
{
    public class ConexaoSqlServer : ConexaoAbstract
    {
        public string stringConexao = @"Server=localhost\SQLEXPRESS;Database=ProcraculoDB;Trusted_Connection=True;";
        public SqlCommand command;
        public SqlDataAdapter dataAdapter;
        public SqlDataReader dataReader;

        public ConexaoSqlServer()
        {
            connection = new SqlConnection(stringConexao);
            command = new SqlCommand();
            command.Connection = (SqlConnection)connection;
        }
    }
}