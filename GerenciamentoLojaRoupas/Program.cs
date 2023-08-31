using System;
using GerenciamentoVendasLojaRoupas.UI;

namespace GerenciamentoVendasLojaRoupas
{
    class Program
    {
        static void Main(string[] args)
        {

            CategoriaUI categoriaUI = new CategoriaUI ();
            ProdutoUI produtoUI = new ProdutoUI ();
            ClienteUI clienteUI = new ClienteUI ();
            VendaUI vendaUI = new VendaUI ();

            while (true)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1 - Gerenciamento de categorias");
                Console.WriteLine("2 - Gerenciamento de produtos");
                Console.WriteLine("3 - Gerenciamento de clientes");
                Console.WriteLine("4 - Realizar vendas");
                Console.WriteLine("0 - Sair");
                Console.Write("Escolha uma opção: ");
                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        CategoriaUI.Menu();
                        break;
                    case 2:
                        ProdutoUI.Menu();
                        break;
                    case 3:
                        ClienteUI.Menu();
                        break;
                    case 4:
                        VendaUI.RealizarVenda();
                        break;
                    case 0:
                        Console.WriteLine("Sessão encerrada.");
                        return;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            }
        }
    }   
}     