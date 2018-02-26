using System;
using System.Collections.Generic;
using System.Linq;
using BibliotecaDDD.Domain.Contracts.Application;
using BibliotecaDDD.Domain.Contracts.Repository;
using BibliotecaDDD.Domain.Entities;
using BibliotecaDDD.Domain.ValueObject;

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

        /// <summary>
        /// Busca Genero por Id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Genero BuscarporId(int id)
        {
            return this._generoRepository.Get(new object[] { id });
        }

        /// <summary>
        /// Busca todos os Generos.
        /// </summary>
        /// <returns></returns>
        public IList<Genero> BuscarTodos()
        {
            return this._generoRepository.Get().ToList();
        }

        /// <summary>
        /// Exclui Genero por Id.
        /// </summary>
        /// <param name="id">id do Genero a ser Excluido</param>
        public void Excluir(int id)
        {
            var genero = _generoRepository.BuscarFilmesdoGenero(id);
            if (genero.Filmes.Count > 0)
                throw new BibliotecaException("Não é Possivel Deletar um Genero que Contenha Filmes.");
            _generoRepository.Delete(new object[] { id });
            _generoRepository.SaveChanges();
        }

        /// <summary>
        /// Salvar Genero.
        /// </summary>
        /// <param name="genero"></param>
        public void Salvar(Genero genero)
        {
            _generoRepository.Add(genero);
            _generoRepository.SaveChanges();
        }
    }
}
