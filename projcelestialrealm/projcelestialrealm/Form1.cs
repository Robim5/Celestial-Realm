using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text;
using static System.Net.Mime.MediaTypeNames;


namespace projcelestialrealm
{
    public partial class Form1 : Form
    {
        List<Usuario> Listadonoanime;
        private conectar conexaoForm1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conexaoForm1 = new conectar("localhost", 3306, "root", "mysql", "trackeranime");
            conexaoForm1.AbrirConexao();

          
        }

        private void labellogin_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void lbfechar_Click(object sender, EventArgs e)
        {
            //conexaoForm1.FecharConexao();
            Close();
        }


        //public void Autenticar(string nomeOuEmail, string senha)
        //{
        //    try
        //    {
        //        string nome = nomeOuEmail;
        //        string email = nomeOuEmail;

        //        int indexSeparador = nomeOuEmail.IndexOf('@');

        //        if (indexSeparador != -1)
        //        {
        //            nome = nomeOuEmail.Substring(0, indexSeparador);
        //            email = nomeOuEmail.Substring(indexSeparador + 1);
        //        }

        //        // Passa a instância existente de conectar diretamente
        //        usuarios usuario = new usuarios(0, nome, "", DateTime.Now, email, DateTime.Now, null, senha, false, conexaoForm1);

        //        if (usuario.Autenticar(conexaoForm1))
        //        {
        //            principal Principal = new principal();
        //            Principal.Show();
        //            this.Hide();
        //        }
        //        else
        //        {
        //            MessageBox.Show("Nome, email ou senha incorretos. Tente novamente.", "Erro de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("Erro durante a autenticação: " + ex.Message);
        //        MessageBox.Show("Ocorreu um erro durante a autenticação. Por favor, tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}


        public static class UserContext
        {
            public static int UserId { get; set; }
        }
        public int UserID { get; set; }
        private void btnlogin_Click(object sender, EventArgs e)
        {


            /*string email = txtemail.Text;
            string password = txtpassword.Text;

            // Validação básica
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios.");
                return;
            }

            string connectionString = "server=localhost;port=3306;user=root;password=mysql;database=trackeranime";
            string query = "SELECT id FROM users WHERE email = @email AND password = @password";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@password", password);

                try
                {
                    connection.Open();
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        // Login bem-sucedido
                        int userId = Convert.ToInt32(result);
                        MessageBox.Show("Login bem-sucedido!");

                        // Armazene o ID do usuário para uso posterior
                        UserContext.UserId = userId;

                        // Abra o próximo formulário ou conceda acesso, etc.
                        principal Principal = new principal();
                        Principal.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Email de usuário ou senha incorretos. Tente novamente.");
                        // Limpar campos ou tomar outra ação conforme necessário
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro ao tentar fazer login: " + ex.Message);
                }
            }*/
           
            string email = txtemail.Text;
            string password = txtpassword.Text;


            // Validação básica
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios.");
                return;
            }

            string connectionString = "server=localhost;port=3306;user=root;password=mysql;database=trackeranime";
            string query = "SELECT * FROM users WHERE email = @email AND password = @password";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@password", password);

                try
                {
                    connection.Open();

                    bool existe = false;

                    var reader =(cmd.ExecuteReader());

                    while (reader.Read())
                    {
                        UserID = (int)reader["id_user"];
                        existe = true;
                    }

                    if (existe)
                    {
                        MessageBox.Show("Login bem-sucedido!");
                        // Aqui você pode abrir o próximo formulário, ou conceder acesso, etc.
                        principal Principal = new principal();
                        Principal.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Email de usuário ou senha incorretos. Tente novamente.");
                        // Limpar campos ou tomar outra ação conforme necessário
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro ao tentar fazer login: " + ex.Message);
                }


                //string nomeOuEmail = txtnomemeil.Text;
                //string senha = txtpassword.Text;

                // Chame o método Autenticar
                //Autenticar(nomeOuEmail, senha);
                //this.Hide();



            }
        }
    }
}

