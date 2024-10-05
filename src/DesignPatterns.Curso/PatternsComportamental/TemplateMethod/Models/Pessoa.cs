namespace DesignPatterns.Curso.PatternsComportamental.TemplateMethod.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public List<Acoes> Acoes { get; set; }

        public Pessoa()
        {
        }

        public Pessoa(string nome, string cpf, List<Acoes> acoes)
        {
            Nome = nome;
            CPF = cpf;
            Acoes = acoes;
        }
    }
}