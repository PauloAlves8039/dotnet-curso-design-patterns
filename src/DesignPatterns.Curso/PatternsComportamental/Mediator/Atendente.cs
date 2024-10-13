using DesignPatterns.Curso.PatternsComportamental.Mediator.AbstractModel;

namespace DesignPatterns.Curso.PatternsComportamental.Mediator
{
    public class Atendente : Contato
    {
        public Atendente(Mediador mediador) : base(mediador) { }

        public void EnviarMensagem(string mensagem)
        {
            Console.WriteLine("Atendente escrevendo...");
            Thread.Sleep(3000);
            this.Mediador.Enviar(mensagem, this);
            Thread.Sleep(3000);
        }

        public void Notificar(string mensagem)
        {
            Console.WriteLine($"Para Atendente: {mensagem}");
        }
    }
}