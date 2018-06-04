using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LeagueIPT.Models
{
    public class Skins
    {
        [Key] public int ID { get; set; }

        public string Nome1 { get; set; }
        public string Nome2 { get; set; }
        public string Img1 { get; set; }
        public string Img2 { get; set; }

        [ForeignKey("Champion")] public int ChampId { get; set; }

        public virtual Champions Champion { get; set; }
    }
}