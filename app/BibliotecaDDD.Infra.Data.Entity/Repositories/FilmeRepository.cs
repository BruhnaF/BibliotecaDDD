using BibliotecaDDD.Domain.Contracts.Repository;
using BibliotecaDDD.Domain.Entities;
using BibliotecaDDD.Infra.Data.Entity.Context;

namespace BibliotecaDDD.Infra.Data.Entity.Repositories
{
    public class FilmeRepository : RepositoryBase<Filme>, FilmeRepositoryContract
    {
        public FilmeRepository(BibliotecaDDDContext context) : base(context)
        {

        }
    }
}
