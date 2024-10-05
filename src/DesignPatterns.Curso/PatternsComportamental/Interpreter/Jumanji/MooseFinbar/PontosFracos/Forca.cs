namespace DesignPatterns.Curso.PatternsComportamental.Interpreter.Jumanji.MooseFinbar.PontosFracos
{
    public class Forca : IPontoFraco
    {
        public void Interpretar(Contexto contexto)
        {
            contexto.Conteudo += "[-] - Força\n";
        }
    }
}