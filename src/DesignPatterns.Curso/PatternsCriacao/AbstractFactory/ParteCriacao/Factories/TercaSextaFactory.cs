using DesignPatterns.Curso.PatternsCriacao.AbstractFactory.ParteCriacao.Interfaces;
using DesignPatterns.Curso.PatternsCriacao.AbstractFactory.ParteProduto.Produtos;

namespace DesignPatterns.Curso.PatternsCriacao.AbstractFactory.ParteCriacao.Factories
{
    public class TercaSextaFactory : IFactory
    {
        public TercaSextaFactory()
        {
            this.ObterRotinaDiaria();
        }
        
        public void ObterRotinaDiaria()
        {
            Console.WriteLine("Factory Terça e Sexta Criada.");
            var dieta = new DietaTercaSexta();
            var treino = new TreinoTercaSexta();

            dieta.ObterAlimentacao();
            treino.ObterTreino();
        }
    }
}
