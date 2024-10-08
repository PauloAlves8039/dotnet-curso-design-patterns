using DesignPatterns.Curso.PatternsComportamental.Visitor.Interfaces;
using DesignPatterns.Curso.PatternsComportamental.Visitor.Products;

namespace DesignPatterns.Curso.PatternsComportamental.Visitor.Visitors
{
    public class SaoPauloVisitor : IVisitor
    {
        public double CalcularImpostoProdutoNaoPerecivel(ProdutoNaoPerecivel produtoNaoPerecivel)
        {
            var imposto = (produtoNaoPerecivel.Peso / 100) + 7;

            Console.WriteLine($"Imposto São Paulo: {imposto}");

            return imposto;
        }

        public double CalcularImpostoProdutoPerecivel(ProdutoPerecivel produtoPerecivel)
        {
            var imposto = (produtoPerecivel.Peso / 100) + 12;

            Console.WriteLine($"Imposto São Paulo: {imposto}");

            return imposto;
        }
    }
}