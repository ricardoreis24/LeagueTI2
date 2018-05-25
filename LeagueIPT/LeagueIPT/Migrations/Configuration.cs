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
                    Nome = "Aatrox",
                    Nick = "The Darkin Blade",
                    ReleaseDate = new DateTime(2013,06,13),
                    Atributo = "Melee",
                    Health = "580 - 2025",
                    Range = 125,
                    AttackDamage = "70 – 124.4",
                    AttackSpeed = "0.651  (+ 0 – 51%)",
                    MovSpeed = 345,
                    Role = "Diver",
                    Descricao = "Aatrox? Is this a champion? I dont know cause nobody plays this sh*t... ",
                    Imagem = "https://vignette.wikia.nocookie.net/leagueoflegends/images/6/67/Aatrox_OriginalCentered.jpg/revision/latest/scale-to-width-down/1215?cb=20180414201907",
                    ProfilePic = "https://vignette.wikia.nocookie.net/leagueoflegends/images/9/9f/Aatrox_OriginalCircle.png/revision/latest?cb=20171112084905"

                },
                
                new Champions
                {
                    ID = 2,
                    Nome = "Ahri",
                    Nick = "The Nine-Tailed Fox",
                    ReleaseDate = new DateTime(2011,12,14),
                    Atributo = "Ranged",
                    Health = "526 – 2090",
                    Range = 550,
                    AttackDamage = "53 – 104",
                    AttackSpeed = "0.668  (+ 0 – 34%)",
                    MovSpeed = 330,
                    Role = "Mage",
                    Descricao = "Easy champ to play, girls love her. She has 3 dashes so you could run away...",
                    Imagem = "https://vignette.wikia.nocookie.net/leagueoflegends/images/f/f1/Ahri_OriginalCentered.jpg/revision/latest/scale-to-width-down/1215?cb=20180414201908",
                    ProfilePic = "https://vignette.wikia.nocookie.net/leagueoflegends/images/2/2c/Ahri_OriginalCircle.png/revision/latest?cb=20171112084906"

                },

                new Champions
                {
                    ID = 3,
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
                    Descricao = "Q + Basic ... ops you're dead. Also you can be invisible with your W and you can run way with R.",
                    Imagem = "https://vignette.wikia.nocookie.net/leagueoflegends/images/c/c5/Akali_OriginalCentered.jpg/revision/latest/scale-to-width-down/1215?cb=20180414201909",
                    ProfilePic = "https://vignette.wikia.nocookie.net/leagueoflegends/images/c/cf/Akali_OriginalCircle.png/revision/latest?cb=20171112084906"

                },

                new Champions
                {
                    ID = 4,
                    Nome = "Alistar",
                    Nick = "The Minotaur",
                    ReleaseDate = new DateTime(2009,02,21),
                    Atributo = "Melee",
                    Health = "613.4 – 2415.4",
                    Range = 125,
                    AttackDamage = "61.1 – 122.7",
                    AttackSpeed = "0.625  (+ 0 – 36.1%)",
                    MovSpeed = 330,
                    Role = "Support",
                    Descricao = "It's a cow... what more can I say",
                    Imagem = "https://vignette.wikia.nocookie.net/leagueoflegends/images/c/c5/Akali_OriginalCentered.jpg/revision/latest/scale-to-width-down/1215?cb=20180414201909",
                    ProfilePic = "https://vignette.wikia.nocookie.net/leagueoflegends/images/9/92/Alistar_OriginalCircle.png/revision/latest?cb=20171112084906"

                },

                new Champions
                {
                    ID = 5,
                    Nome = "Amumu",
                    Nick = "The Sad Mummy",
                    ReleaseDate = new DateTime(2009,06,26),
                    Atributo = "Melee",
                    Health = "613.1 – 2041.1",
                    Range = 125,
                    AttackDamage = "53.4 – 118",
                    AttackSpeed = "0.638  (+ 15.3 – 52.4%)",
                    MovSpeed = 335,
                    Role = "Tank",
                    Descricao = "Tank jungle always crying with an ok ult if used correctly",
                    Imagem = "https://vignette.wikia.nocookie.net/leagueoflegends/images/c/c5/Akali_OriginalCentered.jpg/revision/latest/scale-to-width-down/1215?cb=20180414201909",
                    ProfilePic = "https://vignette.wikia.nocookie.net/leagueoflegends/images/e/ee/Amumu_OriginalCircle.png/revision/latest?cb=20171112084907"

                },

                new Champions
                {
                    ID = 6,
                    Nome = "Anivia",
                    Nick = "The Cryophoenix",
                    ReleaseDate = new DateTime(2009,07,10),
                    Atributo = "Ranged",
                    Health = "480 – 1874",
                    Range = 600,
                    AttackDamage = "51.4 – 105.8",
                    AttackSpeed = "0.625  (+ 0 – 28.6%)",
                    MovSpeed = 325,
                    Role = "Mage",
                    Descricao = "Boring champion... Her passive is AIDS, if you die you became an Egg and you dont die. You have to kill her and kill her again in Egg form...",
                    Imagem = "https://vignette.wikia.nocookie.net/leagueoflegends/images/c/c5/Akali_OriginalCentered.jpg/revision/latest/scale-to-width-down/1215?cb=20180414201909",
                    ProfilePic = "https://vignette.wikia.nocookie.net/leagueoflegends/images/0/05/Anivia_OriginalCircle.png/revision/latest?cb=20171112084907"

                },

                new Champions
                {
                    ID = 7,
                    Nome = "Annie",
                    Nick = "The Dark Child",
                    ReleaseDate = new DateTime(2009,02,21),
                    Atributo = "Ranged",
                    Health = "524 – 2020",
                    Range = 575,
                    AttackDamage = "50.4 – 95",
                    AttackSpeed = "0.579  (+ 0 – 23.1%)",
                    MovSpeed = 325,
                    Role = "Mage",
                    Descricao = "You have no items but you pressed R? Oh look, you got yourself a kill... Also, I feel asleep playing with her.",
                    Imagem = "https://vignette.wikia.nocookie.net/leagueoflegends/images/c/c5/Akali_OriginalCentered.jpg/revision/latest/scale-to-width-down/1215?cb=20180414201909",
                    ProfilePic = "https://vignette.wikia.nocookie.net/leagueoflegends/images/3/37/Annie_OriginalCircle.png/revision/latest?cb=20171112084908"

                },

                new Champions
                {
                    ID = 8,
                    Nome = "Ashe",
                    Nick = "The Frost Archer",
                    ReleaseDate = new DateTime(2009,02,21),
                    Atributo = "Ranged",
                    Health = "527.7 – 1870.7",
                    Range = 600,
                    AttackDamage = "65 – 103.4",
                    AttackSpeed = "0.658  (+ 0 – 56.6%)",
                    MovSpeed = 325,
                    Role = "Marksman",
                    Descricao = "Ashe has a good kit but nobody plays her, dont know why.",
                    Imagem = "https://vignette.wikia.nocookie.net/leagueoflegends/images/c/c5/Akali_OriginalCentered.jpg/revision/latest/scale-to-width-down/1215?cb=20180414201909",
                    ProfilePic = "https://vignette.wikia.nocookie.net/leagueoflegends/images/1/15/Ashe_OriginalCircle.png/revision/latest?cb=20171112084909"

                },

                new Champions
                {
                    ID = 9,
                    Nome = "Aurelion Sol",
                    Nick = "The Star Forger",
                    ReleaseDate = new DateTime(2016,03,24),
                    Atributo = "Ranged",
                    Health = "562 – 2126",
                    Range = 550,
                    AttackDamage = "57 – 111.4",
                    AttackSpeed = "0.625  (+ 0 – 23.1%)",
                    MovSpeed = 325,
                    Role = "Mage",
                    Descricao = "Boring champ... You just run with your W on, doing damage.",
                    Imagem = "https://vignette.wikia.nocookie.net/leagueoflegends/images/c/c5/Akali_OriginalCentered.jpg/revision/latest/scale-to-width-down/1215?cb=20180414201909",
                    ProfilePic = "https://vignette.wikia.nocookie.net/leagueoflegends/images/e/e4/Aurelion_Sol_OriginalCircle.png/revision/latest?cb=20171112084909"

                },

                new Champions
                {
                    ID = 10,
                    Nome = "Azir",
                    Nick = "The Emperor of the Sands",
                    ReleaseDate = new DateTime(2014,09,16),
                    Atributo = "Ranged",
                    Health = "552 – 2116",
                    Range = 525,
                    AttackDamage = "57 – 111.4",
                    AttackSpeed = "0.625  (+ 0 – 23.1%)",
                    MovSpeed = 335,
                    Role = "Mage",
                    Descricao = "Call him Donald Trump cause his Ult places a wall that kicks you back. Super effective against Mexicans",
                    Imagem = "https://vignette.wikia.nocookie.net/leagueoflegends/images/c/c5/Akali_OriginalCentered.jpg/revision/latest/scale-to-width-down/1215?cb=20180414201909",
                    ProfilePic = "https://vignette.wikia.nocookie.net/leagueoflegends/images/f/f9/Azir_OriginalCircle.png/revision/latest?cb=20171112084909"

                },

                new Champions
                {
                    ID = 11,
                    Nome = "Bard",
                    Nick = "The Wandering Caretaker",
                    ReleaseDate = new DateTime(2015,03,12),
                    Atributo = "Ranged",
                    Health = "535 – 2048",
                    Range = 500,
                    AttackDamage = "52 – 103",
                    AttackSpeed = "0.625  (+ 0 – 34%)",
                    MovSpeed = 330,
                    Role = "Support",
                    Descricao = "Good if you have him on your team.",
                    Imagem = "https://vignette.wikia.nocookie.net/leagueoflegends/images/c/c5/Akali_OriginalCentered.jpg/revision/latest/scale-to-width-down/1215?cb=20180414201909",
                    ProfilePic = "https://vignette.wikia.nocookie.net/leagueoflegends/images/c/cb/Bard_OriginalCircle.png/revision/latest?cb=20171112085141"

                },

                new Champions
                {
                    ID = 12,
                    Nome = "Blitzcrank",
                    Nick = "The Great Steam  Golem",
                    ReleaseDate = new DateTime(2009,09,02),
                    Atributo = "Melee",
                    Health = "582.6 – 2197.6",
                    Range = 125,
                    AttackDamage = "61.5 – 121",
                    AttackSpeed = "0.625  (+ 0 – 19.2%)",
                    MovSpeed = 325,
                    Role = "Support",
                    Descricao = "If he grabs you, you'll burn flash and you'll still die.",
                    Imagem = "https://vignette.wikia.nocookie.net/leagueoflegends/images/c/c5/Akali_OriginalCentered.jpg/revision/latest/scale-to-width-down/1215?cb=20180414201909",
                    ProfilePic = "https://vignette.wikia.nocookie.net/leagueoflegends/images/f/f7/Blitzcrank_OriginalCircle.png/revision/latest?cb=20171112085142"

                },

                new Champions
                {
                    ID = 13,
                    Nome = "Brand",
                    Nick = "The Burning Vengeance",
                    ReleaseDate = new DateTime(2011,04,12),
                    Atributo = "Ranged",
                    Health = "519.7 – 2015.7",
                    Range = 550,
                    AttackDamage = "57 – 108",
                    AttackSpeed = "0.625  (+ 0 – 19.2%)",
                    MovSpeed = 340,
                    Role = "Mage",
                    Descricao = "People who play Brand support have no life... You can quote me on that",
                    Imagem = "https://vignette.wikia.nocookie.net/leagueoflegends/images/c/c5/Akali_OriginalCentered.jpg/revision/latest/scale-to-width-down/1215?cb=20180414201909",
                    ProfilePic = "https://vignette.wikia.nocookie.net/leagueoflegends/images/6/6d/Brand_OriginalCircle.png/revision/latest?cb=20171112085143"

                },

                new Champions
                {
                    ID = 14,
                    Nome = "Braum",
                    Nick = "The Heart of the Freljord",
                    ReleaseDate = new DateTime(2014,05,12),
                    Atributo = "Melee",
                    Health = "576.2 – 2055.2",
                    Range = 125,
                    AttackDamage = "55.4 – 109.8",
                    AttackSpeed = "0.644  (+ 0 – 59.5%)",
                    MovSpeed = 335,
                    Role = "Support",
                    Descricao = "ahhhh you're safe with Braum.",
                    Imagem = "https://vignette.wikia.nocookie.net/leagueoflegends/images/c/c5/Akali_OriginalCentered.jpg/revision/latest/scale-to-width-down/1215?cb=20180414201909",
                    ProfilePic = "https://vignette.wikia.nocookie.net/leagueoflegends/images/f/f5/Braum_OriginalCircle.png/revision/latest?cb=20171112085143"

                },

                new Champions
                {
                    ID = 15,
                    Nome = "Caitlyn",
                    Nick = "The Sheriff of Piltover",
                    ReleaseDate = new DateTime(2011,01,04),
                    Atributo = "Ranged",
                    Health = "475 – 1920",
                    Range = 650,
                    AttackDamage = "62 – 99.1",
                    AttackSpeed = "0.568  (+ 10 – 78%)",
                    MovSpeed = 325,
                    Role = "Marksman",
                    Descricao = "W spam = easy kills",
                    Imagem = "https://vignette.wikia.nocookie.net/leagueoflegends/images/c/c5/Akali_OriginalCentered.jpg/revision/latest/scale-to-width-down/1215?cb=20180414201909",
                    ProfilePic = "https://vignette.wikia.nocookie.net/leagueoflegends/images/9/90/Caitlyn_OriginalCircle.png/revision/latest?cb=20171112085442"

                },

                new Champions
                {
                    ID = 16,
                    Nome = "Camille",
                    Nick = "The Steel Shadow",
                    ReleaseDate = new DateTime(2016,12,07),
                    Atributo = "Melee",
                    Health = "575.6 – 2020.6",
                    Range = 125,
                    AttackDamage = "68 – 127.5",
                    AttackSpeed = "0.644  (+ 0 – 42.5%)",
                    MovSpeed = 325,
                    Role = "Bruiser",
                    Descricao = "You design camille should be fired.",
                    Imagem = "https://vignette.wikia.nocookie.net/leagueoflegends/images/c/c5/Akali_OriginalCentered.jpg/revision/latest/scale-to-width-down/1215?cb=20180414201909",
                    ProfilePic = "https://vignette.wikia.nocookie.net/leagueoflegends/images/4/4c/Camille_OriginalCircle.png/revision/latest?cb=20171112085443"

                },

                new Champions
                {
                    ID = 17,
                    Nome = "Cassiopeia",
                    Nick = "The Serpent's Embrace",
                    ReleaseDate = new DateTime(2010,12,14),
                    Atributo = "Ranged",
                    Health = "537 – 2016",
                    Range = 550,
                    AttackDamage = "53 – 104",
                    AttackSpeed = "0.647  (+ 0 – 25.5%)",
                    MovSpeed = 328,
                    Role = "Mage",
                    Descricao = "Its a snake for gods sake.",
                    Imagem = "",
                    ProfilePic = "https://vignette.wikia.nocookie.net/leagueoflegends/images/2/2b/Cassiopeia_OriginalCircle.png/revision/latest?cb=20171112085443"

                },

                new Champions
                {
                    ID = 18,
                    Nome = "Cho'Gath",
                    Nick = "The Terror of the Void",
                    ReleaseDate = new DateTime(2009,06,26),
                    Atributo = "Melee",
                    Health = "574.4 – 1934.4",
                    Range = 125,
                    AttackDamage = "69 – 140.4",
                    AttackSpeed = "0.625  (+ 0 – 24.5%)",
                    MovSpeed = 345,
                    Role = "Tank",
                    Descricao = "Press R for a kill. Also you're tank as f*ck.",
                    Imagem = "",
                    ProfilePic = "https://vignette.wikia.nocookie.net/leagueoflegends/images/4/40/Cho%27Gath_OriginalCircle.png/revision/latest?cb=20171124185151"

                },

                new Champions
                {
                    ID = 19,
                    Nome = "Corki",
                    Nick = "The Daring Bombardier",
                    ReleaseDate = new DateTime(2009,09,19),
                    Atributo = "Ranged",
                    Health = "518 – 1997",
                    Range = 550,
                    AttackDamage = "60 – 111",
                    AttackSpeed = "0.638  (+ 0 – 39.1%)",
                    MovSpeed = 325,
                    Role = "Marksman",
                    Descricao = "He is fun, I guess",
                    Imagem = "",
                    ProfilePic = "https://vignette.wikia.nocookie.net/leagueoflegends/images/e/e9/Corki_OriginalCircle.png/revision/latest?cb=20171112085444"

                },

                new Champions
                {
                    ID = 20,
                    Nome = "Darius",
                    Nick = "The Hand of Noxus",
                    ReleaseDate = new DateTime(2012,05,23),
                    Atributo = "Melee",
                    Health = "582.2 – 2282.2",
                    Range = 175,
                    AttackDamage = "64 – 149",
                    AttackSpeed = "0.625  (+ 0 – 17%)",
                    MovSpeed = 340,
                    Role = "Tank",
                    Descricao = "Ahh do you like dunking on people? Than Darius is the champ for you.",
                    Imagem = "",
                    ProfilePic = "https://vignette.wikia.nocookie.net/leagueoflegends/images/f/f9/Darius_OriginalCircle.png/revision/latest?cb=20171112085445"

                },

                new Champions
                {
                    ID = 21,
                    Nome = "Diana",
                    Nick = "Scorn of the Moon",
                    ReleaseDate = new DateTime(2012,08,07),
                    Atributo = "Melee",
                    Health = "594 – 2209",
                    Range = 150,
                    AttackDamage = "53 – 104",
                    AttackSpeed = "0.625  (+ 0 – 38.3%)",
                    MovSpeed = 345,
                    Role = "Assassin",
                    Descricao = "Discount version of Akali with a bit more crowd control.",
                    Imagem = "",
                    ProfilePic = "https://vignette.wikia.nocookie.net/leagueoflegends/images/c/c6/Diana_OriginalCircle.png/revision/latest?cb=20171112085750"

                },

                new Champions
                {
                    ID = 22,
                    Nome = "Dr. Mundo",
                    Nick = "The Madman of Zaun",
                    ReleaseDate = new DateTime(2009,09,02),
                    Atributo = "Melee",
                    Health = "582.5 – 2095.5",
                    Range = 125,
                    AttackDamage = "61.3 – 120.8",
                    AttackSpeed = "0.625  (+ 15.3 – 62.9%)",
                    MovSpeed = 345,
                    Role = "Tank",
                    Descricao = "Please don't play Mundo, he's too tanky. Hard to kill.",
                    Imagem = "",
                    ProfilePic = "https://vignette.wikia.nocookie.net/leagueoflegends/images/4/47/Dr._Mundo_OriginalCircle.png/revision/latest?cb=20171112085751"

                },

                new Champions
                {
                    ID = 23,
                    Nome = "Draven",
                    Nick = "The Glorious Executioner",
                    ReleaseDate = new DateTime(2012,06,06),
                    Atributo = "Ranged",
                    Health = "557.8 – 1951.8",
                    Range = 550,
                    AttackDamage = "64 – 113.5",
                    AttackSpeed = "0.679  (+ 0 – 45.9%)",
                    MovSpeed = 330,
                    Role = "Marksman",
                    Descricao = "Draven does it all.......",
                    Imagem = "",
                    ProfilePic = "https://vignette.wikia.nocookie.net/leagueoflegends/images/d/d3/Draven_OriginalCircle.png/revision/latest?cb=20171112085750"

                },

                new Champions
                {
                    ID = 24,
                    Nome = "Ekko",
                    Nick = "The Boy Who Shattered Time",
                    ReleaseDate = new DateTime(2015,05,28),
                    Atributo = "Melee",
                    Health = "585 – 2030",
                    Range = 125,
                    AttackDamage = "64 – 113.5",
                    AttackSpeed = "0.625  (+ 10 – 66.1%)",
                    MovSpeed = 340,
                    Role = "Assassin",
                    Descricao = "You can one shot somebody and press R to go back to where you were a few moments back.",
                    Imagem = "",
                    ProfilePic = "https://vignette.wikia.nocookie.net/leagueoflegends/images/e/e3/Ekko_OriginalCircle.png/revision/latest?cb=20171112085751"

                },

                new Champions
                {
                    ID = 25,
                    Nome = "Elise",
                    Nick = "The Spider Queen",
                    ReleaseDate = new DateTime(2012,10,26),
                    Atributo = "Ranged",
                    Health = "534 – 1979",
                    Range = 550,
                    AttackDamage = "55 – 106",
                    AttackSpeed = "0.625  (+ 0 – 29.8%)",
                    MovSpeed = 325,
                    Role = "Mage",
                    Descricao = "You build tank and you deal tons of damage.",
                    Imagem = "",
                    ProfilePic = "https://vignette.wikia.nocookie.net/leagueoflegends/images/3/30/Elise_OriginalCircle.png/revision/latest?cb=20171112085752"

                },

                new Champions
                {
                    ID = 26,
                    Nome = "Evelynn",
                    Nick = "Agony's Embrace",
                    ReleaseDate = new DateTime(2009,05,01),
                    Atributo = "Melee",
                    Health = "572 – 2000",
                    Range = 125,
                    AttackDamage = "61 – 112",
                    AttackSpeed = "0.667  (+ 0 – 35.7%)",
                    MovSpeed = 335,
                    Role = "Mage",
                    Descricao = "After level 6 you're invisible. I hate people who play her.",
                    Imagem = "",
                    ProfilePic = "https://vignette.wikia.nocookie.net/leagueoflegends/images/8/88/Evelynn_OriginalCircle.png/revision/latest?cb=20171112085752"

                },

                new Champions
                {
                    ID = 27,
                    Nome = "Ezreal",
                    Nick = "The Prodigal Explorer",
                    ReleaseDate = new DateTime(2010,03,16),
                    Atributo = "Ranged",
                    Health = "484.4 – 1844.4",
                    Range = 550,
                    AttackDamage = "64 – 105",
                    AttackSpeed = "0.625  (+ 0 – 25.5%)",
                    MovSpeed = 325,
                    Role = "Marksman",
                    Descricao = "Bad if you don't hit skill shots.",
                    Imagem = "",
                    ProfilePic = "https://vignette.wikia.nocookie.net/leagueoflegends/images/f/fb/Ezreal_OriginalCircle.png/revision/latest?cb=20171112085753"

                },

                new Champions
                {
                    ID = 28,
                    Nome = "Fiddlesticks",
                    Nick = "The Harbinger of Doom",
                    ReleaseDate = new DateTime(2009,02,21),
                    Atributo = "Ranged",
                    Health = "524.4 – 1884.4",
                    Range = 480,
                    AttackDamage = "48.4 – 93",
                    AttackSpeed = "0.625  (+ 0 – 35.9%)",
                    MovSpeed = 335,
                    Role = "Mage",
                    Descricao = "He is annoying to play against.",
                    Imagem = "",
                    ProfilePic = "https://vignette.wikia.nocookie.net/leagueoflegends/images/4/43/Fiddlesticks_OriginalCircle.png/revision/latest?cb=20171112090226"

                },

                new Champions
                {
                    ID = 29,
                    Nome = "Fiora",
                    Nick = "The Prodigal Explorer",
                    ReleaseDate = new DateTime(2012,02,29),
                    Atributo = "Melee",
                    Health = "550 – 1995",
                    Range = 150,
                    AttackDamage = "68 – 124.1",
                    AttackSpeed = "0.69  (+ 0 – 54.4%)",
                    MovSpeed = 345,
                    Role = "Bruiser",
                    Descricao = "Has a dash every few seconds plus deals trillions of damage while she heals for billions.",
                    Imagem = "",
                    ProfilePic = "https://vignette.wikia.nocookie.net/leagueoflegends/images/c/ce/Fiora_OriginalCircle.png/revision/latest?cb=20171112090227"

                },

                new Champions
                {
                    ID = 30,
                    Nome = "Fizz",
                    Nick = "The Tidal Trickster",
                    ReleaseDate = new DateTime(2011,11,15),
                    Atributo = "Melee",
                    Health = "570 – 2236",
                    Range = 175,
                    AttackDamage = "58 – 109",
                    AttackSpeed = "0.658  (+ 0 – 52.7%)",
                    MovSpeed = 335,
                    Role = "Assassin",
                    Descricao = "This champ should not be in the game. Has an ability that makes him invulnerable every few seconds",
                    Imagem = "",
                    ProfilePic = "https://vignette.wikia.nocookie.net/leagueoflegends/images/8/84/Fizz_OriginalCircle.png/revision/latest?cb=20171112090227"

                },

                new Champions
                {
                    ID = 31,
                    Nome = "Galio",
                    Nick = "The Colossus",
                    ReleaseDate = new DateTime(2010,08,10),
                    Atributo = "Melee",
                    Health = "562 – 2466",
                    Range = 150,
                    AttackDamage = "59 – 118.5",
                    AttackSpeed = "0.625  (+ 0 – 25.5%)",
                    MovSpeed = 335,
                    Role = "Tank",
                    Descricao = "A tank that does damage. Thank you Riot Design team for this 'balanced' champion",
                    Imagem = "",
                    ProfilePic = "https://vignette.wikia.nocookie.net/leagueoflegends/images/8/82/Galio_OriginalCircle.png/revision/latest?cb=20171112090228"

                },

                new Champions
                {
                    ID = 32,
                    Nome = "Gangplank",
                    Nick = "The Saltwater Scourge",
                    ReleaseDate = new DateTime(2009,08,19),
                    Atributo = "Melee",
                    Health = "540 – 1934",
                    Range = 125,
                    AttackDamage = "64 – 115",
                    AttackSpeed = "0.658  (+ 0 – 54.4%)",
                    MovSpeed = 345,
                    Role = "Bruiser",
                    Descricao = "Super fun to play. I love Gangplank because of Tobias fate. Google search him",
                    Imagem = "",
                    ProfilePic = "https://vignette.wikia.nocookie.net/leagueoflegends/images/6/65/Gangplank_OriginalCircle.png/revision/latest?cb=20171112090228"

                },

                new Champions
                {
                    ID = 33,
                    Nome = "Gnar",
                    Nick = "The Missing Link",
                    ReleaseDate = new DateTime(2014,08,14),
                    Atributo = "Ranged",
                    Health = "510 – 1615",
                    Range = 175,
                    AttackDamage = "59 – 110",
                    AttackSpeed = "0.625  (+ 5.5 – 107.5%)",
                    MovSpeed = 325,
                    Role = "Tank",
                    Descricao = "Omg he's so cute.... oh wtf he just transform himself into a big monster",
                    Imagem = "",
                    ProfilePic = "https://vignette.wikia.nocookie.net/leagueoflegends/images/a/aa/Gnar_OriginalCircle.png/revision/latest?cb=20171112090229"

                },

                new Champions
                {
                    ID = 34,
                    Nome = "Gragas",
                    Nick = "The Rabble Rouser",
                    ReleaseDate = new DateTime(2010,02,02),
                    Atributo = "Melee",
                    Health = "583.5 – 2096.5",
                    Range = 125,
                    AttackDamage = "61.4 – 120.9",
                    AttackSpeed = "0.625  (+ 8 – 42.8%)",
                    MovSpeed = 330,
                    Role = "Tank",
                    Descricao = "A fat Irish who is tank and loves beer... not even kidding",
                    Imagem = "",
                    ProfilePic = "https://vignette.wikia.nocookie.net/leagueoflegends/images/e/e4/Gragas_OriginalCircle.png/revision/latest?cb=20171112090230"

                },

                new Champions
                {
                    ID = 35,
                    Nome = "Graves",
                    Nick = "The Outlaw",
                    ReleaseDate = new DateTime(2011,10,19),
                    Atributo = "Ranged",
                    Health = "551.1 – 2115.1",
                    Range = 425,
                    AttackDamage = "69 – 120",
                    AttackSpeed = "0.481  (+ 0 – 44.2%)",
                    MovSpeed = 340,
                    Role = "Marksman",
                    Descricao = "His ult is too strong",
                    Imagem = "",
                    ProfilePic = "https://vignette.wikia.nocookie.net/leagueoflegends/images/3/36/Graves_OriginalCircle.png/revision/latest?cb=20171112090230"

                },

                new Champions
                {
                    ID = 36,
                    Nome = "Hecarim",
                    Nick = "The Shadow of War",
                    ReleaseDate = new DateTime(2012,04,18),
                    Atributo = "Melee",
                    Health = "	580 – 2110",
                    Range = 175,
                    AttackDamage = "66 – 120.4",
                    AttackSpeed = "0.67  (+ 0 – 42.5%)",
                    MovSpeed = 345,
                    Role = "Bruiser",
                    Descricao = "My little poney...",
                    Imagem = "",
                    ProfilePic = "https://vignette.wikia.nocookie.net/leagueoflegends/images/8/83/Hecarim_OriginalCircle.png/revision/latest?cb=20171112090231"

                },

                new Champions
                {
                    ID = 37,
                    Nome = "Heimerdinger",
                    Nick = "The Revered Inventor",
                    ReleaseDate = new DateTime(2009,10,10),
                    Atributo = "Ranged",
                    Health = "488 – 1967",
                    Range = 550,
                    AttackDamage = "55.5 – 101.4",
                    AttackSpeed = "0.625  (+ 0 – 23.1%)",
                    MovSpeed = 340,
                    Role = "Mage",
                    Descricao = "THE DONGER!!!",
                    Imagem = "",
                    ProfilePic = "https://vignette.wikia.nocookie.net/leagueoflegends/images/8/8e/Heimerdinger_OriginalCircle.png/revision/latest?cb=20171112090709"

                },

                new Champions
                {
                    ID = 38,
                    Nome = "Illaoi",
                    Nick = "The Kraken Priestess",
                    ReleaseDate = new DateTime(2015,11,24),
                    Atributo = "Melee",
                    Health = "585.6 – 2200.6",
                    Range = 125,
                    AttackDamage = "68 – 153",
                    AttackSpeed = "0.571  (+ 0 – 42.5%)",
                    MovSpeed = 340,
                    Role = "Bruiser",
                    Descricao = "She has tentacles. People you enjoy hentai play her a lot (xD)",
                    Imagem = "",
                    ProfilePic = "https://vignette.wikia.nocookie.net/leagueoflegends/images/2/21/Illaoi_OriginalCircle.png/revision/latest?cb=20171112090710"

                },

                new Champions
                {
                    ID = 39,
                    Nome = "Irelia",
                    Nick = "The Blade Dancer",
                    ReleaseDate = new DateTime(2010,11,16),
                    Atributo = "Melee",
                    Health = "550 – 1995",
                    Range = 200,
                    AttackDamage = "60 – 128",
                    AttackSpeed = "0.625  (+ 0 – 42.5%)",
                    MovSpeed = 340,
                    Role = "Bruiser",
                    Descricao = "Yeah she's good I guess",
                    Imagem = "",
                    ProfilePic = "https://vignette.wikia.nocookie.net/leagueoflegends/images/5/59/Irelia_OriginalCircle.png/revision/latest?cb=20180320200353"

                },

                new Champions
                {
                    ID = 40,
                    Nome = "Ivern",
                    Nick = "The Green Father",
                    ReleaseDate = new DateTime(2016,10,05),
                    Atributo = "Melee",
                    Health = "585 – 2200",
                    Range = 125,
                    AttackDamage = "50 – 101",
                    AttackSpeed = "0.644  (+ 0 – 57.8%)",
                    MovSpeed = 325,
                    Role = "Support",
                    Descricao = "You're a tree... You plays this champ??? You're a f*ucking tree. Who design this shoul've of been high at the moment.",
                    Imagem = "",
                    ProfilePic = "https://vignette.wikia.nocookie.net/leagueoflegends/images/5/5f/Ivern_OriginalCircle.png/revision/latest?cb=20171112090711"

                },

            };
            champ.ForEach(aa => context.Champions.AddOrUpdate(a => a.Nome, aa));
            context.SaveChanges();
        }
    }
}
