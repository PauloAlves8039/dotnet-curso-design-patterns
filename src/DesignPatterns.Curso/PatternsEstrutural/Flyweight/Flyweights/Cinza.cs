using DesignPatterns.Curso.PatternsEstrutural.Flyweight.Model;

namespace DesignPatterns.Curso.PatternsEstrutural.Flyweight.Flyweights
{
    public class Cinza : EspacoNave
    {
        public Cinza()
        {
            this.condicao = "voando em linha reta - ";
            this.acao = "disparando lasers";
        }
        
        public override void Exibir(string cor, string tamanho)
        {
            this.cor = cor;
            this.tamanho = tamanho;
            Console.WriteLine($"{this.tamanho} e {this.cor} {this.condicao} {this.acao}");
        }
    }
}