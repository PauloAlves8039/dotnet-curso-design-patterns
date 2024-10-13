namespace DesignPatterns.Curso.PatternsComportamental.Mediator.AbstractModel
{
    public abstract class Contato
    {
        protected Mediador Mediador;

        protected Contato(Mediador mediador)
        {
            Mediador = mediador;
        }
    }
}