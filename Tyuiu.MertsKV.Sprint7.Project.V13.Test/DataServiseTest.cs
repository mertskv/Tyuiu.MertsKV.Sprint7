using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Xml.Linq;
using Tyuiu.MertsKV.Sprint7.Project.V13.Lib;
namespace Tyuiu.MertsKV.Sprint7.Project.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void LoadFromCSVTest()
        {
            DataService ds = new DataService();

            string tempFile = Path.GetTempFileName();

            File.WriteAllText(tempFile, "Название;Столица;Площадь;Население;Плотность;Национальность;Развитая\nРоссия;Москва;1000;100;1;Русские;true");

            try
            {
                ds.LoadFromCsv(tempFile);

                Assert.AreEqual(1, ds.Countries.Count);
                Assert.AreEqual("Россия", ds.Countries[0].Name);
            }
            finally
            {
                File.Delete(tempFile);
            }
        }



        [TestMethod]
        public void GetStatistickAreaTest()
        {
            DataService ds = new DataService();

            ds.Countries.Add(new Country { Name = "Россия", Area = 1000 });
            ds.Countries.Add(new Country { Name = "Германия", Area = 200 });
            ds.Countries.Add(new Country { Name = "Бразилия", Area = 800 });

            string result = ds.GetStatisticsArea();

            Assert.IsTrue(result.Contains("Самая большая: Россия"));
            Assert.IsTrue(result.Contains("Самая маленькая: Германия"));
        }



        [TestMethod]
        public void GetStatisticsPopulationTest()
        {
            DataService ds = new DataService();

            ds.Countries.Add(new Country { Name = "Китай", Population = 1400000000 });
            ds.Countries.Add(new Country { Name = "Россия", Population = 40000 });

            string result = ds.GetStatisticsPopulation();

            Assert.IsTrue(result.Contains("Китай"));
            Assert.IsTrue(result.Contains("Россия"));
        }



        [TestMethod]
        public void GetStatisticsDevelopedTest()
        {

            DataService ds = new DataService();
            ds.Countries.Add(new Country { Name = "Россия", IsDeveloped = true });
            ds.Countries.Add(new Country { Name = "Германия", IsDeveloped = true });
            ds.Countries.Add(new Country { Name = "Бразилия", IsDeveloped = false });

            string result = ds.GetStatisticsDeveloped();

            Assert.IsTrue(result.Contains("Развитых стран: 2 из 3"));
        }



        [TestMethod]
        public void SaveToCsvTest()
        {
            DataService ds = new DataService();
            ds.Countries.Add(new Country
            {
                Name = "Россия",
                Capital = "Москва",
                Area = 100,
                Population = 1000,
                Population_density = 10,
                MainNationality = "Русские",
                IsDeveloped = true
            });

            string tempFile = Path.GetTempFileName();

            try
            {
                ds.SaveToCsv(tempFile);

                string content = File.ReadAllText(tempFile);
                Assert.IsTrue(content.Contains("Россия"));
                Assert.IsTrue(content.Contains("Москва"));
            }
            finally
            {
                File.Delete(tempFile);
            }
        }

        [TestMethod]
        public void SortPopulationHighToLowTest()
        {
            DataService ds = new DataService();

            ds.Countries.Add(new Country { Name = "Россия", Population = 100 });
            ds.Countries.Add(new Country { Name = "Бразилия", Population = 300 });
            ds.Countries.Add(new Country { Name = "Германия", Population = 200 });

            ds.SortPopulationHighToLow();

            Assert.AreEqual("Бразилия", ds.Countries[0].Name);
            Assert.AreEqual("Германия", ds.Countries[1].Name);
            Assert.AreEqual("Россия", ds.Countries[2].Name);
        }

        [TestMethod]
        public void SortPopulationLowToHighTest()
        {
            DataService ds = new DataService();

            ds.Countries.Add(new Country { Name = "Россия", Population = 300 });
            ds.Countries.Add(new Country { Name = "Германия", Population = 100 });
            ds.Countries.Add(new Country { Name = "Бразилия", Population = 200 });

            ds.SortPopulationLowToHigh();

            Assert.AreEqual("Германия", ds.Countries[0].Name);
            Assert.AreEqual("Бразилия", ds.Countries[1].Name);
            Assert.AreEqual("Россия", ds.Countries[2].Name);
        }

        [TestMethod]
        public void FindCountryNameTest()
        {
            DataService ds = new DataService();

            ds.Countries.Add(new Country { Name = "Россия" });
            ds.Countries.Add(new Country { Name = "Германия" });
            ds.Countries.Add(new Country { Name = "Бразилия" });

            int index = ds.FindCountryName("Германия");

            Assert.AreEqual(1, index);
        }

        [TestMethod]
        public void DevelopedFilter_OnlyDevelopedTrue_FiltersCorrectly()
        {
            DataService ds = new DataService();

            ds.Countries.Add(new Country { Name = "Россия", IsDeveloped = true });
            ds.Countries.Add(new Country { Name = "Бразилия", IsDeveloped = false });
            ds.Countries.Add(new Country { Name = "Япония", IsDeveloped = true });

            ds.DevelopedFilter(true);

            Assert.AreEqual(2, ds.Countries.Count);
        }
    }


}




