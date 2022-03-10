using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pokemon;
using Pokemon.Species;

public class INITPIOKEMON : MonoBehaviour
{
    // Start is called before the first frame update
    public Player.Player _player;
    private void OnMouseDown()
    {
        Pokemon.Pokemon[] list = new Pokemon.Pokemon[6];
        list[0] = new Bulbasaur();
        list[0].InitialPokemon(15);
        list[1] = new Venusaur();
        list[1].InitialPokemon(55);
        list[2] = new Charmeleon();
        list[2].InitialPokemon(17);
        list[3] = new Pidgeot();
        list[3].InitialPokemon(70);
        list[4] = new Raichu();
        list[4].InitialPokemon(55);
        list[5] = new Muk();
        list[5].InitialPokemon(70);
        _player.BackPackPokemon.Pokemon = list;
        _player.BackPackPokemon.Pointer = 6;

    }
}
