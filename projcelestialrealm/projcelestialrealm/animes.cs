using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projcelestialrealm
{
    internal class animes
    {

        public int NumeroAnimes { get; set; }
        public string Titulo { get; set; }
        public string Genero { get; set; }
        public string Sinopse { get; set; }
        public double Episodios { get; set; }
        public string Estado { get; set; }
        public int Temporadas { get; set; }
        public decimal Avaliacao { get; set; }
        
        //public DateTime Data { get; set; }
        //public byte[] Foto { get; set; }

        //public DataGridView tabelamanga { get; set; }

        //gerar construtor com alt+enter
        public animes(int numeroAnimes, string titulo, string genero, string sinopse, double episodios, string estado, int temporadas, decimal avaliacao)
        {
            NumeroAnimes = numeroAnimes;
            Titulo = titulo;
            Genero = genero;
            Sinopse = sinopse;
            Episodios = episodios;
            Estado = estado;
            Temporadas = temporadas;
            Avaliacao = avaliacao;

            //this.Foto = foto;
        }



    }
}
