using System.Collections;

namespace Pokemon.Type
{
    public class Flying : Type
    {
        public Flying()
        {
            _typeName = "Flying";
            _superEffective = new ArrayList();
            _superEffective.Add("Grass");
            _effective = new ArrayList();
            _effective.Add("Flying");
            _effective.Add("Poison");
            _effective.Add("Fire");
            _effective.Add("Water");
            _effective.Add("Normal");
            _effective.Add("Psychic");
            _notVeryEffective = new ArrayList();
            _notVeryEffective.Add("Electric");
            _notEffective = new ArrayList();
        }
    }
}