using BibliotecaDDD.Domain.Contracts.Repository;
using BibliotecaDDD.Domain.Entities;
using BibliotecaDDD.Infra.Data.Entity.Context;

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
    }
}