using DesignPatterns.Curso.PatternsComportamental.Strategy.Interfaces;

namespace DesignPatterns.Curso.PatternsComportamental.Strategy
{
    public class CalculaTaxaServicos
    {
        public void Calcular(List<IServico> servicos)
        {
            foreach (IServico servico in servicos)
            {
                servico.CalcularServico();
                Console.WriteLine(new String('-', 40));
            }
        }
    }
}