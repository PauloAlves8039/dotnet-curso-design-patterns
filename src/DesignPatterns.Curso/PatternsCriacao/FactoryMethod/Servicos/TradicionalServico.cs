using DesignPatterns.Curso.PatternsCriacao.FactoryMethod.Interfaces;

namespace DesignPatterns.Curso.PatternsCriacao.FactoryMethod.Servicos
{
    public class TradicionalServico : IServico
    {
        public TradicionalServico()
        {
            Console.WriteLine("Produto Tradicional criado com sucesso!");
        }
        
        public void ExecutaCobrancaServico()
        {
            throw new NotImplementedException();
        }
    }
}