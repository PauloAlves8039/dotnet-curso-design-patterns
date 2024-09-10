using DesignPatterns.Curso.PatternsCriacao.AbstractFactory.ParteProduto.Interfaces;

namespace DesignPatterns.Curso.PatternsCriacao.AbstractFactory.ParteProduto.Produtos
{
    public class DietaSegundaQuinta : IDieta
    {
        public DietaSegundaQuinta()
        {
            this.ObterAlimentacao();
        }
        
        public void ObterAlimentacao()
        {
            Console.WriteLine("Dieta de Segunda e Quinta Feira...");
        }
    }
}