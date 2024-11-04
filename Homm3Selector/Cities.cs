using System.Threading;

namespace Homm3Selector
{
    internal class Cities
    {

        List<String> cities = ["Castle", "Conflux", "Cove", "Dungeon", "Factory", "Fortress", "Inferno", "Necropolis", "Rampart", "Stronghold", "Tower"];
        private string city1 = "not set";
        private string city2 = "not set";
        private string city3 = "not set";
        private int cityNumber1;
        private int cityNumber2;
        private int cityNumber3;

        //Method to create 3 random cities
        public void setCities()
        {
            Random rnd = new Random();

            this.cityNumber1 = rnd.Next(0, cities.Count());
            this.cityNumber2 = rnd.Next(0, cities.Count());
            
            while(cityNumber1 == cityNumber2)
            {
                this.cityNumber2 = rnd.Next(0, cities.Count());
            }

            this.cityNumber3 = rnd.Next(0, cities.Count());

            while (cityNumber2 == cityNumber3 || cityNumber3 == cityNumber1)
            {
                this.cityNumber3 = rnd.Next(0, cities.Count());
            }

            this.city1 = cities[cityNumber1];
            this.city2 = cities[cityNumber2];
            this.city3 = cities[cityNumber3];         
        }

        //Method to remove selected city from the list
        public void citySelect(int cityChosen)
        {
            if (cityChosen == 1) 
            { 
                cities.RemoveAt(getCityNr1());
            }
            else if (cityChosen == 2) 
            {
                cities.RemoveAt(getCityNr2());
            }
            else if (cityChosen == 3) 
            {
                cities.RemoveAt(getCityNr3());
            }
        }

        public string getCity1(){return city1;}
        public string getCity2(){return city2;}
        public string getCity3(){return city3;}
        public int getCityNr1(){return cityNumber1;}
        public int getCityNr2(){return cityNumber2;}
        public int getCityNr3(){return cityNumber3;}
    }
}
