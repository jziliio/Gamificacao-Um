using System;
using System.Collections.Generic;
using LojaDeRoupas.UI;

namespace GerenciamentoVendasLojaRoupas.UI
{
    public class VendaUI
    {
        private static List<Venda> vendas = new List<Venda>();
        private static int vendaIdCounter = 1;

        public static void RealizarVenda()
        {
            Console.WriteLine("Realizar Nova Venda:");

            Venda novaVenda = new Venda();
            novaVenda.Id = vendaIdCounter++;

            Console.Write("ID do Cliente: ");
            int clienteId = int.Parse(Console.ReadLine());
            Cliente cliente = ClienteUI.GetClientePorId(clienteId);
            if (cliente != null)
            {
                novaVenda.Cliente = cliente;
            }
            else
            {
                Console.WriteLine("Cliente não encontrado. A venda será registrada sem cliente.");
            }

            novaVenda.Produtos = SelecionarProdutos();

            novaVenda.DataVenda = DateTime.Now;
            novaVenda.ValorTotal = CalcularValorTotal(novaVenda.Produtos);

            vendas.Add(novaVenda);

            Console.WriteLine("Venda realizada com sucesso!");
        }

        private static List<Produto> SelecionarProdutos()
        {
            List<Produto> produtosSelecionados = new List<Produto>();
            bool continuarSelecionando = true;

            while (continuarSelecionando)
            {
                Console.Write("ID do Produto (ou 0 para finalizar): ");
                int produtoId = int.Parse(Console.ReadLine());

                if (produtoId == 0)
                {
                    continuarSelecionando = false;
                }
                else
                {
                    Produto produto = ProdutoUI.GetProdutoPorId(produtoId);

                    if (produto != null)
                    {
                        produtosSelecionados.Add(produto);
                    }
                    else
                    {
                        Console.WriteLine("Produto não encontrado. Por favor, insira um ID válido.");
                    }
                }
            }

            return produtosSelecionados;
        }

        private static decimal CalcularValorTotal(List<Produto> produtos)
        {
            decimal total = 0;

            foreach (var produto in produtos)
            {
                total += produto.Preco;
            }

            return total;
        }
    }
}