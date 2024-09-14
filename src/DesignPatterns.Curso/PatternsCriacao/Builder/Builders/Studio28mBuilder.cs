using DesignPatterns.Curso.PatternsCriacao.Builder.Studios;

namespace DesignPatterns.Curso.PatternsCriacao.Builder.Builders
{
    public class Studio28mBuilder : StudioBuilder
    {
        public Studio28mBuilder()
        {
            studio = new Studio28m();
        }
        
        public override void DefinirValorStudio()
        {
            studio.DefinirValorStudio(200000.00m);
        }

        public override void EscolherFinanciamento()
        {
            studio.EscolherFinanciamento("FinaInvesti Imoveis");
        }

        public override void EscolherPiso()
        {
            studio.EscolherPiso("Piso Vivículo");
        }
    }
}