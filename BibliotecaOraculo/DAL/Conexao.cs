using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BibliotecaOraculo
{
    public static class Conexao
    {
        private static string stringConexao = @"Server=localhost\SQLEXPRESS;Database=ProcraculoDB;Trusted_Connection=True;";
        private static SqlConnection conn;

        public static void TestarConexao()
        {
            try
            {
                conn.ConnectionString = stringConexao;

                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex}");
            }
        }
    }
}
