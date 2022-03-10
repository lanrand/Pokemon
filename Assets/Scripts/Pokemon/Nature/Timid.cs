using System.Collections;

namespace Pokemon.Nature
{
    public class Timid : Nature//胆小
    {
        public Timid()
        {
            _natureName = "Timid";
            _attackCorrection = 0.9;
            _defenseCorrection = 1;
            _specialAttackCorrection = 1;
            _specialDefenseCorrection = 1;
            _speedCorrection = 1.1;
        }
    }
}