using DesignPatterns.Curso.PatternsCriacao.AbstractFactory.ParteProduto.Interfaces;

namespace DesignPatterns.Curso.PatternsCriacao.AbstractFactory.ParteProduto.Produtos
{
    public class TreinoTercaSexta : ITreino
    {
        public TreinoTercaSexta()
        {
            this.ObterTreino();
        }
        
        public void ObterTreino()
        {
            Console.WriteLine("Treino Terça e Sexta feira...");
        }
    }
}