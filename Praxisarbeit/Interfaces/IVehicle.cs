using NUnit.Framework;

using Praxisarbeit.Class;

namespace Praxisarbeit.Interfaces;
public interface IVehicle
{
    string Name { get; set; }
    int MaxCapacity { get; set; }
    int FreeSpace { get; }
    Location CurrentLocation { get; set; }

    void Load(Container container);
    void Load(IContainer container);
    void MoveTo(Location location);
    void MoveTo(ILocation targetLocation);
    void Unload();
}
