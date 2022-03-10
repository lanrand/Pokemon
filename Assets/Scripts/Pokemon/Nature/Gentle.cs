using System.Collections;

namespace Pokemon.Nature
{
    public class Gentle : Nature//温顺
    {
        public Gentle()
        {
            _natureName = "Gentle";
            _attackCorrection = 1;
            _defenseCorrection = 0.9;
            _specialAttackCorrection = 1;
            _specialDefenseCorrection = 1.1;
            _speedCorrection = 1;
        }
    }
}