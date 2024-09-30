using DesignPatterns.Curso.PatternsEstrutural.Proxy.Interfaces;
using DesignPatterns.Curso.PatternsEstrutural.Proxy.Models;
using DesignPatterns.Curso.PatternsEstrutural.Proxy.SQL;

namespace DesignPatterns.Curso.PatternsEstrutural.Proxy
{
    public class VPNProxy : IProxy
    {
        public void AcessarVPN(User user)
        {
            var sql = new DatabaseConnection();
            sql.RegistrarAcessoVPN(user);
            Console.WriteLine(new String('-', 40));

            var vpn = new VPN();
            vpn.AcessarVPN(user);
        }
    }
}