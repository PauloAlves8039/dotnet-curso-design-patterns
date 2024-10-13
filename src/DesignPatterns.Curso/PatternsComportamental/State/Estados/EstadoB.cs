using DesignPatterns.Curso.PatternsComportamental.State.Interfaces;

namespace DesignPatterns.Curso.PatternsComportamental.State.Estados
{
    public class EstadoB : IEstado
    {
        public void Acao(Context context)
        {
            Console.WriteLine("Executando ações do Estado B");
            context.Estado = new EstadoA();
        }
    }
}