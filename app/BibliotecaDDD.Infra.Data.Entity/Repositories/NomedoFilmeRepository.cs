using BibliotecaDDD.Domain.Contracts.Repository;
using BibliotecaDDD.Domain.Entities;
using BibliotecaDDD.Infra.Data.Entity.Context;

namespace BibliotecaDDD.Infra.Data.Entity.Repositories
{
    public class NomedoFilmeRepository : RepositoryBase<NomedoFilme>, NomedoFilmeRepositoryContract
    {
        public NomedoFilmeRepository(BibliotecaDDDContext context) : base(context)
        {

        }
    }
}
