using DesignPatterns.Curso.PatternsCriacao.AbstractFactory.ParteCriacao.Factories;
using DesignPatterns.Curso.PatternsCriacao.AbstractFactory.ParteCriacao.Interfaces;

namespace DesignPatterns.Curso.PatternsCriacao.AbstractFactory
{
    public class Client
    {
        public void ConsultarRotinaAluno() 
        {
            var continuar = true;
            
            while (continuar) 
            {
                IFactory factory= null;

                Console.WriteLine("-------------------------");
                Console.WriteLine("Selecione a rotina desejada: "); 
                Console.WriteLine("1-Segunda Feira e Quinta Feira"); 
                Console.WriteLine("2-Terça Feira e SExta Feira"); 
                Console.WriteLine("3-Quarta Feira e Sábado"); 

                Console.Write("Selecione a rotina desejada: ");
                string opcao = Console.ReadLine();

                Console.WriteLine("-------------------------");

                switch (opcao)
                {
                    case "1":
                        factory = new SegundaQuintaFactory();
                        break;
                    case "2":
                        factory = new TercaSextaFactory();
                        break;
                    case "3":
                        factory = new QuartaSabadoFactory();
                        break;    
                    default:
                    break;
                }

                Console.Write("Deseja ver outra rotina? (1-Sim ou 2-não): ");
                var resp = Convert.ToInt32(Console.ReadLine());

                continuar = resp == 1;

            }
        }
    }
}