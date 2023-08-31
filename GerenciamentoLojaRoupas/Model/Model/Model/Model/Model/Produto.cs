using GerenciamentoVendasLojaRoupas.UI;

namespace GerenciamentoVendasLojaRoupas
{
    public class Produto
    {
        public int Id { get; set; }
        public required string Nome { get; set; }
        public required string Descricao { get; set; }
        public required decimal Preco { get; set; }
        public required Categoria Categoria { get; set; }
    }
}