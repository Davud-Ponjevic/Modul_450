using System.Collections.Generic;
using Praxisarbeit.Interfaces;
using NUnit.Framework;

namespace Praxisarbeit.Class
{
    public class Order : IOrder
    {
        public string From { get; set; }
        public string To { get; set; }
        public List<IContainer> Containers { get; set; } // Ändern Sie den Rückgabetyp entsprechend

        public Order(string from, string to, List<IContainer> containers)
        {
            From = from;
            To = to;
            Containers = containers;
        }
    }
}
