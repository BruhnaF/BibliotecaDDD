namespace BibliotecaDDD.Infra.Data.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FilmeCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Filme",
                c => new
                    {
                        FilmeId = c.Int(nullable: false, identity: true),
                        Descrição = c.String(nullable: false, maxLength: 40),
                    })
                .PrimaryKey(t => t.FilmeId);
            
            CreateTable(
                "dbo.GeneroFilme",
                c => new
                    {
                        Genero_GeneroId = c.Int(nullable: false),
                        Filme_FilmeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Genero_GeneroId, t.Filme_FilmeId })
                .ForeignKey("dbo.Genero", t => t.Genero_GeneroId)
                .ForeignKey("dbo.Filme", t => t.Filme_FilmeId)
                .Index(t => t.Genero_GeneroId)
                .Index(t => t.Filme_FilmeId);
            
            CreateTable(
                "dbo.FilmeIdioma",
                c => new
                    {
                        Filme_FilmeId = c.Int(nullable: false),
                        Idioma_IdiomaId = c.String(nullable: false, maxLength: 8),
                    })
                .PrimaryKey(t => new { t.Filme_FilmeId, t.Idioma_IdiomaId })
                .ForeignKey("dbo.Filme", t => t.Filme_FilmeId)
                .ForeignKey("dbo.Idioma", t => t.Idioma_IdiomaId)
                .Index(t => t.Filme_FilmeId)
                .Index(t => t.Idioma_IdiomaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.FilmeIdioma", "Idioma_IdiomaId", "dbo.Idioma");
            DropForeignKey("dbo.FilmeIdioma", "Filme_FilmeId", "dbo.Filme");
            DropForeignKey("dbo.GeneroFilme", "Filme_FilmeId", "dbo.Filme");
            DropForeignKey("dbo.GeneroFilme", "Genero_GeneroId", "dbo.Genero");
            DropIndex("dbo.FilmeIdioma", new[] { "Idioma_IdiomaId" });
            DropIndex("dbo.FilmeIdioma", new[] { "Filme_FilmeId" });
            DropIndex("dbo.GeneroFilme", new[] { "Filme_FilmeId" });
            DropIndex("dbo.GeneroFilme", new[] { "Genero_GeneroId" });
            DropTable("dbo.FilmeIdioma");
            DropTable("dbo.GeneroFilme");
            DropTable("dbo.Filme");
        }
    }
}
