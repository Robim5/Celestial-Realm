using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace projcelestialrealm
{
    public class conectar
    {
        private MySqlConnection conexao;


        public conectar(string datasource, int porta, string utilizador, string senha, string database)
        {
            string connectioninfo = $"datasource={datasource};port={porta};username={utilizador};password={senha};database={database};SslMode=none";
            conexao = new MySqlConnection(connectioninfo);
        }

        public void AbrirConexao()
        {
            try
            {
                if (conexao.State == ConnectionState.Closed)
                {
                    conexao.Open();
                    Console.WriteLine("Conexão aberta com sucesso!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao abrir conexão: " + ex.Message);
            }
        }

        public void FecharConexao()
        {
            try
            {
                if (conexao.State == ConnectionState.Open)
                {
                    conexao.Close();
                    Console.WriteLine("Conexão fechada com sucesso!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao fechar conexão: " + ex.Message);
            }
        }

        public MySqlConnection ObterConexao()
        {
            return conexao;
        }

        public void Dispose()
        {
            FecharConexao();
        }
    }
}
