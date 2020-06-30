using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;

namespace SampleCRUDFluentNHibernate.Models
{
    public class NHibernateHelper
    {
        public static ISession OpenSession()
        {
            ISessionFactory sessionFactory = Fluently.Configure()
                .Database(MsSqlCeConfiguration.MsSqlCe40
                    .ConnectionString(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\projetos visual studio\SampleCRUDFluentNHibernate\App_Data\Games.mdf;Integrated Security=True")
                    .ShowSql())
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Game>())
                .ExposeConfiguration(cfg => new SchemaExport(cfg)
                    .Create(false, false))
                .BuildSessionFactory();
            return sessionFactory.OpenSession();
        }
    }
}