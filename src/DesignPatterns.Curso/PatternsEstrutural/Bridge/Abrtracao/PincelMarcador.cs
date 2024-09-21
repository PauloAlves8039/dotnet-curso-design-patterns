using DesignPatterns.Curso.PatternsEstrutural.Bridge.Abrtracao.Interfaces;
using DesignPatterns.Curso.PatternsEstrutural.Bridge.Implementacao.Interfaces;

namespace DesignPatterns.Curso.PatternsEstrutural.Bridge.Abrtracao
{
    public class PincelMarcador : IMaterial
    {
        public ICor CorImplementacao { get; set; }

        public string ConsultarNoEstoque()
        {
            return this.CorImplementacao.ConsultarQuantidadePorCor("Pincel Marcador");
        }
    }
}