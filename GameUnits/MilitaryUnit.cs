using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameUnits
{
    class MilitaryUnit : Unit {
    public override float Cost => AttackPower + XP;

    public int XP { get; private set; }
    public int AttackPower { get; private set; }

    public MilitaryUnit(int health, int movement, int attackPower) 
    : base(health, movement) {
        AttackPower = attackPower;
        XP = 0;
    }

    public override int Health {
        get { return base.Health + XP; }
        set { base.Health = value; }
    }

    public void Attack(Unit unit) {
        XP++;
        unit.Health -= AttackPower;
    }
}
}