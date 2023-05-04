using System;

namespace GameUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            SettlerUnit settler = new SettlerUnit();
            MilitaryUnit military = new MilitaryUnit(6, 21, 14);

            settler.Move(3);
            military.Move(5);

            Console.WriteLine($"Settler Hp: {settler.Health}, Cost: {settler.Cost}");
            Console.WriteLine($"Military Hp: {military.Health}, Cost: {military.Cost}");

            military.Attack(settler);

            Console.WriteLine($"Settler Hp: {settler.Health}, Cost: {settler.Cost}");
            Console.WriteLine($"Military Hp: {military.Health}, Cost: {military.Cost}");
        }
    }
}
