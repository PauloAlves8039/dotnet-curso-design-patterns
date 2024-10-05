using DesignPatterns.Curso.PatternsComportamental.Visitor.Interfaces;
using DesignPatterns.Curso.PatternsComportamental.Visitor.Products;

namespace DesignPatterns.Curso.PatternsComportamental.Visitor.Visitors
{
    public class RioDeJaneiroVisitor : IVisitor
    {
        public double CalcularImpostoProdutoNaoPerecivel(ProdutoNaoPerecivel produtoNaoPerecivel)
        {
            var imposto = (produtoNaoPerecivel.Peso / 100) + 5;

            Console.WriteLine($"Imposto Rio de Janeiro: {imposto}");

            return imposto;
        }

        public double CalcularImpostoProdutoPerecivel(ProdutoPerecivel produtoPerecivel)
        {
            var imposto = (produtoPerecivel.Peso / 100) + 10;

            Console.WriteLine($"Imposto Rio de Janeiro: {imposto}");

            return imposto;
        }
    }
}