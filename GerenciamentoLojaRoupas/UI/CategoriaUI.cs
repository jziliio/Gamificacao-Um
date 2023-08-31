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
                Console.WriteLine("Menu - Categorias:");
                Console.WriteLine("1 - Registrar categoria");
                Console.WriteLine("2 - Listar categorias");
                Console.WriteLine("3 - Buscar categoria por ID");
                Console.WriteLine("4 - Atualizar categoria");
                Console.WriteLine("5 - Remover categoria");
                Console.WriteLine("6 - Voltar");

                Console.Write("Selecione uma opção: ");
                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
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
                    case 6:
                        return;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            }
        }

        public static void RegistrarCategoria()
        {
            Console.WriteLine("Registro de uma nova categoria:");

            Categoria novaCategoria = new Categoria();
            novaCategoria.Id = categoriaIdCounter++;

            Console.Write("Informe o nome: ");
            novaCategoria.Nome = Console.ReadLine();

            Console.Write("Informe a descrição: ");
            novaCategoria.Descricao = Console.ReadLine();

            categorias.Add(novaCategoria);

            Console.WriteLine("A categoria foi registrada.");
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
            Console.Write("Informe o ID da categoria: ");
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
            Console.Write("Informe o ID da categoria para atualizar: ");
            int id = int.Parse(Console.ReadLine());

            Categoria categoria = categorias.Find(c => c.Id == id);

            if (categoria != null)
            {
                Console.Write("Novo nome: ");
                categoria.Nome = Console.ReadLine();

                Console.Write("Nova descrição: ");
                categoria.Descricao = Console.ReadLine();

                Console.WriteLine("Categoria atualizada.");
            }
            else
            {
                Console.WriteLine("Categoria não encontrada.");
            }
        }

        public static void RemoverCategoria()
        {
            Console.Write("Informe o ID da categoria para ser removida: ");
            int id = int.Parse(Console.ReadLine());

            Categoria categoria = categorias.Find(c => c.Id == id);

            if (categoria != null)
            {
                categorias.Remove(categoria);
                Console.WriteLine("Categoria removida.");
            }
            else
            {
                Console.WriteLine("Categoria não encontrada.");
            }
        }
    }
}