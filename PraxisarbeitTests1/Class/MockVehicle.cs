using Praxisarbeit.Interfaces;

namespace Praxisarbeit.Class
{
    internal class MockVehicle : IVehicle
    {
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int MaxCapacity { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int FreeSpace => throw new NotImplementedException();

        public Location CurrentLocation { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Load(Container container)
        {
            throw new NotImplementedException();
        }

        public void Load(IContainer container)
        {
            throw new NotImplementedException();
        }

        public void MoveTo(Location location)
        {
            throw new NotImplementedException();
        }

        public void MoveTo(ILocation targetLocation)
        {
            throw new NotImplementedException();
        }

        public void Unload()
        {
            throw new NotImplementedException();
        }
    }
}