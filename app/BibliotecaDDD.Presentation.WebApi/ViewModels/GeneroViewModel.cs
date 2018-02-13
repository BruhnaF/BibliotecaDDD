using BibliotecaDDD.Domain.Entities;

namespace BibliotecaDDD.Presentation.WebApi.ViewModels
{
    public class GeneroViewModel
    {
        /// <summary>
        /// Construtor Padrão.
        /// </summary>
        public GeneroViewModel()
        {

        }

        /// <summary>
        /// Construtor recebendo o Genero.
        /// </summary>
        /// <param name="genero"></param>
        public GeneroViewModel(Genero genero)
        {
            this.GeneroId = genero.GeneroId;
            this.Nome = genero.Nome;
        }

        /// <summary>
        /// Propriedade Representa o GeneroId.
        /// </summary>
        public int GeneroId { get; set; }

        /// <summary>
        /// Propriedade representa o Nome.
        /// </summary>
        public string Nome { get; set; }


        public Genero ToModel()
        {
            return new Genero { GeneroId = this.GeneroId, Nome = this.Nome };
        }
    }
}