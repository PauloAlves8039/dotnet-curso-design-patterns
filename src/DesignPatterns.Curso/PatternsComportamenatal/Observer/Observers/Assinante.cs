using DesignPatterns.Curso.PatternsComportamenatal.Observer.Interfaces;
using DesignPatterns.Curso.PatternsComportamenatal.Observer.Model;

namespace DesignPatterns.Curso.PatternsComportamenatal.Observer.Observers
{
    public class Assinante : IObservavel
    {
        public Assinante(Pessoa pessoa, string mensagem)
        {
            Pessoa = pessoa;
            Mensagem = mensagem;
        }

        public Pessoa Pessoa { get; set; }
        public string Mensagem { get; set; }

        public void Update()
        {
            Console.WriteLine($"Enviando e-mail para: {Pessoa.Email}\n");
            Console.WriteLine($"Prezado(a) {Pessoa.Nome}\n{Mensagem}");

            Console.WriteLine($"\nINSERT INTO TB_NOFICACAO (PessoaId, Notifica, Mes) VALUES ({Pessoa.Id}, 1, {DateTime.Now.Month})\n");

        }
    }
}