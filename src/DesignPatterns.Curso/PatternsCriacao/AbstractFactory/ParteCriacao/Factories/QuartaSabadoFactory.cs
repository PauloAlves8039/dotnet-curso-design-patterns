using DesignPatterns.Curso.PatternsCriacao.AbstractFactory.ParteCriacao.Interfaces;
using DesignPatterns.Curso.PatternsCriacao.AbstractFactory.ParteProduto.Produtos;

namespace DesignPatterns.Curso.PatternsCriacao.AbstractFactory.ParteCriacao.Factories
{
    public class QuartaSabadoFactory : IFactory
    {
        public QuartaSabadoFactory()
        {
            this.ObterRotinaDiaria();
        }
        
        public void ObterRotinaDiaria()
        {
            Console.WriteLine("Factory Terça e Sexta Criada.");
            var dieta = new DietaQuartaSabado();
            var treino = new TreinoQuartaSabado();

            dieta.ObterAlimentacao();
            treino.ObterTreino();
        }
    }
}
