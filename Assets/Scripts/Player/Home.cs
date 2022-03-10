using System.Collections;
using UnityEngine;

namespace Player
{
    using Pokemon;
    public class Home
    {
        private ArrayList _pokemon = new ArrayList();

        public ArrayList Pokemon
        {
            get => _pokemon;
            set => _pokemon = value;
        }
        public Pokemon AddPokemon(Pokemon pokemon)
        {
            _pokemon.Add(pokemon);
            return pokemon;
        }

        public Pokemon RemovePokemon(Pokemon pokemon)
        {
            _pokemon.Remove(pokemon);
            return pokemon;
        }
    }
}