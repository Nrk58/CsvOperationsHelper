﻿using Autofac;
using CsvOperationsHelper.Business.Helper.CsvHelper;

namespace CsvOperationsHelper.DependencyResolvers
{
    public class AutofacBussinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterGeneric(typeof(CsvHelper<>)).As(typeof(ICsvHelper<>)).InstancePerLifetimeScope();
        }
    }
}
