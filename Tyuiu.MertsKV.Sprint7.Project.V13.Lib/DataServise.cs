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

            // Пропускаем заголовок
            foreach (var line in lines.Skip(1))
            {
                var values = line.Split(';');

                // Проверяем, что в строке достаточно значений
                if (values.Length < 7)
                    continue; // Пропускаем строки с недостаточным количеством данных

                var country = new Country
                {
                    Name = values[0],
                    Capital = values[1],
                    // Безопасный парсинг с заменой точки/запятой
                    Area = SafeParseDouble(values[2]),
                    Population = SafeParseInt(values[3]),
                    Population_density = SafeParseDouble(values[4]),
                    MainNationality = values[5],
                    // Безопасный парсинг bool
                    IsDeveloped = SafeParseBool(values[6]),
                };
                Countries.Add(country);
            }
        }

        // Добавьте эти методы в класс DataService для безопасного парсинга
        private double SafeParseDouble(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                return 0;

            // Заменяем запятую на точку для корректного парсинга
            value = value.Replace(',', '.');

            if (double.TryParse(value, System.Globalization.NumberStyles.Any,
                System.Globalization.CultureInfo.InvariantCulture, out double result))
                return result;

            return 0; // Возвращаем 0 при ошибке вместо исключения
        }

        private int SafeParseInt(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                return 0;

            if (int.TryParse(value, out int result))
                return result;

            return 0; // Возвращаем 0 при ошибке вместо исключения
        }

        private bool SafeParseBool(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                return false;

            value = value.Trim().ToLower();

            // Поддерживаем разные форматы
            return value == "true" || value == "1" || value == "да" || value == "yes";
        }

        public List<Country> SearchAll(string searchText)
        {
            var result = new List<Country>();
            string searchLower = searchText.ToLower();

            foreach (var country in Countries)
            {
                if (country.Name.ToLower().Contains(searchLower) ||
                    country.Capital.ToLower().Contains(searchLower) ||
                    country.MainNationality.ToLower().Contains(searchLower) ||
                    country.Area.ToString().Contains(searchText) ||
                    country.Population.ToString().Contains(searchText))
                {
                    result.Add(country);
                }
            }

            return result;
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
                    $"{country.IsDeveloped}");
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








