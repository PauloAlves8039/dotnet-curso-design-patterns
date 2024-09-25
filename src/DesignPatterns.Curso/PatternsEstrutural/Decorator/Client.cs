using DesignPatterns.Curso.PatternsEstrutural.Decorator.Decorators;
using DesignPatterns.Curso.PatternsEstrutural.Decorator.Interfaces;
using DesignPatterns.Curso.PatternsEstrutural.Decorator.Services;

namespace DesignPatterns.Curso.PatternsEstrutural.Decorator
{
    public class Client
    {
        public void ConsumirServicos() 
        {
            IPet banhoTosa = new BanhoTosa("Banho e Tosa", 45.00);

            IPet acessorioDecorator = new AcessorioDecorator(banhoTosa);
            IPet luxoSpaDecorator = new LuxoSpaDecorator(acessorioDecorator);

            Console.WriteLine("Resumo dos serviços Pet Shop");
            Console.WriteLine(luxoSpaDecorator.GetNomeServico());
            Console.WriteLine("Valor total: " + luxoSpaDecorator.GetValorServico());
        }
    }
}