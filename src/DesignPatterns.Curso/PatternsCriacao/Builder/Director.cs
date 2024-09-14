using DesignPatterns.Curso.PatternsCriacao.Builder.Builders;

namespace DesignPatterns.Curso.PatternsCriacao.Builder
{
    public class Director
    {
        public void ContruirStudio(StudioBuilder studioBuilder) 
        {
            studioBuilder.EscolherPiso();
            studioBuilder.DefinirValorStudio();
            studioBuilder.EscolherFinanciamento();
        }
    }
}