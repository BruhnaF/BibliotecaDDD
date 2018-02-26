using BibliotecaDDD.Domain.Entities;

namespace BibliotecaDDD.Domain.Contracts.Repository
{
    /// <summary>
    /// Interface do GeneroRepository.
    /// </summary>
    public interface GeneroRepositoryContract : RepositoryBaseContract<Genero>
    {
        /// <summary>
        /// Busca por filmes do genero.
        /// </summary>
        /// <param name="id">id do genero a ser encontrado.</param>
        /// <returns></returns>
        Genero BuscarFilmesdoGenero(int id);
    }
}
