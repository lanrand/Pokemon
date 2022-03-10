using System.Collections;

namespace Pokemon.Nature
{
    public class Relaxed : Nature//悠闲
    {
        public Relaxed()
        {
            _natureName = "Relaxed";
            _attackCorrection = 1;
            _defenseCorrection = 1.1;
            _specialAttackCorrection = 1;
            _specialDefenseCorrection = 1;
            _speedCorrection = 0.9;
        }
    }
}