using System.Collections;

namespace Pokemon.Type
{
    public class Grass : Type
    {
        public Grass()
        {
            _typeName = "Grass";
            _superEffective = new ArrayList();
            _superEffective.Add("Water");
            _effective = new ArrayList();
            _effective.Add("Electric");
            _effective.Add("Normal");
            _effective.Add("Psychic");
            _notVeryEffective = new ArrayList();
            _notVeryEffective.Add("Flying");
            _notVeryEffective.Add("Poison");
            _notVeryEffective.Add("Fire");
            _notVeryEffective.Add("Grass");
            _notEffective = new ArrayList();
        }
    }
}