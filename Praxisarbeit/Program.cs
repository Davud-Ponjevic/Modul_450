using Praxisarbeit.Class;
using Praxisarbeit.Interfaces;
using System;
using System.Collections.Generic;

namespace Praxisarbeit
{
    class Program
    {
        static void Main(string[] args)
        {
            // Beispiel für Fahrzeuge
            IVehicle vehicle1 = new Vehicle("Fahrzeug1", 10, new Location(0, 0));
            IVehicle vehicle2 = new Vehicle("Fahrzeug2", 8, new Location(5, 5));

            // Beispiel für eine Liste von Containern
            List<IContainer> containers = new List<IContainer>();
            containers.Add(new Container()); // Beispiel für das Hinzufügen von Containern zur Liste

            // Beispiel für einen Auftrag
            IOrder order = new Order("Standort1", "Standort2", containers);

            // Ausführen des Auftrags
            ExecuteOrder(order, vehicle1);

            Console.ReadLine();
        }

        static void ExecuteOrder(IOrder order, IVehicle vehicle)
        {
            // Beispiel für die Ausführung eines Auftrags
            vehicle.MoveTo(new Location(1, 1)); // Fahrzeug bewegt sich zu einem neuen Standort
            vehicle.Load((Container)order.Containers[0]); // Ein Container wird geladen
            vehicle.MoveTo(new Location(2, 2)); // Fahrzeug bewegt sich zum Zielort
            vehicle.Unload(); // Container wird entladen
        }

    }
}
