using BibliotecaDDD.Domain.Entities;
using System.Collections.Generic;

namespace BibliotecaDDD.Domain.Contracts.Application
{
    /// <summary>
    /// Interface do NomedoFilmeApp.
    /// </summary>
    public interface NomedoFilmeAppContrato
    {
        /// <summary>
        /// Salvar o nome do filme.
        /// </summary>
        /// <param name="nomedoFilme"></param>
        void Salvar(NomedoFilme nomedoFilme);

        /// <summary>
        /// Alterar o nome do filme.
        /// </summary>
        /// <param name="nomedoFilme"></param>
        void Alterar(NomedoFilme nomedoFilme);

        /// <summary>
        /// Excluir o nome do filme por id.
        /// </summary>
        /// <param name="id"></param>
        void Excluir(int id);

        /// <summary>
        /// Buscar nome do filme por id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        NomedoFilme BuscarporId(int id);

        /// <summary>
        /// Buscar todos os nomes do filme.
        /// </summary>
        /// <returns></returns>
        List<NomedoFilme> BuscarTodos();
    }
}
