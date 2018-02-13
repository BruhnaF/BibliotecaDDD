using BibliotecaDDD.Domain.Contracts.Application;
using BibliotecaDDD.Domain.Contracts.Repository;
using BibliotecaDDD.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace BibliotecaDDD.Aplication
{
    /// <summary>
    /// Classe que implementa IdiomaAppContrato. 
    /// </summary>
    public class IdiomaApp : IdiomaAppContrato
    {      
        /// <summary>
        /// variavel que recebe o IdiomaRepositoryContract.
        /// </summary>
        private readonly IdiomaRepositoryContract _idiomaRepository;

        /// <summary>
        /// Construtor que recebe o IdiomaRepositoryContract.
        /// </summary>       
        /// <param name="idiomaRepository"></param>
        public IdiomaApp(IdiomaRepositoryContract idiomaRepository)
        {
            this._idiomaRepository = idiomaRepository;         
        }

        /// <summary>
        /// Metodo para alterar o Idioma.
        /// </summary>
        /// <param name="idioma"></param>
        public void Alterar(Idioma idioma)
        {
            this._idiomaRepository.Update(idioma);
            this._idiomaRepository.SaveChanges();
        }

        /// <summary>
        /// Metodo para Buscar o Idioma por Id.
        /// </summary>
        /// <param name="id">Id a ser encontrado.</param>
        /// <returns></returns>
        public Idioma BuscarporId(string id)
        {
            return this._idiomaRepository.Get(new object[] { id });
        }

        /// <summary>
        /// Metodo para buscar todos os Idiomas.
        /// </summary>
        /// <returns></returns>
        public IList<Idioma> BuscarTodos()
        {
            return this._idiomaRepository.Get().ToList();
        }

        /// <summary>
        /// Metodo para excluir o Idioma pelo Id.
        /// </summary>
        /// <param name="id">Id a ser excluido.</param>
        public void Excluir(string id)
        {
            this._idiomaRepository.Delete(new object[] { id });
            this._idiomaRepository.SaveChanges();
        }

        /// <summary>
        /// Metodo para Salvar Idioma. 
        /// </summary>
        /// <param name="idioma">Idioma a ser Salvo.</param>
        public void Salvar(Idioma idioma)
        {
            this._idiomaRepository.Add(idioma);
            this._idiomaRepository.SaveChanges();
        }
    }
}
