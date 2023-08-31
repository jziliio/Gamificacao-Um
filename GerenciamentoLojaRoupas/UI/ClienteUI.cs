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
                Console.WriteLine("Menu - Clientes:");
                Console.WriteLine("1 - Registrar cliente");
                Console.WriteLine("2 - Listar clientes");
                Console.WriteLine("3 - Buscar cliente por ID");
                Console.WriteLine("4 - Atualizar cliente");
                Console.WriteLine("5 - Remover cliente");
                Console.WriteLine("6 - Voltar");

                Console.Write("Selecione uma opção: ");
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
                    case 6:
                        return;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            }
        }

        public static void RegistrarCliente()
        {
            Console.WriteLine("Registro de um novo cliente:");

            Cliente novoCliente = new Cliente();
            novoCliente.Id = clienteIdCounter++;

            Console.Write("Informe somente o nome: ");
            novoCliente.Nome = Console.ReadLine();

            Console.Write("Informe o sobrenome: ");
            novoCliente.Sobrenome = Console.ReadLine();

            Console.Write("Informe o endereço: ");
            novoCliente.Endereco = Console.ReadLine();

            Console.Write("Informe o número para contato: ");
            novoCliente.NumeroTelefone = Console.ReadLine();

            clientes.Add(novoCliente);

            Console.WriteLine("Cliente registrado.");
        }

        public static void ListarClientes()
        {
            Console.WriteLine("Lista de clientes:");

            foreach (var cliente in clientes)
            {
                Console.WriteLine($"ID: {cliente.Id}, Nome: {cliente.Nome} {cliente.Sobrenome}, Endereço: {cliente.Endereco}, Número de Telefone: {cliente.NumeroTelefone}");
            }
        }

        public static void BuscarClientePorId()
        {
            Console.Write("Informe o ID do Cliente: ");
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
            Console.Write("Informe o ID do cliente para ser atualizado: ");
            int id = int.Parse(Console.ReadLine());

            Cliente cliente = clientes.Find(c => c.Id == id);

            if (cliente != null)
            {
                Console.Write("Informe (somente) o novo nome: ");
                cliente.Nome = Console.ReadLine();

                Console.Write("Informe o novo sobrenome: ");
                cliente.Sobrenome = Console.ReadLine();

                Console.Write("Informe o novo endereço: ");
                cliente.Endereco = Console.ReadLine();

                Console.Write("Informe o novo número para contato: ");
                cliente.NumeroTelefone = Console.ReadLine();

                Console.WriteLine("Cliente atualizado.");
            }
            else
            {
                Console.WriteLine("Cliente não encontrado.");
            }
        }

        public static void RemoverCliente()
        {
            Console.Write("Informe o ID do Cliente a ser removido: ");
            int id = int.Parse(Console.ReadLine());

            Cliente cliente = clientes.Find(c => c.Id == id);

            if (cliente != null)
            {
                clientes.Remove(cliente);
                Console.WriteLine("Cliente removido.");
            }
            else
            {
                Console.WriteLine("Cliente não encontrado.");
            }
        }
    }
}