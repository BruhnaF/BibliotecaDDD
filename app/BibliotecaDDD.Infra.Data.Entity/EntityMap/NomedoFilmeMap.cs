﻿using BibliotecaDDD.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace BibliotecaDDD.Infra.Data.Entity.EntityMap
{
    /// <summary>
    /// Representa o NomedoFilmeMap.
    /// </summary>
    public class NomedoFilmeMap : EntityTypeConfiguration<NomedoFilme>
    {
        /// <summary>
        /// Construtor Padrão.
        /// </summary>
        public NomedoFilmeMap()
        {
            HasKey(n => n.NomedoFilmeId);
            Property(n => n.NomedoFilmeId).IsRequired();

            Property(n => n.Nome).HasMaxLength(NomedoFilme.tamanhoMaximoNome).IsRequired();

            this.HasOptional(n => n.Idioma).WithMany(n => n.IdiomasdosNomes).HasForeignKey(n => n.IdiomaId);
        }
    }
}
