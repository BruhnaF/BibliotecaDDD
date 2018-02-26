using BibliotecaDDD.Domain.Contracts.Repository;
using BibliotecaDDD.Domain.Entities;
using BibliotecaDDD.Infra.Data.Entity.Context;
using System.Data.Entity;
using System.Linq;

namespace BibliotecaDDD.Infra.Data.Entity.Repositories
{
    /// <summary>
    /// Classe de repository para a entidade Idioma.
    /// </summary>
    public class IdiomaRepository : RepositoryBase<Idioma>, IdiomaRepositoryContract
    {
        /// <summary>
        /// Contrutor Padrão.
        /// </summary>
        /// <param name="context">Contexto do Entity para o repository.</param>
        public IdiomaRepository(BibliotecaDDDContext context) : base(context)
        {
        }
        
        /// <summary>
        /// Busca por Filme e nome do filme por Idiomas.
        /// </summary>
        /// <param name="id">Id do filme a ser encontrado.</param>
        /// <returns></returns>
        public Idioma BuscaFilmeeNomedoFilmeporIdiomas(string id)
        {
            return _dbSet.Include(x => x.Filmes).Include(x=>x.IdiomasdosNomes).Where(x=>x.IdiomaId == id).FirstOrDefault();
        }
    }
}