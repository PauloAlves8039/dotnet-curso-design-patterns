using DesignPatterns.Curso.PatternsEstrutural.Bridge.Abrtracao.Interfaces;
using DesignPatterns.Curso.PatternsEstrutural.Bridge.Implementacao.Interfaces;

namespace DesignPatterns.Curso.PatternsEstrutural.Bridge.Implementacao
{
    public class Preto : ICor
    {
        public string ConsultarQuantidadePorCor(string tipoAbstracao)
        {
            var randon = new Random();
            var quantidade = randon.Next(100, 500);

            return $"Existem {quantidade} para {tipoAbstracao} de cor Preta no estoque.";
        }
    }
}