using System.Collections.Generic;
using System.Linq;
using BibliotecaDDD.Domain.Contracts.Application;
using BibliotecaDDD.Domain.Contracts.Repository;
using BibliotecaDDD.Domain.Entities;

namespace BibliotecaDDD.Aplication
{
    public class FilmeApp : FilmeAppContrato
    {
        private readonly FilmeRepositoryContract _filmeRepository;

        public FilmeApp(FilmeRepositoryContract filmeRepository)
        {
            _filmeRepository = filmeRepository;
        }

        public void Alterar(Filme filme)
        {
            _filmeRepository.Update(filme);
            _filmeRepository.SaveChanges();
        }

        public Filme BuscarporId(int id)
        {
            return this._filmeRepository.Get( new object[] { id });
        }

        public List<Filme> BuscarTodos()
        {
            return this._filmeRepository.Get().ToList();
        }

        public void Excluir(int id)
        {
            _filmeRepository.Delete(new object[] { id });
            _filmeRepository.SaveChanges();
        }

        public void Salvar(Filme filme)
        {
            _filmeRepository.Add(filme);
            _filmeRepository.SaveChanges();
        }
    }
}
