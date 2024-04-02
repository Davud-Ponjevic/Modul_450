using NUnit.Framework;
using NUnit.Framework;
using Praxisarbeit.Interfaces;
using Moq;
using System.Collections.Generic;

namespace Praxisarbeit.UnitTests
{
    [TestFixture]
    public class ContainerTests
    {
        [Test]
        public void Container_Creation_PositiveCase()
        {
            // Arrange
            IContainer container;

            // Act
            container = new Mock<IContainer>().Object;

            // Assert
            Assert.NotNull(container);
        }

        [Test]
        public void Container_Creation_NegativeCase()
        {
            // Arrange
            IContainer container = null;

            // Act

            // Assert
            Assert.Null(container);
        }
    }

    [TestFixture]
    public class LocationTests
    {
        [Test]
        public void Location_Creation_PositiveCase()
        {
            // Arrange
            ILocation location;

            // Act
            location = new Mock<ILocation>().Object;

            // Assert
            Assert.NotNull(location);
        }

        [Test]
        public void Location_Creation_NegativeCase()
        {
            // Arrange
            ILocation location = null;

            // Act

            // Assert
            Assert.Null(location);
        }
    }

    [TestFixture]
    public class OrderTests
    {
        [Test]
        public void Order_Creation_PositiveCase()
        {
            // Arrange
            IOrder order;
            List<IContainer> containers = new List<IContainer>();

            // Act
            order = new Mock<IOrder>().Object;

            // Assert
            Assert.NotNull(order);
        }

        [Test]
        public void Order_Creation_NegativeCase()
        {
            // Arrange
            IOrder order = null;

            // Act

            // Assert
            Assert.Null(order);
        }
    }

    [TestFixture]
    public class VehicleTests
    {
        [Test]
        public void Vehicle_Creation_PositiveCase()
        {
            // Arrange
            IVehicle vehicle;
            ILocation location = new Mock<ILocation>().Object;

            // Act
            vehicle = new Mock<IVehicle>().Object;

            // Assert
            Assert.NotNull(vehicle);
        }

        [Test]
        public void Vehicle_Creation_NegativeCase()
        {
            // Arrange
            IVehicle vehicle = null;

            // Act

            // Assert
            Assert.Null(vehicle);
        }
    }
}
