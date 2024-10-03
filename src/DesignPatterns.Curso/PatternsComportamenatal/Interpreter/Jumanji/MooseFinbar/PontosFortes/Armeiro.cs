namespace DesignPatterns.Curso.PatternsComportamenatal.Interpreter.Jumanji.MooseFinbar.PontosFortes
{
    public class Armeiro : IPontoForte
    {
        public void Interpretar(Contexto contexto)
        {
            contexto.Conteudo += "[+] - Manuseio de Armas\n";
        }
    }
}