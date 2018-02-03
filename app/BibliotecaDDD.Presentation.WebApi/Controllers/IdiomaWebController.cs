using BibliotecaDDD.Domain.Contracts.Application;
using BibliotecaDDD.Domain.Entities;
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
    /// ApiController para Idioma.
    /// </summary>
    public class IdiomaWebController : ApiController
    {
        /// <summary>
        /// Armazena Instancia do IdiomaApp.
        /// </summary>
        private readonly IdiomaAppContrato _idiomaApp;

        /// <summary>
        /// Construtor Padrão.
        /// </summary>
        /// <param name="idiomaApp">Instancia do idiomaApp.</param>
        public IdiomaWebController(IdiomaAppContrato idiomaApp)
        {
            _idiomaApp = idiomaApp;
        }

        /// <summary>
        /// Busca Todos os Idiomas Cadastrados.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public HttpResponseMessage Get()
        {            
            try
            {
                var listaIdiomaSalvo = this._idiomaApp.BuscarTodos();
                var listaIdiomaView = listaIdiomaSalvo.Select(x => new IdiomaViewModel(x));

                var retorno = new { sucesso = true, dados = listaIdiomaView };
                return new HttpResponseMessage(HttpStatusCode.OK)
                { Content = new JsonContent(retorno) };
            }
            catch (Exception)
            {
                return new HttpResponseMessage(HttpStatusCode.InternalServerError)
                { Content = new StringContent("Ocorreu um Erro ao Executar a Ação. " +
                "Tente Novamente ou entre em contato com o Administrador.")};
            }
        }

        // GET api/<controller>/5
        public HttpResponseMessage Get(string id)
        {
            try
            {
                var IdiomaSalvo = this._idiomaApp.BuscarporId(id);
                var IdiomaView =  new IdiomaViewModel(IdiomaSalvo);

                var retorno = new { sucesso = true, dados = IdiomaView};
                return new HttpResponseMessage(HttpStatusCode.OK)
                { Content = new JsonContent(retorno) };
            }
            catch (Exception)
            {
                return new HttpResponseMessage(HttpStatusCode.InternalServerError)
                {
                    Content = new StringContent("Ocorreu um Erro ao Executar a Ação. " +
                                "Tente Novamente ou entre em contato com o Administrador.")
                };
            }
        }

        // POST api/<controller>
        [HttpPost]
        public HttpResponseMessage Post(IdiomaViewModel idiomaView)
        {
            try
            {
                var novoIdioma = new Idioma(idiomaView.IdiomaId, idiomaView.Nome);
                this._idiomaApp.Salvar(novoIdioma);

                var retorno = new { sucesso = true, dados = "Idioma Cadastrado com Sucesso" };
                return new HttpResponseMessage(HttpStatusCode.OK)
                { Content = new JsonContent(retorno) };
            }
            catch (Exception ex)
            {
                return new HttpResponseMessage(HttpStatusCode.InternalServerError)
                {
                    Content = new StringContent("Ocorreu um Erro ao Executar a Ação. " +
                                "Tente Novamente ou entre em contato com o Administrador.")
                };
            }
           
        }

        // PUT api/<controller>/5
        [HttpPut]
        public HttpResponseMessage Put( [FromBody]IdiomaViewModel idiomaView)
        {
            try
            {
                Idioma novoIdioma = idiomaView.ToModel();
                this._idiomaApp.Alterar(novoIdioma);

                var retorno = new { sucesso = true, dados = "Idioma Alterado com Sucesso" };
                return new HttpResponseMessage(HttpStatusCode.OK)
                { Content = new JsonContent(retorno) };
            }
            catch (Exception)
            {
                return new HttpResponseMessage(HttpStatusCode.InternalServerError)
                {
                    Content = new StringContent("Ocorreu um Erro ao Executar a Ação. " +
                                "Tente Novamente ou entre em contato com o Administrador.")
                };
            }
            
        }

        // DELETE api/<controller>/5
        [HttpDelete]
        public HttpResponseMessage Delete(string id)
        {
            try
            {               
                this._idiomaApp.Excluir(id);

                var retorno = new { sucesso = true, dados = "Idioma Excluido com Sucesso" };
                return new HttpResponseMessage(HttpStatusCode.OK)
                { Content = new JsonContent(retorno) };
            }
            catch (Exception)
            {
                return new HttpResponseMessage(HttpStatusCode.InternalServerError)
                {
                    Content = new StringContent("Ocorreu um Erro ao Executar a Ação. " +
                                "Tente Novamente ou entre em contato com o Administrador.")
                };
            }
            
        }
    }
}