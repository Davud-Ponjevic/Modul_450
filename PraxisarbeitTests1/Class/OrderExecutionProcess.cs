using Praxisarbeit.Interfaces;
using System;
using System.Collections.Generic;

namespace Praxisarbeit.Class
{
    public class OrderExecutionProcess
    {
        private IVehicleFactory _vehicleFactory;

        public OrderExecutionProcess(IVehicleFactory vehicleFactory)
        {
            _vehicleFactory = vehicleFactory;
        }

        public void ExecuteOrder(IOrder order)
        {
            Console.WriteLine($"Executing order from {order.From} to {order.To}");

            IVehicle vehicle = _vehicleFactory.GetVehicle(); // Using factory method to get a vehicle
            foreach (var container in order.Containers)
            {
                if (vehicle.FreeSpace > 0)
                {
                    vehicle.Load(container);
                }
                else
                {
                    Console.WriteLine("No space left in vehicle. Unloading...");
                    vehicle.Unload();
                    vehicle.Load(container);
                }
            }

            // Move vehicle to destination
            vehicle.MoveTo(new Location(10, 10)); // Assuming destination location is (10, 10)

            // Unload containers at destination
            vehicle.Unload();
        }
    }

    // Factory interface for creating vehicles
    public interface IVehicleFactory
    {
        IVehicle GetVehicle();
    }

    // Implementations of IVehicleFactory
    public class MockVehicleFactory : IVehicleFactory
    {
        public IVehicle GetVehicle()
        {
            return new MockVehicle();
        }
    }

    public class ConcreteVehicleFactory : IVehicleFactory
    {
        public IVehicle GetVehicle()
        {
            return new Vehicle("Concrete Vehicle", 10, new Location(0, 0));
        }
    }
}
