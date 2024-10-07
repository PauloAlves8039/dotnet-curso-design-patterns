using DesignPatterns.Curso.PatternsComportamental.Command.Interfaces;
using DesignPatterns.Curso.PatternsComportamental.Command.Receivers;

namespace DesignPatterns.Curso.PatternsComportamental.Command.Commands
{
    public class AumentaIntensidadeCommand : ICommand
    {
        private readonly LuzLuminariaReceiver _luzLuminariaReceiver;

        public AumentaIntensidadeCommand(LuzLuminariaReceiver luzLuminariaReceiver)
        {
            _luzLuminariaReceiver = luzLuminariaReceiver;
        }

        public void Execute()
        {
            _luzLuminariaReceiver.AumentarIntensidade();
        }
    }
}