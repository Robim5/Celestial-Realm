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


namespace projcelestialrealm
{
    public partial class listaanime : Form
    {

        private conectar conexaoListaAnime;
        BindingList<animes> listaanimes;

        public listaanime(conectar conexao)
        {
            InitializeComponent();
            this.conexaoListaAnime = conexao;
            // Não é necessário chamar ListarAnimes() aqui, pois você já chama no evento Load.
        }

        private void listaanime_Load(object sender, EventArgs e)
        {

            // Adicionar os itens à ComboBox
            cbselectpesq.Items.AddRange(new string[] { "Nome", "Gênero", "Temporadas" });


            ListarAnimes();

            dgvlista.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvlista.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvlista.MultiSelect = false;
            dgvlista.DataSource = listaanimes;
            dgvlista.Columns[0].Visible = false; // não mostra idanime
            dgvlista.Columns[3].Width = 80;
            dgvlista.Columns[4].Width = 80;
        }

        private void ListarAnimes()
        {
            listaanimes = new BindingList<animes>();
            string sqlanimes = "SELECT * FROM animes";

            using (MySqlConnection connection = conexaoListaAnime.ObterConexao())
            {
                try
                {
                    connection.Open();

                    using (MySqlCommand cmd = new MySqlCommand(sqlanimes, connection))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                listaanimes.Add(new animes(
                                    reader.GetInt32("id_anime"),
                                    reader.GetString("titulo"),
                                    reader.GetString("genero"),
                                    reader.GetString("sinopse"),
                                    reader.GetDouble("episodes"),
                                    reader.GetString("estado"),
                                    reader.GetInt32("temporadas"),
                                    reader.GetInt32("avaliação")));
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao listar animes: " + ex.Message);
                }
            }
        }




        //---------------------------------------------------------------------
        //-------------------------BOTAO PESQUISA------------------------------
        //---------------------------------------------------------------------

        

        private void btnpesq_Click(object sender, EventArgs e)
        {
            // Verificar se foi selecionada uma opção de pesquisa
            if (cbselectpesq.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, selecione uma opção de pesquisa.");
                return;
            }

            // Verificar se foi digitado um termo de pesquisa
            string termoPesquisa = txtpesquisa.Text.Trim();
            if (string.IsNullOrWhiteSpace(termoPesquisa))
            {
                MessageBox.Show("Por favor, digite um termo de pesquisa.");
                return;
            }

            // Determinar o campo de pesquisa com base na opção selecionada na ComboBox
            string campoPesquisa = "";
            switch (cbselectpesq.SelectedItem.ToString())
            {
                case "Nome":
                    campoPesquisa = "titulo";
                    break;
                case "Gênero":
                    campoPesquisa = "genero";
                    break;
                case "Temporadas":
                    campoPesquisa = "temporadas";
                    break;
                default:
                    MessageBox.Show("Opção de pesquisa inválida.");
                    return;
            }

            // Converter o termo de pesquisa e o conteúdo do campo para letras minúsculas para comparação insensível a maiúsculas e minúsculas
            termoPesquisa = termoPesquisa.ToLower();

            // Filtrar os resultados na DataGridView com base no campo de pesquisa e no termo de pesquisa
            foreach (DataGridViewRow row in dgvlista.Rows)
            {
                // Se o valor do campo na linha atual contiver o termo de pesquisa (independente de maiúsculas/minúsculas), mantenha a linha visível; caso contrário, oculte-a
                string valorCelula = row.Cells[campoPesquisa].Value.ToString().ToLower();
                row.Visible = valorCelula.Contains(termoPesquisa);
            }
        }


        //---------------------------------------------------------------------
        //-----------------------LABEL SAIR------------------------------------
        //---------------------------------------------------------------------

        private void label1_Click(object sender, EventArgs e)
        {
            principal Principal = new principal();
            Principal.Show();
            this.Hide();
        }

        private void dgvlista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
                if (e.ColumnIndex == dgvlista.Columns["titulo"].Index && e.RowIndex != -1)
                {
                    string anime = dgvlista.Rows[e.RowIndex].Cells["titulo"].Value.ToString();

                    string link = "";

                    // Associar cada anime ao seu link de imagem correspondente
                    switch (anime)
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

                    // Verificar se o link não está vazio antes de definir a imagem na PictureBox
                    if (!string.IsNullOrEmpty(link))
                    {
                        pcbimganime.Load(link);
                    }
                    else
                    {
                    pcbimganime.Image = null;
                    }
                }
            
        }

        private void cbselectpesq_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
