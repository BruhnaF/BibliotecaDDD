using BibliotecaDDD.Domain.Contracts.Application;
using BibliotecaDDD.Domain.Contracts.Repository;
using BibliotecaDDD.Presentation.WebApi.Utils;
using BibliotecaDDD.Presentation.WebApi.ViewModels;
using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BibliotecaDDD.Presentation.WebApi.Controllers
{
    /// <summary>
    /// Classe que representa o Controller do Filme.
    /// </summary>
    public class FilmeWebController : ApiController
    {
        /// <summary>
        /// Representa o filmeApp. 
        /// </summary>
        private readonly FilmeAppContrato _filmeApp;

        /// <summary>
        /// Construtor recebendo o filmeApp.
        /// </summary>
        /// <param name="filmeApp"></param>
        public FilmeWebController(FilmeAppContrato filmeApp)
        {
            _filmeApp = filmeApp;
        }

        /// <summary>
        /// Busca Todos os Filmes. 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public HttpResponseMessage Get()
        {
            try
            {
                
                var listaFilmeSalvo = this._filmeApp.BuscarcomGeneroseIdiomas();
                var listaFilmeView = listaFilmeSalvo.Select(x => new FilmeViewModel(x));

                var retorno = new { sucesso = true, dados = listaFilmeView };
                return new HttpResponseMessage(HttpStatusCode.OK)
                { Content = new JsonContent(retorno) };
            }
            catch (Exception ex)
            {
                return new HttpResponseMessage(HttpStatusCode.InternalServerError)
                {
                    Content = new StringContent("Ocorreu um erro ao Executar a Ação." +
                "Tente novamente ou entre em contato com o administrador.")
                };
            }
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        /// <summary>
        /// Exclui o Filme pela id.
        /// </summary>
        /// <param name="id">Id do filme a ser excluido.</param>
        /// <returns></returns>
        [HttpDelete]
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                this._filmeApp.Excluir(id);
                var retorno = new { sucesso = true, dados = "Filme Excluido com Sucesso" };
                return new HttpResponseMessage(HttpStatusCode.OK)
                { Content = new JsonContent(retorno) };
            }
            catch (Exception ex)
            {
                return new HttpResponseMessage(HttpStatusCode.InternalServerError)
                {
                    Content = new StringContent("Ocorreu um erro ao tentar executar a Ação" +
                        "Tente novamento ou entre em contato com o Administrador.")
                };
            }
        }
    }
}