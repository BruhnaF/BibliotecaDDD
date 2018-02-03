using BibliotecaDDD.Domain.Entities;
using System.Collections.Generic;

namespace BibliotecaDDD.Domain.Contracts.Application
{
    public interface IdiomaAppContrato
    {
        void Salvar(Idioma idioma);
        void Alterar(Idioma idioma);
        void Excluir(string id);
        Idioma BuscarporId(string id);
        IList<Idioma> BuscarTodos();
    }
}
