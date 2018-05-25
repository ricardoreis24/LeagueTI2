using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LeagueIPT.Models
{
    public class Habilidades
    {

        [Key] public int ID { get; set; }

        public string Nome { get; set; }
        public string Descr { get; set; }
        public string Imagem { get; set; }
        public string Range { get; set; }
        public string CoolDown { get; set; }
        [ForeignKey("Champion")]
        public  int IdChampion { get; set; }

        public virtual Champions Champion { get; set; } 
    }
}