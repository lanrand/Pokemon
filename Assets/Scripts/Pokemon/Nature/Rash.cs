using System.Collections;

namespace Pokemon.Nature
{
    public class Rash : Nature//马虎
    {
        public Rash()
        {
            _natureName = "Rash";
            _attackCorrection = 1;
            _defenseCorrection = 1;
            _specialAttackCorrection = 1.1;
            _specialDefenseCorrection = 0.9;
            _speedCorrection = 1;
        }
    }
}