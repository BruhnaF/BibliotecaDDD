using System.Collections.Generic;
namespace BibliotecaDDD.Domain.Entities
{
    public class Filme
    {
        /// <summary>
        /// Construtor Padrão.
        /// </summary>
        public Filme()
        {

        }

        /// <summary>
        /// Construtor recebendo filmeId e descrição.
        /// </summary>
        /// <param name="filmeId"></param>
        /// <param name="descricao"></param>
        public Filme(int filmeId, string descricao)
        {
            this.FilmeId = filmeId;
            this.Descricao = descricao;
        }

        /// <summary>
        /// Representa o FilmeId.
        /// </summary>
        public int FilmeId { get; set; }

        /// <summary>
        /// Representa a Descrição.
        /// </summary>
        public string Descricao { get; set; }

        /// <summary>
        /// Representa a Lista dos Nomes do Filme.
        /// </summary>
        public List<NomedoFilme> NomesdoFilme { get; set; }

        /// <summary>
        /// Representa a Lista de Idiomas. 
        /// </summary>
        public List<Idioma> Idiomas { get; set; }

        /// <summary>
        /// Representa a Lista de Generos.
        /// </summary>
        public List<Genero> Generos { get; set; }

        /// <summary>
        /// Constante que recebe o valor minimo aceitavel para o nome do Idioma. 
        /// </summary>
        public const int tamanhoMininoNome = 3;

        /// <summary>
        /// Constante que recebe o valor maximo aceitavel para o nome do Idioma. 
        /// </summary>
        public const int tamanhoMaximoNome = 40;

        /// <summary>
        /// Adiciona nomes do filme na lista. 
        /// </summary>
        /// <param name="nomedoFilme"></param>
        public void AdicionarNomedoFilme(NomedoFilme nomedoFilme)
        {
            if (NomesdoFilme == null)
                NomesdoFilme = new List<NomedoFilme>();
            NomesdoFilme.Add(nomedoFilme);
        }

        /// <summary>
        /// Adiciona idiomas na lista. 
        /// </summary>
        /// <param name="idioma"></param>
        public void AdicionarIdiomas(Idioma idioma)
        {
            if (Idiomas == null)
                Idiomas = new List<Idioma>();
            Idiomas.Add(idioma);
        }

        /// <summary>
        /// Adiciona generos na lista
        /// </summary>
        /// <param name="genero"></param>
        public void AdicionarGeneros(Genero genero)
        {
            if (Generos == null)
                Generos = new List<Genero>();
            Generos.Add(genero);
        }

        /// <summary>
        /// Remover generos do filme.
        /// </summary>
        /// <param name="genero">genero a ser removido.</param>
        public void RemoverGeneros(Genero genero)
        {
            if (Generos != null)
                Generos.Remove(genero);

            if (Generos.Count.Equals(0))
                Generos = null;
        }

        /// <summary>
        /// Remover Idiomas do Filme.
        /// </summary>
        /// <param name="idioma">Idioma a ser removido.</param>
        public void RemoverIdiomas(Idioma idioma)
        {
            if (Idiomas != null)
                Idiomas.Remove(idioma);
            if (Idiomas.Count.Equals(0))
                Idiomas = null;
        }

        /// <summary>
        /// Remover nome do filme.
        /// </summary>
        /// <param name="nomedoFilme">Nome do filme a ser removido.</param>
        public void RemoverNomesdoFilme(NomedoFilme nomedoFilme)
        {
            if (NomesdoFilme != null)
                NomesdoFilme.Remove(nomedoFilme);
            if (NomesdoFilme.Count.Equals(0))
                NomesdoFilme = null;
        }

        /// <summary>
        /// Remover todos os generos do filme.
        /// </summary>
        public void RemoverTodososGeneros()
        {
            Generos = null;
        }

        /// <summary>
        /// Remover todos os idiomas do filme.
        /// </summary>
        public void RemoverTodososIdiomas()
        {
            Idiomas = null;
        }

        /// <summary>
        /// Remover todos os nomes do filme.
        /// </summary>
        public void RemoverTodososNomesdoFilme()
        {
            NomesdoFilme = null;
        }
    }
}
