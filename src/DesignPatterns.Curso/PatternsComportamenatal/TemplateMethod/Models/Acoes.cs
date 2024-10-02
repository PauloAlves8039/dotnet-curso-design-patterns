namespace DesignPatterns.Curso.PatternsComportamenatal.TemplateMethod.Models
{
    public class Acoes
    {
        public string Sigla { get; set; }
        public int Quantidade { get; set; }
        public double ValorUnitario { get; set; }
        
        public Acoes()
        {
        }

        public Acoes(string sigla, int quantidade, double valorUnitario)
        {
            Sigla = sigla;
            Quantidade = quantidade;
            ValorUnitario = valorUnitario;
        }
    }
}