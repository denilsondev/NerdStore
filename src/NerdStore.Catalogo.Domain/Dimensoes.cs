using NerdStore.Core.DomainObjects;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace NerdStore.Catalogo.Domain
{
    public class Dimensoes
    {
        public decimal Altura { get; private set; }
        public decimal Largura { get; private set; }
        public decimal Profundidade { get; private set; }

        public Dimensoes(decimal altura, decimal largura, decimal profundidade)
        {
            Validacoes.ValidarSeMenorQue(altura, 1, "O Campo altura não pode ser menor ou igual a 1 ");
            Validacoes.ValidarSeMenorQue(largura, 1, "O largura altura não pode ser menor ou igual a 1 ");
            Validacoes.ValidarSeMenorQue(profundidade, 1, "O Campo profundidade não pode ser menor ou igual a 1 ");

            Altura = altura;
            Largura = largura;
            Profundidade = profundidade;

        }

        public string DescricaoFormatada()
        {
            return $"LxAxP: {Largura} x {Altura}x {Profundidade}"; 
        }

        public override string ToString()
        {
            return DescricaoFormatada();
        }
    }
}
