using System.Collections;
using Pokemon.Species;

namespace Pokemon.Type
{
    public class Psychic : Type
    {
        public Psychic()
        {
            _typeName = "Psychic";
            _superEffective = new ArrayList();
            _superEffective.Add("Poison");
            _effective = new ArrayList();
            _effective.Add("Electric");
            _effective.Add("Fire");
            _effective.Add("Flying");
            _effective.Add("Grass");
            _effective.Add("Normal");
            _effective.Add("Water");
            _notVeryEffective = new ArrayList();
            _notVeryEffective.Add("Psychic");
            _notEffective = new ArrayList();
        }
    }
}