using System.Data.Entity;
using System.Linq;
using System.Web.Http;
using LeagueIPT.DTO;
using LeagueIPT.Models;

namespace LeagueIPT.Controllers
{

    public class ChampionsController : ApiController
    {
        private readonly AppBD _db = new AppBD();

        [HttpGet, Route("api/champions")]
        public IHttpActionResult GetChamps(string name = "")
        {
            object champs;
            if (name == "")
            {
                champs = _db.Champions
                    .Select(c => new GetChamps
                    {
                        ID = c.ID,
                        Pic = c.ProfilePic,
                        Name = c.Nome
                    })
                    .ToList();
            }
            else
            {
                champs = _db.Champions
                    .Where(c => c.Nome.ToLower().Contains(name.ToLower()))
                    .Select(c => new GetChamps
                    {
                        ID = c.ID,
                        Pic = c.ProfilePic,
                        Name = c.Nome
                    })
                    .ToList();
            }



            return Ok(champs);
        }

        [HttpGet]
        [Route("api/champions/{id}")]
        public IHttpActionResult GetChamp(int? id)
        {
            if (id == null) return BadRequest();

            var champion = _db.Champions
                .Include(c => c.ListaHabilidades)
                .Where(c => c.ID == id)
                .Select(champ => new GetChamp
                {
                    ID = champ.ID,
                    Nome = champ.Nome,
                    Nick = champ.Nick,
                    ReleaseDate = champ.ReleaseDate,
                    Atributo = champ.Atributo,
                    Health = champ.Health,
                    Range = champ.Range,
                    AttackDamage = champ.AttackDamage,
                    AttackSpeed = champ.AttackSpeed,
                    MovSpeed = champ.MovSpeed,
                    Role = champ.Role,
                    Descricao = champ.Descricao,
                    Imagem = champ.Imagem,
                    ProfilePic = champ.ProfilePic,
                    Lane = champ.Lane,
                    Job = champ.Job,
                    LHabilidades = champ.ListaHabilidades
                        .Select(a => new GetChamp.Habilidades
                        {
                            ID = a.ID,
                            Passiva = a.Passiva,
                            Q = a.Q,
                            W = a.W,
                            E = a.E,
                            R = a.R
                        }).ToList(),
                    LSkins = champ.ListaSkins
                        .Select(a => new GetChamp.Skins
                        {
                            ID = a.ID,
                            Nome1 = a.Nome1,
                            Img1 = a.Img1,
                            Nome2 = a.Nome2,
                            Img2 = a.Img2
                        }).ToList()
                }).FirstOrDefault();

            if (champion == null) return NotFound();
            return Ok(champion);
        }

        [HttpGet]
        [Route("api/champions/{id}/habilidades")]
        public IHttpActionResult GetAbilities(int? id)
        {
            var champion = _db.Champions.Find(id);
            if (id == null)
            {
                return BadRequest();
            }

            var habilidade = champion.ListaHabilidades
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

        [HttpGet]
        [Route("api/champions/{id}/skins")]
        public IHttpActionResult GetSkins(int? id)
        {
            var champion = _db.Champions.Find(id);
            if (id == null)
            {
                return BadRequest();
            }

            var skin = champion.ListaSkins
                .Select(champio => new
                {
                    champio.Nome1,
                    champio.Img1,
                    champio.Nome2,
                    champio.Img2
                });
            return Ok(skin);
        }
    }
}