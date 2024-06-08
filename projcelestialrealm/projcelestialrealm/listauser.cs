using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projcelestialrealm
{



    public partial class listauser : Form
    {
        BindingList<animes> listaanimes;
        private conectar conexaolistauser;

        //public Alterar ListaUserForm { get; set; }



        public listauser()
        {
            InitializeComponent();

            // Instancia o formulário "Alterar" e define a propriedade ListaUserForm
            //ListaUserForm = new Alterar(this);
            //ListaUserForm.Show();

        }




        //public void DetermineUserID(bool isLoggedIn)
        //{
        //    int userid;

        //    if (isLoggedIn)
        //    {
        //        // Se o usuário fez login, usar o UserID do Form1
        //        Form1 form1 = (Form1)Application.OpenForms["Form1"];
        //        if (form1 != null)
        //        {
        //            userid = form1.UserID;
        //        }
        //        else
        //        {
        //            throw new InvalidOperationException("Form1 não encontrado.");
        //        }
        //    }
        //    else
        //    {
        //        // Se o usuário criou conta, usar o UserID do formulário Login
        //        Login form2 = (Login)Application.OpenForms["Login"];
        //        if (form2 != null)
        //        {
        //            userid = form2.UserID;
        //        }
        //        else
        //        {
        //            throw new InvalidOperationException("Login form não encontrado.");
        //        }
        //    }

        //    // Agora você pode usar o `userid` conforme necessário
        //    // Por exemplo, passar `userid` para o método `AdicionarAnime`:
        //    // AdicionarAnime(nome, genero, categoria, userid);
        //}



        public int DetermineUserID(bool isLoggedIn)
        {
            int userid;

            if (isLoggedIn)
            {
                // Se o usuário fez login, usar o UserID do Form1
                Form1 form1 = (Form1)Application.OpenForms["Form1"];
                if (form1 != null)
                {
                    userid = form1.UserID;
                }
                else
                {
                    throw new InvalidOperationException("Form1 não encontrado.");
                }
            }
            else
            {
                // Se o usuário criou conta, usar o UserID do formulário Login
                Login form2 = (Login)Application.OpenForms["Login"];
                if (form2 != null)
                {
                    userid = form2.UserID;
                }
                else
                {
                    throw new InvalidOperationException("Login form não encontrado.");
                }
            }

            // Retorne o `userid` calculado
            return userid;
        }


        private void CarregarEPreencherDataGridViewPorCampos(int userId)
        {
            // String de conexão com o banco de dados
            string connectionString = "Server=localhost;Port=3306;Database=trackeranime;Uid=root;Password=mysql;";

            // Estrutura para armazenar as consultas SQL com base nos campos de interesse
            Dictionary<string, (string query, DataGridView dgv)> queries = new Dictionary<string, (string, DataGridView)>
    {
        { "anime_aver", ("SELECT * FROM lista WHERE user_id = @user_id AND anime_aver IS NOT NULL", dgvcontaver) },
        { "anime_completos", ("SELECT * FROM lista WHERE user_id = @user_id AND anime_completos IS NOT NULL", dgvvistos) },
        { "anime_pausa", ("SELECT * FROM lista WHERE user_id = @user_id AND anime_pausa IS NOT NULL", dgvempausa) },
        { "anime_dropados", ("SELECT * FROM lista WHERE user_id = @user_id AND anime_dropados IS NOT NULL", dgvdesistidos) },
        { "anime_paraassistir", ("SELECT * FROM lista WHERE user_id = @user_id AND anime_paraassistir IS NOT NULL", dgvparaver) }
    };

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                // Abra a conexão com o banco de dados
                connection.Open();

                // Para cada campo, execute a consulta e preencha a DataGridView correspondente
                foreach (var kvp in queries)
                {
                    string campo = kvp.Key;
                    string query = kvp.Value.query;
                    DataGridView dgv = kvp.Value.dgv;

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        // Adicione o parâmetro `user_id` à consulta
                        cmd.Parameters.AddWithValue("@user_id", userId);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            // Limpe a DataGridView antes de preenchê-la
                            dgv.Rows.Clear();

                            // Preencha a DataGridView com os dados obtidos
                            while (reader.Read())
                            {
                                string anime_completos = reader["anime_completos"].ToString();
                                string anime_dropados = reader["anime_dropados"].ToString();
                                string anime_paraassistir = reader["anime_paraassistir"].ToString();
                                string anime_aver = reader["anime_aver"].ToString();
                                string anime_pausa = reader["anime_pausa"].ToString();


                                string final = "";
                                if (anime_completos != "")
                                {
                                    final = anime_completos;
                                }
                                if (anime_pausa != "")
                                {
                                    final = anime_pausa;
                                }
                                if (anime_dropados != "")
                                {
                                    final = anime_dropados;
                                }
                                if (anime_paraassistir != "")
                                {
                                    final = anime_paraassistir;
                                }
                                if (anime_aver != "")
                                {
                                    final = anime_aver;
                                }
                                string genero = reader["genero"].ToString();
                                dgv.Rows.Add(final, genero);
                            }
                        }
                    }
                }
            }
        }



        //rm w nm in comp, pau, dr, pa,
        public void EleminarVelho(string nome, int userid)
        {
            // String de conexão com o banco de dados
            string connectionString = "Server=localhost;Port=3306;Database=trackeranime;Uid=root;Password=mysql;";

            // Usando uma conexão MySQL
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    // Abrindo a conexão
                    connection.Open();

                    // Comando SQL para inserir dados na base de dados
                    string query = "DELETE FROM trackeranime.lista WHERE @user_id = @user_id AND (anime_aver = @nome OR anime_completos = @nome OR anime_pausa = @nome OR anime_dropados = @nome OR anime_paraassistir = @nome);";

                    // Criação do comando SQL
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        // Configurando os parâmetros do comando
                        cmd.Parameters.AddWithValue("@user_id", userid);

                        cmd.Parameters.AddWithValue("@nome", nome);

                        // Executa o comando SQL para inserir os dados
                        cmd.ExecuteNonQuery();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao inserir dados: " + ex.Message);
                }
            }
        }

        public void AdicionarAnime(string nome, string genero, string categoria, int userid)
        {

            EleminarVelho(nome,userid);
            // String de conexão com o banco de dados
            string connectionString = "Server=localhost;Port=3306;Database=trackeranime;Uid=root;Password=mysql;";

            // Usando uma conexão MySQL
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    // Abrindo a conexão
                    connection.Open();

                    // Comando SQL para inserir dados na base de dados
                    string query = "INSERT INTO lista (user_id, anime_id, favoritos, anime_aver, anime_completos, anime_pausa, anime_dropados, anime_paraassistir, genero) VALUES (@user_id, null, null, @anime_aver, @anime_completos, @anime_pausa, @anime_dropados, @anime_paraassistir, @genero)";

                    // Criação do comando SQL
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        // Configurando os parâmetros do comando
                        cmd.Parameters.AddWithValue("@user_id", userid);
                        cmd.Parameters.AddWithValue("@genero", genero);

                        // Definindo os valores dos campos para cada categoria
                        switch (categoria)
                        {
                            case "A ver":
                                cmd.Parameters.AddWithValue("@anime_aver", nome);
                                cmd.Parameters.AddWithValue("@anime_completos", DBNull.Value);
                                cmd.Parameters.AddWithValue("@anime_pausa", DBNull.Value);
                                cmd.Parameters.AddWithValue("@anime_dropados", DBNull.Value);
                                cmd.Parameters.AddWithValue("@anime_paraassistir", DBNull.Value);
                                break;
                            case "Visto":
                                cmd.Parameters.AddWithValue("@anime_aver", DBNull.Value);
                                cmd.Parameters.AddWithValue("@anime_completos", nome);
                                cmd.Parameters.AddWithValue("@anime_pausa", DBNull.Value);
                                cmd.Parameters.AddWithValue("@anime_dropados", DBNull.Value);
                                cmd.Parameters.AddWithValue("@anime_paraassistir", DBNull.Value);
                                break;
                            case "Em espera":
                                cmd.Parameters.AddWithValue("@anime_aver", DBNull.Value);
                                cmd.Parameters.AddWithValue("@anime_completos", DBNull.Value);
                                cmd.Parameters.AddWithValue("@anime_pausa", nome);
                                cmd.Parameters.AddWithValue("@anime_dropados", DBNull.Value);
                                cmd.Parameters.AddWithValue("@anime_paraassistir", DBNull.Value);
                                break;
                            case "Desistido":
                                cmd.Parameters.AddWithValue("@anime_aver", DBNull.Value);
                                cmd.Parameters.AddWithValue("@anime_completos", DBNull.Value);
                                cmd.Parameters.AddWithValue("@anime_pausa", DBNull.Value);
                                cmd.Parameters.AddWithValue("@anime_dropados", nome);
                                cmd.Parameters.AddWithValue("@anime_paraassistir", DBNull.Value);
                                break;
                            case "Para ver":
                                cmd.Parameters.AddWithValue("@anime_aver", DBNull.Value);
                                cmd.Parameters.AddWithValue("@anime_completos", DBNull.Value);
                                cmd.Parameters.AddWithValue("@anime_pausa", DBNull.Value);
                                cmd.Parameters.AddWithValue("@anime_dropados", DBNull.Value);
                                cmd.Parameters.AddWithValue("@anime_paraassistir", nome);
                                break;
                        }

                        // Executa o comando SQL para inserir os dados
                        cmd.ExecuteNonQuery();
                    }

                    // Determinando a DataGridView correta com base na categoria
                    DataGridView dgv = null;
                    switch (categoria)
                    {
                        case "A ver":
                            dgv = dgvcontaver;
                            break;
                        case "Visto":
                            dgv = dgvvistos;
                            break;
                        case "Em espera":
                            dgv = dgvempausa;
                            break;
                        case "Desistido":
                            dgv = dgvdesistidos;
                            break;
                        case "Para ver":
                            dgv = dgvparaver;
                            break;
                    }

                    // Adicionando o anime à DataGridView
                    if (dgv != null)
                    {
                        bool animeExistente = false;

                        // Verificando se o anime já existe na DataGridView
                        for (int i = 0; i < dgv.Rows.Count; i++)
                        {
                            var cellValue = dgv.Rows[i].Cells[0].Value?.ToString();
                            if (cellValue == null || cellValue == "")
                            {
                                continue;
                            }

                            if (cellValue == nome)
                            {
                                animeExistente = true;
                                dgv.Rows.RemoveAt(i);
                                break;
                            }
                        }

                        // Se o anime não existe, adicione-o à DataGridView
                        if (!animeExistente)
                        {
                            dgv.Rows.Add(nome, genero);
                        }

                        // Opcional: Esconder o formulário atual após adicionar o anime
                        this.Hide();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao inserir dados: " + ex.Message);
                }
            }
        }



        ////add a base de dados
        //string connectionString = "Server=localhost;Port=3306;Database=trackeranime;Uid=root;Password=mysql;";
        //using (MySqlConnection connection = new MySqlConnection(connectionString))
        //{
        //    try
        //    {

        //        connection.Open();

        //        string query_criar = "INSERT INTO users ( user_id, anime_aver, anime_completos, anime_pausa, anime_dropados, anime_paraassistir, genero) VALUES (@user_id, @anime_aver, @anime_completos, @anime_pausa, @anime_dropados, @anime_paraassistir, @genero)";
        //        MySqlCommand cmd = new MySqlCommand(query_criar, connection);
        //        cmd.Parameters.AddWithValue("@user_id", UserID);
        //        cmd.Parameters.AddWithValue("@anime_aver", anime_aver);
        //        cmd.Parameters.AddWithValue("@anime_completos", anime_completos);
        //        cmd.Parameters.AddWithValue("@anime_pausa", anime_pausa);
        //        cmd.Parameters.AddWithValue("@anime_dropados", anime_dropados);
        //        cmd.Parameters.AddWithValue("@anime_paraassistir", anime_paraassistir);
        //        cmd.Parameters.AddWithValue("@Genero", genero);

        //        int rowsAffected = cmd.ExecuteNonQuery();



        //        //marcar datagridview como null
        //        DataGridView dgv = null;


        //        //confirmar para onde vai
        //        switch (categoria)
        //        {
        //            case "A ver":
        //                dgv = dgvcontaver;
        //                break;
        //            case "Visto":
        //                dgv = dgvvistos;
        //                break;
        //            case "Em espera":
        //                dgv = dgvempausa;
        //                break;
        //            case "Desistido":
        //                dgv = dgvdesistidos;
        //                break;
        //            case "Para ver":
        //                dgv = dgvparaver;
        //                break;
        //        }

        //        if (dgv != null)
        //        {
        //            bool animeExistente = false;

        //            for (int i = 0; i < dgv.Rows.Count; i++)
        //            {
        //                if (dgv.Rows[i].Cells[0].Value == null || dgv.Rows[i].Cells[0].Value.ToString() == "")
        //                {
        //                    continue;
        //                }

        //                if (dgv.Rows[i].Cells[0].Value.ToString() == nome)
        //                {
        //                    animeExistente = true;
        //                    dgv.Rows.RemoveAt(i);
        //                    break;
        //                }
        //            }

        //            if (!animeExistente)
        //            {
        //                dgv.Rows.Add(nome, genero);
        //            }

        //            this.Hide();

        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Erro ao inserir usuário: " + ex.Message);
        //    }
        //}





        //    private string GetCategoriaColumn(string categoria)
        //    {
        //        Dictionary<string, string> categoriaMap = new Dictionary<string, string>
        //{
        //            {"A ver", "anime_aver"},
        //            {"Visto", "anime_completos"},
        //            {"Em espera", "anime_pausa"},
        //            {"Desistido", "anime_dropados"},
        //            {"Para ver", "anime_paraassistir"}
        //};
        //        return categoriaMap[categoria];
        //    }



        private void listauser_Load(object sender, EventArgs e)
        {
            //string nomeAnime = ListaUserForm.NomeAnime;
            //string generoAnime = ListaUserForm.GeneroAnime;
            //AdicionarAnimeNaDataGridViewSelecionada(nomeAnime, generoAnime, ListaUserForm);


            //// Acesse os valores de nomeAnime e generoAnime
            //string nomeAnime = ListaUserForm.NomeAnime;
            //string generoAnime = ListaUserForm.GeneroAnime;

            //// Remove o anime selecionado de todas as DataGridViews
            //ListaUserForm.RemoverAnime(nomeAnime);

            //// Adiciona o anime selecionado à DataGridView correta
            //ListaUserForm.dgvAtual.Rows.Add(nomeAnime, generoAnime);

            //// Atualiza a DataGridView selecionada
            //ListaUserForm.dgvAtual.Refresh();
            // Obter o ID do usuário a partir do Form1
            Form1 form1 = (Form1)Application.OpenForms["Form1"];
            int userId = form1.UserID;
            ExibirIconeUsuario(userId);


            // Determine o UserID com base no status de login ou criação de conta
            //int userId = DetermineUserID(true);
            userId = DetermineUserID(true);

            // Carregar animes por categoria para o UserID ativo
            CarregarEPreencherDataGridViewPorCampos(userId);

            PreencherInformacoesUsuario(form1.UserID);

            try
            {
                // Determine o status de login ou criação de conta do usuário

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados: " + ex.Message);
            }



        }

        private void PreencherInformacoesUsuario(int userId)
        {
            // String de conexão com o banco de dados
            string connectionString = "Server=localhost;Port=3306;Database=trackeranime;Uid=root;Password=mysql;";

            // Consulta SQL para obter o nome do usuário e a data de entrada com base no UserID
            string query = "SELECT nome FROM users WHERE id_user = @user_id";

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

                            
                        }
                        else
                        {
                            MessageBox.Show("Usuário não encontrado.");
                        }
                    }
                }
            }
        }



        private void dgvvistos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

           
            if (e.RowIndex >= 0)
            {
                // Show a confirmation message box
                DialogResult result = MessageBox.Show("Certeza que deseja remover esse anime?", "Confirmar remoção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                Form1 form1 = (Form1)Application.OpenForms["Form1"];

                if (result == DialogResult.Yes)
                {
                    // Delete the row if the user clicked Yes

                    var query = "DELETE FROM trackeranime.lista WHERE user_id = @user_id AND anime_completos = @nome_anime";
                    string connectionString = "server=localhost;port=3306;user=root;password=mysql;database=trackeranime";

                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();

                        using (MySqlCommand cmd = new MySqlCommand(query, connection))
                        {

                            cmd.Parameters.AddWithValue("@user_id", form1.UserID); //
                            cmd.Parameters.AddWithValue("@nome_anime", dgvvistos.Rows[e.RowIndex].Cells[0].Value);
                            cmd.ExecuteNonQuery();
                            //MessageBox.Show("" + dgvdesistidos.Rows[e.RowIndex].Cells[0].Value);
                        }
                    }
                    dgvvistos.Rows.RemoveAt(e.RowIndex);

                }
            }

            //if (e.RowIndex >= 0)
            //{
            //    // Show a confirmation message box
            //    DialogResult result = MessageBox.Show("Certeza que deseja remover esse anime?", "Confirmar remoção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //    if (result == DialogResult.Yes)
            //    {
            //        // Delete the row if the user clicked Yes
            //        dgvvistos.Rows.RemoveAt(e.RowIndex);
            //    }
            //}
        }

        private void dgvcontaver_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                // Show a confirmation message box
                DialogResult result = MessageBox.Show("Certeza que deseja remover esse anime?", "Confirmar remoção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                Form1 form1 = (Form1)Application.OpenForms["Form1"];

                if (result == DialogResult.Yes)
                {
                    // Delete the row if the user clicked Yes

                    var query = "DELETE FROM trackeranime.lista WHERE user_id = @user_id AND anime_aver = @nome_anime";
                    string connectionString = "server=localhost;port=3306;user=root;password=mysql;database=trackeranime";

                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();

                        using (MySqlCommand cmd = new MySqlCommand(query, connection))
                        {

                            cmd.Parameters.AddWithValue("@user_id", form1.UserID); //
                            cmd.Parameters.AddWithValue("@nome_anime", dgvcontaver.Rows[e.RowIndex].Cells[0].Value);
                            cmd.ExecuteNonQuery();
                            //MessageBox.Show("" + dgvdesistidos.Rows[e.RowIndex].Cells[0].Value);
                        }
                    }
                    dgvcontaver.Rows.RemoveAt(e.RowIndex);

                }
            }

            //if (e.RowIndex >= 0)
            //{
            //    // Show a confirmation message box
            //    DialogResult result = MessageBox.Show("Certeza que deseja remover esse anime?", "Confirmar remoção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //    if (result == DialogResult.Yes)
            //    {
            //        // Delete the row if the user clicked Yes
            //        dgvcontaver.Rows.RemoveAt(e.RowIndex);
            //    }
            //}
        }

        private void dgvempausa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                // Show a confirmation message box
                DialogResult result = MessageBox.Show("Certeza que deseja remover esse anime?", "Confirmar remoção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                Form1 form1 = (Form1)Application.OpenForms["Form1"];

                if (result == DialogResult.Yes)
                {
                    // Delete the row if the user clicked Yes

                    var query = "DELETE FROM trackeranime.lista WHERE user_id = @user_id AND anime_pausa = @nome_anime";
                    string connectionString = "server=localhost;port=3306;user=root;password=mysql;database=trackeranime";

                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();

                        using (MySqlCommand cmd = new MySqlCommand(query, connection))
                        {

                            cmd.Parameters.AddWithValue("@user_id", form1.UserID); //
                            cmd.Parameters.AddWithValue("@nome_anime", dgvempausa.Rows[e.RowIndex].Cells[0].Value);
                            cmd.ExecuteNonQuery();
                            //MessageBox.Show("" + dgvdesistidos.Rows[e.RowIndex].Cells[0].Value);
                        }
                    }
                    dgvempausa.Rows.RemoveAt(e.RowIndex);

                }
            }

            //if (e.RowIndex >= 0)
            //{
            //    // Show a confirmation message box
            //    DialogResult result = MessageBox.Show("Certeza que deseja remover esse anime?", "Confirmar remoção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //    if (result == DialogResult.Yes)
            //    {
            //        // Delete the row if the user clicked Yes
            //        dgvempausa.Rows.RemoveAt(e.RowIndex);
            //    }
            //}
        }

        private void dgvparaver_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                // Show a confirmation message box
                DialogResult result = MessageBox.Show("Certeza que deseja remover esse anime?", "Confirmar remoção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                Form1 form1 = (Form1)Application.OpenForms["Form1"];

                if (result == DialogResult.Yes)
                {
                    // Delete the row if the user clicked Yes

                    var query = "DELETE FROM trackeranime.lista WHERE user_id = @user_id AND anime_paraassistir = @nome_anime";
                    string connectionString = "server=localhost;port=3306;user=root;password=mysql;database=trackeranime";

                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();

                        using (MySqlCommand cmd = new MySqlCommand(query, connection))
                        {

                            cmd.Parameters.AddWithValue("@user_id", form1.UserID); //
                            cmd.Parameters.AddWithValue("@nome_anime", dgvparaver.Rows[e.RowIndex].Cells[0].Value);
                            cmd.ExecuteNonQuery();
                            //MessageBox.Show("" + dgvdesistidos.Rows[e.RowIndex].Cells[0].Value);
                        }
                    }
                    dgvparaver.Rows.RemoveAt(e.RowIndex);

                }
            }


            //if (e.RowIndex >= 0)
            //{
            //    // Show a confirmation message box
            //    DialogResult result = MessageBox.Show("Certeza que deseja remover esse anime?", "Confirmar remoção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //    if (result == DialogResult.Yes)
            //    {
            //        // Delete the row if the user clicked Yes
            //        dgvparaver.Rows.RemoveAt(e.RowIndex);
            //    }
            //}
        }

        private void dgvdesistidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Show a confirmation message box
                DialogResult result = MessageBox.Show("Certeza que deseja remover esse anime?", "Confirmar remoção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                Form1 form1 = (Form1)Application.OpenForms["Form1"];

                if (result == DialogResult.Yes)
                {
                    // Delete the row if the user clicked Yes

                    var query = "DELETE FROM trackeranime.lista WHERE user_id = @user_id AND anime_dropados = @nome_anime";
                    string connectionString = "server=localhost;port=3306;user=root;password=mysql;database=trackeranime";

                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();

                        using (MySqlCommand cmd = new MySqlCommand(query, connection))
                        {

                            cmd.Parameters.AddWithValue("@user_id", form1.UserID); //
                            cmd.Parameters.AddWithValue("@nome_anime", dgvdesistidos.Rows[e.RowIndex].Cells[0].Value);
                            cmd.ExecuteNonQuery();
                            //MessageBox.Show("" + dgvdesistidos.Rows[e.RowIndex].Cells[0].Value);
                        }
                    }
                    dgvdesistidos.Rows.RemoveAt(e.RowIndex);

                }
            }

        }

        private void lbfechar_Click(object sender, EventArgs e)
        {
            principal Principal = new principal();
            Principal.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

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
                                pcbfotoperf.Image = Image.FromStream(ms);
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

        private void pcbfotoperf_Click(object sender, EventArgs e)
        {
           
        }


        //public void AdicionarAnimeNaDataGridViewSelecionada(string nomeAnime, string generoAnime, string categoriaSelecionada)
        //{
        //    DataGridView dgvAtual = null;

        //    switch (categoriaSelecionada)
        //    {
        //        case "A ver":
        //            dgvAtual = dgvcontaver;
        //            break;
        //        case "Visto":
        //            dgvAtual = dgvvistos;
        //            break;
        //        case "Em pausa":
        //            dgvAtual = dgvempausa;
        //            break;
        //        case "Desistido":
        //            dgvAtual = dgvdesistidos;
        //            break;
        //        case "Para ver":
        //            dgvAtual = dgvparaver;
        //            break;
        //        default:
        //            MessageBox.Show("Categoria inválida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            return;
        //    }

        //    if (dgvAtual != null)
        //    {
        //        // Remover o anime selecionado de todas as DataGridViews
        //        RemoverAnime(nomeAnime);

        //        // Adicionar o anime selecionado à DataGridView correta
        //        int rowIndex = dgvAtual.Rows.Add();
        //        dgvAtual.Rows[rowIndex].Cells[0].Value = nomeAnime; // Adiciona o nome do anime na primeira coluna
        //        dgvAtual.Rows[rowIndex].Cells[1].Value = generoAnime; // Adiciona o genero do anime na segunda coluna
        //    }
        //    else
        //    {
        //        MessageBox.Show("Erro ao determinar a DataGridView correta.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        //public void RemoverAnime(string nomeAnime)
        //{
        //    foreach (DataGridView dgv in new DataGridView[] { dgvcontaver, dgvvistos, dgvempausa, dgvdesistidos, dgvparaver })
        //    {
        //        for (int i = dgv.Rows.Count - 1; i >= 0; i--)
        //        {
        //            if (dgv.Rows[i].Cells[0].Value != null && dgv.Rows[i].Cells[0].Value.ToString() == nomeAnime)
        //            {
        //                dgv.Rows.RemoveAt(i);
        //            }
        //        }
        //    }
        //}
    }







}
