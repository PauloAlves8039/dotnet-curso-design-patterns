using DesignPatterns.Curso.PatternsCriacao.AbstractFactory.ParteProduto.Interfaces;

namespace DesignPatterns.Curso.PatternsCriacao.AbstractFactory.ParteProduto.Produtos
{
    public class TreinoQuartaSabado : ITreino
    {
        public TreinoQuartaSabado()
        {
            this.ObterTreino();
        }

        public void ObterTreino()
        {
            Console.WriteLine("Treino Quarta e Sábado...");
        }
    }
}