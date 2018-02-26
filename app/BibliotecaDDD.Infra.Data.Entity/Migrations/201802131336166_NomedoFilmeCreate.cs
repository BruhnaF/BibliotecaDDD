namespace BibliotecaDDD.Infra.Data.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NomedoFilmeCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NomedoFilme",
                c => new
                    {
                        NomedoFilmeId = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 40),
                        IdiomaId = c.String(maxLength: 8),
                        Filme_FilmeId = c.Int(),
                    })
                .PrimaryKey(t => t.NomedoFilmeId)
                .ForeignKey("dbo.Idioma", t => t.IdiomaId)
                .ForeignKey("dbo.Filme", t => t.Filme_FilmeId)
                .Index(t => t.IdiomaId)
                .Index(t => t.Filme_FilmeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.NomedoFilme", "Filme_FilmeId", "dbo.Filme");
            DropForeignKey("dbo.NomedoFilme", "IdiomaId", "dbo.Idioma");
            DropIndex("dbo.NomedoFilme", new[] { "Filme_FilmeId" });
            DropIndex("dbo.NomedoFilme", new[] { "IdiomaId" });
            DropTable("dbo.NomedoFilme");
        }
    }
}
