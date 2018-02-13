using BibliotecaDDD.Domain.Entities;
using System.Collections.Generic;

namespace BibliotecaDDD.Domain.Contracts.Application
{
    public interface GeneroAppContrato
    {
        void Salvar(Genero genero);
        void Alterar(Genero genero);
        void Excluir(int id);
        Genero BuscarporId(int id);
        IList<Genero> BuscarTodos();
    }
}
