using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace projcelestialrealm
{
    public partial class Alterar : Form
    {

        BindingList<animes> listaanimes;

        

        private string tituloAnimeSelecionado;
        private string categoriaSelecionada;
        public listauser ListaUserForm;
       

        public string CategoriaSelecionada { get; private set; }

        public Alterar()
        {
            InitializeComponent();
            
            
        }



        listauser formuserlista;


        //public string NomeAnime { get; private set; }
        //public string GeneroAnime { get; private set; }


        //--------------------------------------------------------------------------------
        //--------------------------LOUD---------------------------------------------
        //---------------------------------------------------------------------------

        private void Alterar_Load(object sender, EventArgs e)
        {
            /*txtgenero.Visible = false;
            txtsinopse.Visible = false;
            txtep.Visible = false;
            label1.Visible = false;
            cbcategoria.Visible = false;
            dgvadicionar.Visible = false;
            dgveliminar.Visible = false;
            btnadicionar.Visible = false;
            btneliminar.Visible = false;*/

            PreencherDataGridView(dgvadicionar);
            

        }



        

        //_-------------------------------------------------------------------------
        //----------------------RADIO BUTTON---------------------------------------
        //--------------------------------------------------------------------------

        /*private void rbadicionar_CheckedChanged(object sender, EventArgs e)
        {
            // Mostrar controles para adicionar
            txtgenero.Visible = true;
            txtsinopse.Visible = true;
            txtep.Visible = true;
            label1.Visible = true;
            cbcategoria.Visible = true;
            dgvadicionar.Visible = true;
            btnadicionar.Visible = true;

            dgveliminar.Visible = false;
            btneliminar.Visible = false;

            // Preencher o DataGridView dgvadicionar com os títulos dos animes
            PreencherDataGridView(dgvadicionar);
        }*/

        /*private void rbeliminar_CheckedChanged(object sender, EventArgs e)
        {
            // Mostrar controles para adicionar
            txtgenero.Visible = true;
            txtsinopse.Visible = true;
            txtep.Visible = true;
            label1.Visible = true;
            cbcategoria.Visible = true;
            dgveliminar.Visible = true;
            btneliminar.Visible = true;

            dgvadicionar.Visible = false;
            btnadicionar.Visible = false;

            // Preencher o DataGridView dgveliminar com os títulos dos animes da base de dados
            PreencherDataGridView(dgveliminar);

        }*/


        //------------------------------------------------------------------------
        //--------------------------PREENCHER DATAGRIDVIEW------------------------
        //------------------------------------------------------------------------

        private void PreencherDataGridView(DataGridView dgv)
        {
            dgv.DataSource = null; // Limpar qualquer fonte de dados anterior

            // Consultar a base de dados para obter os títulos dos animes
            string query = "SELECT titulo FROM animes";

            // Conexão com o banco de dados
            string connectionString = "server=localhost;port=3306;user=root;password=mysql;database=trackeranime";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                try
                {
                    connection.Open();

                    // Executar o comando SQL e preencher o DataGridView com os resultados
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dgv.DataSource = dataTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar os animes: " + ex.Message);
                }
            }
        }

        //-----------------------------------------------------------------------
        //----------------------- CELL CLICK (ERRO)-----------------------------
        //----------------------------------------------------------------------
        private void dgvadicionar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex >= 0)
            //{
            //    DataGridViewRow row = dgvadicionar.Rows[e.RowIndex];
            //    MostrarDetalhesAnime(row);
            //}
        }

        private void dgveliminar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex >= 0)
            //{
            //    DataGridViewRow row = dgveliminar.Rows[e.RowIndex];
            //    MostrarDetalhesAnime(row);
            //}
        }


       

        //------------------------------------------------------------------------
        //--------------------- MOSTRAR OS DETALHES -------------------------------
        //-----------------------------------------------------------------------
        private void MostrarDetalhesAnime(string tituloAnime)
        {
            // Consultar a base de dados para obter os detalhes do anime pelo título
            string query = "SELECT titulo, genero, sinopse, episodes, estado FROM animes WHERE titulo = @titulo";

            // Conexão com o banco de dados
            string connectionString = "server=localhost;port=3306;user=root;password=mysql;database=trackeranime";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                try
                {
                    connection.Open();
                    cmd.Parameters.AddWithValue("@titulo", tituloAnime);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Preencher as caixas de texto com os detalhes do anime
                            txtnome.Text = reader.GetString("titulo");
                            txtgenero.Text = reader.GetString("genero");
                            txtsinopse.Text = reader.GetString("sinopse");
                            txtep.Text = reader.GetString("episodes");

                            // Preencher a ComboBox com as opções disponíveis e selecionar o estado do anime
                            cbcategoria.Items.Clear();
                            cbcategoria.Items.AddRange(new string[] { "A ver", "Visto", "Para ver", "Desistido", "Em espera" });
                            cbcategoria.SelectedItem = reader.GetString("estado");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar os detalhes do anime: " + ex.Message);
                }
            }
        }


        //--------------------------------------------------------------------------
        //------------------------CELL CONTENT--------------------------------------
        //-------------------------------------------------------------------------

        /*private void dgveliminar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgveliminar.Rows[e.RowIndex];
                if (row.Cells["titulo"].Value != null)
                {
                    string titulo = row.Cells["titulo"].Value.ToString();
                    MostrarDetalhesAnime(titulo);
                }
            }
        }*/

        private void dgvadicionar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvadicionar.Rows[e.RowIndex];
                tituloAnimeSelecionado = row.Cells["titulo"].Value.ToString();
            }
        }



        /*private void PreencherCamposAnime(string tituloAnime)
        {
            // Consultar a base de dados para obter as informações do anime usando o título
            string query = "SELECT genero, sinopse, episodes FROM animes WHERE titulo = @titulo";

            // Conexão com o banco de dados
            string connectionString = "server=localhost;port=3306;user=root;password=mysql;database=trackeranime";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                try
                {
                    connection.Open();
                    cmd.Parameters.AddWithValue("@titulo", tituloAnime);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtnome.Text = reader.GetString("titulo");
                            txtgenero.Text = reader.GetString("genero");
                            txtsinopse.Text = reader.GetString("sinopse");
                            txtep.Text = reader.GetString("episodes");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao obter informações do anime: " + ex.Message);
                }
            }
        }*/


        //-------------------------------------------------------------------------------
        //----------------------- Adicionar ---------------------------------------------
        //------------------------------------------------------------------------------

        //public DataGridView dgvAtual = null;

        //public void RemoverAnime(string nomeAnime)
        //{
        //    foreach (DataGridView dgv in new DataGridView[] { ListaUserForm.dgvcontaver, ListaUserForm.dgvvistos, ListaUserForm.dgvempausa, ListaUserForm.dgvdesistidos, ListaUserForm.dgvparaver })
        //    {
        //        if (dgv == dgvAtual)
        //            continue; // Se for a DataGridView atual, pula para a próxima

        //        for (int i = dgv.Rows.Count - 1; i >= 0; i--)
        //        {
        //            if (dgv.Rows[i].Cells[0].Value != null && dgv.Rows[i].Cells[0].Value.ToString() == nomeAnime)
        //            {
        //                dgv.Rows.RemoveAt(i);
        //            }
        //        }
        //    }
        //}

        //public void AdicionarAnime(string nomeAnime, string generoAnime)
        //{
        //    int rowIndex = dgvAtual.Rows.Add();
        //    dgvAtual.Rows[rowIndex].Cells[0].Value = nomeAnime; // Adiciona o nome do anime na primeira coluna
        //    dgvAtual.Rows[rowIndex].Cells[1].Value = generoAnime; // Adiciona o genero do anime na segunda coluna
        //}


        private void btnadicionar_Click(object sender, EventArgs e)
        {


            // Obtenha os valores de nome, gênero e categoria dos campos de texto e seleção
            string nome = txtnome.Text;
            string genero = txtgenero.Text;
            string categoria = cbcategoria.SelectedItem.ToString();

            // Tenta obter a instância existente de listauser
            listauser formListaUser = (listauser)Application.OpenForms["listauser"];

            // Determine o UserID com base na instância de form alterar
            int userid;

            // Você pode determinar o `UserID` de onde for adequado, por exemplo:
            if (Application.OpenForms["Login"] != null)
            {
                // Caso tenha uma instância de Login aberta, obtenha o UserID de lá
                Login formLogin = (Login)Application.OpenForms["Login"];
                userid = formLogin.UserID;
            }
            else if (Application.OpenForms["Form1"] != null)
            {
                // Caso tenha uma instância de Form1 aberta, obtenha o UserID de lá
                Form1 form1 = (Form1)Application.OpenForms["Form1"];
                userid = form1.UserID;
            }
            else
            {
                // Se não conseguir encontrar uma instância para determinar o UserID, defina um valor padrão ou lance uma exceção, se necessário
                throw new InvalidOperationException("Não foi possível determinar o UserID.");
            }

            // Verifique se a instância de listauser existe
            if (formListaUser != null)
            {
                // Chama a função AdicionarAnime da instância existente de listauser, passando os parâmetros corretos
                formListaUser.AdicionarAnime(nome, genero, categoria, userid);
                // Opcional: você pode dar foco ou chamar outra função de formListaUser, dependendo das necessidades
                formListaUser.Focus();
            }
            else
            {
                // Caso não exista uma instância de listauser, você pode lidar com isso criando uma nova instância
                formListaUser = new listauser();
                formListaUser.AdicionarAnime(nome, genero, categoria, userid);
                formListaUser.Show();
                this.Hide();
            }



            //string nomeAnime = txtnome.Text;
            //string generoAnime = txtgenero.Text;

            //if (string.IsNullOrEmpty(nomeAnime) || string.IsNullOrEmpty(generoAnime))
            //{
            //    MessageBox.Show("Por favor, selecione um anime da datagridview.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            //if (ListaUserForm != null)
            //{
            //    ListaUserForm.AdicionarAnimeNaDataGridViewSelecionada(nomeAnime, generoAnime, cbcategoria.SelectedItem.ToString());
            //}
            //else
            //{
            //    MessageBox.Show("Erro: ListaUserForm não foi definido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}


            ////    // Verificar se dgvAtual foi corretamente atribuído
            ////    if (dgvAtual == null)
            ////    {
            ////        MessageBox.Show("Erro ao determinar a DataGridView correta.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            ////        return;
            ////    }

            //    // Remover o anime selecionado de todas as DataGridViews
            //   RemoverAnime(nomeAnime);

            ////    // Adicionar o anime selecionado à DataGridView correta
            ////    AdicionarAnime(nomeAnime, generoAnime);

            ////    listauser listausuario = new listauser();
            ////    listausuario.Show();






            //string nomeAnime = txtnome.Text;
            //string generoAnime = txtgenero.Text;

            //DataGridView dgvAtual = null;

            //switch (cbcategoria.SelectedItem.ToString())
            //{
            //    case "A ver":
            //        dgvAtual = ListaUserForm.dgvcontaver;

            //        break;
            //    case "Visto":
            //        dgvAtual = ListaUserForm.dgvvistos;

            //        break;
            //    case "Em espera":
            //        dgvAtual = ListaUserForm.dgvempausa;

            //        break;
            //    case "Desistido":
            //        dgvAtual = ListaUserForm.dgvdesistidos;
            //        break;
            //    case "Para ver":
            //        dgvAtual = ListaUserForm.dgvparaver;

            //        break;
            //}

            //// Verificar se dgvAtual foi corretamente atribuído
            //if (dgvAtual == null)
            //{
            //    MessageBox.Show("Erro ao determinar a DataGridView correta.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            //// Remover o anime selecionado de todas as DataGridViews
            //foreach (DataGridView dgv in new DataGridView[] { ListaUserForm.dgvcontaver, ListaUserForm.dgvvistos, ListaUserForm.dgvempausa, ListaUserForm.dgvdesistidos, ListaUserForm.dgvparaver })
            //{
            //    if (dgv == dgvAtual)
            //        continue; // Se for a DataGridView atual, pula para a próxima

            //    for (int i = dgv.Rows.Count - 1; i >= 0; i--)
            //    {
            //        if (dgv.Rows[i].Cells[0].Value != null && dgv.Rows[i].Cells[0].Value.ToString() == nomeAnime)
            //        {
            //            dgv.Rows.RemoveAt(i);
            //        }
            //    }
            //}

            //// Adicionar o anime selecionado à DataGridView correta
            //int rowIndex = dgvAtual.Rows.Add();
            //dgvAtual.Rows[rowIndex].Cells[0].Value = nomeAnime; // Adiciona o nome do anime na primeira coluna
            //dgvAtual.Rows[rowIndex].Cells[1].Value = generoAnime; // Adiciona o genero do anime na segunda coluna

            ////dgvAtual.Rows.Add(nomeAnime, generoAnime);

        }











        //---------------------------------------------------------------------------------------
        //---------------------------------------- BOTAO ELEMINAR--------------------------------
        //--------------------------------------------------------------------------------------


        private void btneliminar_Click(object sender, EventArgs e)
        {

        }

        private void dgvadicionar_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvadicionar.SelectedRows.Count > 0)
            {
                string tituloAnime = dgvadicionar.SelectedRows[0].Cells["titulo"].Value.ToString();
                MostrarDetalhesAnime(tituloAnime);
            }
        }

        private void cbcategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
                CategoriaSelecionada = cbcategoria.SelectedItem.ToString();
        }

        private void lbvoltar_Click(object sender, EventArgs e)
        {
            principal Principal = new principal();
            Principal.Show();
            this.Hide();
        }


        private void AdicionarFavorito(int userId, string nomeAnime)
        {
            // String de conexão com o banco de dados
            string connectionString = "Server=localhost;Port=3306;Database=trackeranime;Uid=root;Password=mysql;";

            // Consulta SQL para inserir o anime na lista de favoritos do usuário
            string query = "INSERT INTO lista (user_id, favoritos) VALUES (@user_id, @favoritos)";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                // Abre a conexão com o banco de dados
                connection.Open();

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    // Adiciona os parâmetros à consulta
                    cmd.Parameters.AddWithValue("@user_id", userId);
                    cmd.Parameters.AddWithValue("@favoritos", nomeAnime);

                    // Executa a consulta para adicionar o anime aos favoritos do usuário
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Anime adicionado aos favoritos com sucesso.");
                    }
                    else
                    {
                        MessageBox.Show("Falha ao adicionar o anime aos favoritos.");
                    }
                }
            }
        }
        private void btnfav_Click(object sender, EventArgs e)
        {
            // Obtém o ID do usuário a partir do Form1
            Form1 form1 = (Form1)Application.OpenForms["Form1"];
            int userId = form1.UserID;

            // Obtém o nome do anime da textbox
            string nomeAnime = txtnome.Text;

            // Adiciona o anime aos favoritos do usuário na base de dados
            AdicionarFavorito(userId, nomeAnime);
        }
    }
}
