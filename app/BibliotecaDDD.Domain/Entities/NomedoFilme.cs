namespace BibliotecaDDD.Domain.Entities
{
    public class NomedoFilme
    {
        public NomedoFilme()
        {
            
        }

        public NomedoFilme(int nomedofilmeId, string nome, string idiomaId, Idioma idioma)
        {
            this.NomedoFilmeId = nomedofilmeId;
            this.Nome = nome;
            this.IdiomaId = idiomaId;
            this.Idioma = idioma;
        }

        public int NomedoFilmeId { get; set; }
        public string Nome { get; set; }
        public string IdiomaId { get; set; }

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
