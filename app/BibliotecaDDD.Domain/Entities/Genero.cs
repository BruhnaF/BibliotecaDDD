using System.Collections.Generic;

namespace BibliotecaDDD.Domain.Entities
{
    public class Genero
    {
        /// <summary>
        /// Construtor Padrão.
        /// </summary>
        public Genero()
        {

        }

        /// <summary>
        /// Construtor Recebendo generoId e nome
        /// </summary>
        /// <param name="generoId"></param>
        /// <param name="nome"></param>
        public Genero(int generoId, string nome)
        {
            this.GeneroId = generoId;
            this.Nome = nome;           
        }

        public int GeneroId { get; set; }
        public string Nome { get; set; }

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
        /// Adicionar lista de filme em Genero.
        /// </summary>
        /// <param name="filme"></param>
        public void AdicionarFilmes(Filme filme)
        {
            if (Filmes == null)
                Filmes = new List<Filme>();
            Filmes.Add(filme);
        }
    }
}
