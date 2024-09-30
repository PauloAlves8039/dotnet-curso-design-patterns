using DesignPatterns.Curso.PatternsEstrutural.Proxy.Models;

namespace DesignPatterns.Curso.PatternsEstrutural.Proxy
{
    public class Client
    {
        public void TentarConexaoClientVPN() 
        {
            var proxy = new VPNProxy();

            Console.Write("Digite o Username: ");
            string username = Console.ReadLine();

            Console.WriteLine("Digite o Password: ");
            string password = Console.ReadLine();

            var user = new User(username, password);
            proxy.AcessarVPN(user);
        }
    }
}