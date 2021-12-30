using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;
using BookStore.Domain;

namespace BookStore.Mappings
{
    public class CategoriaMap: EntityTypeConfiguration<Categoria>
    {
        public CategoriaMap()
        {
            ToTable("Categoria");

            HasKey(x => x.Id);

            Property(x => x.Nome)
                .HasMaxLength(30)
                .HasColumnName("nome")
                .IsRequired();

            HasMany(x => x.Livros)
                .WithRequired(x => x.Categoria);

        }
    }
}