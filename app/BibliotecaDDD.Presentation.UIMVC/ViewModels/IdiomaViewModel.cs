using BibliotecaDDD.Domain.Entities;

namespace BibliotecaDDD.Presentation.UIMVC.ViewModels
{
    public class IdiomaViewModel
    {
        public IdiomaViewModel()
        {
                
        }

        public IdiomaViewModel(Idioma idioma)
        {
            this.idiomaId = idioma.IdiomaId;
            this.nome = idioma.Nome;
        }
        /// <summary>
        /// Propriedade que representa o código do Idioma. 
        /// </summary>
        public string idiomaId { get; set; }

        /// <summary>
        /// Propriedade que representa o nome do Idioma.
        /// </summary>
        public string nome { get; set; }       
    }
}