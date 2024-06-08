using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace projcelestialrealm
{
    public partial class Conexao : Form
    {
        private conectar conexaoBD;

        //public MySqlConnection conexao;
        //List<usuarios> Listadonoanime; //lista tipo obra
        //BindingList<animes> listaanimes; //lista obra

        public Conexao()
        {
            InitializeComponent();
            ConectarBanco();
            this.Hide();
        }

        private void Conexao_Load(object sender, EventArgs e)
        {

            //try
            //{

            //    string datasource = txtDatasource.Text;
            //    int porta = int.Parse(txtPorta.Text);
            //    string utilizador = txtUtilizador.Text;
            //    string passowrd = txtPassword.Text;
            //    string connectioninfo = "datasource=" + datasource + ";port=" + porta + ";username=" + utilizador + ";password=" + passowrd + ";database = trackeranime;SslMode=none";
            //    //conexao = new MySqlConnection(connectioninfo);
            //    //conexao.Open();
            //    //MessageBox.Show("Coneção efetuada com sucesso!Reconheceu a base de dados no Mysqlserver");
            //    //ListarAnimes();
            //    using (conexao = new MySqlConnection(connectioninfo))
            //    {
            //        conexao.Open();
            //        MessageBox.Show("Conexão efetuada com sucesso! Reconheceu a base de dados no Mysqlserver");
            //        ListarAnimes(conexao);
            //    }





            //}

            //catch (Exception ex)
            //{ MessageBox.Show(Conexao.ActiveForm, ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            ////ListarAnimes();

            //this.Hide();



        }

        private void ConectarBanco()
        {
            try
            {
                // Substitua as informações de conexão com as corretas
                conexaoBD = new conectar("localhost", 3306, "root", "mysql", "trackeranime");
                conexaoBD.AbrirConexao();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro de conexão: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Se a conexão falhar, você pode encerrar o aplicativo ou tomar outras ações apropriadas
                Environment.Exit(0); // ou Application.Exit();
            }
        }

        private void DesconectarBanco()
        {
            if (conexaoBD != null)
            {
                conexaoBD.FecharConexao();
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            DesconectarBanco();
        }

        //public void ListarAnimes(MySqlConnection conexao)
        //{
        //    //consulta à BD e guardar numa lista cada registo da tabela filmes
        //    listaanimes = new BindingList<animes>();
        //    string sqlanimes = "select * from animes";
        //    //string sqluser = "select * from users";
        //    //conexaoCSForm.conexao();
        //    using (MySqlCommand cmd = new MySqlCommand(sqlanimes, conexao))
        //    {
        //        using (MySqlDataReader reader = cmd.ExecuteReader())
        //        {
        //            while (reader.Read())
        //            {
        //                listaanimes.Add(new animes(reader.GetInt32("id_anime"),
        //                                                   reader.GetString("titulo"),
        //                                                   reader.GetString("genero"),
        //                                                   reader.GetString("sinopse"),
        //                                                   reader.GetDouble("episodes"),
        //                                                   reader.GetString("estado"),
        //                                                   reader.GetInt32("temporadas"),
        //                                                   reader.GetInt32("avaliação")));
        //                //(byte[])reader["foto"]));
        //            }
        //        }
        //    }
        //    //dgvlista.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        //    //dgvlista.EditMode = DataGridViewEditMode.EditProgrammatically;
        //    //dgvlista.MultiSelect = false;
        //    //dgvlista.DataSource = listaanimes;
        //    //dgvlista.Columns[0].Visible = false; //não mostra idanime
        //    ////dgvlista.Columns[6].Visible = false; //não mostra idcategoria
        //    //dgvlista.Columns[3].Width = 80;
        //    //dgvlista.Columns[4].Width = 80;
        //}
    }
}
