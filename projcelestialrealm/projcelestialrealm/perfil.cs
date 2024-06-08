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
using static System.Windows.Forms.LinkLabel;
using System.Text.RegularExpressions;

namespace projcelestialrealm
{
    public partial class perfil : Form
    {
        public perfil()
        {
            InitializeComponent();
        }

        string NumVisto(int user_id, string tipo)
        {
            string connectionString = "Server=localhost;Port=3306;Database=trackeranime;Uid=root;Password=mysql;";

            string query = "SELECT COUNT(*) FROM trackeranime.lista WHERE user_id = @user_id AND @tipo IS NOT NULL".Replace("@tipo", tipo);
           
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {

                    cmd.Parameters.AddWithValue("@user_id", user_id); //
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var saida = reader[reader.GetName(0)].ToString();
                            if(saida == "")
                            {
                                saida = "0";
                            }
                            return saida;
                        }
                    }

                }
             }
            return "0";

        }

        // Método público para retornar o UserID
       
        private void perfil_Load(object sender, EventArgs e)
        {

            txttrocarnom.Visible = false;
            btntrocarnom.Visible = false;
            btntrocarpass.Visible = false;
            btntrocaremail.Visible = false;
            txtemail.Visible = false;

            // Obter o ID do usuário a partir do Form1
            Form1 form1 = (Form1)Application.OpenForms["Form1"];
            int userId = form1.UserID;

            // Preencher os campos com os dados do usuário
            txtnumaver.Text = NumVisto(userId, "anime_aver").ToString();
            txtnumvistos.Text = NumVisto(userId, "anime_completos").ToString();
            txtempausa.Text = NumVisto(userId, "anime_pausa").ToString();
            txtdesistidos.Text = NumVisto(userId, "anime_dropados").ToString();
            txtparaver.Text = NumVisto(userId, "anime_paraassistir").ToString();

            // Exibir o ícone do usuário
            ExibirIconeUsuario(userId);

            PreencherInformacoesUsuario(form1.UserID);

            // Obter o ID do usuário a partir do Form1
            Form1 form2 = (Form1)Application.OpenForms["Form1"];
            int UserID = form1.UserID;

            // Exibe os dois primeiros animes favoritos do usuário nas labels
            ExibirAnimesFavoritos(UserID);


            //Form1 form1 = (Form1)Application.OpenForms["Form1"];

            //txtparaver.Text = NumVisto(form1.UserID, "anime_aver").ToString();
            //txtnumvistos.Text = NumVisto(form1.UserID, "anime_completos").ToString();
            //txtempausa.Text = NumVisto(form1.UserID, "anime_pausa").ToString();
            //txtdesistidos.Text = NumVisto(form1.UserID, "anime_dropados").ToString();
            //txtparaver.Text = NumVisto(form1.UserID, "anime_paraassistir").ToString();


            //ExibirIconeUsuario(form1.UserID);

        }
        string ObterImgAnime(string Nome)
        {
            string link = "Erro";
            switch (Nome)
            {
                case "Naruto":
                    link = "https://m.media-amazon.com/images/M/MV5BZmQ5NGFiNWEtMmMyMC00MDdiLTg4YjktOGY5Yzc2MDUxMTE1XkEyXkFqcGdeQXVyNTA4NzY1MzY@._V1_FMjpg_UX1000_.jpg";
                    break;
                case "One Piece":
                    link = "https://m.media-amazon.com/images/M/MV5BM2YwYTkwNjItNGQzNy00MWE1LWE1M2ItOTMzOGI1OWQyYjA0XkEyXkFqcGdeQXVyMTUzMTg2ODkz._V1_FMjpg_UX1000_.jpg";
                    break;
                case "Attack on Titan":
                    link = "https://m.media-amazon.com/images/M/MV5BNDFjYTIxMjctYTQ2ZC00OGQ4LWE3OGYtNDdiMzNiNDZlMDAwXkEyXkFqcGdeQXVyNzI3NjY3NjQ@._V1_FMjpg_UX1000_.jpg";
                    break;
                case "My Hero Academia":
                    link = "https://upload.wikimedia.org/wikipedia/en/5/5a/Boku_no_Hero_Academia_Volume_1.png";
                    break;
                case "Demon Slayer":
                    link = "https://m.media-amazon.com/images/M/MV5BZDZiZTZhMzgtYTY0ZC00OGUyLWE2NzgtMmM4MjA1YjUxN2YyXkEyXkFqcGdeQXVyMTA3MDk2NDg2._V1_.jpg";
                    break;
                case "Death Note":
                    link = "https://m.media-amazon.com/images/M/MV5BNjRiNmNjMmMtN2U2Yi00ODgxLTk3OTMtMmI1MTI1NjYyZTEzXkEyXkFqcGdeQXVyNjAwNDUxODI@._V1_FMjpg_UX1000_.jpg";
                    break;
                case "Fullmetal Alchemist: Brotherhood":
                    link = "https://m.media-amazon.com/images/M/MV5BZmEzN2YzOTItMDI5MS00MGU4LWI1NWQtOTg5ZThhNGQwYTEzXkEyXkFqcGdeQXVyNTA4NzY1MzY@._V1_FMjpg_UX1000_.jpg";
                    break;
                case "Sword Art Online":
                    link = "https://m.media-amazon.com/images/M/MV5BYjY4MDU2YjMtNzY1MC00ODg1LWIwMzYtMWE5YTA3YTI4ZjMxXkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_FMjpg_UX1000_.jpg";
                    break;
                case "Hunter x Hunter":
                    link = "https://m.media-amazon.com/images/M/MV5BNGM0YTk3MWEtN2JlZC00ZmZmLWIwMDktZTMxZGE5Zjc2MGExXkEyXkFqcGdeQXVyNjAwNDUxODI@._V1_FMjpg_UX1000_.jpg";
                    break;
                case "One Punch Man":
                    link = "https://m.media-amazon.com/images/M/MV5BZjJlNzE5YzEtYzQwYS00NTBjLTk5YzAtYzUwOWQyM2E3OGI2XkEyXkFqcGdeQXVyNTgyNTA4MjM@._V1_.jpg";
                    break;
                case "Cowboy Bebop":
                    link = "https://upload.wikimedia.org/wikipedia/en/a/a9/Cowboy_Bebop_key_visual.jpg";
                    break;
                case "Black Clover":
                    link = "https://upload.wikimedia.org/wikipedia/en/6/69/Black_Clover%2C_volume_1.jpg";
                    break;
                case "Haikyuu!!":
                    link = "https://m.media-amazon.com/images/M/MV5BNjkyNDI2MTgtN2Y3NS00M2RjLWJhNDMtMmNmZmUwMDQwZTE1XkEyXkFqcGdeQXVyNjAwNDUxODI@._V1_FMjpg_UX1000_.jpg";
                    break;
                case "Tokyo Ghoul":
                    link = "https://m.media-amazon.com/images/M/MV5BOTM5ZjA2YWMtYjY3Ny00ZDU1LTk1NjYtMzhjMGY5ZmZkMzgwL2ltYWdlL2ltYWdlXkEyXkFqcGdeQXVyNTAyODkwOQ@@._V1_FMjpg_UX1000_.jpg";
                    break;
                case "The Promised Neverland":
                    link = "https://m.media-amazon.com/images/M/MV5BMTYwYjYyZDgtMTQ3My00YTI4LThmZTUtZmU1MjllOWRlOTdhXkEyXkFqcGdeQXVyMzgxODM4NjM@._V1_FMjpg_UX1000_.jpg";
                    break;
                case "Fruits Basket":
                    link = "https://static.wikia.nocookie.net/fruitsbasket/images/b/ba/Fruits_Basket_2019_Poster_3.jpg/revision/latest?cb=20190317001057";
                    break;
                case "Re:Zero - Starting Life in Another World":
                    link = "https://m.media-amazon.com/images/M/MV5BN2NlM2Y5Y2MtYjU5Mi00ZjZiLWFjNjMtZDNiYzJlMjhkOWZiXkEyXkFqcGdeQXVyNjc2NjA5MTU@._V1_FMjpg_UX1000_.jpg";
                    break;
                case "My Youth Romantic Comedy Is Wrong, As I Expected":
                    link = "https://upload.wikimedia.org/wikipedia/en/c/ca/My_Teen_Romantic_Comedy_SNAFU_cover.jpg";
                    break;
                case "Fire Force":
                    link = "https://m.media-amazon.com/images/M/MV5BY2IyMDA0NGEtZjIyOS00NjU0LThlOTctODA0OTZmMDU2ZTMxXkEyXkFqcGdeQXVyMzgxODM4NjM@._V1_FMjpg_UX1000_.jpg";
                    break;
                case "Vinland Saga":
                    link = "https://resizing.flixster.com/-XZAfHZM39UwaGJIFWKAE8fS0ak=/v3/t/assets/p17127060_b_v9_aa.jpg";
                    break;
                default:
                    link = ""; // Se o anime não estiver na lista, deixe o link vazio
                    break;
            }
            return link;
        }
        private void ExibirAnimesFavoritos(int UserID)
        {
            // String de conexão com o banco de dados
            string connectionString = "Server=localhost;Port=3306;Database=trackeranime;Uid=root;Password=mysql;";

            // Consulta SQL para obter os dois primeiros animes favoritos do usuário
            string query = "SELECT favoritos FROM lista WHERE user_id = @user_id AND favoritos is not null LIMIT 2";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                // Abre a conexão com o banco de dados
                connection.Open();

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    // Adiciona o parâmetro `user_id` à consulta
                    cmd.Parameters.AddWithValue("@user_id", UserID);

                    // Executa a consulta e obtém os resultados
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        int count = 0;
                        while (reader.Read() && count < 2)
                        {
                            string nomeAnime = reader["favoritos"].ToString();

                            // Atualiza as labels com os nomes dos animes favoritos
                            if (count == 0)
                            {
                                lbanime1.Text = nomeAnime;
                                pcbanime1.ImageLocation = ObterImgAnime(nomeAnime);
                            }
                            else if (count == 1)
                            {
                                lbanime2.Text = nomeAnime;
                                pcbanime2.ImageLocation = ObterImgAnime(nomeAnime);

                            }

                            count++;
                        }
                    }
                }
            }
        }

        private void ExibirIconeUsuario(int userId)
        {
            // String de conexão com o banco de dados
            string connectionString = "Server=localhost;Port=3306;Database=trackeranime;Uid=root;Password=mysql;";

            // Consulta SQL para obter o ícone do usuário com base no UserID
            string query = "SELECT icon FROM users WHERE id_user = @user_id";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                // Abra a conexão com o banco de dados
                connection.Open();

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    // Adicione o parâmetro `user_id` à consulta
                    cmd.Parameters.AddWithValue("@user_id", userId);

                    // Execute a consulta e obtenha o ícone do usuário
                    object icon = cmd.ExecuteScalar();

                    // Verifique se o ícone não é nulo
                    if (icon != null && icon != DBNull.Value)
                    {
                        // Converta o ícone para um array de bytes
                        byte[] iconBytes = (byte[])icon;

                        // Crie um MemoryStream a partir dos dados do blob
                        using (MemoryStream ms = new MemoryStream(iconBytes))
                        {
                            // Crie uma imagem a partir do MemoryStream
                            try
                            {
                                pcbfotoperfil.Image = Image.FromStream(ms);
                            }
                            catch (ArgumentException)
                            {
                                MessageBox.Show("Os dados do ícone não representam uma imagem válida.");
                            }
                        }
                    }
                    else
                    {
                        // Caso o ícone seja nulo, exiba uma imagem padrão ou trate de outra forma
                        // Por exemplo, exiba uma mensagem de erro ou não exiba nada
                        MessageBox.Show("Ícone não encontrado para o usuário atual.");
                    }
                }
            }
        }

        private void SalvarNovaImagemUsuario(string imagePath, int userId)
        {
            // Converte a imagem em um array de bytes
            byte[] imageBytes = File.ReadAllBytes(imagePath);

            // String de conexão com o banco de dados
            string connectionString = "Server=localhost;Port=3306;Database=trackeranime;Uid=root;Password=mysql;";

            // Consulta SQL para atualizar o ícone do usuário na base de dados
            string query = "UPDATE users SET icon = @icon WHERE id_user = @user_id";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                // Abre a conexão com o banco de dados
                connection.Open();

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    // Adiciona os parâmetros à consulta
                    cmd.Parameters.AddWithValue("@icon", imageBytes);
                    cmd.Parameters.AddWithValue("@user_id", userId); // Certifique-se de ter o ID do usuário disponível aqui

                    // Executa a consulta
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Ícone do usuário atualizado com sucesso.");
                    }
                    else
                    {
                        MessageBox.Show("Falha ao atualizar o ícone do usuário.");
                    }
                }
            }
        }

        private void lbfechar_Click(object sender, EventArgs e)
        {
            principal Principal = new principal();
            Principal.Show();
            this.Hide();
        }

        private void pcbfotoperfil_Click(object sender, EventArgs e)
        {
            // Obtém a instância do Form1 aberto
            Form1 form1 = (Form1)Application.OpenForms["Form1"];

            // Verifica se form1 é diferente de null para evitar possíveis erros
            if (form1 != null)
            {
                // Cria uma instância do OpenFileDialog para selecionar uma nova imagem
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    // Configurações do OpenFileDialog
                    openFileDialog.Filter = "Arquivos de Imagem|*.jpg;*.jpeg;*.png;*.gif|Todos os arquivos|*.*";
                    openFileDialog.Title = "Selecione uma nova imagem";

                    // Exibe o diálogo para selecionar uma imagem
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            // Carrega a imagem selecionada na PictureBox
                            pcbfotoperfil.Image = Image.FromFile(openFileDialog.FileName);

                            // Salva a nova imagem no banco de dados
                            SalvarNovaImagemUsuario(openFileDialog.FileName, form1.UserID);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erro ao carregar a imagem: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Erro: Form1 não encontrado.");
            }
        }

        private void PreencherInformacoesUsuario(int userId)
        {
            // String de conexão com o banco de dados
            string connectionString = "Server=localhost;Port=3306;Database=trackeranime;Uid=root;Password=mysql;";

            // Consulta SQL para obter o nome do usuário e a data de entrada com base no UserID
            string query = "SELECT nome, data_entrada FROM users WHERE id_user = @user_id";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                // Abre a conexão com o banco de dados
                connection.Open();

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    // Adiciona o parâmetro `user_id` à consulta
                    cmd.Parameters.AddWithValue("@user_id", userId);

                    // Execute a consulta e obtenha o nome do usuário e a data de entrada
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Preenche a label com o nome do usuário
                            lbnomeuser.Text = reader["nome"].ToString();

                            // Preenche a label com a data de entrada do usuário (caso exista)
                            object dataEntrada = reader["data_entrada"];
                            if (dataEntrada != DBNull.Value)
                            {
                                DateTime data = Convert.ToDateTime(dataEntrada);
                                lbdataentrada.Text = data.ToString("dd/MM/yyyy");
                            }
                            else
                            {
                                lbdataentrada.Text = "Data de entrada não disponível";
                            }
                        }
                        else
                        {
                            MessageBox.Show("Usuário não encontrado.");
                        }
                    }
                }
            }
        }

        private void ExcluirConta(int userId)
        {
            // String de conexão com o banco de dados
            string connectionString = "Server=localhost;Port=3306;Database=trackeranime;Uid=root;Password=mysql;";

            // Consulta SQL para excluir a conta do usuário com base no UserID
            string query = "DELETE FROM users WHERE id_user = @user_id";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                // Abre a conexão com o banco de dados
                connection.Open();

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    // Adiciona o parâmetro `user_id` à consulta
                    cmd.Parameters.AddWithValue("@user_id", userId);

                    // Executa a consulta para excluir a conta
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Conta excluída com sucesso.");
                    }
                    else
                    {
                        MessageBox.Show("Falha ao excluir a conta.");
                    }
                }
            }
        }

        private void lblogout_Click(object sender, EventArgs e)
        {
            // Exibe um aviso para confirmar a exclusão da conta
            DialogResult result = MessageBox.Show("Tem certeza de que deseja excluir sua conta? Esta ação é irreversível.", "Confirmar Exclusão de Conta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            // Se o usuário confirmar a exclusão da conta, exclua-a e feche o programa
            if (result == DialogResult.Yes)
            {
                Form1 form1 = (Form1)Application.OpenForms["Form1"];
                ExcluirConta(form1.UserID);
                Application.Exit();
            }
        }

        private void AtualizarNomeUsuario(int userId, string novoNome)
        {
            // String de conexão com o banco de dados
            string connectionString = "Server=localhost;Port=3306;Database=trackeranime;Uid=root;Password=mysql;";

            // Consulta SQL para atualizar o nome do usuário com base no UserID
            string query = "UPDATE users SET nome = @novo_nome WHERE id_user = @user_id";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                // Abre a conexão com o banco de dados
                connection.Open();

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    // Adiciona os parâmetros à consulta
                    cmd.Parameters.AddWithValue("@novo_nome", novoNome);
                    cmd.Parameters.AddWithValue("@user_id", userId);

                    // Executa a consulta para atualizar o nome do usuário
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Nome atualizado com sucesso.");
                        btntrocarnom.Visible = false;
                        txttrocarnom.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Falha ao atualizar o nome.");
                    }
                }
            }
        }
    

        private void btntrocarnom_Click(object sender, EventArgs e)
        {
            // Obtém o ID do usuário a partir do Form1
            Form1 form1 = (Form1)Application.OpenForms["Form1"];
            int userId = form1.UserID;

            // Obtém o novo nome da textbox
            string novoNome = txttrocarnom.Text;

            // Atualiza a label com o novo nome
            lbnomeuser.Text = novoNome;

            // Atualiza o nome do usuário na base de dados
            AtualizarNomeUsuario(userId, novoNome);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txttrocarnom.Visible = true;
            btntrocarnom.Visible = true;
            btntrocaremail.Visible = false;
            btntrocarpass.Visible = false;
            txtemail.Visible = false;
        }

        private void btnchangepass_Click(object sender, EventArgs e)
        {
            txttrocarnom.Visible = true;
            btntrocarnom.Visible = false;
            btntrocarpass.Visible = true;
            btntrocaremail.Visible = false;
            txtemail.Visible= false;
        }

        private void btncangeemail_Click(object sender, EventArgs e)
        {
            txttrocarnom.Visible = false;
            btntrocarnom.Visible = false;
            btntrocarpass.Visible = false;
            btntrocaremail.Visible = true;
            txtemail.Visible = true;
        }

        private void AtualizarEmailUsuario(int userId, string novoEmail)
        {
            // Verifica se o novo email possui "@" e não possui espaços em branco
            if (novoEmail.Contains("@") && !novoEmail.Contains(" "))
            {
                // String de conexão com o banco de dados
                string connectionString = "Server=localhost;Port=3306;Database=trackeranime;Uid=root;Password=mysql;";

                // Consulta SQL para atualizar o email do usuário com base no UserID
                string query = "UPDATE users SET email = @novo_email WHERE id_user = @user_id";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    // Abre a conexão com o banco de dados
                    connection.Open();

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        // Adiciona os parâmetros à consulta
                        cmd.Parameters.AddWithValue("@novo_email", novoEmail);
                        cmd.Parameters.AddWithValue("@user_id", userId);

                        // Executa a consulta para atualizar o email do usuário
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Email atualizado com sucesso.");
                            txtemail.Visible = false;
                            btntrocaremail.Visible = false;
                        }
                        else
                        {
                            MessageBox.Show("Falha ao atualizar o email.");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("O email deve conter um '@' e não pode conter espaços em branco.");
            }
        }
        private void btntrocaremail_Click(object sender, EventArgs e)
        {
            // Obtém o ID do usuário a partir do Form1
            Form1 form1 = (Form1)Application.OpenForms["Form1"];
            int userId = form1.UserID;

            // Obtém o novo email da textbox
            string novoEmail = txtemail.Text;

            // Atualiza o email do usuário na base de dados se o formato for válido
            AtualizarEmailUsuario(userId, novoEmail);
        }

        private void AtualizarSenhaUsuario(int userId, string novaSenha)
        {
            // Verifica se a nova senha contém pelo menos uma letra e um número
            if (Regex.IsMatch(novaSenha, @"[a-zA-Z]") && Regex.IsMatch(novaSenha, @"\d"))
            {
                // String de conexão com o banco de dados
                string connectionString = "Server=localhost;Port=3306;Database=trackeranime;Uid=root;Password=mysql;";

                // Consulta SQL para atualizar a senha do usuário com base no UserID
                string query = "UPDATE users SET password = @nova_senha WHERE id_user = @user_id";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    // Abre a conexão com o banco de dados
                    connection.Open();

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        // Adiciona os parâmetros à consulta
                        cmd.Parameters.AddWithValue("@nova_senha", novaSenha);
                        cmd.Parameters.AddWithValue("@user_id", userId);

                        // Executa a consulta para atualizar a senha do usuário
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Senha atualizada com sucesso.");
                        }
                        else
                        {
                            MessageBox.Show("Falha ao atualizar a senha.");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("A senha deve conter pelo menos uma letra e um número.");
            }
        }

        private void btntrocarpass_Click(object sender, EventArgs e)
        {
            // Obtém o ID do usuário a partir do Form1
            Form1 form1 = (Form1)Application.OpenForms["Form1"];
            int userId = form1.UserID;

            // Obtém a nova senha da textbox
            string novaSenha = txttrocarnom.Text;

            // Atualiza a senha do usuário na base de dados se atender aos critérios
            AtualizarSenhaUsuario(userId, novaSenha);
        }
    }
}
