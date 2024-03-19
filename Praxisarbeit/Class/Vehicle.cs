using Praxisarbeit.Interfaces;

namespace Praxisarbeit.Class
{
    public class Vehicle : IVehicle
    {
        public string Name { get; set; }
        public int MaxCapacity { get; set; }
        public int FreeSpace { get; private set; }
        public ILocation CurrentLocation { get; set; } // Hier wird das Interface ILocation verwendet
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
                Console.WriteLine($"Container geladen auf {Name}.");
                FreeSpace--;
            }
            else
            {
                Console.WriteLine($"Kein Platz mehr auf {Name} für weitere Container.");
            }
        }

        public void MoveTo(ILocation location)
        {
            Console.WriteLine($"{Name} bewegt sich zum Standort ({location.X}, {location.Y}).");
            // Aktualisieren der aktuellen Position des Fahrzeugs
            CurrentLocation = location;
        }

        public void Unload()
        {
            Console.WriteLine($"Container entladen von {Name}.");
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
