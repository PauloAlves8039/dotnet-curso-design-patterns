using DesignPatterns.Curso.PatternsEstrutural.Bridge.Abrtracao.Interfaces;

namespace DesignPatterns.Curso.PatternsEstrutural.Bridge
{
    public class Client
    {
        public IMaterial Material { get; set; }

        public void ConsultarCanetasPinceisNoEstoque() 
        {
            Console.WriteLine(this.Material.ConsultarNoEstoque());
        }
    }
}