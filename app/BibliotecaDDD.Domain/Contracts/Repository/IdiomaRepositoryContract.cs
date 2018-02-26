using BibliotecaDDD.Domain.Entities;

namespace BibliotecaDDD.Domain.Contracts.Repository
{
    /// <summary>
    /// Interface do IdiomaRepository.
    /// </summary>
    public interface IdiomaRepositoryContract : RepositoryBaseContract<Idioma>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Idioma BuscaFilmeeNomedoFilmeporIdiomas(string id);
    }
}
