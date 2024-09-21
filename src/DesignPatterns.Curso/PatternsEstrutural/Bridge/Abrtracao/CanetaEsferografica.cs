using DesignPatterns.Curso.PatternsEstrutural.Bridge.Abrtracao.Interfaces;
using DesignPatterns.Curso.PatternsEstrutural.Bridge.Implementacao.Interfaces;

namespace DesignPatterns.Curso.PatternsEstrutural.Bridge.Abrtracao
{
    public class CanetaEsferografica : IMaterial
    {
        public ICor CorImplementacao { get; set; }

        public string ConsultarNoEstoque()
        {
            return this.CorImplementacao.ConsultarQuantidadePorCor("Caneta Esferográfica");
        }
    }
}