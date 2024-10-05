using DesignPatterns.Curso.PatternsComportamental.Visitor.Interfaces;

namespace DesignPatterns.Curso.PatternsComportamental.Visitor.Products
{
    public class ProdutoPerecivel : IProduct
    {
        public ProdutoPerecivel(string nome, double peso)
        {
            Nome = nome;
            Peso = peso;
        }

        public string Nome { get; set; }
        public double Peso { get; set; }

        public double GetImposto(IVisitor visitor)
        {
            return visitor.CalcularImpostoProdutoPerecivel(this);
        }
    }
}