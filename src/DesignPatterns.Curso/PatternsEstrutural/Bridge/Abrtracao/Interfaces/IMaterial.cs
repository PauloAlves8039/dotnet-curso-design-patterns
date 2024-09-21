using DesignPatterns.Curso.PatternsEstrutural.Bridge.Implementacao.Interfaces;

namespace DesignPatterns.Curso.PatternsEstrutural.Bridge.Abrtracao.Interfaces
{
    public interface IMaterial
    {
        public ICor CorImplementacao { get; set; }

        string ConsultarNoEstoque();
    }
}