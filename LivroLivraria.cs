using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LivroLivraria
{
    public class LivroLivraria
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int Isbn { get; set; }
        public string Genero { get; set; }
        public double Preco { get; set; }

        public LivroLivraria() { }

       public LivroLivraria(string titulo, string autor, int isbn, string genero, double preco)
        {
            this.Titulo = titulo;
            this.Autor = autor;
            this.Isbn = isbn;
            this.Genero = genero;
            this.Preco = preco;
        }

        public string Imprimir()
        {
            return "Título: " + Titulo + "\nAutor: " + Autor + "\nISBN: " + Isbn +
                        "\nGênero: " + Genero + "\nPreço R$ " + Math.Round(Preco);
        }
                           
    }
}
