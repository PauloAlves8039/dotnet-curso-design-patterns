// using DesignPatterns.Curso.PatternsCriacao.AbstractFactory;
// using DesignPatterns.Curso.PatternsCriacao.Singleton;
using DesignPatterns.Curso.PatternsCriacao.Builder;

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

        // var client = new Client();
        // client.ConsultarRotinaAluno();

        #endregion

        #region Singleton

        // var client = new Client();
        // client.ConsumirDB();

        #endregion

        #region Builder

        var client = new Client();
        client.ConsumirDadosStudios();

        #endregion

        Console.ReadKey();
    }
}