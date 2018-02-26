using BibliotecaDDD.Domain.Contracts.Application;
using BibliotecaDDD.Domain.Entities;
using BibliotecaDDD.Domain.ValueObject;
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
    /// ApiController para o Genero.
    /// </summary>
    public class GeneroWebController : ApiController
    {
        /// <summary>
        /// Variavel que recebe GeneroAppContrato.
        /// </summary>
        private readonly GeneroAppContrato _generoApp;

        /// <summary>
        /// Construtor recebe GeneroAppContrato
        /// </summary>
        /// <param name="generoApp"></param>
        public GeneroWebController(GeneroAppContrato generoApp)
        {
            _generoApp = generoApp;
        }

        /// <summary>
        /// Buscar Todos os Generos.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public HttpResponseMessage Get()
        {
            try
            {
                var listaGeneroSalvo = this._generoApp.BuscarTodos();
                var listaGeneroView = listaGeneroSalvo.Select(x => new GeneroViewModel(x));
                var retorno = new { sucesso = true, dados = listaGeneroView };
                return new HttpResponseMessage(HttpStatusCode.OK)
                { Content = new JsonContent(retorno) };
            }
            catch (Exception ex)
            {
                return new HttpResponseMessage(HttpStatusCode.InternalServerError)
                { Content = new StringContent("Ocorreu um Erro ao Executar a Ação. " +
                "Tente Novamente ou entre em contato com o Administrador.") };
            }            
        }

        /// <summary>
        /// Buscar Genero por Id.
        /// </summary>
        /// <param name="id">Id a ser Encontrado.</param>
        /// <returns></returns>
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            try
            {
                var generoSalvo = this._generoApp.BuscarporId(id);
                var generoView = new GeneroViewModel(generoSalvo);
                var retorno = new { sucesso = true, dados = generoView };
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

        /// <summary>
        /// Salvar Genero.
        /// </summary>
        /// <param name="generoView">Genero a ser Salvo.</param>
        /// <returns></returns>
        [HttpPost]
        public HttpResponseMessage Post(GeneroViewModel generoView)
        {
            try
            {
                var novoGenero = new Genero(generoView.GeneroId, generoView.Nome);
                this._generoApp.Salvar(novoGenero);

                var retorno = new { sucesso = true, dados = "Genero Cadastrado com Sucesso" };
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

        /// <summary>
        /// Alterar Generos.
        /// </summary>
        /// <param name="generoView">Genero a ser Alterado.</param>
        /// <returns></returns>
        [HttpPut]
        public HttpResponseMessage Put([FromBody] GeneroViewModel generoView)
        {
            try
            {
                Genero novoGenero = generoView.ToModel();
                this._generoApp.Alterar(novoGenero);

                var retorno = new { sucesso = true, dados = "Genero Alterado com Sucesso" };
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

        /// <summary>
        /// Excluir Genero.
        /// </summary>
        /// <param name="id">Genero a ser Excluido.</param>
        /// <returns></returns>
        [HttpDelete]
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                this._generoApp.Excluir(id);

                var retorno = new { sucesso = true, dados = "Genero Excluido com Sucesso" };
                return new HttpResponseMessage(HttpStatusCode.OK)
                { Content = new JsonContent(retorno) };
            }
            catch (BibliotecaException ex)
            {
                return new HttpResponseMessage(HttpStatusCode.BadRequest)
                {
                    Content = new StringContent(ex.Message)
                };
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