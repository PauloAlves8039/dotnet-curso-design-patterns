using DesignPatterns.Curso.PatternsEstrutural.Adapter.Interfaces;

namespace DesignPatterns.Curso.PatternsEstrutural.Adapter
{
    public class Adapter : IAdapter
    {
        BusinessLegado legado;

        public Adapter(BusinessLegado legado)
        {
            this.legado = legado;
        }
        
        public string ExecutarRotinaContasPagar(string mes)
        {
            return legado.ExecutarRotinaContasPagar(mes);
        }

        public string ExecutarRotinaContasReceber(string mes)
        {
            return legado.ExecutarRotinaContasReceber(mes);
        }
    }
}