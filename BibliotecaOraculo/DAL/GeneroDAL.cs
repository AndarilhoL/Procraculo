using BibliotecaOraculo.Model;
using Renci.SshNet;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BibliotecaOraculo.DAL
{
    class GeneroDAL
    {
        private ConexaoSqlServer conexaoSql = new ConexaoSqlServer();


        public void Salvar(Genero genero)
        {
            //1- Forma de Inserir os Dados
            //conexaoSql.command.CommandText = $"INSERT INTO Genero (Nome) values('{genero.Descricao}')";

            conexaoSql.command.CommandText = $"INSERT INTO Genero (Nome) values(@nome)";
            conexaoSql.command.Parameters.AddWithValue("@nome", genero.Descricao);
            conexaoSql.AbrirConexao();
            conexaoSql.command.ExecuteNonQuery();
        }

        public List<Genero> BuscarAdapter()
        {
            conexaoSql.command.CommandText = $"SELECT * FROM Genero";
            conexaoSql.AbrirConexao();

            conexaoSql.dataAdapter = new SqlDataAdapter();
            conexaoSql.dataAdapter.SelectCommand = conexaoSql.command;

            DataSet dataSet = new DataSet();
            conexaoSql.dataAdapter.Fill(dataSet);

            List<Genero> generos = new List<Genero>();
            foreach (DataRow item in dataSet.Tables[0].Rows)
            {
                Genero genero = new Genero( descricao: item.Field<string>("Nome"), 
                                            idGenero: item.Field<long>("ID_Genero"));
                generos.Add(genero);
            }

            return generos;
        }

        public List<Genero> BuscarReader()
        {
            List<Genero> listaGenero = new List<Genero>();
            conexaoSql.command.CommandText = $"SELECT * FROM Genero";
            conexaoSql.AbrirConexao();

            conexaoSql.dataReader = conexaoSql.command.ExecuteReader();
            if (conexaoSql.dataReader.HasRows)
            {
                while (conexaoSql.dataReader.Read())
                {
                    Genero genero = new Genero(descricao: (string)conexaoSql.dataReader["Nome"],
                                                idGenero: (long)conexaoSql.dataReader["ID_Genero"]);

                    listaGenero.Add(genero);
                }
            }
            conexaoSql.dataReader.Close();

            return listaGenero;
        }

        public void Alterar(Genero genero, string descricao)
        {
            conexaoSql.command.CommandText =    $"UPDATE Genero " +
                                                $"SET Nome = (@nome)" +
                                                $"WHERE ID_Genero = (@idGenero)";
            conexaoSql.command.Parameters.AddWithValue("@nome", descricao);
            conexaoSql.command.Parameters.AddWithValue("@idGenero", genero.IdGenero);
            conexaoSql.AbrirConexao();
            conexaoSql.command.ExecuteNonQuery();
        }
    }
}
