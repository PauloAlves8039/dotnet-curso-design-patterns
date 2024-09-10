using DesignPatterns.Curso.PatternsCriacao.AbstractFactory.ParteProduto.Interfaces;

namespace DesignPatterns.Curso.PatternsCriacao.AbstractFactory.ParteProduto.Produtos
{
    public class DietaQuartaSabado : IDieta
    {
        public DietaQuartaSabado()
        {
            this.ObterAlimentacao();
        }
        
        public void ObterAlimentacao()
        {
            Console.WriteLine("Dieta de Quarta a Sábado...");
        }
    }
}