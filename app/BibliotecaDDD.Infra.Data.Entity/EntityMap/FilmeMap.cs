using BibliotecaDDD.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace BibliotecaDDD.Infra.Data.Entity.EntityMap
{
    /// <summary>
    /// Representa o FilmeMap.
    /// </summary>
    public class FilmeMap : EntityTypeConfiguration<Filme>
    {
        /// <summary>
        /// Contrutor Padrão.
        /// </summary>
        public FilmeMap()
        {
            HasKey(f =>f.FilmeId);
            Property(f => f.FilmeId).IsRequired();

            Property(f => f.Descricao)
                .HasMaxLength(Filme.tamanhoMaximoNome).IsRequired();
        }
    }
}
