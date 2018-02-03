namespace BibliotecaDDD.Domain.Entities
{
    /// <summary>
    /// Classe que representa o Idioma.
    /// </summary>
    public class Idioma
    {
        public Idioma()
        {

        }

        public Idioma(string idiomaId, string nome)
        {
            this.IdiomaId = idiomaId;
            this.Nome = nome;
        }

        /// <summary>
        /// Propriedade que representa o código do Idioma. 
        /// </summary>
        public string IdiomaId { get; set; }

        /// <summary>
        /// Propriedade que representa o nome do Idioma.
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// Constante que recebe o valor minimo aceitavel para o código do Idioma. 
        /// </summary>
        public const int tamanhoMinimoCodigo = 5;

        /// <summary>
        /// Constante que recebe o valor maximo aceitavel para o código do Idioma.
        /// </summary>
        public const int tamanhoMaximoCodigo = 8;

        /// <summary>
        /// Constante que recebe o valor minimo aceitavel para o nome do Idioma. 
        /// </summary>
        public const int tamanhoMininoNome = 3;

        /// <summary>
        /// Constante que recebe o valor maximo aceitavel para o nome do Idioma. 
        /// </summary>
        public const int tamanhoMaximoNome = 40;
    }
}
