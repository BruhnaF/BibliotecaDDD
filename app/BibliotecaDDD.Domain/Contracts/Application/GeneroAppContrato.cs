using BibliotecaDDD.Domain.Entities;
using System.Collections.Generic;

namespace BibliotecaDDD.Domain.Contracts.Application
{
    /// <summary>
    /// Interface do GeneroApp.
    /// </summary>
    public interface GeneroAppContrato
    {
        /// <summary>
        /// Salvar Genero.
        /// </summary>
        /// <param name="genero"></param>
        void Salvar(Genero genero);

        /// <summary>
        /// Alterar Genero.
        /// </summary>
        /// <param name="genero"></param>
        void Alterar(Genero genero);

        /// <summary>
        /// Excluir genero por id.
        /// </summary>
        /// <param name="id">Id do genero a ser excluido.</param>
        void Excluir(int id);

        /// <summary>
        /// Buscar Genero por Id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Genero BuscarporId(int id);

        /// <summary>
        /// Buscar Todos os Generos.
        /// </summary>
        /// <returns></returns>
        IList<Genero> BuscarTodos();
    }
}
