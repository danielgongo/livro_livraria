using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LivroLivraria
{
    public class Acervo : LivroLivraria
    {
        private static List<LivroLivraria> _listaLivros = new List<LivroLivraria>();

        public static List<LivroLivraria> ListaLivros
        {
            get { { return _listaLivros; } }
        }

        public static  void Adicionar(LivroLivraria l)
        {
            ListaLivros.Add(l);
        }

        //Listar os livros
        public static string Listar()
        {
            string saida = "";

            int i = 1;
            foreach(LivroLivraria l in _listaLivros)
            {
                saida += "\n******* LIVRO Nº " + (i++) + "*******\n";
                saida += l.Imprimir() + "\n";
            }

            return saida;
        }

        //Pesquisar por genero
        public static int Pesquisar(string genero)
        {
            int qtd = 0;

            foreach (LivroLivraria l in _listaLivros)
            {
                if(l.Genero.Equals(genero, StringComparison.OrdinalIgnoreCase))
                {
                    qtd++;
                }
            }

            return qtd;
        }

        //Pesquisar por faixa de preço
        public static int Pesquisar(double vInicial, double vFinal)
        {
            int qtd = 0;

            foreach (LivroLivraria l in _listaLivros)
            {
                if(l.Preco >= vInicial && l.Preco <= vFinal)
                {
                    qtd++;
                }
            }

            return qtd;
        }

        //Remover livro pelo título
        public static bool Remover(string titulo)
        {
            foreach(LivroLivraria l in _listaLivros)
            {
               if(l.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase))
                {
                    ListaLivros.Remove(l);
                    return true;
                }
            }

            return false;
        }
        
        //Calcular total do acervo
        public static double CalcularTotalAcervo()
        {
            double total = 0;

            foreach (LivroLivraria l in _listaLivros)
            {
                total += l.Preco;
            }

            return total;
        }

    }
}
