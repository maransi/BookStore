namespace BookStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v2 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Categoria", name: "nomeCategoria", newName: "nome");
        }
        
        public override void Down()
        {
            RenameColumn(table: "dbo.Categoria", name: "nome", newName: "nomeCategoria");
        }
    }
}
