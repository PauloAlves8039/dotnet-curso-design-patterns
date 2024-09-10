using DesignPatterns.Curso.PatternsCriacao.AbstractFactory;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("********** Curso Design Patterns **********");

        #region FactoryMethod

        // var client = new Client();
        // client.ExecutarCriacaoProduto();
        
        #endregion

        
        #region AbstractFactory

        var client = new Client();
        client.ConsultarRotinaAluno();

        #endregion


        Console.ReadKey();
    }
}