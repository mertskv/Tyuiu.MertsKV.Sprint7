using System.ComponentModel;
using System.Diagnostics.Metrics;
namespace Tyuiu.MertsKV.Sprint7.Project.V13.Lib
{

    public class Country
    {
        public string Name { get; set; }
        public string Capital { get; set; }
        public double Area { get; set; }
        public int Population { get; set; }
        public double Population_density { get; set; }
        public string MainNationality { get; set; }
        public bool IsDeveloped { get; set; }
    }


    public class DataService
    {
        public BindingList<Country> Countries { get; private set; }
        public DataService()
        {
            Countries = new BindingList<Country>();
        }

        private BindingList<Country> originalCountries;


        public void LoadFromCsv(string filePath)
        {
            Countries.Clear();
            var lines = File.ReadAllLines(filePath, System.Text.Encoding.UTF8);
            foreach (var line in lines.Skip(1))
            {
                var values = line.Split(';');
                var country = new Country
                {
                    Name = values[0],
                    Capital = values[1],
                    Area = double.Parse(values[2]),
                    Population = int.Parse(values[3]),
                    Population_density = double.Parse(values[4]),
                    MainNationality = values[5],
                    IsDeveloped = bool.Parse(values[6]),
                };
                Countries.Add(country);
            }
        }



        public void SaveToCsv(string filePath)
        {
            var lines = new List<string> {
            "Название;Столица;Площадь;Население;Плотность населения;Преобладающая национальность;Развитая"
        };

            foreach (var country in Countries)
            {
                lines.Add($"{country.Name};{country.Capital};{country.Area};" +
                    $"{country.Population};{country.Population_density};{country.MainNationality};" +
                    $"{country.IsDeveloped};");
            }
            File.WriteAllLines(filePath, lines, System.Text.Encoding.UTF8);
        }



        public string GetStatisticsArea()
        {
            string result = "";

            result += "----------ПЛОЩАДЬ---------- \r\n\r\n";

            double maxArea = 0;
            string maxAreaName = "";
            foreach (Country country in Countries)
            {
                if (country.Area > maxArea)
                {
                    maxArea = country.Area;
                    maxAreaName = country.Name;
                }
            }
            result += $"Самая большая: {maxAreaName} ({maxArea} км²) \r\n";

            double minArea = 999999999;
            string minAreaName = "";
            foreach (Country country in Countries)
            {
                if (country.Area < minArea && country.Area > 0)
                {
                    minArea = country.Area;
                    minAreaName = country.Name;
                }
            }
            result += $"Самая маленькая: {minAreaName} ({minArea} км²) \r\n\r\n";
            return result;
        }



        public string GetStatisticsPopulation()
        {
            string result = "";

            result += "----------НАСЕЛЕНИЕ----------\r\n\r\n";

            int maxPopulation = 0;
            string maxPopulationName = "";
            foreach (Country country in Countries)
            {
                if (country.Population > maxPopulation)
                {
                    maxPopulation = country.Population;
                    maxPopulationName = country.Name;
                }
            }
            result += $"Самое большое население: {maxPopulationName} ({maxPopulation} чел.) \r\n";

            int minPopulation = 999999999;
            string minPopulationName = "";
            foreach (Country country in Countries)
            {
                if (country.Population < minPopulation && country.Population > 0)
                {
                    minPopulation = country.Population;
                    minPopulationName = country.Name;
                }
            }
            result += $"Самое маленькое население: {minPopulationName} ({minPopulation} чел.) \r\n\r\n";
            return result;
        }


        public string GetStatisticsDeveloped()
        {
            string result = "";

            result += "----------РАЗВИТОСТЬ----------\r\n\r\n";
            int developed = 0;
            foreach (Country country in Countries)
            {
                if (country.IsDeveloped == true)
                {
                    developed++;
                }
            }
            result += $"Развитых стран: {developed} из {Countries.Count}";

            return result;
        }


        public void SortPopulationHighToLow()
        {
            List<Country> tempList = new List<Country>();

            foreach (Country c in Countries)
            {
                tempList.Add(c);
            }

            for (int i = 0; i < tempList.Count - 1; i++)
            {
                for (int j = i + 1; j < tempList.Count; j++)
                {
                    if (tempList[i].Population < tempList[j].Population)
                    {
                        Country temp = tempList[i];
                        tempList[i] = tempList[j];
                        tempList[j] = temp;
                    }
                }
            }

            Countries.Clear();

            foreach (Country c in tempList)
            {
                Countries.Add(c);
            }
        }



        public void SortPopulationLowToHigh()
        {
            List<Country> tempList = new List<Country>();

            foreach (Country c in Countries)
            {
                tempList.Add(c);
            }

            for (int i = 0; i < tempList.Count - 1; i++)
            {
                for (int j = i + 1; j < tempList.Count; j++)
                {
                    if (tempList[i].Population > tempList[j].Population)
                    {
                        Country temp = tempList[i];
                        tempList[i] = tempList[j];
                        tempList[j] = temp;
                    }
                }
            }

            Countries.Clear();

            foreach (Country c in tempList)
            {
                Countries.Add(c);
            }
        }



        public int FindCountryName(string countryName)
        {
            for (int i = 0; i < Countries.Count; i++)
            {
                if (Countries[i].Name.ToLower() == countryName.ToLower())
                {
                    return i;
                }
            }
            return -1;
        }


        public void DevelopedFilter(bool OnlyDeveloped)
        {
            if (OnlyDeveloped)
            {
                if (originalCountries == null)
                {
                    originalCountries = new BindingList<Country>(Countries.ToList());
                }

                Countries.Clear();
                foreach (var country in originalCountries)
                {
                    if (country.IsDeveloped)
                    {
                        Countries.Add(country);
                    }
                }
            }
            else
            {
                if (originalCountries != null)
                {
                    Countries.Clear();
                    foreach (var country in originalCountries)
                    {
                        Countries.Add(country);
                    }
                    originalCountries = null;
                }
            }
        }
    }

}








