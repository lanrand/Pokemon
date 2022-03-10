using UnityEngine;

namespace Archive
{
    using Pokemon;
    public class ArchiveBackpackPokemon
    {
        private int pointer = 0;
        private Pokemon[] _pokemon = new Pokemon[6];//ÎïÆ·À¸

        public Pokemon[] Pokemon
        {
            get => _pokemon;
            set => _pokemon = value;
        }

        public int Count()
        {
            return pointer;
        }

        public void AddPokemon(Pokemon pokemon)
        {
            if (pointer >= 6)
            {
                Debug.LogWarning("Pokemon add fail!");
                return;
            }
            _pokemon[pointer] = pokemon;
            pointer++;
        }
    }
}