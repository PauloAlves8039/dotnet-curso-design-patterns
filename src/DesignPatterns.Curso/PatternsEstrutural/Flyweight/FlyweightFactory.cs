using DesignPatterns.Curso.PatternsEstrutural.Flyweight.Flyweights;
using DesignPatterns.Curso.PatternsEstrutural.Flyweight.Model;

namespace DesignPatterns.Curso.PatternsEstrutural.Flyweight
{
    public class FlyweightFactory
    {
        private Dictionary<string, EspacoNave> nave_lista = new Dictionary<string, EspacoNave>();

        public EspacoNave GetEspacoNave(string cor) 
        {
            EspacoNave nave = null;

            if (nave_lista.ContainsKey(cor)) 
            {
                nave = nave_lista[cor];
            }
            else 
            {
                switch (cor)
                {
                    case "azul":
                        nave = new Azul();
                        break;
                    case "cinza":
                        nave = new Cinza();
                        break;
                    case "vermelha":
                        nave = new Vermelha();
                        break;
                    default:
                        break;
                }

                nave_lista.Add(cor, nave);
            }

            return nave;
        }
    }
}