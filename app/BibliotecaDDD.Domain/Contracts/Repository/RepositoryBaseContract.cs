using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace BibliotecaDDD.Domain.Contracts.Repository
{
    /// <summary>
    /// Interface do RepositoryBase.
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public interface RepositoryBaseContract<TEntity> where TEntity : class
    {
        /// <summary>
        /// Metodo Para Adicionar um Objeto.
        /// </summary>
        /// <param name="obj">Objeto a ser Adicionado</param>
        void Add(TEntity obj);

        /// <summary>
        /// Metodo para Alterar Um Objeto.
        /// </summary>
        /// <param name="obj">Objeto a ser Alterado</param>
        void Update(TEntity obj);

        /// <summary>
        /// Metodo para Excluir um Objeto pela Id.
        /// </summary>
        /// <param name="id">Id do Objeto a ser Excluido.</param>
        void Delete(int id);

        /// <summary>
        /// Metodo de Busca de Objeto por Id.
        /// </summary>
        /// <param name="id">Id a ser Encontrado.</param>
        /// <returns></returns>
        TEntity Get(int id);
       
        /// <summary>
        /// Busca por Objeto no Sistema.
        /// </summary>
        /// <param name="filter">Filtra pela expressão, se não for colocada expressão, retorna todos.</param>
        /// <returns></returns>
        IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> filter = null );

        /// <summary>
        /// Salva as Alterações no Contexto.
        /// </summary>
        void SaveChanges();
    }
}
