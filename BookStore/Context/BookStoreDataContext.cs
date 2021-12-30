using BookStore.Domain;
using BookStore.Mappings;
using System.Data.Entity;

namespace BookStore.Context
{
    public class BookStoreDataContext: DbContext
    {

        public BookStoreDataContext(): base("BookStoreConnectionString")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new AutorMap());
            modelBuilder.Configurations.Add(new CategoriaMap());
            modelBuilder.Configurations.Add(new LivroMap());
            
        }

        public DbSet<Autor> Autores { get; set; }
        public DbSet<Categoria> Categorias { get; set; }

        public DbSet<Livro> Livros { get; set; }

    }
}