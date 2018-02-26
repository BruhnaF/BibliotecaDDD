using BibliotecaDDD.Domain.Contracts.Repository;
using BibliotecaDDD.Domain.Entities;
using BibliotecaDDD.Infra.Data.Entity.Context;

namespace BibliotecaDDD.Infra.Data.Entity.Repositories
{
    /// <summary>
    /// Nome do filme repository.
    /// </summary>
    public class NomedoFilmeRepository : RepositoryBase<NomedoFilme>, NomedoFilmeRepositoryContract
    {
        /// <summary>
        /// Construtor recebendo o context.
        /// </summary>
        /// <param name="context"></param>
        public NomedoFilmeRepository(BibliotecaDDDContext context) : base(context)
        {

        }
    }
}
