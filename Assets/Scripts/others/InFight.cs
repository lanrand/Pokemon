using System;
using System.Collections;
using System.Collections.Generic;
using Player;
using Item.Medicine;
using Pokemon.Species;
using Item;
using UnityEditor;
using UnityEngine;



public class InFight
{
    private string _name;//战斗前传入

    private BackpackStuff _backpackStuff;

    private BackPackPokemon _backPackPokemon;

    private ArrayList _currentPokemonList;

    private Pokemon.Pokemon _currentPokemon;

    private Item.Item _item;

    private int _death = 0;

    private int _operation = 5;//-1: 跳过 0: Escape 1: Bag 2: Fight////////

    private InFight _opponent;

    public InFight(Player.Player player)
    {
        _name = player.name;
        ///!!!!!!!!!!!!!!!!!!!!!!!!
        _backpackStuff = player.BackpackStuff;
        _backPackPokemon = player.BackPackPokemon;
        _backpackStuff = new BackpackStuff();
        _backPackPokemon = new BackPackPokemon();
        _currentPokemonList = new ArrayList();
        _currentPokemon = new Pokemon.Pokemon();
        _opponent = new InFight();
    }

    public InFight(InFight player)// for PvE
    {
        _name = "Computer Player";
        _backpackStuff = new BackpackStuff();
        _backPackPokemon = new BackPackPokemon();
        _currentPokemonList = new ArrayList();
        _currentPokemon = new Pokemon.Pokemon();
        _opponent = new InFight();

        for (int i = 0; i < player.CurrentPokemonList.Count; i++)
        {

            int rd = UnityEngine.Random.Range(-2, 2);
            int lv = ((Pokemon.Pokemon)player.CurrentPokemonList[i]).Lv1 + rd;
            if (lv < 1)
                lv = 1;
            if (lv > 100)
                lv = 100;
            Pokemon.LoadPokemonModule loadPokemonModule = new Pokemon.LoadPokemonModule();
            Pokemon.Pokemon pokemon = loadPokemonModule.SetPokemonRandomly(lv);
            pokemon.InitialPokemon(lv);
            _currentPokemonList.Add(pokemon);
        }
    }
    public InFight(int a)// for PvE
    {
        _name = "Computer Player";
        _backpackStuff = new BackpackStuff();
        _backPackPokemon = new BackPackPokemon();
        _currentPokemonList = new ArrayList();
        _currentPokemon = new Pokemon.Pokemon();
        _opponent = new InFight();

        for (int i = 0; i < 1; i++)
        {

            int rd = UnityEngine.Random.Range(-2, 2);
            int lv = a + rd;
            if (lv < 1)
                lv = 1;
            if (lv > 100)
                lv = 100;
            Pokemon.LoadPokemonModule loadPokemonModule = new Pokemon.LoadPokemonModule();
            Pokemon.Pokemon pokemon = loadPokemonModule.SetPokemonRandomly(lv);
            pokemon.InitialPokemon(lv);
            _currentPokemonList.Add(pokemon);
        }
    }

    public InFight()
    {
        _backpackStuff = new BackpackStuff();
        _backPackPokemon = new BackPackPokemon();
        _currentPokemonList = new ArrayList();
        _currentPokemon = new Pokemon.Pokemon();
    }
    public string Name
    {
        get => _name;
        set => _name = value;
    }

    public BackpackStuff BackpackStuff
    {
        get => _backpackStuff;
        set => _backpackStuff = value;
    }

    public BackPackPokemon BackPackPokemon
    {
        get => _backPackPokemon;
        set => _backPackPokemon = value;
    }

    public ArrayList CurrentPokemonList
    {
        get => _currentPokemonList;
        set => _currentPokemonList = value;
    }

    public Pokemon.Pokemon CurrentPokemon
    {
        get => _currentPokemon;
        set => _currentPokemon = value;
    }

    public int Death
    {
        get => _death;
        set => _death = value;
    }

    public int Operation
    {
        get => _operation;
        set => _operation = value;
    }

    public InFight Opponent
    {
        get => _opponent;
        set => _opponent = value;
    }

    public Item.Item Item
    {
        get => _item;
        set => _item = value;
    }
}