using Praxisarbeit.Class;
using Praxisarbeit.Interfaces;
using System;
namespace Praxisarbeit.Class;

public class Location : ILocation
{
    public int X { get; set; }
    public int Y { get; set; }

    public Location(int x, int y)
    {
        X = x;
        Y = y;
    }
}
