using System;
using System.Collections.Generic;

namespace GerenciamentoVendasLojaRoupas
{
    public class Venda
    {
        public int Id { get; set; }
        public required Cliente Cliente { get; set; }
        public required List<Produto> Produtos { get; set; }
        public required DateTime DataVenda { get; set; }
        public required decimal ValorTotal { get; set; }
    }
}