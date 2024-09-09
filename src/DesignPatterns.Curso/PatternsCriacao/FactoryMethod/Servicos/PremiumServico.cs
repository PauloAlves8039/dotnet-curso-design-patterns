using DesignPatterns.Curso.PatternsCriacao.FactoryMethod.Interfaces;

namespace DesignPatterns.Curso.PatternsCriacao.FactoryMethod.Servicos
{
    public class PremiumServico : IServico
    {
        public PremiumServico()
        {
            Console.WriteLine("Produto Premium criado com sucesso!");
        }
        
        public void ExecutaCobrancaServico()
        {
            throw new NotImplementedException();
        }
    }
}