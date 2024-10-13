using DesignPatterns.Curso.PatternsComportamental.State.Interfaces;

namespace DesignPatterns.Curso.PatternsComportamental.State.Estados
{
    public class EstadoA : IEstado
    {
        public void Acao(Context context)
        {
            Console.WriteLine("Executando ações do Estado A");
            context.Estado = new EstadoB();
        }
    }
}