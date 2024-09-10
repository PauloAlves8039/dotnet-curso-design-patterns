using DesignPatterns.Curso.PatternsCriacao.AbstractFactory.ParteCriacao.Interfaces;
using DesignPatterns.Curso.PatternsCriacao.AbstractFactory.ParteProduto.Produtos;

namespace DesignPatterns.Curso.PatternsCriacao.AbstractFactory.ParteCriacao.Factories
{
    public class SegundaQuintaFactory : IFactory
    {
        public SegundaQuintaFactory()
        {
            this.ObterRotinaDiaria();
        }
        
        public void ObterRotinaDiaria()
        {
            Console.WriteLine("Factory Segunda e Quinta Criada.");
            var dieta = new DietaSegundaQuinta();
            var treino = new TreinoSegundaQuinta();

            dieta.ObterAlimentacao();
            treino.ObterTreino();
        }
    }
}
