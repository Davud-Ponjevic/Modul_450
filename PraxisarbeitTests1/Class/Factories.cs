using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraxisarbeitTests1.Class
{
    using global::PraxisarbeitTests1.Mocks;
    using Praxisarbeit.Class;
    using Praxisarbeit.Interfaces;

    namespace PraxisarbeitTests1.Factories
    {
        public interface IContainerFactory
        {
            IContainer GetContainer();
        }

        public class MockContainerFactory : IContainerFactory
        {
            public IContainer GetContainer()
            {
                return new MockContainer();
            }
        }

        public class ConcreteContainerFactory : IContainerFactory
        {
            public IContainer GetContainer()
            {
                return new Container(); // Hier wird die konkrete Container-Implementierung zurückgegeben
            }
        }
    }

}
