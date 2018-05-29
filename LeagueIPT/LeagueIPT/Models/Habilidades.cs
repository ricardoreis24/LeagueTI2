using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeagueIPT.Models
{
    public class Habilidades
    {
        [Key] public int ID { get; set; }

        public string Passiva { get; set; }
        public string Q { get; set; }
        public string W { get; set; }
        public string E { get; set; }
        public string R { get; set; }

        [ForeignKey("Champion")] public int IdChampion { get; set; }

        public virtual Champions Champion { get; set; }
    }
}