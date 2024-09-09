using DesignPatterns.Curso.PatternsCriacao.FactoryMethod;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("********** Curso Design Patterns **********");

        #region FactoryMethod

        var client = new Client();
        client.ExecutarCriacaoProduto();
        
        #endregion


        Console.ReadKey();
    }
}