using DesignPatterns.Curso.PatternsComportamental.Command.Interfaces;
using DesignPatterns.Curso.PatternsComportamental.Command.Receivers;

namespace DesignPatterns.Curso.PatternsComportamental.Command.Commands
{
    public class DiminuiIntensidadeCommand : ICommand
    {
        private readonly LuzLuminariaReceiver _luzLuminariaReceiver;

        public DiminuiIntensidadeCommand(LuzLuminariaReceiver luzLuminariaReceiver)
        {
            _luzLuminariaReceiver = luzLuminariaReceiver;
        }

        public void Execute()
        {
            _luzLuminariaReceiver.DiminuirIntensidade();
        }
    }
}