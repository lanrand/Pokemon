using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using Player;
using UnityEngine.UI;

public class battleControl : MonoBehaviour
{
    private bool isPVP;
    private bool isbattling;
    public Player.Player player;
    public Player.Player player2;

    private int chooseCount;
    private bool flag;

    private Battle.Battle battle;
    public static InFight infight;
    private InFight InFight2;

    public Image choose;
    /*public Image log;
    public Text log_Info;*/
    public Button[] buttons;// ??????confrim???????????????
    public Button[] buttonlist;//?????????¦Å?button

    public Button sureBattle;

    public GameObject battleScene;
    public GameObject camera1;
    public GameObject playPanel;
    public GameObject whatPV2;
    public GameObject battleCamera;
    public GameObject logImage;
    public GameObject firstBattle;
    public GameObject confirmPanel;

    static int PVEKey = 0;

    // Start is called before the first frame update
    public void Start()
    {
        chooseCount = 0;
        sureBattle.onClick.AddListener(doBattle);
        BackPackPokemon backPackPokemon = new BackPackPokemon();
        Pokemon.Pokemon[] test1 = new Pokemon.Pokemon[6];
        test1[0] = new Pokemon.Species.Pikachu();
        test1[1] = new Pokemon.Species.Pidgeotto();
        test1[2] = new Pokemon.Species.Wartortle();
        test1[3] = new Pokemon.Species.Venusaur();
        test1[4] = new Pokemon.Species.Charmeleon();
        test1[5] = new Pokemon.Species.Muk();

        test1[0].InitialPokemon(5);
        test1[1].InitialPokemon(60);
        test1[2].InitialPokemon(60);
        test1[3].InitialPokemon(60);
        test1[4].InitialPokemon(60);
        test1[5].InitialPokemon(60);
        backPackPokemon.Pokemon = test1;
        /*player.BackPackPokemon = backPackPokemon;*/
        player2.BackPackPokemon = backPackPokemon;
        /*if (infight != null)
        {
            infight.CurrentPokemonList.Clear();
        }*/
    }

    void doBattle()
    {
        PVEKey = 1;
    }
    void onClick(Button button, InFight infight1)
    {
        if (isPVP == false || (isPVP == true && chooseCount<3))
        {
            switch (button.name)
            {
                case "yes":
                    infight1.CurrentPokemonList.Add(player.BackPackPokemon.Pokemon[0]);
                    buttonlist[0].enabled = false;
                    chooseCount++;
                    break;
                case "yes1":
                    infight1.CurrentPokemonList.Add((Pokemon.Pokemon)player.BackPackPokemon.Pokemon[1]);
                    buttonlist[1].enabled = false;
                    chooseCount++;
                    break;
                case "yes2":
                    infight1.CurrentPokemonList.Add((Pokemon.Pokemon)player.BackPackPokemon.Pokemon[2]);
                    buttonlist[2].enabled = false;
                    chooseCount++;
                    break;
                case "yes3":
                    infight1.CurrentPokemonList.Add((Pokemon.Pokemon)player.BackPackPokemon.Pokemon[3]);
                    buttonlist[3].enabled = false;
                    chooseCount++;
                    break;
                case "yes4":
                    infight1.CurrentPokemonList.Add((Pokemon.Pokemon)player.BackPackPokemon.Pokemon[4]);
                    buttonlist[4].enabled = false;
                    chooseCount++;
                    break;
                case "yes5":
                    infight1.CurrentPokemonList.Add((Pokemon.Pokemon)player.BackPackPokemon.Pokemon[5]);
                    buttonlist[5].enabled = false;
                    chooseCount++;
                    break;
                default:
                    Debug.LogWarning("No find button yes!!");
                    break;

            }
        }
        else if((isPVP == true && chooseCount >= 3))
        {
            switch (button.name)
            {
                case "yes":
                    infight1.CurrentPokemonList.Add(player2.BackPackPokemon.Pokemon[0]);
                    buttonlist[0].enabled = false;
                    chooseCount++;
                    break;
                case "yes1":
                    infight1.CurrentPokemonList.Add(player2.BackPackPokemon.Pokemon[1]);
                    buttonlist[1].enabled = false;
                    chooseCount++;
                    break;
                case "yes2":
                    infight1.CurrentPokemonList.Add(player2.BackPackPokemon.Pokemon[2]);
                    buttonlist[2].enabled = false;
                    chooseCount++;
                    break;
                case "yes3":
                    infight1.CurrentPokemonList.Add(player2.BackPackPokemon.Pokemon[3]);
                    buttonlist[3].enabled = false;
                    chooseCount++;
                    break;
                case "yes4":
                    infight1.CurrentPokemonList.Add(player2.BackPackPokemon.Pokemon[4]);
                    buttonlist[4].enabled = false;
                    chooseCount++;
                    break;
                case "yes5":
                    infight1.CurrentPokemonList.Add(player2.BackPackPokemon.Pokemon[5]);
                    buttonlist[5].enabled = false;
                    chooseCount++;
                    break;
                default:
                    Debug.LogWarning("No find button yes!!");
                    break;

            }

        }
    }

    public void isPvP(bool isPVP)
    {
        this.isPVP = isPVP;
    }
    


    // Update is called once per frame

    void Update()
    {
        if (isPVP && chooseCount == 3 && flag == false)
        {
            flag = true;
            Pokemon.Pokemon[] list = player2.BackPackPokemon.Pokemon;
            for (int i = 0; i < 6; i++)
            {
                Pokemon.Pokemon pokemon = (Pokemon.Pokemon)list[i];
                if (pokemon!=null)
                {
                    Text[] text = buttonlist[i].gameObject.GetComponentsInChildren<Text>();
                    text[0].text = pokemon.SpeciesName1;
                    buttonlist[i].enabled = true;
                }
                else
                {
                    Text[] text = buttonlist[i].gameObject.GetComponentsInChildren<Text>();
                    text[0].text = "No pokemon";
                    buttonlist[i].enabled = false;
                }
            }
            foreach (Button button in buttons)
            {
                button.onClick.RemoveAllListeners();
                button.onClick.AddListener(delegate ()
                {
                    onClick(button, InFight2);
                });
            }
        }

/*        void delayInfo()
        {
            setInfo("dddd");
        }*/
        if ((PVEKey==1&& !isPVP)|| (!isPVP && chooseCount >= 3 && isbattling == false || isPVP && chooseCount>=6 && isbattling == false))
        {
            isbattling = true;
            battleScene.SetActive(true);
            logImage.SetActive(true);
            Invoke("delayLog", 2);
            choose.gameObject.SetActive(false);
            whatPV2.SetActive(true);
            if (isPVP)
            {
                whatPV.a = 1;
            }
            else
            {
                whatPV.a = 2;
            }
            if (isPVP)
            {
               battle = new Battle.PvP(infight,InFight2);
               battlePVP.theBattle = battle;
               
            }
            else
            {
                battle = new Battle.PvE(infight);
                battlePVE.theBattle = battle;
                Debug.Log(battlePVE.theBattle.Me1.CurrentPokemonList.Count);
            }
           
            Pokemon.Pokemon[] array1 = new Pokemon.Pokemon[battle.Me1.CurrentPokemonList.Count];
            Pokemon.Pokemon[] array2 = new Pokemon.Pokemon[battle.You1.CurrentPokemonList.Count];
            for(int i = 0; i < array1.Length; i++)
            {
                array1[i] = (Pokemon.Pokemon)battle.Me1.CurrentPokemonList[i];
            }
            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = (Pokemon.Pokemon)battle.You1.CurrentPokemonList[i];
            }
            if (isPVP)
            {
                battlePVP.theBattle.Me1 = infight;
                battlePVP.theBattle.You1 = InFight2;
                battlePVP.poke1 = infight.CurrentPokemonList;
                battlePVP.poke2 = InFight2.CurrentPokemonList;
                battlePVP.initPokemons();
            }
            else
            {
                battlePVE.theBattle.Me1 = infight;
                battlePVE.poke1 = battlePVE.theBattle.Me1.CurrentPokemonList;
                battlePVE.poke2 = battlePVE.theBattle.You1.CurrentPokemonList;
                battlePVE.initPokemons();

                Debug.Log(999);
                PVEKey = 0;
            }
            /*battleCamera.SetActive(true);
            battleScene.SetActive(true);
            camera1.SetActive(false);
            playPanel.SetActive(false);
            gameObject.SetActive(false);
            logImage.SetActive(false);
            firstBattle.SetActive(false);
            confirmPanel.SetActive(true);*/
            battleCamera.SetActive(true);
            camera1.SetActive(false);
            playPanel.SetActive(false);
            // gameObject.SetActive(false);
            firstBattle.SetActive(false);
            confirmPanel.SetActive(true);

            // ??????:?§Ý??????
        }
    }
    void delayLog()
    {
        logImage.SetActive(false);
/*        playPanel.SetActive(false);*/
    }
    public void InitBattle()
    {
        infight = new InFight(player);
        InFight2 = new InFight(player2);
        flag = false;
        chooseCount = 0;
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
