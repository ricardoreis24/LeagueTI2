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
                    Pic = c.ProfilePic
                })
                .ToList();

            if (champs.Count == 0)
            {
                return NotFound();
            }


            return Ok(champs);
        }

        [HttpGet, Route("api/champions/{id}")]
        public IHttpActionResult GetChamps(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }

            var champ = _db.Champions
                .Where(c=> c.ID == id)
                .Select(c => c)
                .FirstOrDefault();

            if (champ == null)
            {
                return NotFound();
            }


            return Ok(champ);
        }


    }
}