using BibliotecaDDD.Domain.Entities;

namespace BibliotecaDDD.Presentation.WebApi.ViewModels
{
    /// <summary>
    /// Representa a view de idioma.
    /// </summary>
    public class IdiomaViewModel
    {
        /// <summary>
        /// Construtor Padrão.
        /// </summary>
        public IdiomaViewModel() { }       

        /// <summary>
        /// Construtor Padrão que recebe o Idioma.
        /// </summary>
        /// <param name="idioma"> Model para transformar em View.</param>
        public IdiomaViewModel(Idioma idioma)
        {
            this.IdiomaId = idioma.IdiomaId;
            this.Nome = idioma.Nome;
        }

        /// <summary>
        /// Propriedade que representa o código do Idioma. 
        /// </summary>
        public string IdiomaId { get; set; }

        /// <summary>
        /// Propriedade que representa o nome do Idioma.
        /// </summary>
        public string Nome { get; set; }

        public Idioma ToModel()
        {
            return new Idioma { IdiomaId = this.IdiomaId, Nome = this.Nome };
        }
    }
}