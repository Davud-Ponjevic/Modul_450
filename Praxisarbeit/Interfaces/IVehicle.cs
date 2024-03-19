using Praxisarbeit.Class;

namespace Praxisarbeit.Interfaces;
public interface IVehicle
{
    string Name { get; set; }
    int MaxCapacity { get; set; }
    int FreeSpace { get; }
    Location CurrentLocation { get; set; }

    void Load(Container container);
    void MoveTo(Location location);
    void Unload();
}
