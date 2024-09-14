using DesignPatterns.Curso.PatternsCriacao.Builder.Builders;
using DesignPatterns.Curso.PatternsCriacao.Builder.Studios;

namespace DesignPatterns.Curso.PatternsCriacao.Builder
{
    public class Client
    {
        public void ConsumirDadosStudios() 
        {
            Director director = new Director();
            StudioBuilder studioBuilder;
            Studio studio;

            studioBuilder = new Studio24mBuilder();
            director.ContruirStudio(studioBuilder);
            studio = studioBuilder.GetStudio();
            ImprimirResultado(studio, "24m1");

            studioBuilder = new Studio26mBuilder();
            director.ContruirStudio(studioBuilder);
            studio = studioBuilder.GetStudio();
            ImprimirResultado(studio, "26m1");

            studioBuilder = new Studio28mBuilder();
            director.ContruirStudio(studioBuilder);
            studio = studioBuilder.GetStudio();
            ImprimirResultado(studio, "28m1");

        }

        private void ImprimirResultado(Studio studio, string nome) 
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine($"[+] - Studio {nome}");
            Console.WriteLine("Valor: {0}\nPiso: {1}\nFinanciamento: {2}", studio.ValorStudio.ToString("C"), 
                studio.TipoPiso, 
                studio.TipoFinanciamento);
        }
    }
}