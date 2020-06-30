using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FluentNHibernate.Mapping;

namespace SampleCRUDFluentNHibernate.Models
{
    class GameMap : ClassMap<Game>
    {
        public GameMap()
        {
            Id(x => x.Id);
            Map(x => x.Name);
            Map(x => x.Year);
            Table("Games");
        }
    }
}