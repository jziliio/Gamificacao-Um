using System;
using System.Collections.Generic;
using GerenciamentoVendasLojaRoupas;
using GerenciamentoVendasLojaRoupas.UI;

namespace GerenciamentoVendasLojaRoupas.UI
{
    public class ProdutoUI
    {
        private static List<Produto> produtos = new List<Produto>();
        private static int produtoIdCounter = 1;

        public static void Menu()
        {
            while (true)
            {
                Console.WriteLine("Menu - Produtos:");
                Console.WriteLine("1 - Registrar produto");
                Console.WriteLine("2 - Listar produtos");
                Console.WriteLine("3 - Buscar produto por ID");
                Console.WriteLine("4 - Atualizar produto");
                Console.WriteLine("5 - Remover produto");
                Console.WriteLine("6 - Voltar");

                Console.Write("Selecione uma opção: ");
                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        RegistrarProduto();
                        break;
                    case 2:
                        ListarProdutos();
                        break;
                    case 3:
                        BuscarProdutoPorId();
                        break;
                    case 4:
                        AtualizarProduto();
                        break;
                    case 5:
                        RemoverProduto();
                        break;
                    case 0:
                        return;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            }
        }

        public static void RegistrarProduto()
        {
            Console.WriteLine("Registro de um novo produto:");

            Produto novoProduto = new Produto();
            novoProduto.Id = produtoIdCounter++;

            Console.Write("Informe o nome do produto: ");
            novoProduto.Nome = Console.ReadLine();

            Console.Write("Informe a descrição do produto: ");
            novoProduto.Descricao = Console.ReadLine();

            Console.Write("Informe o preço do produto: ");
            novoProduto.Preco = decimal.Parse(Console.ReadLine());

            Console.Write("ID da Categoria: ");
            int categoriaId = int.Parse(Console.ReadLine());
            Categoria categoria = CategoriaUI.GetCategoriaPorId(categoriaId);
            if (categoria != null)
            {
                novoProduto.Categoria = categoria;
            }
            else
            {
                Console.WriteLine("Categoria não encontrada.");
            }

            produtos.Add(novoProduto);

            Console.WriteLine("Produto registrado.");
        }

        public static void ListarProdutos()
        {
            Console.WriteLine("Lista de Produtos:");

            foreach (var produto in produtos)
            {
                string categoriaNome = produto.Categoria != null ? produto.Categoria.Nome : "Sem Categoria";
                Console.WriteLine($"ID: {produto.Id}, Nome: {produto.Nome}, Descrição: {produto.Descricao}, Preço: {produto.Preco:C}, Categoria: {categoriaNome}");
            }
        }

        public static void BuscarProdutoPorId()
        {
            Console.Write("Informe o ID do produto a ser buscado: ");
            int id = int.Parse(Console.ReadLine());

            Produto produto = produtos.Find(p => p.Id == id);

            if (produto != null)
            {
                string categoriaNome = produto.Categoria != null ? produto.Categoria.Nome : "Sem Categoria";
                Console.WriteLine($"ID: {produto.Id}, Nome: {produto.Nome}, Descrição: {produto.Descricao}, Preço: {produto.Preco:C}, Categoria: {categoriaNome}");
            }
            else
            {
                Console.WriteLine("Produto não encontrado.");
            }
        }

        public static void AtualizarProduto()
        {
            Console.Write("Informe o ID do produto a ser atualizado: ");
            int id = int.Parse(Console.ReadLine());

            Produto produto = produtos.Find(p => p.Id == id);

            if (produto != null)
            {
                Console.Write("Informe o novo nome: ");
                produto.Nome = Console.ReadLine();

                Console.Write("Informe a nova descrição: ");
                produto.Descricao = Console.ReadLine();

                Console.Write("Informe o novo preço: ");
                produto.Preco = decimal.Parse(Console.ReadLine());

                Console.Write("Informe o ID da nova categoria: ");
                int categoriaId = int.Parse(Console.ReadLine());
                Categoria novaCategoria = CategoriaUI.GetCategoriaPorId(categoriaId);
                if (novaCategoria != null)
                {
                    produto.Categoria = novaCategoria;
                }
                else
                {
                    Console.WriteLine("Categoria não encontrada.");
                }

                Console.WriteLine("Produto atualizado.");
            }
            else
            {
                Console.WriteLine("Produto não encontrado.");
            }
        }

        public static void RemoverProduto()
        {
            Console.Write("Informe o ID do produto a ser removido: ");
            int id = int.Parse(Console.ReadLine());

            Produto produto = produtos.Find(p => p.Id == id);

            if (produto != null)
            {
                produtos.Remove(produto);
                Console.WriteLine("Produto removido.");
            }
            else
            {
                Console.WriteLine("Produto não encontrado.");
            }
        }
    }
}