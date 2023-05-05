using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameUnits
{
    class MilitaryUnit : XPUnit
    {
        public int AttackPower { get; private set; }
        public MilitaryUnit(int health, int movement, int attackPower) : base(health, movement)
        {
            AttackPower = attackPower;
        }

        public override float Cost => AttackPower + XP;

        public override int Health
        {
            get { return base.Health + XP; }
            set { base.Health = value; }
        }

        public void Attack(Unit unit)
        {
            XP++;
            unit.Health -= AttackPower;
        }

        public override string ToString()
        {
            return $"{GetType().Name}: HP={Health} COST={Cost:f2} AP={AttackPower}";
        }
    }
}
