using System;
using System.Collections.Generic;
using GerenciamentoVendasLojaRoupas;

namespace GerenciamentoVendasLojaRoupas.UI
{
    public class ClienteUI
    {
        private static List<Cliente> clientes = new List<Cliente>();
        private static int clienteIdCounter = 1;

        public static void Menu()
        {
            while (true)
            {
                Console.WriteLine("Menu de Clientes:");
                Console.WriteLine("1. Registrar Cliente");
                Console.WriteLine("2. Listar Clientes");
                Console.WriteLine("3. Buscar Cliente por ID");
                Console.WriteLine("4. Atualizar Cliente");
                Console.WriteLine("5. Remover Cliente");
                Console.WriteLine("0. Voltar");

                Console.Write("Escolha uma opção: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        RegistrarCliente();
                        break;
                    case 2:
                        ListarClientes();
                        break;
                    case 3:
                        BuscarClientePorId();
                        break;
                    case 4:
                        AtualizarCliente();
                        break;
                    case 5:
                        RemoverCliente();
                        break;
                    case 0:
                        return;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            }
        }

        public static void RegistrarCliente()
        {
            Console.WriteLine("Registrar Novo Cliente:");

            Cliente novoCliente = new Cliente();
            novoCliente.Id = clienteIdCounter++;

            Console.Write("Nome: ");
            novoCliente.Nome = Console.ReadLine();

            Console.Write("Sobrenome: ");
            novoCliente.Sobrenome = Console.ReadLine();

            Console.Write("Endereço: ");
            novoCliente.Endereco = Console.ReadLine();

            Console.Write("Número de Telefone: ");
            novoCliente.NumeroTelefone = Console.ReadLine();

            clientes.Add(novoCliente);

            Console.WriteLine("Cliente registrado com sucesso!");
        }

        public static void ListarClientes()
        {
            Console.WriteLine("Lista de Clientes:");

            foreach (var cliente in clientes)
            {
                Console.WriteLine($"ID: {cliente.Id}, Nome: {cliente.Nome} {cliente.Sobrenome}, Endereço: {cliente.Endereco}, Número de Telefone: {cliente.NumeroTelefone}");
            }
        }

        public static void BuscarClientePorId()
        {
            Console.Write("Digite o ID do Cliente: ");
            int id = int.Parse(Console.ReadLine());

            Cliente cliente = clientes.Find(c => c.Id == id);

            if (cliente != null)
            {
                Console.WriteLine($"ID: {cliente.Id}, Nome: {cliente.Nome} {cliente.Sobrenome}, Endereço: {cliente.Endereco}, Número de Telefone: {cliente.NumeroTelefone}");
            }
            else
            {
                Console.WriteLine("Cliente não encontrado.");
            }
        }

        public static void AtualizarCliente()
        {
            Console.Write("Digite o ID do Cliente para atualizar: ");
            int id = int.Parse(Console.ReadLine());

            Cliente cliente = clientes.Find(c => c.Id == id);

            if (cliente != null)
            {
                Console.WriteLine($"Atualizando Cliente {cliente.Nome} {cliente.Sobrenome}:");

                Console.Write("Novo Nome: ");
                cliente.Nome = Console.ReadLine();

                Console.Write("Novo Sobrenome: ");
                cliente.Sobrenome = Console.ReadLine();

                Console.Write("Novo Endereço: ");
                cliente.Endereco = Console.ReadLine();

                Console.Write("Novo Número de Telefone: ");
                cliente.NumeroTelefone = Console.ReadLine();

                Console.WriteLine("Cliente atualizado com sucesso!");
            }
            else
            {
                Console.WriteLine("Cliente não encontrado.");
            }
        }

        public static void RemoverCliente()
        {
            Console.Write("Digite o ID do Cliente para remover: ");
            int id = int.Parse(Console.ReadLine());

            Cliente cliente = clientes.Find(c => c.Id == id);

            if (cliente != null)
            {
                clientes.Remove(cliente);
                Console.WriteLine("Cliente removido com sucesso!");
            }
            else
            {
                Console.WriteLine("Cliente não encontrado.");
            }
        }
    }
}