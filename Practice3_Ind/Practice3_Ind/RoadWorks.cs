using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3_Ind
{
    public class RoadWorks
    {
        public double Width { get; set; }
        public double Length { get; set; }
        public double MassPerSquareMeter { get; set; }
        public int ID { get; set; }
        public string Material { get; set; }

        public RoadWorks(int id, double length, double width, double massPerSquareMeter, string material)
        {
            Width = width;
            Length = length;
            MassPerSquareMeter = massPerSquareMeter;
            ID = id;
            Material = material;
        }

        public virtual double CalculateQuality()
        {
            double result = (Width * Length * MassPerSquareMeter) / 1000;
            return Math.Round(result, 3);
        }

        public string Print()
        {
            return $"ID: {ID}, Ширина: {Width}, Длина: {Length}, Массс на 1 кв.м: {MassPerSquareMeter}, Материал: {Material}";
        }
        public static bool ContainsID(List<RoadWorks> roadWorksList, int id)
        {
            return roadWorksList.Any(rw => rw.ID == id);
        }
        public static void Add(List<RoadWorks> roadWorksList, RoadWorks roadWorks)
        {
            roadWorksList.Add(roadWorks);
        }

        public static void Add(List<RoadWorks> roadWorksList, int id, double length, double width, double massPerSquareMeter, string roadMaterial)
        {
            RoadWorks roadWorks = new RoadWorks(id, length, width, massPerSquareMeter, roadMaterial);
            roadWorksList.Add(roadWorks);
        }

        public static void Remove(List<RoadWorks> roadWorksList, RoadWorks roadWorks)
        {
            roadWorksList.Remove(roadWorks);
        }

        public static void RemoveById(List<RoadWorks> roadWorksList, int id)
        {
            RoadWorks roadWorks = roadWorksList.FirstOrDefault(rw => rw.ID == id);
            if (roadWorks != null)
                roadWorksList.Remove(roadWorks);
        }
    }
}
