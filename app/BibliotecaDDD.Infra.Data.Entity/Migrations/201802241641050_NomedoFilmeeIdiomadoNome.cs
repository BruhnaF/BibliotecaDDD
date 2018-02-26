namespace BibliotecaDDD.Infra.Data.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NomedoFilmeeIdiomadoNome : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Filme", "Descricao", c => c.String(nullable: false, maxLength: 40));
            DropColumn("dbo.Filme", "Descrição");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Filme", "Descrição", c => c.String(nullable: false, maxLength: 40));
            DropColumn("dbo.Filme", "Descricao");
        }
    }
}
