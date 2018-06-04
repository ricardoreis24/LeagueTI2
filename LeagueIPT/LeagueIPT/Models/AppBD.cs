using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LeagueIPT.Models {
    public class AppBD: DbContext{

        public AppBD() : base("AppBD") { }

        public virtual DbSet<Habilidades> Habilidades { get; set; }
        public virtual DbSet<Champions> Champions { get; set; }
        public virtual DbSet<Skins> Skins { get; set; }

    }
}
