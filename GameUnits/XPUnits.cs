namespace GameUnits
{
    abstract class XPUnit : Unit
    {
        public int XP { get; protected set; }

        public XPUnit(int health, int movement) : base(health, movement)
        {
            XP = 0;
        }

        public override string ToString()
        {
            return $"{base.ToString()} {XP}";
        }
    }
}