using System.Collections.Generic;

namespace BibliotecaDDD.Domain.Entities
{
    /// <summary>
    /// Classe que representa o Idioma.
    /// </summary>
    public class Idioma
    {
        /// <summary>
        /// Construtor Padrão.
        /// </summary>
        public Idioma()
        {

        }

        /// <summary>
        /// Construtor Recebendo idiomaId e nome
        /// </summary>
        /// <param name="idiomaId"></param>
        /// <param name="nome"></param>
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

        /// <summary>
        /// Lista de Filmes.       
        /// </summary>
        public List<Filme> Filmes { get; set; }

        /// <summary>
        /// Lista de idiomas.
        /// </summary>
        public List<NomedoFilme> IdiomasdosNomes { get; set; }

        /// <summary>
        /// Adicionar lista de filmes em genero.
        /// </summary>
        /// <param name="filme"></param>
        public void AdicionarFilmes(Filme filme)
        {
            if (Filmes == null)
                Filmes = new List<Filme>();
            Filmes.Add(filme);
        }

        /// <summary>
        /// Adicionar lista de nomes do filme em genero.
        /// </summary>
        /// <param name="idiomadosNomes"></param>
        public void AdicionarIdiomadosNomes(NomedoFilme idiomadosNomes)
        {
            if (IdiomasdosNomes == null)
                IdiomasdosNomes = new List<NomedoFilme>();
            IdiomasdosNomes.Add(idiomadosNomes);
        }
    }
}
