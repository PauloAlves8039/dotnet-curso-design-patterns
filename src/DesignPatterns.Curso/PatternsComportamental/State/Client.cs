using DesignPatterns.Curso.PatternsComportamental.State.Estados;

namespace DesignPatterns.Curso.PatternsComportamental.State
{
    public class Client
    {
        public void ExecutarContext()
        {
            Context context = new Context(new EstadoA());

            context.Trocar();
            context.Trocar();

        }
    }
}