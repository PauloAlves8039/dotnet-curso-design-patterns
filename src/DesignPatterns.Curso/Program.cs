// using DesignPatterns.Curso.PatternsCriacao.AbstractFactory;
// using DesignPatterns.Curso.PatternsCriacao.Singleton;
// using DesignPatterns.Curso.PatternsCriacao.Builder;
// using DesignPatterns.Curso.PatternsCriacao.Prototype;
// using DesignPatterns.Curso.PatternsEstrutural.Adapter;
// using DesignPatterns.Curso.PatternsEstrutural.Flyweight;
// using DesignPatterns.Curso.PatternsEstrutural.Bridge;
// using DesignPatterns.Curso.PatternsEstrutural.Bridge.Abrtracao;
// using DesignPatterns.Curso.PatternsEstrutural.Bridge.Implementacao;
// using DesignPatterns.Curso.PatternsEstrutural.Composite;
// using DesignPatterns.Curso.PatternsEstrutural.Decorator;
// using DesignPatterns.Curso.PatternsEstrutural.Facade;
// using DesignPatterns.Curso.PatternsEstrutural.Proxy;
// using DesignPatterns.Curso.PatternsComportamental.TemplateMethod;
// using DesignPatterns.Curso.PatternsComportamental.Interpreter.Jumanji;
// using DesignPatterns.Curso.PatternsComportamental.Observer;

using DesignPatterns.Curso.PatternsComportamental.Visitor;

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

        // var client = new Client();
        // client.ConsumirDadosStudios();

        #endregion

        #region Prototype

        // var cliente = new Cliente();
        // cliente.ConsumirDadosStudios();

        #endregion
        
        #region Adapter

        // var cloud = new CloudComputing();
        // cloud.ProcessarContas("setembro");

        #endregion

        #region Flyweight

        // var client = new Client();
        // client.ConsumirFlayweight();

        #endregion
        
        #region Bridge

        // Client client;
        // Random random;

        // while (true) 
        // {
        //     client = new Client();
        //     random = new Random();

        //     if (random.Next(2) == 1) 
        //     {
        //         client.Material = new CanetaEsferografica();
        //     }
        //     else 
        //     {
        //         client.Material = new PincelMarcador();
        //     }

        //     if (random.Next(1, 3) == 1) 
        //     {
        //         client.Material.CorImplementacao = new Azul();
        //     }
        //     else if (random.Next(1, 3) == 2) 
        //     {
        //         client.Material.CorImplementacao = new Preto();
        //     }
        //     else 
        //     {
        //         client.Material.CorImplementacao = new Vermelho();
        //     }

        //     client.ConsultarCanetasPinceisNoEstoque();
            
        //     Console.WriteLine("Pressione enter para continuar ou qualquer tecla finalizar...");
        //     ConsoleKeyInfo key = Console.ReadKey();

        //     if (key.KeyChar != 13) 
        //     {
        //         break;
        //     }
        // }

        #endregion
        
        #region Composite

        // var client = new Client();
        // client.EfetuarCompra();

        #endregion
        
        #region Decorator

        // var client = new Client();
        // client.ConsumirServicos();

        #endregion

        #region Facade

        // var facade = new FacadeManager();
        // facade.ExecutarComplexidade();

        #endregion

        #region Proxy

        // var client = new Client();
        // client.TentarConexaoClientVPN();

        #endregion
        
        #region Templat Method

        // var client = new Client();
        // client.ConsumirEndpointXML();

        #endregion

        #region Interpreter

        // var apresentaPopup = new ApresentaPopup();
        // apresentaPopup.ApresentarHabilidadesPopup();

        #endregion

        #region Observer

        // var sendEmail = new SendMail();
        // sendEmail.EnviarEmail();

        #endregion

        #region Visitor

        var fiscal = new Fiscal();
        fiscal.CalcularImpostos();

        #endregion
        
        // Console.ReadKey();
    }
}