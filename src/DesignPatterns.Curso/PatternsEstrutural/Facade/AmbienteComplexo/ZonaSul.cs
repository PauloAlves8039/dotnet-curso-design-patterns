namespace DesignPatterns.Curso.PatternsEstrutural.Facade.AmbienteComplexo
{
    public class ZonaSul
    {
        public List<object> ExecutaRotinaVendasPerdidas(DateTime periodo) 
        {
            Console.WriteLine("[-] - Executando complexidade rotina vendas perdidas região Sul");
            return new List<object>();
        }
    }
}