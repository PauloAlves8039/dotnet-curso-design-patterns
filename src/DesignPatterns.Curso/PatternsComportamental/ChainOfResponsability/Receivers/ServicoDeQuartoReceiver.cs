using DesignPatterns.Curso.PatternsComportamental.ChainOfResponsability.AbstractModel;

namespace DesignPatterns.Curso.PatternsComportamental.ChainOfResponsability.Receivers
{
    public class ServicoDeQuartoReceiver : CobrancaReceiver
    {
        public override Checkout ExecutarCobrancaServico(Checkout checkout)
        {
            Console.WriteLine("Realizando cobrança de taxa dos serviços de quarto...");
            checkout.ValorTotal += (checkout.ValorTotal * 0.03);

            return base.ExecutarCobrancaServico(checkout);
        }
    }
}