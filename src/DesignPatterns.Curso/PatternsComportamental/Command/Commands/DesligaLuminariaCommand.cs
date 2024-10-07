using DesignPatterns.Curso.PatternsComportamental.Command.Interfaces;
using DesignPatterns.Curso.PatternsComportamental.Command.Receivers;

namespace DesignPatterns.Curso.PatternsComportamental.Command.Commands
{
    public class DesligaLuminariaCommand : ICommand
    {
        private readonly LuzLuminariaReceiver _luzLuminariaReceiver;

        public DesligaLuminariaCommand(LuzLuminariaReceiver luzLuminariaReceiver)
        {
            _luzLuminariaReceiver = luzLuminariaReceiver;
        }

        public void Execute()
        {
            _luzLuminariaReceiver.DesligarLuz();
        }
    }
}