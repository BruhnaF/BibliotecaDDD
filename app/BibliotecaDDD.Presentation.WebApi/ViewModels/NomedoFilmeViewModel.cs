using BibliotecaDDD.Domain.Entities;

namespace BibliotecaDDD.Presentation.WebApi.ViewModels
{
    public class NomedoFilmeViewModel
    {
        public NomedoFilmeViewModel()
        {

        }

        public NomedoFilmeViewModel(NomedoFilme nomedoFilme)
        {
            this.NomedoFilmeId = nomedoFilme.NomedoFilmeId;
            this.Nome = nomedoFilme.Nome;
            this.IdiomaId = nomedoFilme.IdiomaId;
        }

        public int NomedoFilmeId { get; set; }
        public string Nome { get; set; }
        public string IdiomaId { get; set; }

        public NomedoFilme ToModel()
        {
            return new NomedoFilme { NomedoFilmeId = this.NomedoFilmeId, Nome = this.Nome, IdiomaId = this.IdiomaId };
        }
    }
}