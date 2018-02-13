using BibliotecaDDD.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace BibliotecaDDD.Infra.Data.Entity.EntityMap
{
    public class GeneroMap : EntityTypeConfiguration<Genero>
    {
        public GeneroMap()
        {
            HasKey(g => g.GeneroId);
            Property(g => g.GeneroId).IsRequired();            

            Property(g => g.Nome)
                .HasMaxLength(Genero.tamanhoMaximoNome).IsRequired();
        }
    }
}