using DesignPatterns.Curso.PatternsEstrutural.Decorator.Interfaces;

namespace DesignPatterns.Curso.PatternsEstrutural.Decorator.Decorators
{
    public class AcessorioDecorator : PetDecorator
    {
        public AcessorioDecorator(IPet pet) : base(pet) { }

        public override double GetValorServico()
        {
            return base.GetValorServico();
        }

        public override string GetNomeServico()
        {
            return base.GetNomeServico() + "\n[+] Acessório";
        }
    }
}