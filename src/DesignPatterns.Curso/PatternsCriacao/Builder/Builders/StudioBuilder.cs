using DesignPatterns.Curso.PatternsCriacao.Builder.Studios;

namespace DesignPatterns.Curso.PatternsCriacao.Builder.Builders
{
    public abstract class StudioBuilder
    {
        protected Studio studio;

        public Studio GetStudio()
        {
            return studio;
        }

        public abstract void EscolherPiso();
        public abstract void EscolherFinanciamento();
        public abstract void DefinirValorStudio();
    }
}