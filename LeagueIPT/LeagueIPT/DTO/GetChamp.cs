using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LeagueIPT.Models;

namespace LeagueIPT.DTO
{
    public class GetChamp
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Nick { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Atributo { get; set; }
        public string Health { get; set; }
        public int Range { get; set; }
        public string AttackDamage { get; set; }
        public string AttackSpeed { get; set; }
        public int MovSpeed { get; set; }
        public string Role { get; set; }
        public string Descricao { get; set; }
        public string Imagem { get; set; }
        public string ProfilePic { get; set; }
        public string Lane { get; set; }
        public string Job { get; set; }
        public ICollection<Habilidades> LHabilidades { get; set; }
        public List<Skins> LSkins { get; set; }


        public class Habilidades
        {
            public int ID { get; set; }

            public string Passiva { get; set; }
            public string Q { get; set; }
            public string W { get; set; }
            public string E { get; set; }
            public string R { get; set; }
        }

        public class Skins
        {
            public int ID { get; set; }

            public string Nome1 { get; set; }
            public string Img1 { get; set; }
            public string Nome2 { get; set; }
            public string Img2 { get; set; }
        }
    }
}