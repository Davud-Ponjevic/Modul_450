using Praxisarbeit.Interfaces;
using System;

namespace Praxisarbeit.Class
{
    public class Vehicle : IVehicle
    {
        public string Name { get; set; }
        public int MaxCapacity { get; set; }
        public int FreeSpace { get; private set; }
        public ILocation CurrentLocation { get; set; }
        Location IVehicle.CurrentLocation { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Vehicle(string name, int maxCapacity, ILocation initialLocation)
        {
            Name = name;
            MaxCapacity = maxCapacity;
            FreeSpace = MaxCapacity;
            CurrentLocation = initialLocation;
        }

        public void Load(IContainer container)
        {
            if (FreeSpace >= 1)
            {
                Console.WriteLine($"Container loaded onto {Name}.");
                FreeSpace--;
            }
            else
            {
                Console.WriteLine($"No more space on {Name} for additional containers.");
            }
        }

        public void MoveTo(ILocation location)
        {
            Console.WriteLine($"{Name} moving to location ({location.X}, {location.Y}).");
            CurrentLocation = location;
        }

        public void Unload()
        {
            Console.WriteLine($"Container unloaded from {Name}.");
            FreeSpace = MaxCapacity;
        }

        public void Load(Container container)
        {
            throw new NotImplementedException();
        }

        public void MoveTo(Location location)
        {
            throw new NotImplementedException();
        }
    }
}
