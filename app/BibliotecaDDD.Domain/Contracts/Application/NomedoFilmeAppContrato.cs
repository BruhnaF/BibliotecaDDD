using BibliotecaDDD.Domain.Entities;
using System.Collections.Generic;

namespace BibliotecaDDD.Domain.Contracts.Application
{
    public interface NomedoFilmeAppContrato
    {
        void Salvar(NomedoFilme nomedoFilme);
        void Alterar(NomedoFilme nomedoFilme);
        void Excluir(int id);
        NomedoFilme BuscarporId(int id);
        List<NomedoFilme> BuscarTodos();
    }
}
