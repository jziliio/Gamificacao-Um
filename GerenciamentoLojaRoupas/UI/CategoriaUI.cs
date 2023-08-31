using System;
using System.Collections.Generic;
using GerenciamentoVendasLojaRoupas;

namespace GerenciamentoVendasLojaRoupas.UI
{
    public class CategoriaUI
    {
        private static List<Categoria> categorias = new List<Categoria>();
        private static int categoriaIdCounter = 1;

        public static void Menu()
        {
            while (true)
            {
                Console.WriteLine("Menu de Categorias:");
                Console.WriteLine("1. Registrar Categoria");
                Console.WriteLine("2. Listar Categorias");
                Console.WriteLine("3. Buscar Categoria por ID");
                Console.WriteLine("4. Atualizar Categoria");
                Console.WriteLine("5. Remover Categoria");
                Console.WriteLine("0. Voltar");

                Console.Write("Escolha uma opção: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        RegistrarCategoria();
                        break;
                    case 2:
                        ListarCategorias();
                        break;
                    case 3:
                        BuscarCategoriaPorId();
                        break;
                    case 4:
                        AtualizarCategoria();
                        break;
                    case 5:
                        RemoverCategoria();
                        break;
                    case 0:
                        return;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            }
        }

        public static void RegistrarCategoria()
        {
            Console.WriteLine("Registrar Nova Categoria:");

            Categoria novaCategoria = new Categoria();
            novaCategoria.Id = categoriaIdCounter++;

            Console.Write("Nome: ");
            novaCategoria.Nome = Console.ReadLine();

            Console.Write("Descrição: ");
            novaCategoria.Descricao = Console.ReadLine();

            categorias.Add(novaCategoria);

            Console.WriteLine("Categoria registrada com sucesso!");
        }

        public static void ListarCategorias()
        {
            Console.WriteLine("Lista de Categorias:");

            foreach (var categoria in categorias)
            {
                Console.WriteLine($"ID: {categoria.Id}, Nome: {categoria.Nome}, Descrição: {categoria.Descricao}");
            }
        }

        public static void BuscarCategoriaPorId()
        {
            Console.Write("Digite o ID da Categoria: ");
            int id = int.Parse(Console.ReadLine());

            Categoria categoria = categorias.Find(c => c.Id == id);

            if (categoria != null)
            {
                Console.WriteLine($"ID: {categoria.Id}, Nome: {categoria.Nome}, Descrição: {categoria.Descricao}");
            }
            else
            {
                Console.WriteLine("Categoria não encontrada.");
            }
        }

        public static void AtualizarCategoria()
        {
            Console.Write("Digite o ID da Categoria para atualizar: ");
            int id = int.Parse(Console.ReadLine());

            Categoria categoria = categorias.Find(c => c.Id == id);

            if (categoria != null)
            {
                Console.WriteLine($"Atualizando Categoria {categoria.Nome}:");

                Console.Write("Novo Nome: ");
                categoria.Nome = Console.ReadLine();

                Console.Write("Nova Descrição: ");
                categoria.Descricao = Console.ReadLine();

                Console.WriteLine("Categoria atualizada com sucesso!");
            }
            else
            {
                Console.WriteLine("Categoria não encontrada.");
            }
        }

        public static void RemoverCategoria()
        {
            Console.Write("Digite o ID da Categoria para remover: ");
            int id = int.Parse(Console.ReadLine());

            Categoria categoria = categorias.Find(c => c.Id == id);

            if (categoria != null)
            {
                categorias.Remove(categoria);
                Console.WriteLine("Categoria removida com sucesso!");
            }
            else
            {
                Console.WriteLine("Categoria não encontrada.");
            }
        }
    }
}