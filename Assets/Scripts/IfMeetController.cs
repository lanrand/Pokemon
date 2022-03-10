using System;
using UnityEngine;
using Random = UnityEngine.Random;
using UnityEngine;
using Player;
using UnityEngine.UI;

namespace DefaultNamespace
{
    public class IfMeetController : MonoBehaviour
    {
        private Player.Player _player;
        private Vector3 _position;
        private float _delayTime = 0.5f;
        private float _currentTime;

        public Player.Player player;

        public Image choose;

        private Battle.Battle battle;

        public static InFight infight;

        public Button[] buttons;// ??????confrim???????????????
        public Button[] buttonlist;//?????????��?button

        public Button sureBattle;

/*        public GameObject pve;*/

        public GameObject battleScene;
        public GameObject camera1;
        public GameObject playPanel;
        public GameObject whatPV2;
        public GameObject battleCamera;
        public GameObject logImage;
        public GameObject firstBattle;
        public GameObject confirmPanel;

        public GameObject battlecontrol;

        public static int PVEKey;

        
        public void OnEnable()
        {
            this._player = GameObject.Find("Pokemon").GetComponent<Player.Player>();
            _position = _player.transform.position;
            _delayTime = 0.5f;
            _currentTime = Time.time;
            Random.InitState(DateTime.Now.Second);
        }

        public void Start()
        {
            foreach (Button button in buttons)
            {
                button.onClick.AddListener(delegate () {
                    onClick(button, infight);
                });
            }
            sureBattle.onClick.AddListener(doBattle);
            sureBattle.onClick.AddListener(mainIt);
            infight = new InFight();
            InitPokemons();
        }
        void doBattle()
        {
            Debug.Log("?111");
            PVEKey = 1;
        }
        public void Update()
        {
            if (Time.time >= _currentTime + _delayTime )
            {
                if (_player.transform.position != _position)
                {
                    battlecontrol.SetActive(false);
                    int a = Random.Range(0, 25);
                    if (a < 4)
                    {
                        firstBattle.SetActive(true);
                        _position = _player.transform.position;
                        choose.gameObject.SetActive(true);
                        Debug.Log("Meet!!!");
                    }
                }
                
                _currentTime = Time.time;
                 //Debug.Log("Time"+Time.time);
                // Debug.Log(_delayTime);
            }
        }
        void mainIt()
        {
            //_delayTime = 0.5f;
            if (PVEKey == 1)
            {
                /*                         whatPV.a = 2;*/
                battle = new Battle.PvE(infight, ((Pokemon.Pokemon)infight.CurrentPokemonList[0]).Lv1);
                Debug.Log("?????");
                battleScene.SetActive(true);
                logImage.SetActive(true);
                Invoke("delayLog", 2);
                choose.gameObject.SetActive(false);
                battlePVE.theBattle = battle;

                Pokemon.Pokemon[] array1 = new Pokemon.Pokemon[battle.Me1.CurrentPokemonList.Count];
                Pokemon.Pokemon[] array2 = new Pokemon.Pokemon[battle.You1.CurrentPokemonList.Count];
                for (int i = 0; i < array1.Length; i++)
                {
                    array1[i] = (Pokemon.Pokemon)battle.Me1.CurrentPokemonList[i];
                }
                for (int i = 0; i < array2.Length; i++)
                {
                    array2[i] = (Pokemon.Pokemon)battle.You1.CurrentPokemonList[i];
                }
                battlePVE.theBattle.Me1 = infight;
                battlePVE.poke1 = battlePVE.theBattle.Me1.CurrentPokemonList;
                battlePVE.poke2 = battlePVE.theBattle.You1.CurrentPokemonList;
                Debug.Log(battlePVE.poke2.Count);
                battlePVE.initPokemons();

                PVEKey = 0;

                battleCamera.SetActive(true);
                camera1.SetActive(false);
                playPanel.SetActive(false);
                gameObject.SetActive(false);
                firstBattle.SetActive(false);
                confirmPanel.SetActive(true);
            }
        }
        void delayLog()
        {
            logImage.SetActive(false);
            /*        playPanel.SetActive(false);*/
        }
        void onClick(Button button, InFight infight1)
        {
                switch (button.name)
                {
                    case "yes":
                        infight1.CurrentPokemonList.Add(player.BackPackPokemon.Pokemon[0]);
                        buttonlist[0].enabled = false;
/*                        chooseCount++;*/
                        break;
                    case "yes1":
                        infight1.CurrentPokemonList.Add((Pokemon.Pokemon)player.BackPackPokemon.Pokemon[1]);
                        buttonlist[1].enabled = false;
/*                        chooseCount++;*/
                        break;
                    case "yes2":
                        infight1.CurrentPokemonList.Add((Pokemon.Pokemon)player.BackPackPokemon.Pokemon[2]);
                        buttonlist[2].enabled = false;
/*                        chooseCount++;*/
                        break;
                    case "yes3":
                        infight1.CurrentPokemonList.Add((Pokemon.Pokemon)player.BackPackPokemon.Pokemon[3]);
                        buttonlist[3].enabled = false;
/*                        chooseCount++;*/
                        break;
                    case "yes4":
                        infight1.CurrentPokemonList.Add((Pokemon.Pokemon)player.BackPackPokemon.Pokemon[4]);
                        buttonlist[4].enabled = false;
/*                        chooseCount++;*/
                        break;
                    case "yes5":
                        infight1.CurrentPokemonList.Add((Pokemon.Pokemon)player.BackPackPokemon.Pokemon[5]);
                        buttonlist[5].enabled = false;
/*                        chooseCount++;*/
                        break;
                    default:
                        Debug.LogWarning("No find button yes!!");
                        break;

                }
        }
        public void InitPokemons()
        {
            foreach (Button button in buttons)
            {
                button.onClick.RemoveAllListeners();
            }

            Pokemon.Pokemon[] list = player.BackPackPokemon.Pokemon;
            for (int i = 0; i < 6; i++)
            {
                Pokemon.Pokemon pokemon = (Pokemon.Pokemon)list[i];
                if (pokemon == null)
                {
                    Text[] text = buttonlist[i].gameObject.GetComponentsInChildren<Text>();
                    text[0].text = "No pokemon";
                    buttonlist[i].enabled = false;
                }
                else
                {
                    Text[] text = buttonlist[i].gameObject.GetComponentsInChildren<Text>();
                    text[0].text = pokemon.SpeciesName1;
                    buttonlist[i].enabled = true;
                }
            }
            foreach (Button button in buttons)
            {
                button.onClick.AddListener(delegate () {
                    onClick(button, infight);
                });
            }
        }
    }
}