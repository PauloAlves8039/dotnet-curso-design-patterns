using DesignPatterns.Curso.PatternsComportamental.Strategy.Enums;

namespace DesignPatterns.Curso.PatternsComportamental.Strategy.Models
{
    public class Orcamento
    {
        public int IdCliente { get; set; }
        public double ValorDiaria { get; set; }
        public int Quantidade { get; set; }
        public double ValorTotal { get; set; }
        public bool CupomDesconto { get; set; }
        public PorcentagemServicos Porcentagem { get; set; }

        public Orcamento(int idCliente, 
                        double valorDiaria, 
                        int quantidade, 
                        PorcentagemServicos porcentagem,
                        bool cupomDesconto = false)
        {
            IdCliente = idCliente;
            ValorDiaria = valorDiaria;
            Quantidade = quantidade;
            CupomDesconto = cupomDesconto;
            Porcentagem = porcentagem;
            CalcularValorTotal();
        }


        private void CalcularValorTotal()
        {
            this.ValorTotal = this.Quantidade * this.ValorDiaria;
        }
    }
}