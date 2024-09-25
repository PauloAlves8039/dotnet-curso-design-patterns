using DesignPatterns.Curso.PatternsEstrutural.Decorator.Interfaces;

namespace DesignPatterns.Curso.PatternsEstrutural.Decorator.Decorators
{
    public class LuxoSpaDecorator : PetDecorator
    {
        public LuxoSpaDecorator(IPet pet) : base(pet) { }

        public override double GetValorServico()
        {
            return base.GetValorServico() + 200.00; 
        }

        public override string GetNomeServico()
        {
            return base.GetNomeServico() + "\n[+] Luxo Spa";
        }
    }
}