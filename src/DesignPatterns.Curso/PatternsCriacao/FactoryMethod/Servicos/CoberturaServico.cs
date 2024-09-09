using DesignPatterns.Curso.PatternsCriacao.FactoryMethod.Interfaces;

namespace DesignPatterns.Curso.PatternsCriacao.FactoryMethod.Servicos
{
    public class CoberturaServico : IServico
    {
        public CoberturaServico()
        {
            Console.WriteLine("Produto Cobertura criado com sucesso!");
        }
        
        public void ExecutaCobrancaServico()
        {
            throw new NotImplementedException();
        }
    }
}