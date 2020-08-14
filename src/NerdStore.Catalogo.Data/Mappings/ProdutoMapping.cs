using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NerdStore.Catalogo.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace NerdStore.Catalogo.Data.Mappings
{
    class ProdutoMapping : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Nome).IsRequired().HasColumnType("varchar250");
            builder.Property(c => c.Descricao).IsRequired().HasColumnType("varchar250");
            builder.Property(c => c.Imagem).IsRequired().HasColumnType("varchar250");
            builder.OwnsOne(c => c.Dimensoes, cm =>
            {
                cm.Property(c => c.Altura).HasColumnName("Altura").HasColumnType("int");
                cm.Property(c => c.Largura).HasColumnName("Largura").HasColumnType("int");
                cm.Property(c => c.Profundidade).HasColumnName("Profundidade").HasColumnType("int");
            });
            builder.ToTable("Produtos");
        }
    }
}
