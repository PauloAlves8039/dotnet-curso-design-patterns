using DesignPatterns.Curso.PatternsCriacao.AbstractFactory.ParteProduto.Interfaces;

namespace DesignPatterns.Curso.PatternsCriacao.AbstractFactory.ParteProduto.Produtos
{
    public class DietaTercaSexta : IDieta
    {
        public DietaTercaSexta()
        {
            this.ObterAlimentacao();
        }
        
        public void ObterAlimentacao()
        {
            Console.WriteLine("Dieta de Terça e Sexta Feira...");
        }
    }
}