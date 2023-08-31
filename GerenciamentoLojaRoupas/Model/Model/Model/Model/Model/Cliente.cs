namespace GerenciamentoVendasLojaRoupas
{
    public class Cliente
    {
        public int Id { get; set; }
        public required string Nome { get; set; }
        public required string Sobrenome { get; set; }
        public required string Endereco { get; set; }
        public required string NumeroTelefone { get; set; }
    }
}
