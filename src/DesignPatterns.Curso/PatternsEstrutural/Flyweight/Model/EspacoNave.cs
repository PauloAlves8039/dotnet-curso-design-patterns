namespace DesignPatterns.Curso.PatternsEstrutural.Flyweight.Model
{
    public abstract class EspacoNave
    {
        protected string condicao;
        protected string acao;
        
        public string cor { get; set; }
        public string tamanho { get; set; }

        public abstract void Exibir(string cor, string tamanho);
    }
}