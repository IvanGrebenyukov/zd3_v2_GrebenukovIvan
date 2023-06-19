using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3_Ind
{
    public class WeatherRoadWorks : RoadWorks
    {
        public double StrengthCoefficient { get; set; }
        public string RoadType { get; set; }

        public WeatherRoadWorks(int id, double length, double width, double massPerSquareMeter, string material, double strengthCoefficient, string roadType)
            : base(id, length, width, massPerSquareMeter, material)
        {
            StrengthCoefficient = strengthCoefficient;
        }

        public override double CalculateQuality()
        {
            double baseQuality = base.CalculateQuality();
            double modifiedQuality;

            modifiedQuality = StrengthCoefficient >= 5 && StrengthCoefficient <= 8 ?
                baseQuality * 1.1 :
                (StrengthCoefficient == 3 || StrengthCoefficient == 4 || StrengthCoefficient == 9 || StrengthCoefficient == 10) ?
                    baseQuality * 1.6 :
                    1.9 * baseQuality;

            return Math.Round(modifiedQuality, 3);
        }
        public static bool ContainsID(List<WeatherRoadWorks> weatherRoadWorksList, int id)
        {
            return weatherRoadWorksList.Any(rw => rw.ID == id);
        }
        public new string Print()
        {
            return $"ID: {ID}, Длина: {Length}, Ширина: {Width}, Масса: {MassPerSquareMeter}, Материал: {Material}, Тип дороги: {RoadType}, Коэффициент прочности: {StrengthCoefficient}";
        }
        public static void Add(List<WeatherRoadWorks> weatherRoadWorksList, WeatherRoadWorks weatherRoadWorks)
        {
            weatherRoadWorksList.Add(weatherRoadWorks);
        }

        public static void Add(List<WeatherRoadWorks> weatherRoadWorksList, int id, double length, double width, double massPerSquareMeter, string roadMaterial, double strengthCoefficient, string roadType)
        {
            WeatherRoadWorks weatherRoadWorks = new WeatherRoadWorks(id, length, width, massPerSquareMeter, roadMaterial, strengthCoefficient, roadType );
            weatherRoadWorksList.Add(weatherRoadWorks);
        }

        public static void Remove(List<WeatherRoadWorks> weatherRoadWorksList, WeatherRoadWorks weatherRoadWorks)
        {
            weatherRoadWorksList.Remove(weatherRoadWorks);
        }

        public static void RemoveById(List<WeatherRoadWorks> weatherRoadWorksList, int id)
        {
            WeatherRoadWorks weatherRoadWorks = weatherRoadWorksList.FirstOrDefault(wrw => wrw.ID == id);
            if (weatherRoadWorks != null)
                weatherRoadWorksList.Remove(weatherRoadWorks);
        }
    }
}
