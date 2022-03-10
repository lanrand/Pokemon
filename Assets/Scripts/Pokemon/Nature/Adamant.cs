using System.Collections;

namespace Pokemon.Nature
{
    public class Adamant : Nature//固执
    {
        public Adamant()
        {
            _natureName = "Adamant";
            _attackCorrection = 1.1;
            _defenseCorrection = 1;
            _specialAttackCorrection = 0.9;
            _specialDefenseCorrection = 1;
            _speedCorrection = 1;
        }
    }
}