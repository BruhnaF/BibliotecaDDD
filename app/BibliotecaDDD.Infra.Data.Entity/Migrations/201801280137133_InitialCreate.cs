namespace BibliotecaDDD.Infra.Data.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Idioma",
                c => new
                    {
                        idiomaId = c.String(nullable: false, maxLength: 8),
                        nome = c.String(nullable: false, maxLength: 40),
                    })
                .PrimaryKey(t => t.idiomaId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Idioma");
        }
    }
}
