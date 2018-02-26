using System.Collections.Generic;
using System.Linq;
using BibliotecaDDD.Domain.Contracts.Application;
using BibliotecaDDD.Domain.Contracts.Repository;
using BibliotecaDDD.Domain.Entities;

namespace BibliotecaDDD.Aplication
{
    public class NomedoFilmeApp : NomedoFilmeAppContrato
    {
        /// <summary>
        /// Representa o nomedoFilmeRepository.
        /// </summary>
        private readonly NomedoFilmeRepositoryContract _nomedoFilmeRepository;

        /// <summary>
        /// Construtor Resebendo o nomedofilmeRepository.
        /// </summary>
        /// <param name="nomedoFilmeRepository"></param>
        public NomedoFilmeApp(NomedoFilmeRepositoryContract nomedoFilmeRepository)
        {
            _nomedoFilmeRepository = nomedoFilmeRepository;
        }

        /// <summary>
        /// Altera o nome do filme. 
        /// </summary>
        /// <param name="nomedoFilme"></param>
        public void Alterar(NomedoFilme nomedoFilme)
        {
            _nomedoFilmeRepository.Update(nomedoFilme);
            _nomedoFilmeRepository.SaveChanges();
        }

        /// <summary>
        /// Busca nome do filme por id.
        /// </summary>
        /// <param name="id">id do nome do filme a ser encontrado.</param>
        /// <returns></returns>
        public NomedoFilme BuscarporId(int id)
        {
            return this._nomedoFilmeRepository.Get(new object[] { id });
        }

        /// <summary>
        /// Busca todos os nomes do filme.
        /// </summary>
        /// <returns></returns>
        public List<NomedoFilme> BuscarTodos()
        {
            return this._nomedoFilmeRepository.Get().ToList();
        }

        /// <summary>
        /// Excluir nome do filme por id.
        /// </summary>
        /// <param name="id">id do nome do filme a ser excluido.</param>
        public void Excluir(int id)
        {
            _nomedoFilmeRepository.Delete(new object[] { id });
            _nomedoFilmeRepository.SaveChanges();
        }

        /// <summary>
        /// Salvar nome do filme.
        /// </summary>
        /// <param name="nomedoFilme">nome do filme a ser salvo.</param>
        public void Salvar(NomedoFilme nomedoFilme)
        {
            _nomedoFilmeRepository.Add(nomedoFilme);
            _nomedoFilmeRepository.SaveChanges();
        }
    }
}
