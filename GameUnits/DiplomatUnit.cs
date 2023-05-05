namespace GameUnits
{
    class DiplomatUnit : XPUnit
    {
        public override float Cost => 7.1f;
        public override int Health => 1;
        public override int Movement => 6;

        public DiplomatUnit() : base(1, 6)
        {
        }

        public void MakeAgreement(Unit unit)
        {
            if (unit is DiplomatUnit)
            {
                XP += 3;
            }
            else if (unit is SettlerUnit)
            {
                XP += 2;
            }
            else
            {
                XP++;
            }
        }

        public override string ToString()
        {
            return $"{GetType().Name}: HP={Health} COST={Cost:f2} XP={XP}";
        }
    }
}