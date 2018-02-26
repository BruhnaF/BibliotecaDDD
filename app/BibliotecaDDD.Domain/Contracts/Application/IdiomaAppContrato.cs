using BibliotecaDDD.Domain.Entities;
using System.Collections.Generic;

namespace BibliotecaDDD.Domain.Contracts.Application
{
    /// <summary>
    /// Interface do IdiomaApp.
    /// </summary>
    public interface IdiomaAppContrato
    {
        /// <summary>
        /// Salvar Idioma.
        /// </summary>
        /// <param name="idioma"></param>
        void Salvar(Idioma idioma);

        /// <summary>
        /// Alterar Idioma.
        /// </summary>
        /// <param name="idioma"></param>
        void Alterar(Idioma idioma);

        /// <summary>
        /// Excluir idioma por id.
        /// </summary>
        /// <param name="id">Id do idioma a ser excluido.</param>
        void Excluir(string id);

        /// <summary>
        /// Busca genero por id.
        /// </summary>
        /// <param name="id">Id do idioma a ser encontrado.</param>
        /// <returns></returns>
        Idioma BuscarporId(string id);

        /// <summary>
        /// Busca por todos os Idiomas.
        /// </summary>
        /// <returns></returns>
        IList<Idioma> BuscarTodos();
    }
}
