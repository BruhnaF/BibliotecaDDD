using BibliotecaDDD.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace BibliotecaDDD.Presentation.WebApi.ViewModels
{
    public class FilmeViewModel
    {
        public FilmeViewModel(Filme filme)
        {
            this.FilmeId = filme.FilmeId;
            this.Descricao = filme.Descricao;
            Generos = new List<GeneroViewModel>();

            if (filme.Generos != null)
                Generos = filme.Generos.Select(x => new GeneroViewModel(x)).ToList();

            if (filme.Idiomas != null)
                Idiomas = filme.Idiomas.Select(x => new IdiomaViewModel(x)).ToList();

            if (filme.NomesdoFilme != null)
                NomesdoFilme = filme.NomesdoFilme.Select(x => new NomedoFilmeViewModel(x)).ToList();
        }

        public int FilmeId { get; set; }
        public string Descricao { get; set; }

        public List<IdiomaViewModel> Idiomas { get; set; }
        public List<GeneroViewModel> Generos { get; set; }
        public List<NomedoFilmeViewModel> NomesdoFilme { get; set; }
    }
}