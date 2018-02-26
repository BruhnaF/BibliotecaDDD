using BibliotecaDDD.Domain.Entities;
using System.Collections.Generic;

namespace BibliotecaDDD.Domain.Contracts.Repository
{
    /// <summary>
    /// Interface do FilmeRepository.
    /// </summary>
    public interface FilmeRepositoryContract : RepositoryBaseContract<Filme>
    {
        /// <summary>
        /// Busca por filme completo.
        /// </summary>
        /// <returns>Retorna lista de filmes.</returns>
        IEnumerable<Filme> BuscarFilmesCompleto();       

        /// <summary>
        /// Busca por filme completo por Id.
        /// </summary>
        /// <param name="id">Id do filme a ser encontrado.</param>
        /// <returns></returns>
        Filme BuscarFilmesCompleto(int id);
    }
}
