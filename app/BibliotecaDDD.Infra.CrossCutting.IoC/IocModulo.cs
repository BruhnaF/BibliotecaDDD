﻿using BibliotecaDDD.Aplication;
using BibliotecaDDD.Domain.Contracts.Application;
using BibliotecaDDD.Domain.Contracts.Repository;
using BibliotecaDDD.Infra.Data.Entity.Context;
using BibliotecaDDD.Infra.Data.Entity.Repositories;
using SimpleInjector;
using SimpleInjector.Integration.Web;

namespace BibliotecaDDD.Infra.CrossCutting.IoC
{
    /// <summary>
    /// Modulo de Injeção de Dependencia.
    /// </summary>
    public class IoCModulo
    {
        public static void Inicializador(ref Container container)
        {
            var lifestyletype = Lifestyle.Scoped;
            container.Options.DefaultScopedLifestyle = new WebRequestLifestyle();

            container.Register<IdiomaAppContrato, IdiomaApp>(lifestyletype);

            container.Register<IdiomaRepositoryContract, IdiomaRepository>(lifestyletype);

            container.Register(typeof(RepositoryBaseContract<>), typeof (RepositoryBase<>), lifestyletype);
            container.Register<BibliotecaDDDContext>(lifestyletype);

            container.Verify();

        }
    }
}
