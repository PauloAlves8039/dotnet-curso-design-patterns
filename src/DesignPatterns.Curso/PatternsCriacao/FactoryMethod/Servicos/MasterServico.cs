using DesignPatterns.Curso.PatternsCriacao.FactoryMethod.Interfaces;

namespace DesignPatterns.Curso.PatternsCriacao.FactoryMethod.Servicos
{
    public class MasterServico : IServico
    {
        public MasterServico()
        {
            Console.WriteLine("Produto Master criado com sucesso!");
        }
        
        public void ExecutaCobrancaServico()
        {
            throw new NotImplementedException();
        }
    }
}