namespace DesignPatterns.Curso.PatternsComportamental.ChainOfResponsability
{
    public class Checkout
    {
        public int ClienteId { get; set; }
        public int QuantidadeDias { get; set; }
        public double ValorDiaria { get; set; }
        public double ValorTotal { get; set; }

        public Checkout(int clienteId, int quantidadeDias, double valorDiaria)
        {
            ClienteId = clienteId;
            QuantidadeDias = quantidadeDias;
            ValorDiaria = valorDiaria;
            CalcularTotal();
        }

        private void CalcularTotal()
        {
            this.ValorTotal = this.QuantidadeDias * this.ValorDiaria;
        }
    }
}