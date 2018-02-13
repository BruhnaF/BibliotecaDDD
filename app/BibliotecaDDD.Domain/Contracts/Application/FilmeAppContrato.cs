using BibliotecaDDD.Domain.Entities;
using System.Collections.Generic;

namespace BibliotecaDDD.Domain.Contracts.Application
{
    public interface FilmeAppContrato
    {
        void Salvar(Filme filme);
        void Alterar(Filme filme);
        void Excluir(int id);
        Filme BuscarporId(int id);
        List<Filme> BuscarTodos();
    }
}
