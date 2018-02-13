using System.Collections.Generic;
using System.Linq;
using BibliotecaDDD.Domain.Contracts.Application;
using BibliotecaDDD.Domain.Contracts.Repository;
using BibliotecaDDD.Domain.Entities;

namespace BibliotecaDDD.Aplication
{
    public class NomedoFilmeApp : NomedoFilmeAppContrato
    {
        private readonly NomedoFilmeRepositoryContract _nomedoFilmeRepository;

        public NomedoFilmeApp(NomedoFilmeRepositoryContract nomedoFilmeRepository)
        {
            _nomedoFilmeRepository = nomedoFilmeRepository;
        }

        public void Alterar(NomedoFilme nomedoFilme)
        {
            _nomedoFilmeRepository.Update(nomedoFilme);
            _nomedoFilmeRepository.SaveChanges();
        }

        public NomedoFilme BuscarporId(int id)
        {
            return this._nomedoFilmeRepository.Get(new object[] { id });
        }

        public List<NomedoFilme> BuscarTodos()
        {
            return this._nomedoFilmeRepository.Get().ToList();
        }

        public void Excluir(int id)
        {
            _nomedoFilmeRepository.Delete(new object[] { id });
            _nomedoFilmeRepository.SaveChanges();
        }

        public void Salvar(NomedoFilme nomedoFilme)
        {
            _nomedoFilmeRepository.Add(nomedoFilme);
            _nomedoFilmeRepository.SaveChanges();
        }
    }
}
