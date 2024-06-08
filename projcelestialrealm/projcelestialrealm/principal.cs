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
    public partial class principal : Form
    {
        private conectar conexaoPrincipal;

       

        public principal()
        {
            InitializeComponent();
            //conexaoPrincipal = new Conexao();  // Certifique-se de que a classe Conexao tenha um construtor padrão.
        }

        private void principal_Load(object sender, EventArgs e)
        {
            //conexaoPrincipal.Show();
            //conexaoPrincipal.Close();
        }

        private void lbsair_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem certeza que deseja fechar o programa?", "Fechar Programa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Fecha o formulário atual
                this.Close();
            }
        }

        private void lbanimes_Click(object sender, EventArgs e)
        {
           
            // No formulário principal ou onde você instanciar o formulário listaanime
            conectar conexao = new conectar("localhost", 3306, "root", "mysql", "trackeranime");
            listaanime formListaAnime = new listaanime(conexao);
            formListaAnime.Show();
            this.Hide();
        }

        private void lblista_Click(object sender, EventArgs e)
        {
            listauser formListaUser = new listauser();
            formListaUser.Show();
            this.Hide();
        }

        private void lbperfil_Click(object sender, EventArgs e)
        {
            perfil perfil = new perfil();
            perfil.Show();
            this.Hide();
        }

        private void lbalterar_Click(object sender, EventArgs e)
        {
            // Criar uma instância do formulário ListaUser
            listauser listaUserForm = new listauser();

            // Passar a instância do formulário ListaUser ao criar o formulário Alterar
            Alterar alterar = new Alterar();

            // Exibir o formulário Alterar
            alterar.Show();

            // Esconder o formulário atual (se necessário)
            this.Hide();
        }
    }
}
