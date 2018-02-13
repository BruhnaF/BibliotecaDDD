namespace BibliotecaDDD.Infra.Data.Entity.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class GeneroCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Genero",
                c => new
                    {
                        GeneroId = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 40),
                    })
                .PrimaryKey(t => t.GeneroId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Genero");
        }
    }
}
