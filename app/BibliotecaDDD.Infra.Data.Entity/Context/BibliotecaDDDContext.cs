using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace BibliotecaDDD.Infra.Data.Entity.Context
{
    /// <summary>
    /// Classe Context
    /// </summary>
    public class BibliotecaDDDContext : DbContext
    {

        /// <summary>
        /// Construtor Padrão.
        /// </summary>
        public BibliotecaDDDContext() : base("BibliotecaDDDConection")
        {
            
        }

        /// <summary>
        /// Configurações de Construção de Models.
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
        }
    }
}
