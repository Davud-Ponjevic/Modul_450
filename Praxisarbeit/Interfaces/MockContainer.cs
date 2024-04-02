using Praxisarbeit.Interfaces;

namespace PraxisarbeitTests1.Mocks
{
    public class MockContainer : IContainer
    {
        public int ID { get; private set; }

        public MockContainer(int id)
        {
            ID = id;
        }

        public MockContainer()
        {
        }
    }
}
