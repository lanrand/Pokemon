using System.Collections;

namespace Pokemon.Type
{
    public class Water : Type
    {
        public Water()
        {
            _typeName = "Water";
            _superEffective = new ArrayList();
            _superEffective.Add("Fire");
            _effective = new ArrayList();
            _effective.Add("Flying");
            _effective.Add("Poison");
            _effective.Add("Electric");
            _effective.Add("Normal");
            _effective.Add("Psychic");
            _notVeryEffective = new ArrayList();
            _notVeryEffective.Add("Water");
            _notVeryEffective.Add("Grass");
            _notEffective = new ArrayList();
        }
    }
}