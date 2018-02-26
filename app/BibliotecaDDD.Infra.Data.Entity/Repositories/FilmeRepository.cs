using System.Collections.Generic;
using BibliotecaDDD.Domain.Contracts.Repository;
using BibliotecaDDD.Domain.Entities;
using BibliotecaDDD.Infra.Data.Entity.Context;
using System.Data.Entity;
using System.Linq;

namespace BibliotecaDDD.Infra.Data.Entity.Repositories
{
    /// <summary>
    /// Representa o FilmeRepository.
    /// </summary>
    public class FilmeRepository : RepositoryBase<Filme>, FilmeRepositoryContract
    {
        /// <summary>
        /// Construtor Padrão recebendo o context.
        /// </summary>
        /// <param name="context"></param>
        public FilmeRepository(BibliotecaDDDContext context) : base(context)
        {
            
        }
        
        /// <summary>
        /// Busca por filmes completo por id.
        /// </summary>
        /// <param name="id">id do filme a ser encontrado.</param>
        /// <returns></returns>
        public Filme BuscarFilmesCompleto(int id)
        {
            return _dbSet.Include(x => x.Generos)
                .Include(x => x.Idiomas).Include(x => x.NomesdoFilme)
                .Where(x => x.FilmeId == id).FirstOrDefault();
        }
             
        /// <summary>
        /// Buscar por todos os filmes completos.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Filme> BuscarFilmesCompleto()
        {
            return this._dbSet.Include(x=>x.Generos).Include(x=>x.Idiomas).Include(x=>x.NomesdoFilme);
        }
        
    }
}
