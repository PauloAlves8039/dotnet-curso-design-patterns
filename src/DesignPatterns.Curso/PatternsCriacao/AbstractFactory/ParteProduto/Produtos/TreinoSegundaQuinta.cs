using DesignPatterns.Curso.PatternsCriacao.AbstractFactory.ParteProduto.Interfaces;

namespace DesignPatterns.Curso.PatternsCriacao.AbstractFactory.ParteProduto.Produtos
{
    public class TreinoSegundaQuinta : ITreino
    {
        public TreinoSegundaQuinta()
        {
            this.ObterTreino();
        }
        
        public void ObterTreino()
        {
            Console.WriteLine("Treino Segunda e Quinta feira...");
        }
    }
}