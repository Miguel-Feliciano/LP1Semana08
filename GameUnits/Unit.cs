using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameUnits
{
    abstract class Unit {
    public abstract float Cost { get; }
    public virtual int Health { get; set; }
    public int Movement { get; private set; }
    private int _distanceMoved;
    
    public Unit(int health, int movement) {
        Health = health;
        Movement = movement;
        _distanceMoved = 0;
    }

    public void Move(int distance) {
        Console.WriteLine($"Unit moved {distance} places");
        _distanceMoved += distance;
    }
}
}