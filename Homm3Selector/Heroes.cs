using System.IO;

namespace Homm3Selector
{
    internal class Heroes
    {
        private string? heroPath1;
        private string? heroPath2;
        private string? heroPath3;
        private int heroId1;
        private int heroId2;
        private int heroId3;
        private string? path;
        private string localPath = "C:\\Users\\AweSa\\source\\repos\\homm3\\homm3draft-master\\Homm3Selector\\images\\Heroes\\";
        private string[]? heroes;
        private int heroListLength;
        private string? heroName1;
        private string? heroName2;
        private string? heroName3;

        public void generateHeroes(int cityNumber)
        {
            //Switch case to get the paths of the selected cities heroes.
            switch (cityNumber)
            {
                case 0:
                    this.path = localPath + "Castle Heroes\\";
                    heroes = Directory.GetFiles(path);
                    heroListLength = heroes.Length;
                    break;
                case 1:
                    this.path = localPath + "Conflux Heroes\\";
                    heroes = Directory.GetFiles(path);
                    heroListLength = heroes.Length;
                    break;
                case 2:
                    this.path = localPath + "Cove Heroes\\";
                    heroes = Directory.GetFiles(path);
                    heroListLength = heroes.Length;
                    break;
                case 3:
                    this.path = localPath + "Dungeon Heroes\\";
                    heroes = Directory.GetFiles(path);
                    heroListLength = heroes.Length;
                    break;
                case 4:
                    this.path = localPath + "Factory Heroes\\";
                    heroes = Directory.GetFiles(path);
                    heroListLength = heroes.Length;
                    break;
                case 5:
                    this.path = localPath + "Fortress Heroes\\";
                    heroes = Directory.GetFiles(path);
                    heroListLength = heroes.Length;
                    break;
                case 6:
                    this.path = localPath + "Inferno Heroes\\";
                    heroes = Directory.GetFiles(path);
                    heroListLength = heroes.Length;
                    break;
                case 7:
                    this.path = localPath + "Necropolis Heroes\\";
                    heroes = Directory.GetFiles(path); 
                    heroListLength = heroes.Length;
                    break;
                case 8:
                    this.path = localPath + "Rampart Heroes\\";
                    heroes = Directory.GetFiles(path);
                    heroListLength = heroes.Length;
                    break;
                case 9:
                    this.path = localPath + "Stronghold Heroes\\";
                    heroes = Directory.GetFiles(path);
                    heroListLength = heroes.Length;
                    break;
                case 10:
                    this.path = localPath + "Tower Heroes\\";
                    heroes = Directory.GetFiles(path);
                    heroListLength = heroes.Length;
                    break;
            }

            //Generating 3 random hero ID's
            setHeroID();

            //Setting the hero paths and hero names
            setHeroPaths();
            setHeroNames();
        }

        public void setHeroPaths()
        {
            this.heroPath1 = heroes[heroId1];
            this.heroPath2 = heroes[heroId2];
            this.heroPath3 = heroes[heroId3];
        }
        public void setHeroNames()
        {
            this.heroName1 = heroes[heroId1];
            this.heroName1 = heroName1.Substring(heroName1.LastIndexOf("\\") + 1);
            this.heroName1 = heroName1.Substring(0, heroName1.Length - 4);
            this.heroName2 = heroes[heroId2];
            this.heroName2 = heroName2.Substring(heroName2.LastIndexOf("\\") + 1);
            this.heroName2 = heroName2.Substring(0, heroName2.Length - 4);
            this.heroName3 = heroes[heroId3];
            this.heroName3 = heroName3.Substring(heroName3.LastIndexOf("\\") + 1);
            this.heroName3 = heroName3.Substring(0, heroName3.Length - 4);
        }

        public void setHeroID()
        {
            Random rnd = new Random();

            this.heroId1 = rnd.Next(0, heroListLength);
            this.heroId2 = rnd.Next(0, heroListLength);
            while (heroId1 == heroId2)
            {
                this.heroId2 = rnd.Next(0, heroListLength);
            }
            this.heroId3 = rnd.Next(0, heroListLength);
            while (heroId2 == heroId3 || heroId3 == heroId1)
            {
                this.heroId3 = rnd.Next(0, heroListLength);
            }
        }

        public void heroes_refresh()
        {
            setHeroID();
            setHeroPaths();
            setHeroNames();
        }

        public string? getHeroPath1() { return heroPath1; }
        public string? getHeroPath2() { return heroPath2; }
        public string? getHeroPath3() { return heroPath3; }
        public string? getHeroname1() { return heroName1; }
        public string? getHeroname2() { return heroName2; }
        public string? getHeroname3() { return heroName3; }
    }
}
