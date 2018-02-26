using BibliotecaDDD.Domain.Contracts.Repository;
using BibliotecaDDD.Domain.Entities;
using BibliotecaDDD.Infra.Data.Entity.Context;
using System.Data.Entity;
using System.Linq;

namespace BibliotecaDDD.Infra.Data.Entity.Repositories
{
    /// <summary>
    /// Representa o GeneroRepository.
    /// </summary>
    public class GeneroRepository : RepositoryBase<Genero>, GeneroRepositoryContract
    {
        /// <summary>
        /// Constrtor Padrão recebendo o contexto.
        /// </summary>
        /// <param name="context"></param>
        public GeneroRepository(BibliotecaDDDContext context) : base(context)
        {

        }

        /// <summary>
        /// Buscar por Filmes do Genero por id.
        /// </summary>
        /// <param name="id">id do genero a ser encontrado.</param>
        /// <returns></returns>
        public Genero BuscarFilmesdoGenero(int id)
        {
            return this._dbSet.Include(x=>x.Filmes).Where(x=>x.GeneroId == id).FirstOrDefault();
        }
    }
}
