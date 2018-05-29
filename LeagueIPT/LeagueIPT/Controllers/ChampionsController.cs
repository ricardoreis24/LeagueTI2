using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Results;
using LeagueIPT.Models;
using System.Data.Entity;
using LeagueIPT.DTO;

namespace LeagueIPT.Controllers
{
    public class ChampionsController : ApiController
    {
        private AppBD _db = new AppBD();

        [HttpGet, Route("api/champions")]
        public IHttpActionResult GetChamps()
        {
            var champs = _db.Champions
                .Select(c => new GetChamps
                {
                    ID = c.ID,
                    Pic = c.ProfilePic,
                    Name = c.Nome
                })
                .ToList();

           


            return Ok(champs);
        }

        [HttpGet, Route("api/champions/{id}")]
        public IHttpActionResult GetChamps(int? id)
        {
            Champions champ = _db.Champions.Find(id);
            if (id == null)
            {
                return NotFound();
            }
            var resultado = new
            {
                champ.ID,
                champ.Nome,
                champ.Nick,
                champ.ReleaseDate,
                champ.Atributo,
                champ.Health,
                champ.Range,
                champ.AttackDamage,
                champ.AttackSpeed,
                champ.MovSpeed,
                champ.Role,
                champ.Descricao,
                champ.Imagem,
                champ.ProfilePic,
                champ.Lane,
                champ.Job,


            };

            return Ok(resultado);
        }

        [HttpGet, Route("api/champions/{id}/habilidades")]
        public IHttpActionResult GetChamp(int? id)
        {
            Champions champion = _db.Champions.Find(id);
            if (id == null)
            {
                return BadRequest();
            }

            var habilidade = champion.ListaHabilidates
                .Select(champi => new
                {
                    champi.Passiva,
                    champi.Q,
                    champi.W,
                    champi.E,
                    champi.R

                });


            return Ok(habilidade);
        }




    }
}