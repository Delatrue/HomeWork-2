using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4
{
    internal class BuildingDescription
    {
        private int _buildingNumber;
        private int _buildingHeight;
        private int _numberFloors;
        private int _numberFlats;
        private int _numberEntrances;
        private static int _buildNumber = 0;

        public int Building (int buildHeight, int buildFloors, int buildFlats, int buildEntrance )
        {
            _buildingNumber = ++_buildNumber;
            _buildingHeight = buildHeight;
            _numberFloors = buildFloors;
            _numberFlats = buildFlats;
            _numberEntrances = buildEntrance;
            Console.WriteLine(
                $"Номер дома: {_buildingNumber } \n" +
                $"Высота дома: {_buildingHeight } \n" +
                $"Число этажей: {_numberFloors} \n" +
                $"Число квартир: {_numberFlats } \n" +
                $"Число подъездов: {_numberEntrances } \n");
            return _buildNumber;
        }
        public void HeightFloor()
        {
            Console.WriteLine($"Высота этажа: {_buildingHeight /= _numberFloors} \n");
        }
        public void FlatsOnFloor()
        {
            Console.WriteLine($"Число квартир на этаже: {_numberFlats/ _numberFloors} \n");
        }
        public void FlatsInEntrance()
        {
            Console.WriteLine($"Число квартир в подьезде: {_numberFlats / _numberEntrances} \n");
        }
    }
}
