using System.Collections;

namespace Pokemon.Type
{
    public class Electric : Type
    {
        public Electric()
        {
            _typeName = "Electric";
            _superEffective = new ArrayList();
            _superEffective.Add("Flying");
            _superEffective.Add("Water");
            _effective = new ArrayList();
            _effective.Add("Poison");
            _effective.Add("Fire");
            _effective.Add("Normal");
            _effective.Add("Psychic");
            _notVeryEffective = new ArrayList();
            _notVeryEffective.Add("Grass");
            _notVeryEffective.Add("Electric");
            _notEffective = new ArrayList();
        }
    }
}