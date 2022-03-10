using System.Collections;
using Pokemon.Species;

namespace Pokemon.Type
{
    public class Normal : Type
    {
        public Normal()
        {
            _typeName = "Normal";
            _superEffective = new ArrayList();
            _effective = new ArrayList();
            _effective.Add("Electric");
            _effective.Add("Fire");
            _effective.Add("Flying");
            _effective.Add("Grass");
            _effective.Add("Normal");
            _effective.Add("Poison");
            _effective.Add("Water");
            _effective.Add("Psychic");
            _notVeryEffective = new ArrayList();
            _notEffective = new ArrayList();
        }
    }
}