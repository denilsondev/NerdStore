using NerdStore.Core.DomainObjects;
using System;
using Xunit;

namespace NerdStore.Catalogo.Domain.Tests
{
    public class ProdutoTests
    {
        [Fact]
        public void Produto_Validar_ValidacoesDevemRetornarExceptions()
        {
            //Arrange & Act & Assert

            var ex = Assert.Throws<DomainException>(() => 
            {
                new Produto(string.Empty, "Descricao", false, 100, Guid.NewGuid(), DateTime.Now, "imagem", new Dimensoes(2, 2, 2) );
            });
            Assert.Equal("O campo Nome do produto n�o pode estar vazio", ex.Message);


            ex = Assert.Throws<DomainException>(() =>
            {
                new Produto("Nome", string.Empty, false, 100, Guid.NewGuid(), DateTime.Now, "imagem", new Dimensoes(2, 2, 2));
            });
            Assert.Equal("O campo Descri��o do produto n�o pode estar vazio", ex.Message);

        }
    }
}
