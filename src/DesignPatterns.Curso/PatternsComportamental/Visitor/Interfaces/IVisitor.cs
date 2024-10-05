using DesignPatterns.Curso.PatternsComportamental.Visitor.Products;

namespace DesignPatterns.Curso.PatternsComportamental.Visitor.Interfaces
{
    public interface IVisitor
    {
        double CalcularImpostoProdutoPerecivel(ProdutoPerecivel produtoPerecivel);
        double CalcularImpostoProdutoNaoPerecivel(ProdutoNaoPerecivel produtoNaoPerecivel);
    }
}