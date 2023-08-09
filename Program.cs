using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivroLivraria
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            int menu;
            int isbn;
            double vInicial, vFinal;
            //Ref para a classe LivriLivraria
            LivroLivraria objLivro;

            string titulo, autor, genero;

            double preco;

            do
            {
                ExibirMenu();

                menu = Convert.ToInt32(Console.ReadLine());
                
                switch (menu)
                {
                     

                    case 1://cadastrar livro
                        Console.WriteLine("======> Cadastrar");
                        Console.WriteLine("Digite o título: ");
                        titulo = Console.ReadLine();
                        Console.WriteLine("Autor "); 
                        autor = Console.ReadLine();
                        Console.WriteLine("Gênero: ");
                        genero = Console.ReadLine();
                        Console.WriteLine("ISBN: ");
                        isbn = int.Parse(Console.ReadLine());
                        Console.WriteLine("Preço: ");
                        preco = double.Parse(Console.ReadLine());

                        //criar objeto da classe
                        objLivro = new LivroLivraria(titulo, autor, isbn, genero, preco);
                        Acervo.Adicionar(objLivro);
                        break;
                    case 2:
                        Console.WriteLine("======> Listar");
                        Console.WriteLine(Acervo.Listar());
                        break;
                    case 3:
                        Console.WriteLine("======> Remover");
                        Console.WriteLine("Digite o titulo do livro");
                        titulo = Console.ReadLine();

                        if (!Acervo.ListaLivros.Equals(""))//Acervo não vazio
                        {
                            if (Acervo.Remover(titulo))
                            {
                                Console.WriteLine("Titulo Removido com sucesso!");
                            }
                            else
                            {
                                Console.WriteLine("Livro não encontrado!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Não existem livros no acervo!");
                        }
                        break;
                    case 4:
                        Console.WriteLine("======> Pesquisar por gênero");
                        Console.WriteLine("Digite o gênero: ");
                        genero = Console.ReadLine();
                        Console.WriteLine("Existem {0} livros do gênero {1}.", Acervo.Pesquisar(genero), genero);

                        break;
                    case 5:
                        Console.WriteLine("======> Pesquisar por faixa de preço");
                        Console.WriteLine("Valor inicial R$ \nValorFinal R$");
                        vInicial = double.Parse(Console.ReadLine());
                        vFinal = double.Parse(Console.ReadLine());
                        Console.WriteLine("Existem " + Acervo.Pesquisar(vInicial, vFinal) + "livros entre R$ " +
                        Math.Round(vInicial) + " e " + Math.Round(vFinal));

                        break;
                    case 6:
                        Console.WriteLine("======> Total em R$ em livros do acervo ");
                        Console.WriteLine("O total é R$: ", Math.Round(Acervo.CalcularTotalAcervo()));
                        break;
                    case 7:
                        Console.WriteLine("Você saiu do sistema.");
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            
            } while (menu != 7);

            Console.ReadKey();
            
        }

        public static void ExibirMenu()
        {

            Console.Clear();
            Console.WriteLine("========== LIVRO LIVRARIA ==========");
            Console.WriteLine("1 - CADASTRAR");
            Console.WriteLine("2 - LISTAR");
            Console.WriteLine("3 = EXCLUIR LIVRO");
            Console.WriteLine("4 - PESQUISAR POR GÊNERO");
            Console.WriteLine("5 - PESQUISAR POR FAIXA DE PRECO");
            Console.WriteLine("6 - CALCULAR TOTAL DO ACERVO");
            Console.WriteLine("7 - SAIR");
            Console.WriteLine("====> Escolha uma opção: ");

           

        }
    }
}
