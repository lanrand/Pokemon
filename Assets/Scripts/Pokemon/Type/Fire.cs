using System.Collections;

namespace Pokemon.Type
{
    public class Fire : Type
    {
        public Fire()
        {
            _typeName = "Fire";
            _superEffective = new ArrayList();
            _superEffective.Add("Grass");
            _effective = new ArrayList();
            _effective.Add("Flying");
            _effective.Add("Poison");
            _effective.Add("Electric");
            _effective.Add("Normal");
            _effective.Add("Psychic");
            _notVeryEffective = new ArrayList();
            _notVeryEffective.Add("Fire");
            _notVeryEffective.Add("Water");
            _notEffective = new ArrayList();
        }
    }
}