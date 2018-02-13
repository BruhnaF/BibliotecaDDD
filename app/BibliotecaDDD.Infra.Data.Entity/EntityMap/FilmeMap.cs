using BibliotecaDDD.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace BibliotecaDDD.Infra.Data.Entity.EntityMap
{
    public class FilmeMap : EntityTypeConfiguration<Filme>
    {
        public FilmeMap()
        {
            HasKey(f =>f.FilmeId);
            Property(f => f.FilmeId).IsRequired();

            Property(f => f.Descrição)
                .HasMaxLength(Filme.tamanhoMaximoNome).IsRequired();
        }
    }
}
