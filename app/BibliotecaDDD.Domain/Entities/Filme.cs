using System.Collections.Generic;
namespace BibliotecaDDD.Domain.Entities
{
    public class Filme
    {
        public Filme()
        {

        }

        public Filme(int filmeId, string descricao)
        {
            this.FilmeId = filmeId;
            this.Descrição = descricao;           
        }

        public int FilmeId { get; set; }
        public string Descrição { get; set; }

    //    public List<NomedoFilme> NomesdoFilme { get; set; }
        public List<Idioma> Idiomas { get; set; }
        public List<Genero> Generos { get; set; }

        /// <summary>
        /// Constante que recebe o valor minimo aceitavel para o nome do Idioma. 
        /// </summary>
        public const int tamanhoMininoNome = 3;

        /// <summary>
        /// Constante que recebe o valor maximo aceitavel para o nome do Idioma. 
        /// </summary>
        public const int tamanhoMaximoNome = 40;
        

        //public void AdicionarNomedoFilme(NomedoFilme nomedoFilme)
        //{
        //    if (NomesdoFilme == null)
        //        NomesdoFilme = new List<NomedoFilme>();
        //    NomesdoFilme.Add(nomedoFilme);
        //}

        public void AdicionarIdiomas(Idioma idioma)
        {
            if (Idiomas == null)
                Idiomas = new List<Idioma>();
            Idiomas.Add(idioma);
        }

        public void AdicionarGeneros(Genero genero)
        {
            if (Generos == null)
                Generos = new List<Genero>();
            Generos.Add(genero);            
        }        
    }
}
