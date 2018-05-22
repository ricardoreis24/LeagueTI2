using System.Collections.Generic;
using LeagueIPT.Models;

namespace LeagueIPT.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<LeagueIPT.Models.AppBD>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(LeagueIPT.Models.AppBD context)
        {
            var champ = new List<Champions>
            {
                new Champions
                {
                    ID = 1,
                    Nome = "Akali",
                    Nick = "The Fist Of Shadow",
                    ReleaseDate = new DateTime(2010,05,11),
                    Atributo = "Melee",
                    Health = "593-2123",
                    Range = 125,
                    AttackDamage = "58.4 - 112.8",
                    AttackSpeed = "0.694  (+ 0 – 52.7%)",
                    MovSpeed = 350,
                    Role = "Assassin",
                    Imagem = "https://vignette.wikia.nocookie.net/leagueoflegends/images/c/c5/Akali_OriginalCentered.jpg/revision/latest/scale-to-width-down/1215?cb=20180414201909"

                }

            };
            champ.ForEach(aa => context.Champions.AddOrUpdate(a => a.Nome, aa));
            context.SaveChanges();
        }
    }
}
