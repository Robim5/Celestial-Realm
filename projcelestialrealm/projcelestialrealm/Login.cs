using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//guardar senha em segurança
using System.Security.Cryptography;
using System.Text;
using System.Globalization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.IO;
using System.CodeDom;

namespace projcelestialrealm
{
    public partial class Login : Form
    {

        private conectar conexaologin;


        public Login()
        {
            InitializeComponent();
        }

        private void PreencherDias(int mes, int ano)
        {
            // Limpar itens existentes
            cbdia.Items.Clear();

            // Determinar o número de dias com base no mês e no ano selecionados
            int numeroDias;

            if (mes == 2) // Fevereiro
            {
                // Verificar se é um ano bissexto
                bool bissexto = DateTime.IsLeapYear(ano);
                numeroDias = bissexto ? 29 : 28;
            }
            else if (mes == 4 || mes == 6 || mes == 9 || mes == 11) // Abril, Junho, Setembro, Novembro
            {
                numeroDias = 30;
            }
            else
            {
                numeroDias = 31;
            }

            // Preencher ComboBox do dia com os dias correspondentes
            for (int i = 1; i <= numeroDias; i++)
            {
                cbdia.Items.Add(i);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

             /*//Preencher ComboBox do dia com valores de 1 a 31
            for (int i = 1; i <= 31; i++)
            {
               cbdia.Items.Add(i);
            }

             //Preencher ComboBox do mês com os nomes dos meses
            string[] meses = { "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro" };
            cbmes.Items.AddRange(meses);

            //Preencher ComboBox do ano com valores de 1900 a 2100 (você pode ajustar conforme necessário)
            for (int i = 1900; i <= 2024; i++)
            {
                cbano.Items.Add(i);
            }*/

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }


        //-------------------------------------------------------------------------------------------------------------------------
        //____---------------------------______________________--------SENHA---------------_________________-------------_----------
        //------------------------------------------------------------------------------------------------------------------------



        /* private string HashSenha(string senha)
         {
             using (SHA256 sha256 = SHA256.Create())
             {
                 byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(senha));
                 StringBuilder builder = new StringBuilder();

                 // Converte os bytes do hash para uma representação hexadecimal
                 foreach (byte b in bytes)
                 {
                     builder.Append(b.ToString("x2"));
                 }

                 return builder.ToString();
             }
         }*/



        //-------------------------------------------------------------------------------------------------------------------------
        //____---------------------------______________________--------EMAIL---------------_________________-------------_----------
        //------------------------------------------------------------------------------------------------------------------------

        // comentado

        //verificar se o email já existe
        /*private bool EmailJaCadastrado(string email)
        {
            string connectionString = "server=localhost;port=3306;user=root;password=mysql;database=trackeranime";
            string query = "SELECT COUNT(*) FROM users WHERE email = @email";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@email", email);

                try
                {
                    connection.Open();
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0; // Retorna true se o email já estiver cadastrado, caso contrário, retorna false
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro ao verificar o email cadastrado: " + ex.Message);
                    return false; // Em caso de erro, retorna false
                }
            }
        }*/


        //-------------------------------------------------------------------------------------------------------------------------
        //____-----------------------_______________-------- Inserir User ---------------_________________-------------_----------
        //------------------------------------------------------------------------------------------------------------------------



        /*private bool InserirUsuario(string nome, string genero, DateTime dataNascimento, string email, string senha)
        {
            // Data de entrada (data atual)
            DateTime dataEntrada = DateTime.Now;
            bool registado = true;

            // Conexão com o banco de dados
            string connectionString = "Server=localhost;Port=3306;Database=trackeranime;Uid=root;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Comando SQL para inserir o usuário
                    string query = "INSERT INTO users (nome, genero, data_nascimento, email, data_entrada, icon, senha, registado) VALUES (@Nome, @Genero, @DataNascimento, @Email, @DataEntrada, NULL, @Senha, true)";

                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@Nome", nome);
                    cmd.Parameters.AddWithValue("@Genero", genero);
                    cmd.Parameters.AddWithValue("@DataNascimento", dataNascimento);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@DataEntrada", dataEntrada);
                    cmd.Parameters.AddWithValue("@Senha", senha);

                    // Executar o comando SQL
                    int rowsAffected = cmd.ExecuteNonQuery();

                    // Verificar se o usuário foi inserido com sucesso
                    if (rowsAffected > 0)
                    {
                        return true; // Usuário inserido com sucesso
                    }
                    else
                    {
                        return false; // Falha ao inserir o usuário
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao inserir usuário: " + ex.Message);
                    return false; // Falha ao inserir o usuário
                }
            }
        }*/


        //-------------------------------------------------------------------------------------------------------------------------
        //____-----------------___________--------INICIAR SESSÃO---------------_____________----------_----------
        //------------------------------------------------------------------------------------------------------------------------

        public int UserID { get; set; }
        private void btniniciarsessao_Click(object sender, EventArgs e)
        {

            //----------------------------------------------------------------------------------------------------
            //------------------------------------------~ TENTATIVA 2 ----------------------------------------------
            //----------------------------------------------------------------------------------------------------

            

            // Valores dos campos do formulário
            string nome = txtnome.Text;
            string email = txtemail.Text;
            string password = txtpassword.Text;
            string genero = rbnfem.Checked ? "Feminino" : "Masculino";
            int dia = Convert.ToInt32(cbdia.SelectedItem);
            int mes = Convert.ToInt32(cbmes.SelectedItem);
            int ano = Convert.ToInt32(cbano.SelectedItem);

            // Validar se todos os campos foram preenchidos
            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password) || (!rbnfem.Checked && !rbnmasc.Checked) || dia == 0 || mes == 0 || ano == 0)
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios.");
                return;
            }

            // Montar a data de nascimento
            DateTime dataNascimento = new DateTime(ano, mes, dia);

            // Data de entrada (data atual)
            DateTime dataEntrada = DateTime.Now;

            // Definir se o usuário está registrado
            bool registado = true;

            // Inserir os dados na base de dados
            string connectionString = "Server=localhost;Port=3306;Database=trackeranime;Uid=root;Password=mysql;";
            string query = "SELECT * FROM users WHERE email = @email AND password = @password";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {

                    connection.Open();

                    string query_criar = "INSERT INTO users (nome, genero, data_nascimento, email, data_entrada, icon, password, registado) VALUES (@Nome, @Genero, @DataNascimento, @Email, @DataEntrada, NULL, @Password, @Registado)";
                    MySqlCommand cmd = new MySqlCommand(query_criar, connection);
                    cmd.Parameters.AddWithValue("@Nome", nome);
                    cmd.Parameters.AddWithValue("@Genero", genero);
                    cmd.Parameters.AddWithValue("@DataNascimento", dataNascimento);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@DataEntrada", dataEntrada);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.Parameters.AddWithValue("@Registado", registado);
                    int rowsAffected = cmd.ExecuteNonQuery();
                      
                    cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@password", password);

                    var reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        UserID = (int)reader["id_user"];
                    }
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Cadastro realizado com sucesso!");
                        Form1 formezinho = new Form1();
                        formezinho.Show();
                        MessageBox.Show("Agora que criou conta faça o login", "Conta Criada!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        System.Windows.Forms.Application.Restart();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Ocorreu um erro ao cadastrar o usuário. Por favor, tente novamente.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao inserir usuário: " + ex.Message);
                }
            }

            //// Valores dos campos do formulário
            //string nome = txtnome.Text;
            //string email = txtemail.Text;
            //string password = txtpassword.Text;
            //string genero = rbnfem.Checked ? "Feminino" : "Masculino";
            //int dia = Convert.ToInt32(cbdia.SelectedItem);
            //int mes = Convert.ToInt32(cbmes.SelectedItem);
            //int ano = Convert.ToInt32(cbano.SelectedItem);

            //// Validar se todos os campos foram preenchidos
            //if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password) || (!rbnfem.Checked && !rbnmasc.Checked) || dia == 0 || mes == 0 || ano == 0)
            //{
            //    MessageBox.Show("Por favor, preencha todos os campos obrigatórios.");
            //    return;
            //}

            //// Montar a data de nascimento
            //DateTime dataNascimento = new DateTime(ano, mes, dia);

            //// Data de entrada (data atual)
            //DateTime dataEntrada = DateTime.Now;

            //// Definir se o usuário está registrado
            //bool registado = true;

            //// Gerar código de salvamento único
            //string codigoSalvamento = Guid.NewGuid().ToString("N"); // Generate a unique code

            //// Inserir os dados na base de dados
            //string connectionString = "Server=localhost;Port=3306;Database=trackeranime;Uid=root;Password=mysql;";
            //using (MySqlConnection connection = new MySqlConnection(connectionString))
            //{
            //    try
            //    {
            //        connection.Open();
            //        string query = "INSERT INTO users (nome, genero, data_nascimento, email, data_entrada, icon, password, registado, codigosalv) VALUES (@Nome, @Genero, @DataNascimento, @Email, @DataEntrada, NULL, @Password, @Registado, @CodigoSalvamento)";
            //        MySqlCommand cmd = new MySqlCommand(query, connection);
            //        cmd.Parameters.AddWithValue("@Nome", nome);
            //        cmd.Parameters.AddWithValue("@Genero", genero);
            //        cmd.Parameters.AddWithValue("@DataNascimento", dataNascimento);
            //        cmd.Parameters.AddWithValue("@Email", email);
            //        cmd.Parameters.AddWithValue("@DataEntrada", dataEntrada);
            //        cmd.Parameters.AddWithValue("@Password", HashPassword(password)); // Hash the password
            //        cmd.Parameters.AddWithValue("@Registado", registado);
            //        cmd.Parameters.AddWithValue("@CodigoSalvamento", codigoSalvamento);
            //        int rowsAffected = cmd.ExecuteNonQuery();

            //        if (rowsAffected > 0)
            //        {
            //            MessageBox.Show("Cadastro realizado com sucesso!");
            //            principal Principal = new principal();
            //            Principal.Show();
            //            this.Hide();
            //        }
            //        else
            //        {
            //            MessageBox.Show("Ocorreu um erro ao cadastrar o usuário. Por favor, tente novamente.");
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        LogError(ex); // Log the exception
            //        MessageBox.Show("Erro ao inserir usuário. Por favor, tente novamente.");
            //    }
            //}

            //// Hash the password using a password hashing algorithm
            //string HashPassword(string password)
            //{
            //    // Implement a password hashing algorithm like bcrypt, scrypt, or PBKDF2
            //    // For demonstration purposes, I'll use a simple SHA256 hash
            //    using (SHA256 sha256 = SHA256.Create())
            //    {
            //        byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
            //        return BitConverter.ToString(bytes).Replace("-", "").ToLowerInvariant();
            //    }
            //}

            //// Log the exception
            //void LogError(Exception ex)
            //{
            //    // Implement a logging mechanism, e.g., using NLog or Serilog
            //    // For demonstration purposes, I'll use a simple Console.WriteLine
            //    Console.WriteLine($"Erro ao inserir usuário: {ex.Message}");
            //}




            //----------------------------------------------------------------------------------------------------
            //------------------------------------------TENTATIVA 1 ----------------------------------------------
            //----------------------------------------------------------------------------------------------------

            /*// Valores dos campos do formulário
            string nome = txtnome.Text;
            string email = txtemail.Text;
            string senha = txtpassword.Text;
            string genero = rbnfem.Checked ? "Feminino" : "Masculino";
            int dia = Convert.ToInt32(cbdia.SelectedItem);
            int mes = Convert.ToInt32(cbmes.SelectedItem);
            int ano = Convert.ToInt32(cbano.SelectedItem);

            // Validar se todos os campos foram preenchidos
            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(senha) ||
                (!rbnfem.Checked && !rbnmasc.Checked) || dia == 0 || mes == 0 || ano == 0)
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios.");
                return;
            }

            // Montar a data de nascimento
            DateTime dataNascimento = new DateTime(ano, mes, dia);

            // Verificar se o email já está cadastrado
            if (EmailJaCadastrado(email))
            {
                MessageBox.Show("Este email já está cadastrado. Por favor, use outro.");
                return;
            }

            // Inserir os dados na base de dados
            if (InserirUsuario(nome, genero, dataNascimento, email, senha))
            {
                MessageBox.Show("Cadastro realizado com sucesso!");
                // redirecionar para o formulário principal
                principal Principal = new principal();
                Principal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Ocorreu um erro ao cadastrar o usuário. Por favor, tente novamente.");
            }*/
        }







        //-------------------------------------------------------------------------------------------------------------------------
        //____---------------------------______________________--------DATA---------------_________________-------------_----------
        //------------------------------------------------------------------------------------------------------------------------





        private void cbmes_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obter o índice do mês selecionado (base 1)
            int mes = Convert.ToInt32(cbmes.SelectedItem);

            // Obter o ano selecionado
            int ano = cbano.SelectedIndex != -1 ? Convert.ToInt32(cbano.SelectedItem) : 0;

            // Preencher ComboBox do dia com base no mês e no ano selecionados
            if (mes != 0 && ano != 0)
            {
                PreencherDias(mes, ano);
            }
        }

        private void cbano_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obter o índice do mês selecionado (base 1)
            int mes = cbmes.SelectedIndex + 1;

            // Obter o ano selecionado
            int ano = Convert.ToInt32(cbano.SelectedItem);

            // Preencher ComboBox do dia com base no mês e no ano selecionados
            PreencherDias(mes, ano);
        }

        private void cbdia_Click(object sender, EventArgs e)
        {
            // Verificar se o ano e o mês foram selecionados
            if (cbano.SelectedIndex == -1 || cbmes.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, selecione primeiro o ano e o mês.");
                cbdia.SelectedIndex = -1; // Limpar a seleção do dia
            }
            else
            {
                // Obter o índice do mês selecionado (base 1)
                int mes = Convert.ToInt32(cbmes.SelectedItem);

                // Obter o ano selecionado
                int ano = Convert.ToInt32(cbano.SelectedItem);

                // Preencher ComboBox do dia com base no mês e no ano selecionados
                PreencherDias(mes, ano);
            }
        }

        private void cbmes_Click(object sender, EventArgs e)
        {
            // Verificar se o ano foi selecionado
            if (cbano.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, selecione primeiro o ano.");
                cbmes.SelectedIndex = -1; // Limpar a seleção do mês
            }
            else
            {
                // Habilitar o ComboBox de mês
                cbmes.Enabled = true;
                // Limpar itens existentes
                cbmes.Items.Clear();
                //Preencher ComboBox do mês com números de 1 a 12
                for (int i = 1; i <= 12; i++)
                {
                    cbmes.Items.Add(i);
                }
            }
        }

        private void cbano_Click(object sender, EventArgs e)
        {
            // Limpar itens existentes
            cbano.Items.Clear();
            // Habilitar o ComboBox de ano
            cbano.Enabled = true;
            //Preencher ComboBox do ano com valores de 1900 a 2100 (você pode ajustar conforme necessário)
            for (int i = 1900; i <= 2024; i++)
            {
                cbano.Items.Add(i);
            }
        }
    }
}
