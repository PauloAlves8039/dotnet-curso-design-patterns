
using DesignPatterns.Curso.PatternsComportamental.Command.Interfaces;
using DesignPatterns.Curso.PatternsComportamental.Command.Receivers;

namespace DesignPatterns.Curso.PatternsComportamental.Command.Commands
{
    public class LigaLuminariaCommand : ICommand
    {
        private readonly LuzLuminariaReceiver _luzLuminariaReceiver;

        public LigaLuminariaCommand(LuzLuminariaReceiver luzLuminariaReceiver)
        {
            _luzLuminariaReceiver = luzLuminariaReceiver;
        }

        public void Execute()
        {
            _luzLuminariaReceiver.LigarLuz();
        }
    }
}