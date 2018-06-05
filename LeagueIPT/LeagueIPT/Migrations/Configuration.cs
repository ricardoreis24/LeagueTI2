using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using LeagueIPT.Models;

namespace LeagueIPT.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<AppBD>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(AppBD context)
        {
            var champ = new List<Champions>
            {
                new Champions
                {
                    ID = 1,
                    Nome = "Aatrox",
                    Nick = "The Darkin Blade",
                    ReleaseDate = new DateTime(2013, 06, 13),
                    Atributo = "Melee",
                    Health = "580 - 2025",
                    Range = 125,
                    AttackDamage = "70 – 124.4",
                    AttackSpeed = "0.651  (+ 0 – 51%)",
                    MovSpeed = 345,
                    Role = "Diver",
                    Descricao =
                        "Aatrox? Is this a champion? I dont know cause nobody plays this sh*t... He is like, the most joked around champion in the game because his kit is old. His abilities are so easy to dodge and he does little to no damage. He is super out of meta.",
                    Lane =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/8/84/Top_Icon.png/revision/latest/scale-to-width-down/120?cb=20161112025307",
                    Job =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/e/e6/Fighter.png/revision/latest/scale-to-width-down/120?cb=20161117175200",
                    Imagem =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/6/67/Aatrox_OriginalCentered.jpg/revision/latest/scale-to-width-down/1215?cb=20180414201907",
                    ProfilePic =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/9/9f/Aatrox_OriginalCircle.png/revision/latest?cb=20171112084905"
                },

                new Champions
                {
                    ID = 2,
                    Nome = "Ahri",
                    Nick = "The Nine-Tailed Fox",
                    ReleaseDate = new DateTime(2011, 12, 14),
                    Atributo = "Ranged",
                    Health = "526 – 2090",
                    Range = 550,
                    AttackDamage = "53 – 104",
                    AttackSpeed = "0.668  (+ 0 – 34%)",
                    MovSpeed = 330,
                    Role = "Mage",
                    Descricao =
                        "Easy champ to play, girls love her because she is super girly. She has one ability that throws a heart. A HEART!! Besides that, she is actually fun. You do damage, you crowd control, and you can run away with your ultimate.",
                    Lane =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/7/70/Mid_icon.png/revision/latest/scale-to-width-down/120?cb=20170515021433",
                    Job =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/6/6e/Slayer.png/revision/latest?cb=20161117175201",
                    Imagem =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/f/f1/Ahri_OriginalCentered.jpg/revision/latest/scale-to-width-down/1215?cb=20180414201908",
                    ProfilePic =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/2/2c/Ahri_OriginalCircle.png/revision/latest?cb=20171112084906"
                },

                new Champions
                {
                    ID = 3,
                    Nome = "Akali",
                    Nick = "The Fist Of Shadow",
                    ReleaseDate = new DateTime(2010, 05, 11),
                    Atributo = "Melee",
                    Health = "593-2123",
                    Range = 125,
                    AttackDamage = "58.4 - 112.8",
                    AttackSpeed = "0.694  (+ 0 – 52.7%)",
                    MovSpeed = 350,
                    Role = "Assassin",
                    Descricao =
                        "HAHAHAHAHAHAHAHA Akali... you cant really run away from her. She can dash with her ultimate, her W makes her invisible and can dash with it. It's such a fun champion to play and she's very strong too. Q + Basic you're dead. True definition of assassin.",
                    Lane =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/7/70/Mid_icon.png/revision/latest/scale-to-width-down/120?cb=20170515021433",
                    Job =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/6/6e/Slayer.png/revision/latest?cb=20161117175201",
                    Imagem =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/c/c5/Akali_OriginalCentered.jpg/revision/latest/scale-to-width-down/1215?cb=20180414201909",
                    ProfilePic =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/c/cf/Akali_OriginalCircle.png/revision/latest?cb=20171112084906"
                },

                new Champions
                {
                    ID = 4,
                    Nome = "Alistar",
                    Nick = "The Minotaur",
                    ReleaseDate = new DateTime(2009, 02, 21),
                    Atributo = "Melee",
                    Health = "613.4 – 2415.4",
                    Range = 125,
                    AttackDamage = "61.1 – 122.7",
                    AttackSpeed = "0.625  (+ 0 – 36.1%)",
                    MovSpeed = 330,
                    Role = "Support",
                    Descricao =
                        "He is a tank cow. A COW! Alistar is fun to play. You can initiate plays, save your teammates and such be annoying as hell. Even tho he is not meta, you can't really go wrong with alistar.",
                    Lane =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/e/e0/Support_icon.png/revision/latest/scale-to-width-down/120?cb=20170515021434",
                    Job =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/e/e6/Fighter.png/revision/latest/scale-to-width-down/120?cb=20161117175200",
                    Imagem =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/3/30/Alistar_OriginalCentered.jpg/revision/latest/scale-to-width-down/1215?cb=20180414201910",
                    ProfilePic =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/9/92/Alistar_OriginalCircle.png/revision/latest?cb=20171112084906"
                },

                new Champions
                {
                    ID = 5,
                    Nome = "Amumu",
                    Nick = "The Sad Mummy",
                    ReleaseDate = new DateTime(2009, 06, 26),
                    Atributo = "Melee",
                    Health = "613.1 – 2041.1",
                    Range = 125,
                    AttackDamage = "53.4 – 118",
                    AttackSpeed = "0.638  (+ 15.3 – 52.4%)",
                    MovSpeed = 335,
                    Role = "Tank",
                    Descricao =
                        "Tank jungle always crying with an ok ult if used correctly. His ultimate is literally the best ability he has. It has a great range and can stun everyone on it for like 1 to 2 seconds. It's a game changer if you know when to use it.",
                    Lane =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/1/1b/Jungle_icon.png/revision/latest/scale-to-width-down/120?cb=20170515021433",
                    Job =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/9/9d/Tank.png/revision/latest/scale-to-width-down/119?cb=20161117175202",
                    Imagem =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/b/b4/Amumu_OriginalCentered.jpg/revision/latest/scale-to-width-down/1215?cb=20180414201911",
                    ProfilePic =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/e/ee/Amumu_OriginalCircle.png/revision/latest?cb=20171112084907"
                },

                new Champions
                {
                    ID = 6,
                    Nome = "Anivia",
                    Nick = "The Cryophoenix",
                    ReleaseDate = new DateTime(2009, 07, 10),
                    Atributo = "Ranged",
                    Health = "480 – 1874",
                    Range = 600,
                    AttackDamage = "51.4 – 105.8",
                    AttackSpeed = "0.625  (+ 0 – 28.6%)",
                    MovSpeed = 325,
                    Role = "Mage",
                    Descricao =
                        "Boring champion... Only thing good about her is her passive. Honestly I dont even know what to write here. Look there's a professional player that only plays Anivia. Google search Froggen, thank me later if you wanna play or learn her.",
                    Lane =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/7/70/Mid_icon.png/revision/latest/scale-to-width-down/120?cb=20170515021433",
                    Job =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/2/20/Mage.png/revision/latest/scale-to-width-down/119?cb=20161117175200",
                    Imagem =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/c/c0/Anivia_OriginalCentered.jpg/revision/latest/scale-to-width-down/1215?cb=20180414201911",
                    ProfilePic =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/0/05/Anivia_OriginalCircle.png/revision/latest?cb=20171112084907"
                },

                new Champions
                {
                    ID = 7,
                    Nome = "Annie",
                    Nick = "The Dark Child",
                    ReleaseDate = new DateTime(2009, 02, 21),
                    Atributo = "Ranged",
                    Health = "524 – 2020",
                    Range = 575,
                    AttackDamage = "50.4 – 95",
                    AttackSpeed = "0.579  (+ 0 – 23.1%)",
                    MovSpeed = 325,
                    Role = "Mage",
                    Descricao =
                        "You have no items but you pressed R? Oh look, you got yourself a kill... Also, I feel asleep playing with her. Even tho she is strong and easy to play I think its boring, little to no action. Also her voice lines are annoying cause she is a little girl.",
                    Lane =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/7/70/Mid_icon.png/revision/latest/scale-to-width-down/120?cb=20170515021433",
                    Job =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/2/20/Mage.png/revision/latest/scale-to-width-down/119?cb=20161117175200",
                    Imagem =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/8/81/Annie_OriginalCentered.jpg/revision/latest/scale-to-width-down/1215?cb=20180414201912",
                    ProfilePic =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/3/37/Annie_OriginalCircle.png/revision/latest?cb=20171112084908"
                },

                new Champions
                {
                    ID = 8,
                    Nome = "Ashe",
                    Nick = "The Frost Archer",
                    ReleaseDate = new DateTime(2009, 02, 21),
                    Atributo = "Ranged",
                    Health = "527.7 – 1870.7",
                    Range = 600,
                    AttackDamage = "65 – 103.4",
                    AttackSpeed = "0.658  (+ 0 – 56.6%)",
                    MovSpeed = 325,
                    Role = "Marksman",
                    Descricao =
                        "Ashe has a good kit but nobody plays her, dont know why. You can stun champions with your ult, you can grant vision to your team and you have strong damage and insane poke with your W.",
                    Lane =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/3/32/Bot_icon.png/revision/latest/scale-to-width-down/120?cb=20171118085356",
                    Job =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/a/a0/Marksman.png/revision/latest?cb=20161117175201",
                    Imagem =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/b/b8/Ashe_OriginalCentered.jpg/revision/latest/scale-to-width-down/1215?cb=20180414201913",
                    ProfilePic =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/1/15/Ashe_OriginalCircle.png/revision/latest?cb=20171112084909"
                },

                new Champions
                {
                    ID = 9,
                    Nome = "Aurelion Sol",
                    Nick = "The Star Forger",
                    ReleaseDate = new DateTime(2016, 03, 24),
                    Atributo = "Ranged",
                    Health = "562 – 2126",
                    Range = 550,
                    AttackDamage = "57 – 111.4",
                    AttackSpeed = "0.625  (+ 0 – 23.1%)",
                    MovSpeed = 325,
                    Role = "Mage",
                    Descricao =
                        "Boring champ... You just run with your W on, doing damage. Cant even think of anything else to say honestly.",
                    Lane =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/7/70/Mid_icon.png/revision/latest/scale-to-width-down/120?cb=20170515021433",
                    Job =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/2/20/Mage.png/revision/latest/scale-to-width-down/119?cb=20161117175200",
                    Imagem =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/6/65/Aurelion_Sol_OriginalCentered.jpg/revision/latest/scale-to-width-down/1215?cb=20180414201914",
                    ProfilePic =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/e/e4/Aurelion_Sol_OriginalCircle.png/revision/latest?cb=20171112084909"
                },

                new Champions
                {
                    ID = 10,
                    Nome = "Azir",
                    Nick = "The Emperor of the Sands",
                    ReleaseDate = new DateTime(2014, 09, 16),
                    Atributo = "Ranged",
                    Health = "552 – 2116",
                    Range = 525,
                    AttackDamage = "57 – 111.4",
                    AttackSpeed = "0.625  (+ 0 – 23.1%)",
                    MovSpeed = 335,
                    Role = "Mage",
                    Descricao =
                        "Call him Donald Trump cause his Ult places a wall that kicks you back. Super effective against Mexicans. He has a good kit but because of the current meta he is a bit weak.",
                    Lane =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/7/70/Mid_icon.png/revision/latest/scale-to-width-down/120?cb=20170515021433",
                    Job =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/2/20/Mage.png/revision/latest/scale-to-width-down/119?cb=20161117175200",
                    Imagem =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/0/03/Azir_OriginalCentered.jpg/revision/latest/scale-to-width-down/1215?cb=20180414201914",
                    ProfilePic =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/f/f9/Azir_OriginalCircle.png/revision/latest?cb=20171112084909"
                },

                new Champions
                {
                    ID = 11,
                    Nome = "Bard",
                    Nick = "The Wandering Caretaker",
                    ReleaseDate = new DateTime(2015, 03, 12),
                    Atributo = "Ranged",
                    Health = "535 – 2048",
                    Range = 500,
                    AttackDamage = "52 – 103",
                    AttackSpeed = "0.625  (+ 0 – 34%)",
                    MovSpeed = 330,
                    Role = "Support",
                    Descricao =
                        "Good if you have him on your team. He has damage and utility to save your team, however its a very hard champion to play with. You have a big learning curve.",
                    Lane =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/e/e0/Support_icon.png/revision/latest/scale-to-width-down/120?cb=20170515021434",
                    Job =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/2/20/Mage.png/revision/latest/scale-to-width-down/119?cb=20161117175200",
                    Imagem =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/4/40/Bard_OriginalCentered.jpg/revision/latest/scale-to-width-down/1215?cb=20180414201951",
                    ProfilePic =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/c/cb/Bard_OriginalCircle.png/revision/latest?cb=20171112085141"
                },

                new Champions
                {
                    ID = 12,
                    Nome = "Blitzcrank",
                    Nick = "The Great Steam  Golem",
                    ReleaseDate = new DateTime(2009, 09, 02),
                    Atributo = "Melee",
                    Health = "582.6 – 2197.6",
                    Range = 125,
                    AttackDamage = "61.5 – 121",
                    AttackSpeed = "0.625  (+ 0 – 19.2%)",
                    MovSpeed = 325,
                    Role = "Support",
                    Descricao =
                        "If he grabs you, you'll burn flash and you'll still die. Playing Blitzcrank never gets old",
                    Lane =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/e/e0/Support_icon.png/revision/latest/scale-to-width-down/120?cb=20170515021434",
                    Job =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/9/9d/Tank.png/revision/latest/scale-to-width-down/119?cb=20161117175202",
                    Imagem =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/6/65/Blitzcrank_OriginalCentered.jpg/revision/latest/scale-to-width-down/1215?cb=20180414201951",
                    ProfilePic =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/f/f7/Blitzcrank_OriginalCircle.png/revision/latest?cb=20171112085142"
                },

                new Champions
                {
                    ID = 13,
                    Nome = "Brand",
                    Nick = "The Burning Vengeance",
                    ReleaseDate = new DateTime(2011, 04, 12),
                    Atributo = "Ranged",
                    Health = "519.7 – 2015.7",
                    Range = 550,
                    AttackDamage = "57 – 108",
                    AttackSpeed = "0.625  (+ 0 – 19.2%)",
                    MovSpeed = 340,
                    Role = "Mage",
                    Descricao = "People who play Brand support have no life... You can quote me on that",
                    Lane =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/7/70/Mid_icon.png/revision/latest/scale-to-width-down/120?cb=20170515021433",
                    Job =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/2/20/Mage.png/revision/latest/scale-to-width-down/119?cb=20161117175200",
                    Imagem =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/f/f0/Brand_OriginalCentered.jpg/revision/latest/scale-to-width-down/1215?cb=20180414201952",
                    ProfilePic =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/6/6d/Brand_OriginalCircle.png/revision/latest?cb=20171112085143"
                },

                new Champions
                {
                    ID = 14,
                    Nome = "Braum",
                    Nick = "The Heart of the Freljord",
                    ReleaseDate = new DateTime(2014, 05, 12),
                    Atributo = "Melee",
                    Health = "576.2 – 2055.2",
                    Range = 125,
                    AttackDamage = "55.4 – 109.8",
                    AttackSpeed = "0.644  (+ 0 – 59.5%)",
                    MovSpeed = 335,
                    Role = "Support",
                    Descricao = "ahhhh you're safe with Braum.",
                    Lane =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/e/e0/Support_icon.png/revision/latest/scale-to-width-down/120?cb=20170515021434",
                    Job =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/9/9d/Tank.png/revision/latest/scale-to-width-down/119?cb=20161117175202",
                    Imagem =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/6/66/Braum_OriginalCentered.jpg/revision/latest/scale-to-width-down/1215?cb=20180414201953",
                    ProfilePic =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/f/f5/Braum_OriginalCircle.png/revision/latest?cb=20171112085143"
                },

                new Champions
                {
                    ID = 15,
                    Nome = "Caitlyn",
                    Nick = "The Sheriff of Piltover",
                    ReleaseDate = new DateTime(2011, 01, 04),
                    Atributo = "Ranged",
                    Health = "475 – 1920",
                    Range = 650,
                    AttackDamage = "62 – 99.1",
                    AttackSpeed = "0.568  (+ 10 – 78%)",
                    MovSpeed = 325,
                    Role = "Marksman",
                    Descricao = "W spam = easy kills",
                    Lane =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/3/32/Bot_icon.png/revision/latest/scale-to-width-down/120?cb=20171118085356",
                    Job =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/a/a0/Marksman.png/revision/latest?cb=20161117175201",
                    Imagem =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/e/ef/Caitlyn_OriginalCentered.jpg/revision/latest/scale-to-width-down/1215?cb=20180414201954",
                    ProfilePic =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/9/90/Caitlyn_OriginalCircle.png/revision/latest?cb=20171112085442"
                },

                new Champions
                {
                    ID = 16,
                    Nome = "Camille",
                    Nick = "The Steel Shadow",
                    ReleaseDate = new DateTime(2016, 12, 07),
                    Atributo = "Melee",
                    Health = "575.6 – 2020.6",
                    Range = 125,
                    AttackDamage = "68 – 127.5",
                    AttackSpeed = "0.644  (+ 0 – 42.5%)",
                    MovSpeed = 325,
                    Role = "Bruiser",
                    Descricao = "You design camille should be fired.",
                    Lane =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/8/84/Top_Icon.png/revision/latest/scale-to-width-down/120?cb=20161112025307",
                    Job =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/e/e6/Fighter.png/revision/latest/scale-to-width-down/120?cb=20161117175200",
                    Imagem =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/3/3d/Camille_OriginalCentered.jpg/revision/latest/scale-to-width-down/1215?cb=20180414201955",
                    ProfilePic =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/4/4c/Camille_OriginalCircle.png/revision/latest?cb=20171112085443"
                },

                new Champions
                {
                    ID = 17,
                    Nome = "Cassiopeia",
                    Nick = "The Serpent's Embrace",
                    ReleaseDate = new DateTime(2010, 12, 14),
                    Atributo = "Ranged",
                    Health = "537 – 2016",
                    Range = 550,
                    AttackDamage = "53 – 104",
                    AttackSpeed = "0.647  (+ 0 – 25.5%)",
                    MovSpeed = 328,
                    Role = "Mage",
                    Descricao = "Its a snake for gods sake.",
                    Lane =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/7/70/Mid_icon.png/revision/latest/scale-to-width-down/120?cb=20170515021433",
                    Job =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/2/20/Mage.png/revision/latest/scale-to-width-down/119?cb=20161117175200",
                    Imagem =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/2/23/Cassiopeia_OriginalCentered.jpg/revision/latest/scale-to-width-down/1215?cb=20180414201955",
                    ProfilePic =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/2/2b/Cassiopeia_OriginalCircle.png/revision/latest?cb=20171112085443"
                },

                new Champions
                {
                    ID = 18,
                    Nome = "Cho'Gath",
                    Nick = "The Terror of the Void",
                    ReleaseDate = new DateTime(2009, 06, 26),
                    Atributo = "Melee",
                    Health = "574.4 – 1934.4",
                    Range = 125,
                    AttackDamage = "69 – 140.4",
                    AttackSpeed = "0.625  (+ 0 – 24.5%)",
                    MovSpeed = 345,
                    Role = "Tank",
                    Descricao = "Press R for a kill. Also you're tank as f*ck.",
                    Lane =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/8/84/Top_Icon.png/revision/latest/scale-to-width-down/120?cb=20161112025307",
                    Job =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/9/9d/Tank.png/revision/latest/scale-to-width-down/119?cb=20161117175202",
                    Imagem =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/7/70/Cho%27Gath_OriginalCentered.jpg/revision/latest/scale-to-width-down/1215?cb=20180414201956",
                    ProfilePic =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/4/40/Cho%27Gath_OriginalCircle.png/revision/latest?cb=20171124185151"
                },

                new Champions
                {
                    ID = 19,
                    Nome = "Corki",
                    Nick = "The Daring Bombardier",
                    ReleaseDate = new DateTime(2009, 09, 19),
                    Atributo = "Ranged",
                    Health = "518 – 1997",
                    Range = 550,
                    AttackDamage = "60 – 111",
                    AttackSpeed = "0.638  (+ 0 – 39.1%)",
                    MovSpeed = 325,
                    Role = "Marksman",
                    Descricao = "He is fun, I guess",
                    Lane =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/7/70/Mid_icon.png/revision/latest/scale-to-width-down/120?cb=20170515021433",
                    Job =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/a/a0/Marksman.png/revision/latest?cb=20161117175201",
                    Imagem =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/2/28/Corki_OriginalCentered.jpg/revision/latest/scale-to-width-down/1215?cb=20180414201957",
                    ProfilePic =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/e/e9/Corki_OriginalCircle.png/revision/latest?cb=20171112085444"
                },

                new Champions
                {
                    ID = 20,
                    Nome = "Darius",
                    Nick = "The Hand of Noxus",
                    ReleaseDate = new DateTime(2012, 05, 23),
                    Atributo = "Melee",
                    Health = "582.2 – 2282.2",
                    Range = 175,
                    AttackDamage = "64 – 149",
                    AttackSpeed = "0.625  (+ 0 – 17%)",
                    MovSpeed = 340,
                    Role = "Tank",
                    Descricao = "Ahh do you like dunking on people? Than Darius is the champ for you.",
                    Lane =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/8/84/Top_Icon.png/revision/latest/scale-to-width-down/120?cb=20161112025307",
                    Job =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/e/e6/Fighter.png/revision/latest/scale-to-width-down/120?cb=20161117175200",
                    Imagem =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/e/eb/Darius_OriginalCentered.jpg/revision/latest/scale-to-width-down/1215?cb=20180414201958",
                    ProfilePic =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/f/f9/Darius_OriginalCircle.png/revision/latest?cb=20171112085445"
                },

                new Champions
                {
                    ID = 21,
                    Nome = "Diana",
                    Nick = "Scorn of the Moon",
                    ReleaseDate = new DateTime(2012, 08, 07),
                    Atributo = "Melee",
                    Health = "594 – 2209",
                    Range = 150,
                    AttackDamage = "53 – 104",
                    AttackSpeed = "0.625  (+ 0 – 38.3%)",
                    MovSpeed = 345,
                    Role = "Assassin",
                    Descricao = "Discount version of Akali with a bit more crowd control.",
                    Lane =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/7/70/Mid_icon.png/revision/latest/scale-to-width-down/120?cb=20170515021433",
                    Job =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/6/6e/Slayer.png/revision/latest?cb=20161117175201",
                    Imagem =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/c/cd/Diana_OriginalCentered.jpg/revision/latest/scale-to-width-down/1215?cb=20180414202027",
                    ProfilePic =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/c/c6/Diana_OriginalCircle.png/revision/latest?cb=20171112085750"
                },

                new Champions
                {
                    ID = 22,
                    Nome = "Dr. Mundo",
                    Nick = "The Madman of Zaun",
                    ReleaseDate = new DateTime(2009, 09, 02),
                    Atributo = "Melee",
                    Health = "582.5 – 2095.5",
                    Range = 125,
                    AttackDamage = "61.3 – 120.8",
                    AttackSpeed = "0.625  (+ 15.3 – 62.9%)",
                    MovSpeed = 345,
                    Role = "Tank",
                    Descricao = "Please don't play Mundo, he's too tanky. Hard to kill.",
                    Lane =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/8/84/Top_Icon.png/revision/latest/scale-to-width-down/120?cb=20161112025307",
                    Job =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/9/9d/Tank.png/revision/latest/scale-to-width-down/119?cb=20161117175202",
                    Imagem =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/7/7d/Dr._Mundo_OriginalCentered.jpg/revision/latest/scale-to-width-down/1215?cb=20180414202028",
                    ProfilePic =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/4/47/Dr._Mundo_OriginalCircle.png/revision/latest?cb=20171112085751"
                },

                new Champions
                {
                    ID = 23,
                    Nome = "Draven",
                    Nick = "The Glorious Executioner",
                    ReleaseDate = new DateTime(2012, 06, 06),
                    Atributo = "Ranged",
                    Health = "557.8 – 1951.8",
                    Range = 550,
                    AttackDamage = "64 – 113.5",
                    AttackSpeed = "0.679  (+ 0 – 45.9%)",
                    MovSpeed = 330,
                    Role = "Marksman",
                    Descricao = "Draven does it all.......",
                    Lane =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/3/32/Bot_icon.png/revision/latest/scale-to-width-down/120?cb=20171118085356",
                    Job =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/a/a0/Marksman.png/revision/latest?cb=20161117175201",
                    Imagem =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/6/63/Draven_OriginalCentered.jpg/revision/latest/scale-to-width-down/1215?cb=20180414202029",
                    ProfilePic =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/d/d3/Draven_OriginalCircle.png/revision/latest?cb=20171112085750"
                },

                new Champions
                {
                    ID = 24,
                    Nome = "Ekko",
                    Nick = "The Boy Who Shattered Time",
                    ReleaseDate = new DateTime(2015, 05, 28),
                    Atributo = "Melee",
                    Health = "585 – 2030",
                    Range = 125,
                    AttackDamage = "64 – 113.5",
                    AttackSpeed = "0.625  (+ 10 – 66.1%)",
                    MovSpeed = 340,
                    Role = "Assassin",
                    Descricao =
                        "You can one shot somebody and press R to go back to where you were a few moments back.",
                    Lane =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/7/70/Mid_icon.png/revision/latest/scale-to-width-down/120?cb=20170515021433",
                    Job =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/6/6e/Slayer.png/revision/latest?cb=20161117175201",
                    Imagem =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/3/33/Ekko_OriginalCentered.jpg/revision/latest/scale-to-width-down/1215?cb=20180414202030",
                    ProfilePic =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/e/e3/Ekko_OriginalCircle.png/revision/latest?cb=20171112085751"
                },

                new Champions
                {
                    ID = 25,
                    Nome = "Elise",
                    Nick = "The Spider Queen",
                    ReleaseDate = new DateTime(2012, 10, 26),
                    Atributo = "Ranged",
                    Health = "534 – 1979",
                    Range = 550,
                    AttackDamage = "55 – 106",
                    AttackSpeed = "0.625  (+ 0 – 29.8%)",
                    MovSpeed = 325,
                    Role = "Mage",
                    Descricao = "You build tank and you deal tons of damage.",
                    Lane =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/1/1b/Jungle_icon.png/revision/latest/scale-to-width-down/120?cb=20170515021433",
                    Job =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/e/e6/Fighter.png/revision/latest/scale-to-width-down/120?cb=20161117175200",
                    Imagem =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/a/af/Elise_OriginalCentered.jpg/revision/latest/scale-to-width-down/1215?cb=20180414202031",
                    ProfilePic =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/3/30/Elise_OriginalCircle.png/revision/latest?cb=20171112085752"
                },

                new Champions
                {
                    ID = 26,
                    Nome = "Evelynn",
                    Nick = "Agony's Embrace",
                    ReleaseDate = new DateTime(2009, 05, 01),
                    Atributo = "Melee",
                    Health = "572 – 2000",
                    Range = 125,
                    AttackDamage = "61 – 112",
                    AttackSpeed = "0.667  (+ 0 – 35.7%)",
                    MovSpeed = 335,
                    Role = "Mage",
                    Descricao = "After level 6 you're invisible. I hate people who play her.",
                    Lane =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/1/1b/Jungle_icon.png/revision/latest/scale-to-width-down/120?cb=20170515021433",
                    Job =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/6/6e/Slayer.png/revision/latest?cb=20161117175201",
                    Imagem =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/4/43/Evelynn_OriginalCentered.jpg/revision/latest/scale-to-width-down/1215?cb=20180414202031",
                    ProfilePic =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/8/88/Evelynn_OriginalCircle.png/revision/latest?cb=20171112085752"
                },

                new Champions
                {
                    ID = 27,
                    Nome = "Ezreal",
                    Nick = "The Prodigal Explorer",
                    ReleaseDate = new DateTime(2010, 03, 16),
                    Atributo = "Ranged",
                    Health = "484.4 – 1844.4",
                    Range = 550,
                    AttackDamage = "64 – 105",
                    AttackSpeed = "0.625  (+ 0 – 25.5%)",
                    MovSpeed = 325,
                    Role = "Marksman",
                    Descricao = "Bad if you don't hit skill shots.",
                    Lane =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/3/32/Bot_icon.png/revision/latest/scale-to-width-down/120?cb=20171118085356",
                    Job =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/a/a0/Marksman.png/revision/latest?cb=20161117175201",
                    Imagem =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/9/91/Ezreal_OriginalCentered.jpg/revision/latest/scale-to-width-down/1215?cb=20180414202032",
                    ProfilePic =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/f/fb/Ezreal_OriginalCircle.png/revision/latest?cb=20171112085753"
                },

                new Champions
                {
                    ID = 28,
                    Nome = "Fiddlesticks",
                    Nick = "The Harbinger of Doom",
                    ReleaseDate = new DateTime(2009, 02, 21),
                    Atributo = "Ranged",
                    Health = "524.4 – 1884.4",
                    Range = 480,
                    AttackDamage = "48.4 – 93",
                    AttackSpeed = "0.625  (+ 0 – 35.9%)",
                    MovSpeed = 335,
                    Role = "Mage",
                    Descricao = "He is annoying to play against.",
                    Lane =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/1/1b/Jungle_icon.png/revision/latest/scale-to-width-down/120?cb=20170515021433",
                    Job =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/2/20/Mage.png/revision/latest/scale-to-width-down/119?cb=20161117175200",
                    Imagem =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/a/a6/Fiddlesticks_OriginalCentered.jpg/revision/latest/scale-to-width-down/1215?cb=20180414202033",
                    ProfilePic =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/4/43/Fiddlesticks_OriginalCircle.png/revision/latest?cb=20171112090226"
                },

                new Champions
                {
                    ID = 29,
                    Nome = "Fiora",
                    Nick = "The Prodigal Explorer",
                    ReleaseDate = new DateTime(2012, 02, 29),
                    Atributo = "Melee",
                    Health = "550 – 1995",
                    Range = 150,
                    AttackDamage = "68 – 124.1",
                    AttackSpeed = "0.69  (+ 0 – 54.4%)",
                    MovSpeed = 345,
                    Role = "Bruiser",
                    Descricao =
                        "Has a dash every few seconds plus deals trillions of damage while she heals for billions.",
                    Lane =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/8/84/Top_Icon.png/revision/latest/scale-to-width-down/120?cb=20161112025307",
                    Job =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/e/e6/Fighter.png/revision/latest/scale-to-width-down/120?cb=20161117175200",
                    Imagem =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/2/25/Fiora_OriginalCentered.jpg/revision/latest/scale-to-width-down/1215?cb=20180414202034",
                    ProfilePic =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/c/ce/Fiora_OriginalCircle.png/revision/latest?cb=20171112090227"
                },

                new Champions
                {
                    ID = 30,
                    Nome = "Fizz",
                    Nick = "The Tidal Trickster",
                    ReleaseDate = new DateTime(2011, 11, 15),
                    Atributo = "Melee",
                    Health = "570 – 2236",
                    Range = 175,
                    AttackDamage = "58 – 109",
                    AttackSpeed = "0.658  (+ 0 – 52.7%)",
                    MovSpeed = 335,
                    Role = "Assassin",
                    Descricao =
                        "This champ should not be in the game. Has an ability that makes him invulnerable every few seconds",
                    Lane =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/7/70/Mid_icon.png/revision/latest/scale-to-width-down/120?cb=20170515021433",
                    Job =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/6/6e/Slayer.png/revision/latest?cb=20161117175201",
                    Imagem =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/6/60/Fizz_OriginalCentered.jpg/revision/latest/scale-to-width-down/1215?cb=20180414202034",
                    ProfilePic =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/8/84/Fizz_OriginalCircle.png/revision/latest?cb=20171112090227"
                },

                new Champions
                {
                    ID = 31,
                    Nome = "Galio",
                    Nick = "The Colossus",
                    ReleaseDate = new DateTime(2010, 08, 10),
                    Atributo = "Melee",
                    Health = "562 – 2466",
                    Range = 150,
                    AttackDamage = "59 – 118.5",
                    AttackSpeed = "0.625  (+ 0 – 25.5%)",
                    MovSpeed = 335,
                    Role = "Tank",
                    Descricao = "A tank that does damage. Thank you Riot Design team for this 'balanced' champion",
                    Lane =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/8/84/Top_Icon.png/revision/latest/scale-to-width-down/120?cb=20161112025307",
                    Job =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/2/20/Mage.png/revision/latest/scale-to-width-down/119?cb=20161117175200",
                    Imagem =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/5/51/Galio_OriginalCentered.jpg/revision/latest/scale-to-width-down/1215?cb=20180414202110",
                    ProfilePic =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/8/82/Galio_OriginalCircle.png/revision/latest?cb=20171112090228"
                },

                new Champions
                {
                    ID = 32,
                    Nome = "Gangplank",
                    Nick = "The Saltwater Scourge",
                    ReleaseDate = new DateTime(2009, 08, 19),
                    Atributo = "Melee",
                    Health = "540 – 1934",
                    Range = 125,
                    AttackDamage = "64 – 115",
                    AttackSpeed = "0.658  (+ 0 – 54.4%)",
                    MovSpeed = 345,
                    Role = "Bruiser",
                    Descricao = "Super fun to play. I love Gangplank because of Tobias fate. Google search him",
                    Lane =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/8/84/Top_Icon.png/revision/latest/scale-to-width-down/120?cb=20161112025307",
                    Job =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/a/a0/Marksman.png/revision/latest?cb=20161117175201",
                    Imagem =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/f/f0/Gangplank_OriginalCentered.jpg/revision/latest/scale-to-width-down/1215?cb=20180414202111",
                    ProfilePic =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/6/65/Gangplank_OriginalCircle.png/revision/latest?cb=20171112090228"
                },

                new Champions
                {
                    ID = 33,
                    Nome = "Gnar",
                    Nick = "The Missing Link",
                    ReleaseDate = new DateTime(2014, 08, 14),
                    Atributo = "Ranged",
                    Health = "510 – 1615",
                    Range = 175,
                    AttackDamage = "59 – 110",
                    AttackSpeed = "0.625  (+ 5.5 – 107.5%)",
                    MovSpeed = 325,
                    Role = "Tank",
                    Descricao = "Omg he's so cute.... oh wtf he just transform himself into a big monster",
                    Lane =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/8/84/Top_Icon.png/revision/latest/scale-to-width-down/120?cb=20161112025307",
                    Job =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/e/e6/Fighter.png/revision/latest/scale-to-width-down/120?cb=20161117175200",
                    Imagem =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/f/f4/Gnar_OriginalCentered.jpg/revision/latest/scale-to-width-down/1215?cb=20180414202113",
                    ProfilePic =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/a/aa/Gnar_OriginalCircle.png/revision/latest?cb=20171112090229"
                },

                new Champions
                {
                    ID = 34,
                    Nome = "Gragas",
                    Nick = "The Rabble Rouser",
                    ReleaseDate = new DateTime(2010, 02, 02),
                    Atributo = "Melee",
                    Health = "583.5 – 2096.5",
                    Range = 125,
                    AttackDamage = "61.4 – 120.9",
                    AttackSpeed = "0.625  (+ 8 – 42.8%)",
                    MovSpeed = 330,
                    Role = "Tank",
                    Descricao = "A fat Irish who is tank and loves beer... not even kidding",
                    Lane =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/1/1b/Jungle_icon.png/revision/latest/scale-to-width-down/120?cb=20170515021433",
                    Job =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/9/9d/Tank.png/revision/latest/scale-to-width-down/119?cb=20161117175202",
                    Imagem =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/3/33/Gragas_OriginalCentered.jpg/revision/latest/scale-to-width-down/1215?cb=20180414202113",
                    ProfilePic =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/e/e4/Gragas_OriginalCircle.png/revision/latest?cb=20171112090230"
                },

                new Champions
                {
                    ID = 35,
                    Nome = "Graves",
                    Nick = "The Outlaw",
                    ReleaseDate = new DateTime(2011, 10, 19),
                    Atributo = "Ranged",
                    Health = "551.1 – 2115.1",
                    Range = 425,
                    AttackDamage = "69 – 120",
                    AttackSpeed = "0.481  (+ 0 – 44.2%)",
                    MovSpeed = 340,
                    Role = "Marksman",
                    Descricao = "His ult is too strong",
                    Lane =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/1/1b/Jungle_icon.png/revision/latest/scale-to-width-down/120?cb=20170515021433",
                    Job =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/a/a0/Marksman.png/revision/latest?cb=20161117175201",
                    Imagem =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/a/a5/Graves_OriginalCentered.jpg/revision/latest/scale-to-width-down/1215?cb=20180414202114",
                    ProfilePic =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/3/36/Graves_OriginalCircle.png/revision/latest?cb=20171112090230"
                },

                new Champions
                {
                    ID = 36,
                    Nome = "Hecarim",
                    Nick = "The Shadow of War",
                    ReleaseDate = new DateTime(2012, 04, 18),
                    Atributo = "Melee",
                    Health = "	580 – 2110",
                    Range = 175,
                    AttackDamage = "66 – 120.4",
                    AttackSpeed = "0.67  (+ 0 – 42.5%)",
                    MovSpeed = 345,
                    Role = "Bruiser",
                    Descricao = "My little poney...",
                    Lane =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/1/1b/Jungle_icon.png/revision/latest/scale-to-width-down/120?cb=20170515021433",
                    Job =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/e/e6/Fighter.png/revision/latest/scale-to-width-down/120?cb=20161117175200",
                    Imagem =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/3/3c/Hecarim_OriginalCentered.jpg/revision/latest/scale-to-width-down/1215?cb=20180414202115",
                    ProfilePic =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/8/83/Hecarim_OriginalCircle.png/revision/latest?cb=20171112090231"
                },

                new Champions
                {
                    ID = 37,
                    Nome = "Heimerdinger",
                    Nick = "The Revered Inventor",
                    ReleaseDate = new DateTime(2009, 10, 10),
                    Atributo = "Ranged",
                    Health = "488 – 1967",
                    Range = 550,
                    AttackDamage = "55.5 – 101.4",
                    AttackSpeed = "0.625  (+ 0 – 23.1%)",
                    MovSpeed = 340,
                    Role = "Mage",
                    Descricao = "THE DONGER!!!",
                    Lane =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/7/70/Mid_icon.png/revision/latest/scale-to-width-down/120?cb=20170515021433",
                    Job =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/2/20/Mage.png/revision/latest/scale-to-width-down/119?cb=20161117175200",
                    Imagem =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/4/4a/Heimerdinger_OriginalCentered.jpg/revision/latest/scale-to-width-down/1215?cb=20180414202115",
                    ProfilePic =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/8/8e/Heimerdinger_OriginalCircle.png/revision/latest?cb=20171112090709"
                },

                new Champions
                {
                    ID = 38,
                    Nome = "Illaoi",
                    Nick = "The Kraken Priestess",
                    ReleaseDate = new DateTime(2015, 11, 24),
                    Atributo = "Melee",
                    Health = "585.6 – 2200.6",
                    Range = 125,
                    AttackDamage = "68 – 153",
                    AttackSpeed = "0.571  (+ 0 – 42.5%)",
                    MovSpeed = 340,
                    Role = "Bruiser",
                    Descricao = "She has tentacles. People you enjoy hentai play her a lot (xD)",
                    Lane =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/8/84/Top_Icon.png/revision/latest/scale-to-width-down/120?cb=20161112025307",
                    Job =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/e/e6/Fighter.png/revision/latest/scale-to-width-down/120?cb=20161117175200",
                    Imagem =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/4/4b/Illaoi_OriginalCentered.jpg/revision/latest/scale-to-width-down/1215?cb=20180414202116",
                    ProfilePic =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/2/21/Illaoi_OriginalCircle.png/revision/latest?cb=20171112090710"
                },

                new Champions
                {
                    ID = 39,
                    Nome = "Irelia",
                    Nick = "The Blade Dancer",
                    ReleaseDate = new DateTime(2010, 11, 16),
                    Atributo = "Melee",
                    Health = "550 – 1995",
                    Range = 200,
                    AttackDamage = "60 – 128",
                    AttackSpeed = "0.625  (+ 0 – 42.5%)",
                    MovSpeed = 340,
                    Role = "Bruiser",
                    Descricao = "Yeah she's good I guess",
                    Lane =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/8/84/Top_Icon.png/revision/latest/scale-to-width-down/120?cb=20161112025307",
                    Job =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/e/e6/Fighter.png/revision/latest/scale-to-width-down/120?cb=20161117175200",
                    Imagem =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/6/6f/Irelia_OriginalCentered.jpg/revision/latest/scale-to-width-down/1215?cb=20180414202117",
                    ProfilePic =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/5/59/Irelia_OriginalCircle.png/revision/latest?cb=20180320200353"
                },

                new Champions
                {
                    ID = 40,
                    Nome = "Ivern",
                    Nick = "The Green Father",
                    ReleaseDate = new DateTime(2016, 10, 05),
                    Atributo = "Melee",
                    Health = "585 – 2200",
                    Range = 125,
                    AttackDamage = "50 – 101",
                    AttackSpeed = "0.644  (+ 0 – 57.8%)",
                    MovSpeed = 325,
                    Role = "Support",
                    Descricao =
                        "You're a tree... You plays this champ??? You're a f*ucking tree. Who design this shoul've of been high at the moment.",
                    Lane =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/1/1b/Jungle_icon.png/revision/latest/scale-to-width-down/120?cb=20170515021433",
                    Job =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/2/20/Mage.png/revision/latest/scale-to-width-down/119?cb=20161117175200",
                    Imagem =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/2/20/Ivern_OriginalCentered.jpg/revision/latest/scale-to-width-down/1215?cb=20180414203243",
                    ProfilePic =
                        "https://vignette.wikia.nocookie.net/leagueoflegends/images/5/5f/Ivern_OriginalCircle.png/revision/latest?cb=20171112090711"
                }
            };
            champ.ForEach(aa => context.Champions.AddOrUpdate(a => a.Nome, aa));
            context.SaveChanges();

            var habilidade = new List<Habilidades>
            {
                new Habilidades
                {
                    ID = 1,
                    Passiva = "Gains bonus Attack Damage and Attack Speed from hitting enemy champions.",
                    Q = "Aatrox dashes to the target area.",
                    W = "Deals bonus on-hit physical damage.",
                    E = "Aatrox unleashes two converging energy waves in the target direction.",
                    R =
                        "He draws in the blood of his foes, dealing Ability power magic damage to nearby enemy champions.",
                    IdChampion = 1
                },


                new Habilidades
                {
                    ID = 2,
                    Passiva =
                        "Whenever Ahri lands 2 ability hits against a champion within 1.5 seconds, she gain 20% bonus movement speed for 3 seconds.",
                    Q = "Sends an orb of arcane energy in the target direction, dealing power magic damage.",
                    W = "Summons three spectral flames which orbit her for up to 5 seconds.",
                    E =
                        "Ahri blows a kiss in a line, dealing magic damage to the first enemy hit, charming and slowing them by 65%.",
                    R = "Ahri dashes in the direction of the cursor.",
                    IdChampion = 2
                },

                new Habilidades
                {
                    ID = 3,
                    Passiva = "Akali's first two basic attacks are empowered.",
                    Q =
                        "Akali throws her kama at the target unit, dealing magic damage. Basic attacks detonate the kama dealing bonus damage",
                    W = "Creates a smoke cover that makes akali invisible.",
                    E = "Akali flourishes her kamas, dealing physical damage to all enemies around her.",
                    R = "Akali dashes to the target unit, dealing them magic damage.",
                    IdChampion = 3
                },

                new Habilidades
                {
                    ID = 4,
                    Passiva =
                        "Alistar roars,healing himself for 20 - 139 (based on level) health and all nearby allied champions.",
                    Q =
                        "Slams the ground beneath him, dealing magic damage to all nearby enemies knocking them up for 1 second.",
                    W =
                        "Dashes to the target enemy dealing magic damage, stunning them for 1 second and knocking them back 650 units.",
                    E = "Alistar tramples the ground around him every 0.5 seconds for 5 seconds.",
                    R = "Reduces all incoming physical and magic damage for the next 7 seconds.",
                    IdChampion = 4
                },

                new Habilidades
                {
                    ID = 5,
                    Passiva =
                        "Amumu's basic attacks curse the enemy. Cursed enemies will receive 10% bonus true damage.",
                    Q = "Amumu tosses a bandage in the target direction that stuns and pulls him to that location.",
                    W = "Cries a continuous pool of tears dealing magic damage to everyone around him.",
                    E = "Amumu takes reduced physical damage.",
                    R = "Deals magic damage to nearby enemies and stuns them for 2 seconds.",
                    IdChampion = 5
                },

                new Habilidades
                {
                    ID = 6,
                    Passiva =
                        "Upon taking fatal damage, Anivia transforms into an egg.If the egg survives, Anivia is reborn.",
                    Q = "Launches a massive chunk of ice which flies toward the target location.",
                    W = "Anivia summons an impassable wall of ice at the target location.",
                    E = "Anivia blasts the target with a freezing wind, dealing magic damage.",
                    R = "Calls forth a driving rain of ice and hail at the target location.",
                    IdChampion = 6
                },

                new Habilidades
                {
                    ID = 7,
                    Passiva = "Everytime she casts 3 abilities, Annie will stun with the 4th ability.",
                    Q = "Annie hurls a fireball at the target enemy, dealing magic damage.",
                    W = "Releases a cone of fire in the target direction, dealing magic damage.",
                    E = "Reduce damage taken for the next 3 seconds.",
                    R = "Summons a bear, dealing magic damage to everyone around her.",
                    IdChampion = 7
                },

                new Habilidades
                {
                    ID = 8,
                    Passiva = "Slows enemies when she hits them with basics.",
                    Q = "Gains bonus attack speed for 4 seconds.",
                    W =
                        "Ashe fires 9 arrows in a cone in the target direction, dealing physical damage to all enemies hit.",
                    E = "Grants vision to target area.",
                    R = "Fires an arrow that stuns enemies if they're hit.",
                    IdChampion = 8
                },

                new Habilidades
                {
                    ID = 9,
                    Passiva = "Constantly orbited by three Stars that if enemies get hit, deals magic damage.",
                    Q = "Fires the core of a newborn star in the target direction that stuns enemies.",
                    W = "Increases range and damage of passive.",
                    E = "Aurelion Sol gains an increasing bonus movement speed and can go through walls.",
                    R = "Exhales a wave of starfire in a line, dealing magic damage to all enemies hit.",
                    IdChampion = 9
                },

                new Habilidades
                {
                    ID = 10,
                    Passiva = "Creates a Turret on any destroyed turrets.",
                    Q = "Dashes his soldiers towards the target location.",
                    W = "Azir summons an untargetable Sand Soldier.",
                    E = "Azir shields himself for 1.5 seconds and dashes to one of his Sand Soldiers",
                    R =
                        "Azir calls forth a phalanx of soldiers from behind him, charging forward in the target direction.",
                    IdChampion = 10
                },

                new Habilidades
                {
                    ID = 11,
                    Passiva = "Way to complex to be written here. Just google it.",
                    Q = "Bard fires a burst of spirit energy in the target direction, dealing magic damage.",
                    W = "Creates a thing on the ground that when consume grants health to ally champions.",
                    E = "Opens a one-way magical corridor through a piece of terrain in the target direction.",
                    R =
                        "Bard sends magical energy arcing to the target location, putting all units and structures in the target area invulnerable.",
                    IdChampion = 11
                },

                new Habilidades
                {
                    ID = 12,
                    Passiva =
                        "When Blitz receives damage which brings him below 20% maximum health, he shields himself.",
                    Q = "Fires his right hand in the target direction, pulling the first enemy hit to him.",
                    W = "On cast grants bonus movement speed to Blitzcrank.",
                    E = "Blitzcrank's next basic attack knocks up his target for 1 second.",
                    R = "Blitzcrank detonates his static field, dealing magic damage.",
                    IdChampion = 12
                },

                new Habilidades
                {
                    ID = 13,
                    Passiva = "If you hit 2 abilities in a row, stuns the enemy.",
                    Q = "Brand launches a fireball in the target direction that deals magic damage.",
                    W = "After a 0.625-second delay, Brand makes the target area erupt in flames.",
                    E = "Sets the target enemy aflame, dealing magic damage.",
                    R = "Launches a fireball at the target enemy that bounces between nearby enemies up to four times.",
                    IdChampion = 13
                },

                new Habilidades
                {
                    ID = 14,
                    Passiva = "Marks the enemy. After 4 basic attacks hit the marked champion, it stuns him.",
                    Q = "Propels ice from his shield in the target direction, dealing magic damage.",
                    W = "Braum dashes to the target ally.",
                    E =
                        "Braum raises his shield in the target direction, creating a barrier that reduces the damage he takes.",
                    R = "Leaps into the air and slams his shield into the ground knocking anyone on the way.",
                    IdChampion = 14
                },

                new Habilidades
                {
                    ID = 15,
                    Passiva = "Her basics do bonus damage after 6 hits.",
                    Q = "Fires a projectile in the target direction that deals physical damage.",
                    W = "Places a trap on the map. If a champion is caught, Caitlyn will do bonus damage.",
                    E = "Caitlyn fires a net and recoils 400 units in the opposite direction.",
                    R = "Fires a homing projectile toward the target that deals physical damage.",
                    IdChampion = 15
                },

                new Habilidades
                {
                    ID = 16,
                    Passiva = "Grants an adaptive shield.",
                    Q = "Camille's next basic attack has 175 range, deals bonus physical damage.",
                    W =
                        "After a brief delay, Camille sweeps her leg to deal physical damage to all enemies in a cone in front of her.",
                    E = "Camille can dash and go throgh walls.",
                    R = "Traps target on a hexagonal zone.",
                    IdChampion = 16
                },

                new Habilidades
                {
                    ID = 17,
                    Passiva = "Gains 4 - 72 (based on level) base movement speed.",
                    Q =
                        "After a 0.4-second delay, Cassiopeia blasts the target area with poison, dealing magic damage.",
                    W = "Cassiopeia spits forth eight bolts of venom in an arc.",
                    E =
                        "Cassiopeia launches her fangs at the target enemy, dealing them 52 - 120 (based on level) (+ 10% AP) magic damage.",
                    R = "Cassiopeia blasts enemies in a cone in the target direction, dealing magic damage.",
                    IdChampion = 17
                },

                new Habilidades
                {
                    ID = 18,
                    Passiva =
                        "Whenever Cho'Gath kills an enemy or destroys a structure, he restores 20 - 71 (based on level) health.",
                    Q = "Causes the target area to rupture after a 0.625 seconds delay and knocks them up.",
                    W = "Roars in the target direction, dealing magic damage to enemies.",
                    E = "Cho'Gath's next 3 basic attacks within 6 seconds have 50 bonus range.",
                    R = "Attempts to eat the target enemy, dealing true damage.",
                    IdChampion = 18
                },

                new Habilidades
                {
                    ID = 19,
                    Passiva = "Basic attacks do 20% AD and 80% AP damage.",
                    Q = "Corki launches a bomb at the target area, dealing magic damage.",
                    W = "Corki dashes to the target location, dropping bombs.",
                    E = "Corki activates his gatling gun and sprays bullets in a cone in front of him for 4 seconds.",
                    R = "Fires a missile in a line that explodes if it hits an enemy.",
                    IdChampion = 19
                },

                new Habilidades
                {
                    ID = 20,
                    Passiva = "Darius' basic attacks and damaging abilities cause enemies to bleed for 5 seconds.",
                    Q = "Spins his axe around him doing physical damage.",
                    W = "Darius' next basic attack within 4 seconds gains 25 bonus range.",
                    E = "Pulls enemy champions towards him.",
                    R = "Attempts to execute the targeted enemy champion, dealing true damage.",
                    IdChampion = 20
                },

                new Habilidades
                {
                    ID = 21,
                    Passiva = "Casting an ability grants Diana bonus attack speed.",
                    Q = "Unleashes a bolt of lunar energy that travels in an arc, dealing magic damage.",
                    W = "Diana shields herself for up to 5 seconds.",
                    E = "Increases the attack speed gained from passive.",
                    R = "Diana dashes to the target enemy, dealing magic damage.",
                    IdChampion = 21
                },

                new Habilidades
                {
                    ID = 22,
                    Passiva = "Passively regenerates 0.3% of his maximum health each second.",
                    Q = "Dr. Mundo hurls a cleaver in the target direction, dealing magic damage.",
                    W = "Sets himself on fire, dealing magic damage to nearby enemies.",
                    E = "Dr. Mundo gains bonus attack damage for 5 seconds.",
                    R = "Regenerates health for 12 seconds and gains bonus movement speed.",
                    IdChampion = 22
                },

                new Habilidades
                {
                    ID = 23,
                    Passiva = "Using Q gets him stacks. If he kills a champion, gains extra gold based on the stacks.",
                    Q = "His next basic attack within 5.8 seconds deal bonus attack damage.",
                    W = "Gains bonus attack and movement speed.",
                    E = "Draven throws his axes in a line, dealing physical damage.",
                    R = "Draven hurls two massive axes in the target direction.",
                    IdChampion = 23
                },

                new Habilidades
                {
                    ID = 24,
                    Passiva = "Gains bonus movement speed after 3 basics.",
                    Q = "Ekko throws a device in the target direction, dealing magic damage.",
                    W = "Shields himself if the ability hits him.",
                    E = "Ekko dashes towards the target location.",
                    R = "Goes back to where he was 4 seconds ago, healing himself.",
                    IdChampion = 24
                },

                new Habilidades
                {
                    ID = 25,
                    Passiva = "Basic attacks do bonus damage",
                    Q = "summons a venom-gorged spider for 3 seconds.",
                    W = "Elise fires a web in the target direction that stuns.",
                    E = "Elise transforms into a menacing spider.",
                    R = "Elise transforms into her human form.",
                    IdChampion = 25
                },

                new Habilidades
                {
                    ID = 26,
                    Passiva = "After level 6 Eve becomes inviseble.",
                    Q = "Launchs a dart in the target direction.",
                    W = "Evelynn curses the target champion for 5 seconds.",
                    E = "Dashes toward the target enemy.",
                    R = "Dashes back 725 units dealing magic damage",
                    IdChampion = 26
                },

                new Habilidades
                {
                    ID = 27,
                    Passiva = "Ezreal gains bonus attack speed every time he hits his abilities.",
                    Q = "Fires a bolt of energy in a line, dealing physical damage to the first enemy hit.",
                    W = "Fires a wave of energy in a line, dealing magic damage to enemy champions struck.",
                    E = "Ezreal blinks to the target location.",
                    R = "Ezreal fires an energy projectile in the target direction.",
                    IdChampion = 27
                },

                new Habilidades
                {
                    ID = 28,
                    Passiva =
                        "Standing still or channeling abilities for 1.5 seconds grants Fiddlesticks bonus movement speed.",
                    Q = "Fiddlesticks causes the target enemy to be feared.",
                    W = "Deals magic damage each second, and heals himself for a percentage of the damage done.",
                    E = "Sends a crow to the target enemy that bounces to nearby enemies up to 5 times.",
                    R =
                        "Fiddlesticks blinks to the target location with a murder of crows flying wildly around him for 5 seconds.",
                    IdChampion = 28
                },

                new Habilidades
                {
                    ID = 29,
                    Passiva = "If she hits a basic, deals true damage and heals her.",
                    Q = "Fiora dashes a short distance in the target direction, then stabs a nearby enemy.",
                    W = "Parries in the target direction, becoming invulnerable.",
                    E =
                        "Fiora's next two basic attacks within 4 seconds have 175 attack range and 50% bonus attack speed.",
                    R = "Can heal of her basic attacks.",
                    IdChampion = 29
                },

                new Habilidades
                {
                    ID = 30,
                    Passiva = "Takes 4 - 14 (based on level) less physical damage from basic attacks.",
                    Q = "Dashes a fixed distance towards the target enemy.",
                    W = "Fizz's next basic attack is empowered.",
                    E = "Vaults towards the target location, becoming Playful untargetable for 0.75 seconds.",
                    R =
                        "Throws a lure forward in a line that attracts a shark, causing it to emerge after 2 seconds, dealing magic damage.",
                    IdChampion = 30
                },

                new Habilidades
                {
                    ID = 31,
                    Passiva = "Galio's next basic attack deals more damage.",
                    Q = "Fires two windblasts that arc to either side before converging to the target area.",
                    W = "Gains a shield that exclusively absorbs magic damage.",
                    E = "Dashes forward, stopping upon hitting terrain or an enemy champion.",
                    R = "Dashes to targeted ally champion.",
                    IdChampion = 31
                },

                new Habilidades
                {
                    ID = 32,
                    Passiva = "Gangplank's next basic attack burns the target with true damage.",
                    Q = "Shoots the target enemy with his pistol, dealing physical damage.",
                    W = "Eats oranges that heal and remove all Crowd Control.",
                    E = "Places a powder keg.",
                    R = "Fires from above 12 waves of canon balls.",
                    IdChampion = 32
                },

                new Habilidades
                {
                    ID = 33,
                    Passiva = "Ok so he has 2 forms. I'm not gonna write all down here",
                    Q = "Just google it.",
                    W = "Trust me, it would be hard to write it all.",
                    E = "Besides, no one plays gnar.",
                    R = "He's so out of meta. OMEGALOL.",
                    IdChampion = 33
                },

                new Habilidades
                {
                    ID = 34,
                    Passiva = "Gragas heals for 6% maximum health upon using an ability.",
                    Q = "Rolls a cask to the target location dealing magic damage.",
                    W = "Gragas reduces incoming damage for 2.5 seconds.",
                    E = "Charges forward, dealing magic damage to all nearby enemies upon colliding.",
                    R = "Gragas hurls a cask for 0.55 seconds to the target location exploding on impact.",
                    IdChampion = 34
                },

                new Habilidades
                {
                    ID = 35,
                    Passiva = "Graves' shotgun holds up to 2 shells. After 2 shots he needs to reload.",
                    Q = "Fires a round in the target direction that deals physical damage.",
                    W = "Fires a smoke canister at the target area that blinds enemies on the area.",
                    E = "Graves dashes in the target direction, resetting his attack timer.",
                    R = "Fires an explosive shell in the target direction, dealing physical damage.",
                    IdChampion = 35
                },

                new Habilidades
                {
                    ID = 36,
                    Passiva = "The more movement speed he has the more attack damage he gains.",
                    Q = "Cleaves nearby enemies, dealing physical damage.",
                    W = "Hecarim surrounds himself with the spirit of dread for 4 seconds.",
                    E =
                        "Gains bonus movement speed for 4 seconds, beginning at 25% and increasing to 75% over 3 seconds.",
                    R = "Hecarim summons spectral riders and dashes in the target direction with them.",
                    IdChampion = 36
                },

                new Habilidades
                {
                    ID = 37,
                    Passiva = "Gains 20% bonus movement speed while near allied turrets or his own.",
                    Q = "Heimerdinger deploys a H-28G Evolution Turret at the target location.",
                    W = "Heimerdinger unleashes a wave of 5 rockets that converge to the target location.",
                    E = "Hurls a grenade at the target location, dealing magic damage, stunning them oh hit.",
                    R = "Heimerdinger empowers his next basic ability.",
                    IdChampion = 37
                },

                new Habilidades
                {
                    ID = 38,
                    Passiva = "Periodically spawns a Tentacle on nearby impassable terrain.",
                    Q = "Illaoi slams her idol into the ground.",
                    W =
                        "Illaoi's next basic attack within 6 seconds gains 225 bonus range and causes her to dash to her target.",
                    E = "Illaoi unleashes a tentacle in the target direction",
                    R =
                        "Leaps into the air before slamming her idol into the ground, dealing physical damage to nearby enemies.",
                    IdChampion = 38
                },

                new Habilidades
                {
                    ID = 39,
                    Passiva = "Deal more damage the more basic attacks she hits.",
                    Q = "Irelia dashes through the target enemy, dealing physical damage.",
                    W = "Irelia swipes with her blades in the target direction, dealing physical damage.",
                    E = "Sends a blade to the target location for up to 3.5 seconds. If hit by 2 they get stun.",
                    R = "Irelia launches a barrage of blades through a wide line in the target direction.",
                    IdChampion = 39
                },

                new Habilidades
                {
                    ID = 40,
                    Passiva = "Nothing that really matters. No one plays this champ.",
                    Q = "He throws a stun.",
                    W = "Ivern grows a patch of brush at the target location.",
                    E = "Shields ally or himself.",
                    R = "Ivern summons his sentinel friend.",
                    IdChampion = 40
                }
            };
            habilidade.ForEach(aa => context.Habilidades.AddOrUpdate(a => a.ID, aa));
            context.SaveChanges();

            var skin = new List<Skins>
            {
                new Skins
                {
                    ID = 1,
                    Nome1 = "Justicar Aatrox",
                    Img1 = "http://ddragon.leagueoflegends.com/cdn/img/champion/splash/Aatrox_1.jpg",
                    Nome2 = "Mecha Aatrox",
                    Img2 = "http://ddragon.leagueoflegends.com/cdn/img/champion/splash/Aatrox_2.jpg",
                    ChampId = 1
                },
                new Skins
                {
                    ID = 2,
                    Nome1 = "Arcade Ahri",
                    Img1 = "http://ddragon.leagueoflegends.com/cdn/img/champion/splash/Ahri_7.jpg",
                    Nome2 = "Popstar Ahri",
                    Img2 = "http://ddragon.leagueoflegends.com/cdn/img/champion/splash/Ahri_4.jpg",
                    ChampId = 2
                },
                new Skins
                {
                    ID = 4,
                    Nome1 = "Moo Cow Alistar",
                    Img1 = "http://ddragon.leagueoflegends.com/cdn/img/champion/splash/Alistar_10.jpg",
                    Nome2 = "Infernal Alistar",
                    Img2 = "http://ddragon.leagueoflegends.com/cdn/img/champion/splash/Alistar_6.jpg",
                    ChampId = 4
                },
                new Skins
                {
                    ID = 5,
                    Nome1 = "Surprise Party Amumu",
                    Img1 = "http://ddragon.leagueoflegends.com/cdn/img/champion/splash/Amumu_8.jpg",
                    Nome2 = "Little Knight Amumu",
                    Img2 = "http://ddragon.leagueoflegends.com/cdn/img/champion/splash/Amumu_6.jpg",
                    ChampId = 5
                },
                new Skins
                {
                    ID = 6,
                    Nome1 = "Team Spirit Anivia",
                    Img1 = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Anivia_1.jpg",
                    Nome2 = "Black Frost Anivia",
                    Img2 = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Anivia_5.jpg",
                    ChampId = 6
                },
                new Skins
                {
                    ID = 7,
                    Nome1 = "Hextech Annie",
                    Img1 = "http://ddragon.leagueoflegends.com/cdn/img/champion/splash/Annie_10.jpg",
                    Nome2 = "Panda Annie",
                    Img2 = "http://ddragon.leagueoflegends.com/cdn/img/champion/splash/Annie_8.jpg",
                    ChampId = 7
                },
                new Skins
                {
                    ID = 3,
                    Nome1 = "Blood Moon Akali",
                    Img1 = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Akali_5.jpg",
                    Nome2 = "Silver Fang Akali",
                    Img2 = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Akali_6.jpg",
                    ChampId = 3
                },
                new Skins
                {
                    ID = 8,
                    Nome1 = "Project Ashe",
                    Img1 = "http://ddragon.leagueoflegends.com/cdn/img/champion/splash/Ashe_8.jpg",
                    Nome2 = "Heartseeker Ashe",
                    Img2 = "http://ddragon.leagueoflegends.com/cdn/img/champion/splash/Ashe_6.jpg",
                    ChampId = 8
                },
                new Skins
                {
                    ID = 9,
                    Nome1 = "Ashen Lord",
                    Img1 = "http://ddragon.leagueoflegends.com/cdn/img/champion/splash/AurelionSol_1.jpg",
                    Nome2 = "Default",
                    Img2 = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/AurelionSol_0.jpg",
                    ChampId = 9
                },
                new Skins
                {
                    ID = 10,
                    Nome1 = "Galatic Azir",
                    Img1 = "http://ddragon.leagueoflegends.com/cdn/img/champion/splash/Azir_1.jpg",
                    Nome2 = "SKT T1 Azir",
                    Img2 = "http://ddragon.leagueoflegends.com/cdn/img/champion/splash/Azir_3.jpg",
                    ChampId = 10
                },
                new Skins
                {
                    ID = 11,
                    Nome1 = "Snow Day Bard",
                    Img1 = "https://www.mobafire.com/images/champion/skins/landscape/bard-snow-day.jpg",
                    Nome2 = "Bard Bard",
                    Img2 = "https://www.mobafire.com/images/champion/skins/landscape/bard-bard.jpg",
                    ChampId = 11
                },
                new Skins
                {
                    ID = 12,
                    Nome1 = "Definitely not Blitzcrank",
                    Img1 = "http://ddragon.leagueoflegends.com/cdn/img/champion/splash/Blitzcrank_5.jpg",
                    Nome2 = "iBlitz",
                    Img2 = "http://ddragon.leagueoflegends.com/cdn/img/champion/splash/Blitzcrank_6.jpg",
                    ChampId = 12
                },
                new Skins
                {
                    ID = 13,
                    Nome1 = "Zombie Brand",
                    Img1 = "http://ddragon.leagueoflegends.com/cdn/img/champion/splash/Brand_4.jpg",
                    Nome2 = "Battle Boss Brand",
                    Img2 = "http://ddragon.leagueoflegends.com/cdn/img/champion/splash/Brand_6.jpg",
                    ChampId = 13
                },
                new Skins
                {
                    ID = 14,
                    Nome1 = "El Tigre Braum",
                    Img1 = "http://ddragon.leagueoflegends.com/cdn/img/champion/splash/Braum_2.jpg",
                    Nome2 = "Santa Braum",
                    Img2 = "https://www.mobafire.com/images/champion/skins/landscape/braum-santa.jpg",
                    ChampId = 14
                },
                new Skins
                {
                    ID = 15,
                    Nome1 = "HeadHunter Caitlyn",
                    Img1 = "http://ddragon.leagueoflegends.com/cdn/img/champion/splash/Caitlyn_6.jpg",
                    Nome2 = "Safari Caitlyn",
                    Img2 = "http://ddragon.leagueoflegends.com/cdn/img/champion/splash/Caitlyn_3.jpg",
                    ChampId = 15
                },
                new Skins
                {
                    ID = 16,
                    Nome1 = "Program Camille",
                    Img1 = "http://ddragon.leagueoflegends.com/cdn/img/champion/splash/Camille_1.jpg",
                    Nome2 = "Default",
                    Img2 = "http://ddragon.leagueoflegends.com/cdn/img/champion/splash/Camille_0.jpg",
                    ChampId = 16
                },
                new Skins
                {
                    ID = 17,
                    Nome1 = "Jade Fang Cassiopeia",
                    Img1 = "http://ddragon.leagueoflegends.com/cdn/img/champion/splash/Cassiopeia_4.jpg",
                    Nome2 = "Mythic Cassiopeia",
                    Img2 = "http://ddragon.leagueoflegends.com/cdn/img/champion/splash/Cassiopeia_3.jpg",
                    ChampId = 17
                },
                new Skins
                {
                    ID = 18,
                    Nome1 = "BattleCast Prime Cho'Gath",
                    Img1 = "http://ddragon.leagueoflegends.com/cdn/img/champion/splash/Chogath_5.jpg",
                    Nome2 = "Gentleman Cho'Gath",
                    Img2 = "http://ddragon.leagueoflegends.com/cdn/img/champion/splash/Chogath_2.jpg",
                    ChampId = 18
                },
                new Skins
                {
                    ID = 19,
                    Nome1 = "Arcade Corki",
                    Img1 = "http://ddragon.leagueoflegends.com/cdn/img/champion/splash/Corki_8.jpg",
                    Nome2 = "Red Baron Corki",
                    Img2 = "http://ddragon.leagueoflegends.com/cdn/img/champion/splash/Corki_3.jpg",
                    ChampId = 19
                },
                new Skins
                {
                    ID = 20,
                    Nome1 = "DunkMaster Darius",
                    Img1 = "http://ddragon.leagueoflegends.com/cdn/img/champion/splash/Darius_4.jpg",
                    Nome2 = "Lorde Darius",
                    Img2 = "http://ddragon.leagueoflegends.com/cdn/img/champion/splash/Darius_1.jpg",
                    ChampId = 20
                },
                new Skins
                {
                    ID = 21,
                    Nome1 = "Infernal Diana",
                    Img1 = "http://ddragon.leagueoflegends.com/cdn/img/champion/splash/Diana_3.jpg",
                    Nome2 = "Lunar Goddness Diana",
                    Img2 = "http://ddragon.leagueoflegends.com/cdn/img/champion/splash/Diana_2.jpg",
                    ChampId = 21
                },
                new Skins
                {
                    ID = 22,
                    Nome1 = "PoolParty Mundo",
                    Img1 = "http://ddragon.leagueoflegends.com/cdn/img/champion/splash/DrMundo_8.jpg",
                    Nome2 = "Mundo Mundo",
                    Img2 = "http://ddragon.leagueoflegends.com/cdn/img/champion/splash/DrMundo_4.jpg",
                    ChampId = 22
                },
                new Skins
                {
                    ID = 23,
                    Nome1 = "PoolParty Draven",
                    Img1 = "http://ddragon.leagueoflegends.com/cdn/img/champion/splash/Draven_4.jpg",
                    Nome2 = "Draven Draven",
                    Img2 = "http://ddragon.leagueoflegends.com/cdn/img/champion/splash/Draven_6.jpg",
                    ChampId = 23
                },
                new Skins
                {
                    ID = 24,
                    Nome1 = "Sandstorm Ekko",
                    Img1 = "http://ddragon.leagueoflegends.com/cdn/img/champion/splash/Ekko_1.jpg",
                    Nome2 = "Project Ekko",
                    Img2 = "http://ddragon.leagueoflegends.com/cdn/img/champion/splash/Ekko_3.jpg",
                    ChampId = 24
                },
                new Skins
                {
                    ID = 25,
                    Nome1 = "SKT T1 Elise",
                    Img1 = "http://ddragon.leagueoflegends.com/cdn/img/champion/splash/Elise_4.jpg",
                    Nome2 = "Blood Moon Elise",
                    Img2 = "http://ddragon.leagueoflegends.com/cdn/img/champion/splash/Elise_3.jpg",
                    ChampId = 25
                },
                new Skins
                {
                    ID = 26,
                    Nome1 = "Tango Evelynn",
                    Img1 = "http://ddragon.leagueoflegends.com/cdn/img/champion/splash/Evelynn_3.jpg",
                    Nome2 = "Shadow Evelynn",
                    Img2 = "http://ddragon.leagueoflegends.com/cdn/img/champion/splash/Evelynn_1.jpg",
                    ChampId = 26
                },
                new Skins
                {
                    ID = 27,
                    Nome1 = "Arcade Ezreal",
                    Img1 = "http://ddragon.leagueoflegends.com/cdn/img/champion/splash/Ezreal_9.jpg",
                    Nome2 = "Pulsefire Ezreal",
                    Img2 = "http://ddragon.leagueoflegends.com/cdn/img/champion/splash/Ezreal_5.jpg",
                    ChampId = 27
                },
                new Skins
                {
                    ID = 28,
                    Nome1 = "Union Jack Fiddle",
                    Img1 = "http://ddragon.leagueoflegends.com/cdn/img/champion/splash/Fiddlesticks_2.jpg",
                    Nome2 = "Surprise Party Fiddle",
                    Img2 = "http://ddragon.leagueoflegends.com/cdn/img/champion/splash/Fiddlesticks_6.jpg",
                    ChampId = 28
                },
                new Skins
                {
                    ID = 29,
                    Nome1 = "Pool Party Fiora",
                    Img1 = "http://ddragon.leagueoflegends.com/cdn/img/champion/splash/Fiora_5.jpg",
                    Nome2 = "Project Fiora",
                    Img2 = "http://ddragon.leagueoflegends.com/cdn/img/champion/splash/Fiora_4.jpg",
                    ChampId = 29
                },
                new Skins
                {
                    ID = 30,
                    Nome1 = "Fisherman Fizz",
                    Img1 = "http://ddragon.leagueoflegends.com/cdn/img/champion/splash/Fizz_3.jpg",
                    Nome2 = "Tundra Fizz",
                    Img2 = "http://ddragon.leagueoflegends.com/cdn/img/champion/splash/Fizz_2.jpg",
                    ChampId = 30
                },
                new Skins
                {
                    ID = 31,
                    Nome1 = "Birdio",
                    Img1 = "http://ddragon.leagueoflegends.com/cdn/img/champion/splash/Galio_6.jpg",
                    Nome2 = "Debonair Galio",
                    Img2 = "http://ddragon.leagueoflegends.com/cdn/img/champion/splash/Galio_5.jpg",
                    ChampId = 31
                },
                new Skins
                {
                    ID = 32,
                    Nome1 = "Sailor GangPlank",
                    Img1 = "http://ddragon.leagueoflegends.com/cdn/img/champion/splash/Gangplank_3.jpg",
                    Nome2 = "Spooky GangPlank",
                    Img2 = "http://ddragon.leagueoflegends.com/cdn/img/champion/splash/Gangplank_1.jpg",
                    ChampId = 32
                },
                new Skins
                {
                    ID = 33,
                    Nome1 = "Gentleman Gnar",
                    Img1 = "http://ddragon.leagueoflegends.com/cdn/img/champion/splash/Gnar_2.jpg",
                    Nome2 = "Dino Gnar",
                    Img2 = "http://ddragon.leagueoflegends.com/cdn/img/champion/splash/Gnar_1.jpg",
                    ChampId = 33
                },
                new Skins
                {
                    ID = 34,
                    Nome1 = "HillBilly Gragas",
                    Img1 = "http://ddragon.leagueoflegends.com/cdn/img/champion/splash/Gragas_2.jpg",
                    Nome2 = "Scuba Gragas",
                    Img2 = "http://ddragon.leagueoflegends.com/cdn/img/champion/splash/Gragas_1.jpg",
                    ChampId = 34
                },
                new Skins
                {
                    ID = 35,
                    Nome1 = "PoolParty Graves",
                    Img1 = "http://ddragon.leagueoflegends.com/cdn/img/champion/splash/Graves_5.jpg",
                    Nome2 = "Snow Day Graves",
                    Img2 = "http://ddragon.leagueoflegends.com/cdn/img/champion/splash/Graves_7.jpg",
                    ChampId = 35
                },
                new Skins
                {
                    ID = 36,
                    Nome1 = "Arcade Hecarim",
                    Img1 = "http://ddragon.leagueoflegends.com/cdn/img/champion/splash/Hecarim_4.jpg",
                    Nome2 = "Reaper Hecarim",
                    Img2 = "http://ddragon.leagueoflegends.com/cdn/img/champion/splash/Hecarim_2.jpg",
                    ChampId = 36
                },
                new Skins
                {
                    ID = 37,
                    Nome1 = "Snowmerdinger",
                    Img1 = "http://ddragon.leagueoflegends.com/cdn/img/champion/splash/Heimerdinger_4.jpg",
                    Nome2 = "Hazmat Heimer",
                    Img2 = "http://ddragon.leagueoflegends.com/cdn/img/champion/splash/Heimerdinger_5.jpg",
                    ChampId = 37
                },
                new Skins
                {
                    ID = 38,
                    Nome1 = "Void Binger Illaoi",
                    Img1 = "http://ddragon.leagueoflegends.com/cdn/img/champion/splash/Illaoi_1.jpg",
                    Nome2 = "Mecha Illaoi",
                    Img2 = "http://ddragon.leagueoflegends.com/cdn/img/champion/splash/Illaoi_2.jpg",
                    ChampId = 38
                },
                new Skins
                {
                    ID = 39,
                    Nome1 = "Night Blade Irelia",
                    Img1 = "http://ddragon.leagueoflegends.com/cdn/img/champion/splash/Irelia_1.jpg",
                    Nome2 = "Infiltrator Irelia",
                    Img2 = "http://ddragon.leagueoflegends.com/cdn/img/champion/splash/Irelia_3.jpg",
                    ChampId = 39
                },
                new Skins
                {
                    ID = 40,
                    Nome1 = "Candy King Ivern",
                    Img1 = "http://ddragon.leagueoflegends.com/cdn/img/champion/splash/Ivern_1.jpg",
                    Nome2 = "Default",
                    Img2 = "http://ddragon.leagueoflegends.com/cdn/img/champion/splash/Ivern_0.jpg",
                    ChampId = 40
                }
            };
            skin.ForEach(aa => context.Skins.AddOrUpdate(a => a.ID, aa));
            context.SaveChanges();
        }
    }
}