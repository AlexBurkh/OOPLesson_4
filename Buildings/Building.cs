using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buildings
{
    public class Building
    {
        internal Building(Double height, Int32 numOfFlats, Int32 numOfEntrances) : this(height, 5, numOfFlats, numOfEntrances) { }
        internal Building(Double height, Int32 numOfFloors, Int32 numOfFlats, Int32 numOfEntrances) 
        { 
            _id = GenerateId();
            _height = height;
            _numOfEntrances = numOfEntrances;
            _numOfFlats = numOfFlats;
            _numOfFloors = numOfFloors;
        }

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

        private static Int32 GenerateId()
        {
            return _currentId++;
        }
    }
}
