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
                Console.WriteLine("Menu de Produtos:");
                Console.WriteLine("1. Registrar Produto");
                Console.WriteLine("2. Listar Produtos");
                Console.WriteLine("3. Buscar Produto por ID");
                Console.WriteLine("4. Atualizar Produto");
                Console.WriteLine("5. Remover Produto");
                Console.WriteLine("0. Voltar");

                Console.Write("Escolha uma opção: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
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
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            }
        }

        public static void RegistrarProduto()
        {
            Console.WriteLine("Registrar Novo Produto:");

            Produto novoProduto = new Produto();
            novoProduto.Id = produtoIdCounter++;

            Console.Write("Nome: ");
            novoProduto.Nome = Console.ReadLine();

            Console.Write("Descrição: ");
            novoProduto.Descricao = Console.ReadLine();

            Console.Write("Preço: ");
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
                Console.WriteLine("Categoria não encontrada. O produto será registrado sem categoria.");
            }

            produtos.Add(novoProduto);

            Console.WriteLine("Produto registrado com sucesso!");
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
            Console.Write("Digite o ID do Produto: ");
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
            Console.Write("Digite o ID do Produto para atualizar: ");
            int id = int.Parse(Console.ReadLine());

            Produto produto = produtos.Find(p => p.Id == id);

            if (produto != null)
            {
                Console.WriteLine($"Atualizando Produto {produto.Nome}:");

                Console.Write("Novo Nome: ");
                produto.Nome = Console.ReadLine();

                Console.Write("Nova Descrição: ");
                produto.Descricao = Console.ReadLine();

                Console.Write("Novo Preço: ");
                produto.Preco = decimal.Parse(Console.ReadLine());

                Console.Write("ID da Nova Categoria: ");
                int categoriaId = int.Parse(Console.ReadLine());
                Categoria novaCategoria = CategoriaUI.GetCategoriaPorId(categoriaId);
                if (novaCategoria != null)
                {
                    produto.Categoria = novaCategoria;
                }
                else
                {
                    Console.WriteLine("Categoria não encontrada. O produto continuará com a categoria anterior.");
                }

                Console.WriteLine("Produto atualizado com sucesso!");
            }
            else
            {
                Console.WriteLine("Produto não encontrado.");
            }
        }

        public static void RemoverProduto()
        {
            Console.Write("Digite o ID do Produto para remover: ");
            int id = int.Parse(Console.ReadLine());

            Produto produto = produtos.Find(p => p.Id == id);

            if (produto != null)
            {
                produtos.Remove(produto);
                Console.WriteLine("Produto removido com sucesso!");
            }
            else
            {
                Console.WriteLine("Produto não encontrado.");
            }
        }
    }
}