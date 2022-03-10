using System.Collections;

namespace Pokemon.Type
{
    public class Poison : Type
    {
        public Poison()
        {
            _typeName = "Poison";
            _superEffective = new ArrayList();
            _superEffective.Add("Grass");
            _effective = new ArrayList();
            _effective.Add("Flying");
            _effective.Add("Fire");
            _effective.Add("Water");
            _effective.Add("Electric");
            _effective.Add("Normal");
            _effective.Add("Psychic");
            _notVeryEffective = new ArrayList();
            _notVeryEffective.Add("Poison");
            _notEffective = new ArrayList();
        }
    }
}