using DesignPatterns.Curso.PatternsComportamental.Mediator.AbstractModel;

namespace DesignPatterns.Curso.PatternsComportamental.Mediator
{
    public class MediadorConcreto : Mediador
    {
        private Atendente _atendente;
        private Paciente _paciente;

        public Atendente Atendente
        {
            set
            {
                _atendente = value;
            }
        }

        public Paciente Paciente
        {
            set
            {
                _paciente = value;
            }
        }


        public override void Enviar(string mensagem, Contato contato)
        {
            if (contato == _paciente)
            {
                _atendente.Notificar(mensagem);
            }
            else
            {
                _paciente.Notificar(mensagem);
            }
        }
    }
}