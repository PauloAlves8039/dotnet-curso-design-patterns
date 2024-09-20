namespace DesignPatterns.Curso.PatternsEstrutural.Flyweight
{
    public class Client
    {
        List<string> coresTamanhos = new List<string>
        {
            "azul:pequena","cinza:média", "vermelha:grande",
            "azul:pequena","cinza:média", "vermelha:grande",
            "azul:pequena","cinza:média", "vermelha:grande"
        };
        
        public void ConsumirFlayweight() 
        {
            var factory = new FlyweightFactory();

            foreach (var item in coresTamanhos) 
            {
                var cor = item.Split(":")[0];
                var tamanho = item.Split(":")[1];
                var espacoNave = factory.GetEspacoNave(cor);
                espacoNave.Exibir(cor, tamanho);
            }
        }
    }
}