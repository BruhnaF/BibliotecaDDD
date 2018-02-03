using BibliotecaDDD.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BibliotecaDDD.Infra.Data.Entity.EntityMap
{
    public class IdiomaMap : EntityTypeConfiguration<Idioma>
    {
        public IdiomaMap()
        {
            HasKey(i => i.IdiomaId);
            Property(i => i.IdiomaId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasMaxLength(Idioma.tamanhoMaximoCodigo);

            Property(i => i.Nome)
                .HasMaxLength(Idioma.tamanhoMaximoNome).IsRequired();    
        }
    }
}
