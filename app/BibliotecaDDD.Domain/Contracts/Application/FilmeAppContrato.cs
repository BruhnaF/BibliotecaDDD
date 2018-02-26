using BibliotecaDDD.Domain.Entities;
using System.Collections.Generic;

namespace BibliotecaDDD.Domain.Contracts.Application
{
    /// <summary>
    /// Interface do FilmeApp.
    /// </summary>
    public interface FilmeAppContrato
    {
        /// <summary>
        /// Salvar filme. 
        /// </summary>
        /// <param name="filme">filme a ser salvo</param>
        void Salvar(Filme filme);

        /// <summary>
        /// Alterar filme.
        /// </summary>
        /// <param name="filme">filme a ser alterado.</param>
        void Alterar(Filme filme);

        /// <summary>
        /// Excluir filme por id.
        /// </summary>
        /// <param name="id">id do filme a ser Excluido.</param>
        void Excluir(int id);

        /// <summary>
        /// Busca por filmes por id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Filme BuscarporId(int id);

        /// <summary>
        /// Buscar todos os filmes.
        /// </summary>
        /// <returns></returns>
        List<Filme> BuscarTodos();

        /// <summary>
        /// Buscar pot filmes completos.
        /// </summary>
        /// <returns></returns>
        IList<Filme> BuscarcomGeneroseIdiomas();
    }
}
