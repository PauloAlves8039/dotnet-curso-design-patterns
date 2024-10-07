using DesignPatterns.Curso.PatternsComportamental.Command.Commands;
using DesignPatterns.Curso.PatternsComportamental.Command.Receivers;

namespace DesignPatterns.Curso.PatternsComportamental.Command
{
    public class Client
    {
        public void FalarComandos()
        {
            var luminaria = new LuzLuminariaReceiver();
            var controle = new ControleInvoker();

            controle.AddCommand("LigaLuz", new LigaLuminariaCommand(luminaria));
            controle.AddCommand("DesligaLuz", new DesligaLuminariaCommand(luminaria));
            controle.AddCommand("AumentaIntensidade", new AumentaIntensidadeCommand(luminaria));
            controle.AddCommand("DiminuiIntensidade", new DiminuiIntensidadeCommand(luminaria));

            controle.ExecuteCommand("LigaLuz");

            controle.ExecuteCommand("AumentaIntensidade");
            
            controle.ExecuteCommand("DiminuiIntensidade");
            controle.ExecuteCommand("DiminuiIntensidade");
            controle.ExecuteCommand("DiminuiIntensidade");
            controle.ExecuteCommand("DiminuiIntensidade");
            controle.ExecuteCommand("DiminuiIntensidade");
            
            controle.ExecuteCommand("DiminuiIntensidade");

            controle.ExecuteCommand("AumentaIntensidade");
            controle.ExecuteCommand("AumentaIntensidade");
            controle.ExecuteCommand("AumentaIntensidade");
            controle.ExecuteCommand("AumentaIntensidade");
            controle.ExecuteCommand("AumentaIntensidade");


            controle.ExecuteCommand("DesligaLuz");
        }
    }
}