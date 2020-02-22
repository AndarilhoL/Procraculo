using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BibliotecaOraculo
{
    public static class Conexao
    {
        private static string stringConexao = @"Server=localhost\SQLEXPRESS;Database=ProcraculoDB;Trusted_Connection=True;";
        public static SqlConnection conn = new SqlConnection();

        public static void TestarConexao()
        {
            try
            {
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
                else
                {
                    conn.ConnectionString = stringConexao;
                    conn.Open();
                    MessageBox.Show("Conexão Efetuada");
                }              
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex}");
            }
        }
    }
}
