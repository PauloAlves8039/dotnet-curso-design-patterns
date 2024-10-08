using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesignPatterns.Curso.PatternsComportamental.Strategy.Interfaces;
using DesignPatterns.Curso.PatternsComportamental.Strategy.Models;

namespace DesignPatterns.Curso.PatternsComportamental.Strategy.Servicos
{
    public class PremiumServico : IServico
    {
        private Orcamento _orcamento;

        public PremiumServico(Orcamento orcamento)
        {
            _orcamento = orcamento;
        }

        public void CalcularServico()
        {
            var porcentagem = _orcamento.ValorTotal * ((double)_orcamento.Porcentagem / 100);
            _orcamento.ValorTotal += porcentagem;

            if (_orcamento.CupomDesconto)
            {
                Console.WriteLine($"\nValor sem desconto: {_orcamento.ValorTotal.ToString("C")}");
                _orcamento.ValorTotal -= _orcamento.ValorTotal * 0.02;
                Console.WriteLine($"Cupom de desconto de 2% para suíte Premium.\n");
            }

            Console.WriteLine($"Tipo Quarto: {_orcamento.Porcentagem}\nPorcentagem Serviço: {porcentagem.ToString("C")}\nQuant. Dias: {_orcamento.Quantidade}\nValor Dia: {_orcamento.ValorDiaria}\n*Valor Total: {_orcamento.ValorTotal}");
        }
    }
}