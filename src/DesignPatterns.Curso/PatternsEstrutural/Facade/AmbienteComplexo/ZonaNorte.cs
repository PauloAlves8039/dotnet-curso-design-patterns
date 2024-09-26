namespace DesignPatterns.Curso.PatternsEstrutural.Facade.AmbienteComplexo
{
    public class ZonaNorte
    {
        public List<object> ExecutaRotinaVendasPerdidas(DateTime periodo) 
        {
            Console.WriteLine("[-] - Executando complexidade rotina vendas perdidas região Norte");
            return new List<object>();
        }
    }
}