using System;
using System.Collections;
using System.Linq;
using UnityEngine;

namespace Player
{
    using Pokemon;
    public class BackPackPokemon 
    {
        private int pointer = 0;
        private Pokemon[] _pokemon = new Pokemon[6];//物品栏

        public Pokemon[] Pokemon
        {
            get => _pokemon;
            set => _pokemon = value;
        }

        public int Pointer
        {
            get => pointer;
            set => pointer = value;
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

        public override string ToString()
        {
            
            // var a = "";
            // for (var index = 0; index < _pokemon.Length; index++)
            // {
            //     var VARIABLE = _pokemon[index];
            //     a += VARIABLE.IndividualName1;
            // }

            return Count().ToString();
        }
        public Pokemon RemovePokemon(Pokemon pokemon)
        {
            for (int i = 0; i < pointer; i++)
            {
                if (_pokemon[i] == pokemon)
                {
                    for (int j = i; j + 1 <= pointer - 1; j++)
                    {
                        Debug.Log("j:" + j + " pointer" + pointer);
                        _pokemon[j] = _pokemon[j + 1];
                    }

                    _pokemon[pointer-1] = null;
                    pointer--;
                    break;
                }
            }

            return pokemon;
        }
    }
}