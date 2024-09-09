using DesignPatterns.Curso.PatternsCriacao.FactoryMethod.Enums;
using DesignPatterns.Curso.PatternsCriacao.FactoryMethod.Interfaces;

namespace DesignPatterns.Curso.PatternsCriacao.FactoryMethod
{
    public abstract class ServicoFactory
    {
        public abstract IServico FabricarProduto(eTiposServicos tiposServicos );
    }
}