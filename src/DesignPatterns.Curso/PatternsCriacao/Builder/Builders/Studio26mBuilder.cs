using DesignPatterns.Curso.PatternsCriacao.Builder.Studios;

namespace DesignPatterns.Curso.PatternsCriacao.Builder.Builders
{
    public class Studio26mBuilder : StudioBuilder
    {
        public Studio26mBuilder()
        {
            studio = new Studio26m();
        }
        
        public override void DefinirValorStudio()
        {
            studio.DefinirValorStudio(190000.00m);
        }

        public override void EscolherFinanciamento()
        {
            studio.EscolherFinanciamento("Investi Fácil");
        }

        public override void EscolherPiso()
        {
            studio.EscolherPiso("Cerâmica");
        }
    }
}