using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Player;
using Pokemon;

public class choosePokemon : MonoBehaviour
{
    // Start is called before the first frame update
    public Player.Player player;
    private Pokemon.Pokemon current;
    private Pokemon.Pokemon xiaohuolong;
    private Pokemon.Pokemon miaowa;
    private Pokemon.Pokemon jieni;
    private Pokemon.Pokemon pika;

    void Start()
    {
        xiaohuolong = new Pokemon.Species.Charmander();
        xiaohuolong.InitialPokemon(5);
        xiaohuolong.Iv1 = 31;

        miaowa = new Pokemon.Species.Bulbasaur();
        miaowa.InitialPokemon(5);
        miaowa.Iv1 = 31;

        jieni = new Pokemon.Species.Squirtle();
        jieni.InitialPokemon(5);
        jieni.Iv1 = 31;

        pika = new Pokemon.Species.Pikachu();
        pika.InitialPokemon(5);
        pika.Iv1 = 31;

        current = xiaohuolong;
    }

    public void ChooseChar()
    {
        current = xiaohuolong;
    }

    public void ChoBu()
    {
        current = miaowa;
    }

    public void ChoSq()
    {
        current = jieni;
    }

    public void Sure()
    {
        player.BackPackPokemon.AddPokemon(current);
        player.BackPackPokemon.AddPokemon(pika);

    }

    public void setavtivate()
    {
        if(player.BackPackPokemon.Count() == 0)
        {
            gameObject.SetActive(true);
        }
    }

    // Update is called once per frame
}
