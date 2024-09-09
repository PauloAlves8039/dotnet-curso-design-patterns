using DesignPatterns.Curso.PatternsCriacao.FactoryMethod.Enums;
using DesignPatterns.Curso.PatternsCriacao.FactoryMethod.Interfaces;
using DesignPatterns.Curso.PatternsCriacao.FactoryMethod.Servicos;

namespace DesignPatterns.Curso.PatternsCriacao.FactoryMethod
{
    public class SelecionaServico : ServicoFactory
    {
        public override IServico FabricarProduto(eTiposServicos tiposServicos)
        {
            switch (tiposServicos)
            {
                case eTiposServicos.tradicional:
                    return new TradicionalServico();
                case eTiposServicos.premium:
                    return new PremiumServico();
                case eTiposServicos.master:
                    return new MasterServico();
                case eTiposServicos.cobertura:
                    return new CoberturaServico();
                default:
                    return null;
            }
        }
    }
}