namespace BibliotecaDDD.Infra.Data.Entity.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<BibliotecaDDD.Infra.Data.Entity.Context.BibliotecaDDDContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "BibliotecaDDD.Infra.Data.Entity.Context.BibliotecaDDDContext";
        }

        protected override void Seed(BibliotecaDDD.Infra.Data.Entity.Context.BibliotecaDDDContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
