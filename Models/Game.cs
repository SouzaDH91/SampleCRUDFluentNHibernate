using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleCRUDFluentNHibernate.Models
{
    public class Game
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string Year { get; set; }
    }
}