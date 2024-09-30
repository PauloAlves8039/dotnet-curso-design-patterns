using DesignPatterns.Curso.PatternsEstrutural.Proxy.Models;

namespace DesignPatterns.Curso.PatternsEstrutural.Proxy.SQL
{
    public class DatabaseConnection
    {
        public void RegistrarAcessoVPN(User user)
        {
            var query = $@"INSERT INTO TB_RegistroVPN (User, Password, DataHora)
            \nVALUES('{user.Username}', '{user.Password}', '{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}')\n";

            Console.WriteLine("[!] - Registrando acesso pelo proxy...\n");
            Console.WriteLine(query);

        }
    }
}