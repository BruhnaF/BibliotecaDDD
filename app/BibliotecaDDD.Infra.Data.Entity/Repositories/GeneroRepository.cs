using BibliotecaDDD.Domain.Contracts.Repository;
using BibliotecaDDD.Domain.Entities;
using BibliotecaDDD.Infra.Data.Entity.Context;

namespace BibliotecaDDD.Infra.Data.Entity.Repositories
{
    public class GeneroRepository : RepositoryBase<Genero>, GeneroRepositoryContract
    {
        public GeneroRepository(BibliotecaDDDContext context) : base(context)
        {

        }
    }
}
