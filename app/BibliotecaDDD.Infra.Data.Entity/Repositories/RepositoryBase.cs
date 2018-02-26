using BibliotecaDDD.Domain.Contracts.Repository;
using BibliotecaDDD.Infra.Data.Entity.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace BibliotecaDDD.Infra.Data.Entity.Repositories
{
    /// <summary>
    /// Classe que implementa a interface RepositoryBaseContract.
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public class RepositoryBase<TEntity> : IDisposable, RepositoryBaseContract<TEntity> where TEntity : class
    {
        private readonly BibliotecaDDDContext _context;
        protected DbSet<TEntity> _dbSet;

        /// <summary>
        /// Construtor Padrão, recebendo o contexto.
        /// </summary>
        /// <param name="context"></param>
        public RepositoryBase(BibliotecaDDDContext context)
        {
           this._context = context;
           this._dbSet = context.Set<TEntity>();
        }

        /// <summary>
        /// Adiciona objeto no Contexto.
        /// </summary>
        /// <param name="obj">Objeto a ser Adicionado.</param>
        public void Add(TEntity obj)
        {
            _dbSet.Add(obj);
        }

        /// <summary>
        /// Remove objeto do Contexto. 
        /// </summary>
        /// <param name="id">Id do Objeto a ser Removido.</param>
        public void Delete(object[] id)
        {
            _dbSet.Remove(Get(id));
        }

        /// <summary>
        /// Finaliza o contexto.
        /// </summary>
        public void Dispose()
        {
            _dbSet = null;
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Busca objeto pela Id.
        /// </summary>
        /// <param name="id">Id a ser encontrada.</param>
        /// <returns></returns>
        public TEntity Get(object[] id)
        {
           return _dbSet.Find(id);
        }

        /// <summary>
        /// Busca por Objeto no Sistema.
        /// </summary>
        /// <param name="filter">Filtra pela expressão, se não for colocada expressão, retorna todos.</param>
        /// <returns></returns>
        public IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> filter = null)
        {
            IQueryable<TEntity> query = _dbSet;
            if(filter != null)
            {
                query = query.Where(filter);
            }           

            return query;
        }

        /// <summary>
        /// Salva contexto no Banco.
        /// </summary>
        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        /// <summary>
        /// Altera o contexto.
        /// </summary>
        /// <param name="obj"></param>
        public void Update(TEntity obj)
        {
            _context.Entry(obj).State = EntityState.Modified;
        }
    }
}
