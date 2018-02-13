using System.Collections.Generic;
using System.Linq;
using BibliotecaDDD.Domain.Contracts.Application;
using BibliotecaDDD.Domain.Contracts.Repository;
using BibliotecaDDD.Domain.Entities;

namespace BibliotecaDDD.Aplication
{
    public class GeneroApp : GeneroAppContrato
    {
        /// <summary>
        /// Variavel que recebe o GeneroRepositoryContract.
        /// </summary>
        private readonly GeneroRepositoryContract _generoRepository;

        /// <summary>
        /// Construtor que recebe o GeneroRepositoryContract.
        /// </summary>
        /// <param name="generoRepository"></param>
        public GeneroApp(GeneroRepositoryContract generoRepository)
        {
            _generoRepository = generoRepository;
        }

        /// <summary>
        /// Metodo para alterar o genero.
        /// </summary>
        /// <param name="genero">Genero a ser Alterado.</param>
        public void Alterar(Genero genero)
        {
            _generoRepository.Update(genero);
            _generoRepository.SaveChanges();
        }

        public Genero BuscarporId(int id)
        {
            return this._generoRepository.Get(new object[] { id });
        }

        public IList<Genero> BuscarTodos()
        {
            return this._generoRepository.Get().ToList();
        }

        public void Excluir(int id)
        {
            _generoRepository.Delete(new object[] { id });
            _generoRepository.SaveChanges();
        }

        public void Salvar(Genero genero)
        {
            _generoRepository.Add(genero);
            _generoRepository.SaveChanges();
        }
    }
}
