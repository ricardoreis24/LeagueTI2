using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LeagueIPT.Models
{
    public class Champions
    {

        [Key] public int ID { get; set; }

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
        public virtual ICollection<Habilidades> ListaHabilidades { get; set; }
        public virtual ICollection<Skins> ListaSkins { get; set; }
    }
}