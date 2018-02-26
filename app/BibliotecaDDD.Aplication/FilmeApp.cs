using System.Collections.Generic;
using System.Linq;
using BibliotecaDDD.Domain.Contracts.Application;
using BibliotecaDDD.Domain.Contracts.Repository;
using BibliotecaDDD.Domain.Entities;

namespace BibliotecaDDD.Aplication
{
    /// <summary>
    /// Classe que Representa o FilmeApp.
    /// </summary>
    public class FilmeApp : FilmeAppContrato
    {
        /// <summary>
        /// Representa o filmeRepository.
        /// </summary>
        private readonly FilmeRepositoryContract _filmeRepository;       

        /// <summary>
        /// Construtor recebendo o filmeRepository.
        /// </summary>
        /// <param name="filmeRepository"></param>
        public FilmeApp(FilmeRepositoryContract filmeRepository)
        {
            _filmeRepository = filmeRepository;
        }

        /// <summary>
        /// Altera o Filme.
        /// </summary>
        /// <param name="filme"></param>
        public void Alterar(Filme filme)
        {
            _filmeRepository.Update(filme);
            _filmeRepository.SaveChanges();
        }

        /// <summary>
        /// Busca Filme Completo.
        /// </summary>
        /// <returns></returns>
        public IList<Filme> BuscarcomGeneroseIdiomas()
        {
            return this._filmeRepository.BuscarFilmesCompleto().ToList();
        }

        /// <summary>
        /// Busca filme por Id;
        /// </summary>
        /// <param name="id">Id do filme a ser encontrado.</param>
        /// <returns></returns>
        public Filme BuscarporId(int id)
        {
            return this._filmeRepository.Get(new object[] { id });
        }

        /// <summary>
        /// Busca todos os filmes.
        /// </summary>
        /// <returns></returns>
        public List<Filme> BuscarTodos()
        {                       
            return this._filmeRepository.Get().ToList();     
        }

        /// <summary>
        /// Exclui o Filme.
        /// </summary>
        /// <param name="id"></param>
        public void Excluir(int id)
        {
            var filme = _filmeRepository.BuscarFilmesCompleto(id);
            filme.RemoverTodososGeneros();
            filme.RemoverTodososIdiomas();
            filme.RemoverTodososNomesdoFilme();
            _filmeRepository.Delete(new object[] { filme.FilmeId });
            _filmeRepository.SaveChanges();
        }

        /// <summary>
        /// Salva o Filme.
        /// </summary>
        /// <param name="filme"></param>
        public void Salvar(Filme filme)
        {
            _filmeRepository.Add(filme);
            _filmeRepository.SaveChanges();
        }
    }
}
