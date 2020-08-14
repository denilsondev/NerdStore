using NerdStore.Core.DomainObjects;
using System.Collections.Generic;

namespace NerdStore.Catalogo.Domain
{
   public class Categoria : Entity
    {
        public string Nome { get; set; }
        public int Codigo { get; set; }

        // EF Relation
        public ICollection<Produto> Produtos { get; set; }

        public Categoria()
        {

        }
        public Categoria(string nome, int codigo)
        {
            Nome = nome;
            Codigo = codigo;

            Validar();
        }

        public override string ToString()
        {
            return $"{Nome} - {Codigo}";
        }

        public void Validar()
        {
            Validacoes.ValidarSeVazio(Nome, "O campo Nome do produto não pode ser vazio");
            Validacoes.ValidarSeIgual(Codigo, 0, "O campo Codigo do produto não pode ser vazio");
        }

    }

}
