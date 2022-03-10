using System;
using System.Collections;
using System.Collections.Generic;
using Pokemon.Species;

using UnityEngine;

namespace Player
{
    public class Player : MonoBehaviour
    {
        private string _playerName;

        public string PlayerName
        {
            get => _playerName;
            set => _playerName = value;
        }

        private int _money;

        private Home _home;
        

        public Pokemon.Pokemon[] CurrentPokemonList
        {
            get => _currentPokemonList;
            set => _currentPokemonList = value;
        }

        public int Money
        {
            get => _money;
            set => _money = value;
        }

        public Home Home
        {
            get => _home;
            set => _home = value;
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

        private BackpackStuff _backpackStuff;

        private BackPackPokemon _backPackPokemon;

        private Pokemon.Pokemon[] _currentPokemonList = new Pokemon.Pokemon[3]; 
        
        public float speed_move;


        private void Awake()
        {
            _backpackStuff = new BackpackStuff();
            _backPackPokemon = new BackPackPokemon();
            _home = new Home();
            _money = 8000;
            Application.targetFrameRate = 60;
        }

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void FixedUpdate()
        {
            Physics.gravity = new Vector3(0, -35, 0);
            float y = Input.GetAxis("Horizontal")
                      * Time.deltaTime * speed_move;
            float x = Input.GetAxis("Vertical")
                      * Time.deltaTime * speed_move;
            transform.Translate(-x, 0, y);


            if (Input.GetKey(KeyCode.Q))

            {

                transform.Rotate(new Vector3(0,1,0), -1.2f);

            }

            if (Input.GetKey(KeyCode.E))

            {

                transform.Rotate(new Vector3(0,1,0), 1.2f);

            }
        }
        public void RemoveFromBagToHome(Pokemon.Pokemon pokemon)
        {
            if (_backPackPokemon.Pointer<=1)
            {
                Debug.Log("Store failed! Your bag need at least one pokemon!");
            }
            else
            {
                this._home.AddPokemon(_backPackPokemon.RemovePokemon(pokemon));
                Debug.Log("RemoveFromBagToHome success!");
            }
        }

        public void RemoveFromHomeToBag(Pokemon.Pokemon pokemon)
        {
            if (_backPackPokemon.Pointer >= 6)
            {
                Debug.Log("Your bag is full,please remove one to home at first!");
            }
            else
            {
                _backPackPokemon.AddPokemon(_home.RemovePokemon(pokemon));
                Debug.Log(_home.Pokemon.Count);
                Debug.Log("RemoveFromHomeToBag success!");
            }
        }
    }
}