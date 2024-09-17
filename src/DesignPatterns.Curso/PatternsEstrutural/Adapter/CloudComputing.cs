using DesignPatterns.Curso.PatternsEstrutural.Adapter.Interfaces;

namespace DesignPatterns.Curso.PatternsEstrutural.Adapter
{
    public class CloudComputing
    {
        IAdapter adapter;

        public CloudComputing()
        {
            this.adapter = new Adapter(new BusinessLegado());
        }

        public void ProcessarContas(string mes) 
        {
            var time = 3000;
            
            var result = this.adapter.ExecutarRotinaContasPagar(mes);
            Console.WriteLine("Processando camada cloud computing conta a pagar...");
            Console.WriteLine(result);
            Thread.Sleep(time);

            Console.WriteLine(new string('-', 40));

            result = this.adapter.ExecutarRotinaContasReceber(mes);
            Console.WriteLine("Processando camada cloud computing conta a receber...");
            Console.WriteLine(result);
            Thread.Sleep(time);

            Console.WriteLine("\nProcesso finalizado com sucesso!");
        }
    }
}