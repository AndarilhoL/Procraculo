using System;
using System.Data.Common;

namespace BibliotecaOraculo.Entidades
{
    public abstract class ConexaoAbstract
    {
        public DbConnection connection;

        public void AbrirConexao()
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
        public void FecharConexao()
        {
            try
            {
                if(connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
        public bool TestarConexao()
        {
            try
            {                
                bool isAberta = false;

                if (connection.State == System.Data.ConnectionState.Closed)
                {

                    connection.Open();
                    isAberta = true;
                }

                return isAberta;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
