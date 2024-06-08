using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projcelestialrealm
{
     internal class Usuario
     {
        private static int userId;
        private int idUsuario;
        private string Nome;
        private string Genero;
        private DateTime Datanascimento;
        private string Email;
        private DateTime Dataentrada;
        private byte[] Foto;
        private string Password;
        private bool Registado;
        private conectar conexao;

        public Usuario(int idusuario, string nome, string genero, DateTime datanascimento, string email, DateTime dataentrada, byte[] foto, string password, bool registado, conectar conexao)
        {
            this.idUsuario = idusuario;
            this.Nome = nome;
            this.Genero = genero;
            this.Datanascimento = datanascimento;
            this.Email = email;
            this.Dataentrada = dataentrada;
            this.Foto = foto;
            this.Password = password;
            this.Registado = registado;
            this.conexao = conexao;
        }

        public bool Autenticar(conectar conexao)
        {
            try
            {
                // Lógica para autenticar o usuário usando as informações fornecidas
                // Neste exemplo, estamos autenticando apenas se o usuário estiver registrado
                return Registado;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao autenticar: " + ex.Message);
                return false;
            }
        }

        public static int UserId
        {
            get { return userId; }
            set { userId = value; }
        }

        public int NumeroUsuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }

        public string NomeUsuario
        {
            get { return Nome; }
            set { Nome = value; }
        }

        public string GeneroUsuario
        {
            get { return Genero; }
            set { Genero = value; }
        }

        public DateTime DataNascimento
        {
            get { return Datanascimento; }
            set { Datanascimento = value; }
        }

        public string EmailUsuario
        {
            get { return Email; }
            set { Email = value; }
        }

        public DateTime DataEntrada
        {
            get { return Dataentrada; }
            set { Dataentrada = value; }
        }

        public byte[] FotoUsuario
        {
            get { return Foto; }
            set { Foto = value; }
        }

        public string SenhaUsuario
        {
            get { return Password; }
            set { Password = value; }
        }

        public bool Registrado
        {
            get { return Registado; }
            set { Registado = value; }
        }

        public conectar Conexao
        {
            get { return conexao; }
            set { conexao = value; }
        }

     }
}
