using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Collections.Generic;

namespace Praxisarbeit.Interfaces
{
    public interface IOrder
    {
        string From { get; set; }
        string To { get; set; }
        List<IContainer> Containers { get; set; } // Ändern Sie den Rückgabetyp entsprechend
    }
}
