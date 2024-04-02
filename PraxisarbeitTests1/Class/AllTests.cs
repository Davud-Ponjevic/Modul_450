using Microsoft.VisualStudio.TestTools.UnitTesting;
using Praxisarbeit.Class;
using Praxisarbeit.Interfaces;
using PraxisarbeitTests1.Class.PraxisarbeitTests1.Factories;
using PraxisarbeitTests1.Mocks;

namespace PraxisarbeitTests
{
    [TestClass]
    public class AllTests
    {
        [TestMethod]
        public void Location_Constructor_Success()
        {
            // Arrange
            int expectedX = 5;
            int expectedY = 10;

            // Act
            Location location = new Location(expectedX, expectedY);

            // Assert
            Assert.IsNotNull(location);
            Assert.AreEqual(expectedX, location.X);
            Assert.AreEqual(expectedY, location.Y);
        }

        [TestMethod]
        public void Location_Constructor_InvalidCoordinates_ExceptionThrown()
        {
            // Arrange & Act & Assert
            Assert.ThrowsException<ArgumentException>(() => new Location(-1, 0));
            Assert.ThrowsException<ArgumentException>(() => new Location(0, -1));
        }

        [TestMethod]
        public void Vehicle_Load_Success()
        {
            // Arrange
            ILocation location = new Location(0, 0);
            IVehicle vehicle = new Vehicle("Test Vehicle", 10, location);
            IContainerFactory factory = new ConcreteContainerFactory(); // Using concrete implementation
            IContainer container = factory.GetContainer();

            // Act
            vehicle.Load(container);

            // Assert
            Assert.AreEqual(9, vehicle.FreeSpace);
        }

        [TestMethod]
        public void OrderExecutionProcess_ExecutesOrder_Success()
        {
            // Arrange
            IOrder order = new Order("Location A", "Location B", new List<IContainer> { new MockContainer(), new MockContainer() });
            IVehicleFactory vehicleFactory = new MockVehicleFactory(); // Using mock vehicles
            OrderExecutionProcess process = new OrderExecutionProcess(vehicleFactory);

            // Act
            process.ExecuteOrder(order);

            // Assert
            // Add assertions as needed
        }

        // Other test methods...
    }
}
