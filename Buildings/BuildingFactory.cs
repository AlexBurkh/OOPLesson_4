using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buildings
{
    public class BuildingFactory
    {
        private BuildingFactory() { }

        private static Hashtable _buildings = new Hashtable();
        public static Hashtable Buildings { get { return _buildings; } }
        public static void CreateBuilding(Double height, Int32 numOfFloors, Int32 numOfFlats, Int32 numOfEntrances)
        {
            Building b = new Building(height, numOfFloors, numOfFlats, numOfEntrances);
            _buildings.Add(b.Id, b);
        }
        public static void CreateBuilding(Double height, Int32 numOfFlats, Int32 numOfEntrances)
        {
            Building b = new Building(height, numOfFlats, numOfEntrances);
            _buildings.Add(b.Id, b);
        }
    }
}
