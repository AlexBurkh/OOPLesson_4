using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Building
    {
        private static Int32 _currentId = 0;
        private Int32 _id;
        private Double _height;
        private Int32 _numOfFloors;
        private Int32 _numOfFlats;
        private Int32 _numOfEntrances;

        
        public Int32 Id
        {
            get { return _id; }
        }
        public Double Height { get { return _height; } set { if (value > 0) _height = value; } }
        public Int32 NumOfFloors { get { return _numOfFloors; } set { if (value > 0) _numOfFloors = value; } }
        public Int32 NumOfFlats { get { return _numOfFlats; } set { if (value > 0) _numOfFlats = value; } }
        public Int32 NumOfEntrances { get { return _numOfEntrances; } set { if (value > 0) _numOfEntrances = value; } }

        public Double CountFloorHeight()
        {
            return _height / _numOfFloors;
        }
        public Int32 CountFlatsInEntrance()
        {
            return _numOfFlats / _numOfEntrances;
        }
        public Int32 CountFlatsOnFloor()
        {
            return _numOfFlats / _numOfFloors;
        }

        private Int32 GenerateId()
        {
            return _currentId++;
        }
    }
}
