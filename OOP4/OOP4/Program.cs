using System;

namespace OOP4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BuildingDescription house = new BuildingDescription();
            house.Building(15, 5, 40, 2);
            house.HeightFloor();
            house.FlatsOnFloor();
            house.FlatsInEntrance();
        }
    }
}
