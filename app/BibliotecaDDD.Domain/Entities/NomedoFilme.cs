namespace BibliotecaDDD.Domain.Entities
{
    public class NomedoFilme
    {
        /// <summary>
        /// Construtor Padrão.
        /// </summary>
        public NomedoFilme()
        {
            
        }

        /// <summary>
        /// Construtor recebendo propriedades.
        /// </summary>
        /// <param name="nomedofilmeId"></param>
        /// <param name="nome"></param>
        /// <param name="idiomaId"></param>
        /// <param name="idioma"></param>
        public NomedoFilme(int nomedofilmeId, string nome, string idiomaId, Idioma idioma)
        {
            this.NomedoFilmeId = nomedofilmeId;
            this.Nome = nome;
            this.IdiomaId = idiomaId;
            this.Idioma = idioma;
        }

        /// <summary>
        /// Representa o id do nome do filme.
        /// </summary>
        public int NomedoFilmeId { get; set; }

        /// <summary>
        /// Representa o nome.
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// Representa o IdiomaId.
        /// </summary>
        public string IdiomaId { get; set; }

        /// <summary>
        /// Representa a Classe Idioma.
        /// </summary>
        public Idioma Idioma { get; set; }

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
