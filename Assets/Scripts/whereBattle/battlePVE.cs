using System.Collections;
using System.Collections.Generic;
using Player;
using Player.BagScript;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class battlePVE : MonoBehaviour
{
    public GameObject player1;
    public GameObject player2;

    public static Battle.Battle theBattle;

    public static ArrayList poke1;
    public static ArrayList poke2;

    public static Pokemon.Pokemon us;
    public static Pokemon.Pokemon enemy;

    public static InFight currentFight;
    public static Pokemon.Pokemon currentPokemon;

    public Text name1;
    public Text name2;

    public Text Lv1;
    public Text Lv2;

    public Text hp1;
    public Text hp2;

    public Image nuddle1;
    public Image nuddle2;

    public Text aMove1;
    public Text aMove2;
    public Text aMove3;
    public Text aMove4;

    public Button move1;
    public Button move2;
    public Button move3;
    public Button move4;

    public Button skip;
    public Button bag;
    public Button theEscape;

    public GameObject meWin;
    public GameObject youWin;

    public GameObject runYes;
    public GameObject runNot;


    public Text afterPlayer1;
    public Text afterPlayer2;

    public Text informationText;

    public GameObject playPanel;
    public GameObject camera1;
    public GameObject battlePanel;
    public GameObject battleCamera;

    public static Pokemon.Pokemon[] afterBattle1;
    public static Pokemon.Pokemon[] afterBattle2;

    public static int ifExit = 0;
    public static string battleInformation = "";
    public static string upName = "";
    public static int prehp1;
    public static int prehp2;
    public static int key1;
    
    public Image enemy_image;
    public Image our_image;
    private Dictionary<string, string> dic = new Dictionary<string, string>();
    
    public int bag_op = 0;
    public GameObject bagPanel;

    public int ifCatch = 0;

    public Text myCondition;
    public Text enemyCondition;
    public GameObject Catch;


    public void Start()
    {
        skip.onClick.AddListener(skipOnClick);
        bag.onClick.AddListener(bagOnClick);
        theEscape.onClick.AddListener(escapeOnClick);
        move1.onClick.AddListener(moveOnClick1);
        move2.onClick.AddListener(moveOnClick2);
        move3.onClick.AddListener(moveOnClick3);
        move4.onClick.AddListener(moveOnClick4);
        
        dic.Add("Pikachu", "Sprite Assets/Fight/pika");
        dic.Add("Charmander", "Sprite Assets/Fight/huolong");
        dic.Add("Bulbasaur", "Sprite Assets/Fight/miaowa");
        dic.Add("Squirtle", "Sprite Assets/Fight/jieni");
        dic.Add("Wartortle", "Sprite Assets/Fight/jini");
        dic.Add("Charmeleon", "Sprite Assets/Fight/huolong");
        dic.Add("Grimer", "Sprite Assets/Fight/chouni");
        dic.Add("Ivysaur", "Sprite Assets/Fight/miaowa");
        dic.Add("Pidgeotto", "Sprite Assets/Fight/bobo");
        dic.Add("Pidgey", "Sprite Assets/Fight/bobo");
        dic.Add("Raichu", "Sprite Assets/Fight/pika");
        dic.Add("Pidgeot", "Sprite Assets/Fight/bobo");
        dic.Add("Venusaur", "Sprite Assets/Fight/miaowa");
        dic.Add("Blastoise", "Sprite Assets/Fight/jini");
        dic.Add("Charizard", "Sprite Assets/Fight/huolong");
        dic.Add("Muk", "Sprite Assets/Fight/chouni");
    }
    public static void initPokemons()
    {
        poke1 = theBattle.Me1.CurrentPokemonList;
        poke2 = theBattle.You1.CurrentPokemonList;
        

        us = (Pokemon.Pokemon)poke1[0];
        enemy = (Pokemon.Pokemon)poke2[0];

        Debug.Log(us.SpeciesName1);

        theBattle.Me1.CurrentPokemon = us;
        theBattle.You1.CurrentPokemon = enemy;

        theBattle.Me1.Opponent = theBattle.You1;
        theBattle.You1.Opponent = theBattle.Me1;

        theBattle.Me1.Opponent.CurrentPokemon = enemy;
        theBattle.You1.Opponent.CurrentPokemon = us;

        currentPokemon = us;
        currentFight = theBattle.Me1;

        prehp1 = us.HpCurrent1;
        prehp2 = enemy.HpCurrent1;
        key1 = 1;
    }
    public void setMoves()
    {

        if (currentPokemon.CurrentMoves1[0].MoveName1 != null)
        {
            aMove1.text = currentPokemon.CurrentMoves1[0].MoveName1 + " " +
                currentPokemon.CurrentMoves1[0].PpCurrent1 + " / " + currentPokemon.CurrentMoves1[0].PpDefault1;
        }
        else
        {
            aMove1.text = "";
        }
        if (currentPokemon.CurrentMoves1[1].MoveName1 != null && currentPokemon.CurrentMoves1[1].PpCurrent1 > 0)
        {
            aMove2.text = currentPokemon.CurrentMoves1[1].MoveName1 + " " +
                currentPokemon.CurrentMoves1[1].PpCurrent1 + " / " + currentPokemon.CurrentMoves1[1].PpDefault1;
        }
        else
        {
            aMove2.text = "";
        }
        if (currentPokemon.CurrentMoves1[2].MoveName1 != null && currentPokemon.CurrentMoves1[2].PpCurrent1 > 0)
        {
            aMove3.text = currentPokemon.CurrentMoves1[2].MoveName1 + " " +
                currentPokemon.CurrentMoves1[2].PpCurrent1 + " / " + currentPokemon.CurrentMoves1[2].PpDefault1;
        }
        else
        {
            aMove3.text = "";
        }
        if (currentPokemon.CurrentMoves1[3].MoveName1 != null && currentPokemon.CurrentMoves1[3].PpCurrent1 > 0)
        {
            aMove4.text = currentPokemon.CurrentMoves1[3].MoveName1 + " " +
                currentPokemon.CurrentMoves1[3].PpCurrent1 + " / " + currentPokemon.CurrentMoves1[3].PpDefault1;
        }else
        {
            aMove4.text = "";
        }
    }

    public static int op1 = 5;
    int key = 0;
    public void doBattle()
    {
        if (theBattle.SetComputerMove(theBattle.You1))
        {
            key = 1;
        }
        while (op1 != 5 && key == 1 && bag_op == 0)
        {
            theBattle.SetFormerLatter();
            Debug.Log("Former: " + theBattle.Former1.CurrentPokemon.SpeciesName1 + 
                "Later: " + theBattle.Latter1.CurrentPokemon.SpeciesName1);
            battleInformation += "\nFormer: " + theBattle.Former1.CurrentPokemon.SpeciesName1 +"\n"+
                "Later: " + theBattle.Latter1.CurrentPokemon.SpeciesName1+"\n";

            if (!theBattle.Former1.CurrentPokemon.StatusCondition1.StatusConditionName1.Equals("Normal"))
            {
                Debug.Log(theBattle.Former1.CurrentPokemon.SpeciesName1 + " is " +
                    theBattle.Former1.CurrentPokemon.StatusCondition1.StatusConditionName1);
                battleInformation += theBattle.Former1.CurrentPokemon.SpeciesName1 + " is " +
                    theBattle.Former1.CurrentPokemon.StatusCondition1.StatusConditionName1 + "\n";
            }
            if (!theBattle.Latter1.CurrentPokemon.StatusCondition1.StatusConditionName1.Equals("Normal"))
            {
                Debug.Log(theBattle.Latter1.CurrentPokemon.SpeciesName1 + " is " +
                    theBattle.Latter1.CurrentPokemon.StatusCondition1.StatusConditionName1);
                battleInformation += theBattle.Latter1.CurrentPokemon.SpeciesName1 + " is " +
                    theBattle.Latter1.CurrentPokemon.StatusCondition1.StatusConditionName1 + "\n";
            }
            if (theBattle.SetCurrentUseMove(theBattle.Former1, 0))
            {
                theBattle.Operation(theBattle.Former1);
                if (theBattle.Latter1.CurrentPokemon.HpCurrent1 <= 0)
                {
                    op1 = 5;
                    key = 0;
                    break;
                }
            }
            theBattle.AfterAction(theBattle.Former1);
            if (theBattle.Former1.CurrentPokemon.HpCurrent1 <= 0)
            {
                op1 = 5;
                key = 0;
                break;
            }
            if (theBattle.Me1.Operation == 0 || theBattle.You1.Operation == 0)
            {
                if (ifExit == 1)
                {
                    runYes.SetActive(true);
                    ifExit = 0;
                    Invoke("delay3",2);
                }
                else
                {
                    runNot.SetActive(true);
                    Invoke("delayOpen", 3);

                }
            }
            if (theBattle.SetCurrentUseMove(theBattle.Latter1, 0))
            {
                /*                Debug.Log(theBattle.Latter1.)*/

                theBattle.Operation(theBattle.Latter1);

                if (theBattle.Former1.CurrentPokemon.HpCurrent1 <= 0)
                {
                    op1 = 5;
                    key = 0;
                    break;
                }
            }
            theBattle.AfterAction(theBattle.Latter1);
            op1 = 5;
            key = 0;
            break;
        }
    }
    void delayOpen()
    {
        runNot.SetActive(false);
    }
    void skipOnClick()
    {
        currentFight.Operation = -1;
        if (currentFight == theBattle.Me1)
        {
            op1 = currentFight.Operation;
            /*currentFight = theBattle.You1;*/
        }
        else
        {
            currentFight = theBattle.Me1;
            key = 1;
            currentPokemon = us;
        }

    }

    void escapeOnClick()
    {
        currentFight.Operation = 0;
        if (currentFight == theBattle.Me1)
        {
            op1 = currentFight.Operation;
            /*currentFight = theBattle.You1;*/
        }
        else
        {
            currentFight = theBattle.Me1;
            key = 1;
            currentPokemon = us;
        }
    }

    void bagOnClick()
    {
        currentFight.Operation = 5;
        if (currentFight == theBattle.Me1)
        {
            op1 = currentFight.Operation;
            bag_op = 1;
            /* currentFight = theBattle.You1;*/
        }
        else
        {
            currentFight = theBattle.Me1;
            key = 1;
            currentPokemon = us;
        }
        
        //bagPanel = GameObject.Find("Bag");
        BackPackStuffControllerInBattle backPackStuffController = bagPanel.GetComponent<BackPackStuffControllerInBattle>();
        bagPanel.SetActive(true);
        backPackStuffController.IniBag();
        bag.enabled = false;
    }

    public void ReSetBagOp()
    {
        bag_op = 0;
    }

    void moveOnClick1()
    {

        currentFight.Operation = 2;
        if (currentFight == theBattle.Me1&&currentPokemon.CurrentMoves1[0].PpCurrent1 > 0)
        {
            op1 = currentFight.Operation;
            currentFight.CurrentPokemon.CurrentUse1 = currentFight.CurrentPokemon.CurrentMoves1[0];
            /*currentFight = theBattle.You1;*/
        }
        else
        {
            currentFight.CurrentPokemon.CurrentUse1 = currentFight.CurrentPokemon.CurrentMoves1[0];
            currentFight = theBattle.Me1;
            currentPokemon = us;
            key = 1;
        }
    }

    void moveOnClick2()
    {

        currentFight.Operation = 2;
        if (currentFight == theBattle.Me1 && currentPokemon.CurrentMoves1[1].PpCurrent1 > 0)
        {
            op1 = currentFight.Operation;
            currentFight.CurrentPokemon.CurrentUse1 = currentFight.CurrentPokemon.CurrentMoves1[1];
            /*currentFight = theBattle.You1;*/
        }
        else
        {
            currentFight.CurrentPokemon.CurrentUse1 = currentFight.CurrentPokemon.CurrentMoves1[1];
            currentFight = theBattle.Me1;
            key = 1;
            currentPokemon = us;
        }
    }

    void moveOnClick3()
    {
        currentFight.Operation = 2;
        if (currentFight == theBattle.Me1 && currentPokemon.CurrentMoves1[2].PpCurrent1 > 0)
        {
            op1 = currentFight.Operation;
            currentFight.CurrentPokemon.CurrentUse1 = currentFight.CurrentPokemon.CurrentMoves1[2];
            /*currentFight = theBattle.You1;*/
        }
        else
        {
            currentFight.CurrentPokemon.CurrentUse1 = currentFight.CurrentPokemon.CurrentMoves1[2];
            currentFight = theBattle.Me1;
            key = 1;
            currentPokemon = us;
        }
    }

    void moveOnClick4()
    {
        currentFight.Operation = 2;
        if (currentFight == theBattle.Me1 && currentPokemon.CurrentMoves1[3].PpCurrent1 > 0)
        {
            op1 = currentFight.Operation;
            currentFight.CurrentPokemon.CurrentUse1 = currentFight.CurrentPokemon.CurrentMoves1[3];

            /*currentFight = theBattle.You1;*/
        }
        else
        {
            currentFight.CurrentPokemon.CurrentUse1 = currentFight.CurrentPokemon.CurrentMoves1[3];
            currentFight = theBattle.Me1;
            key = 1;
            currentPokemon = us;
        }
    }
    void Update()
    {
        Debug.Log(key1+" , "+ poke1.Count + " , " + poke2.Count);
        Debug.Log(((Pokemon.Pokemon)poke1[0]).SpeciesName1);
        if (key1!=0)
        {
            if (!us.StatusCondition1.StatusConditionName1.Equals("Normal"))
                myCondition.text = us.StatusCondition1.StatusConditionName1;
            if (!enemy.StatusCondition1.StatusConditionName1.Equals("Normal"))
                enemyCondition.text = enemy.StatusCondition1.StatusConditionName1;
            
            informationText.text = battleInformation;
            hp1.text = "Hp: " + us.HpCurrent1 + "/" + us.HpDefault1;
            hp2.text = "Hp: " + enemy.HpCurrent1 + "/" + enemy.HpDefault1;

            player1 = GameObject.Find(us.SpeciesName1 + "1");
            player2 = GameObject.Find(enemy.SpeciesName1 + "2");

            name1.text = us.SpeciesName1;
            name2.text = enemy.SpeciesName1;
            our_image.sprite = Resources.Load<Sprite>(dic[us.SpeciesName1]);
            enemy_image.sprite = Resources.Load<Sprite>(dic[enemy.SpeciesName1]);

            Lv1.text = "Lv " + us.Lv1.ToString();
            Lv2.text = "Lv " + enemy.Lv1.ToString();

            hp1.text = "Hp: " + us.HpCurrent1 + "/" + us.HpDefault1;
            hp2.text = "Hp: " + enemy.HpCurrent1 + "/" + enemy.HpDefault1;

            setMoves();
            post();
            doBattle();

            theBattle.Me1.CurrentPokemon = us;
            theBattle.You1.CurrentPokemon = enemy;

            theBattle.Me1.Opponent.CurrentPokemon = enemy;
            theBattle.You1.Opponent.CurrentPokemon = us;
            nuddle1.fillAmount = (float)((float)(us.HpCurrent1) / us.HpDefault1);
            nuddle2.fillAmount = (float)((float)(enemy.HpCurrent1) / enemy.HpDefault1);

            if (us.HpCurrent1 <= 0 && (poke1.Count >= 2 && ((Pokemon.Pokemon)poke1[1]).HpCurrent1 == ((Pokemon.Pokemon)poke1[1]).HpDefault1))
            {

                us = ((Pokemon.Pokemon)poke1[1]);
                player1.transform.position = new Vector3(0, 0, 0);
                player1 = GameObject.Find(us.SpeciesName1 + "1");
                nuddle1.fillAmount = 1;
                name1.text = us.SpeciesName1;
                our_image.sprite = Resources.Load<Sprite>(dic[us.SpeciesName1]);

                hp1.text = "Hp: " + us.HpCurrent1 + "/" + us.HpDefault1;
                Lv1.text = "Lv " + us.Lv1.ToString();
                currentPokemon = us;

                prehp1 = us.HpCurrent1;
                prehp2 = enemy.HpCurrent1;
                post1();
            }
            else if (poke1.Count >= 3 && us.HpCurrent1 <= 0 && us == ((Pokemon.Pokemon)poke1[1])
                && ((Pokemon.Pokemon)poke1[2]).HpCurrent1 == ((Pokemon.Pokemon)poke1[2]).HpDefault1)
            {
                us = ((Pokemon.Pokemon)poke1[2]);
                player1.transform.position = new Vector3(0, 0, 0);
                player1 = GameObject.Find(us.SpeciesName1 + "1");
                nuddle1.fillAmount = 1;
                name1.text = us.SpeciesName1;
                our_image.sprite = Resources.Load<Sprite>(dic[us.SpeciesName1]);
                hp1.text = "Hp: " + us.HpCurrent1 + "/" + us.HpDefault1;
                Lv1.text = "Lv " + us.Lv1.ToString();
                currentPokemon = us;

                prehp1 = us.HpCurrent1;
                prehp2 = enemy.HpCurrent1;
                post1();
            }
            else if (((Pokemon.Pokemon)poke1[poke1.Count - 1]).HpCurrent1 <= 0)
            {
                int[] result = theBattle.BattleEnd(theBattle.You1, theBattle.Me1);
                theBattle.Me1.CurrentPokemonList.Clear();
                for (int i = 0; i < result.Length; i++)
                {
                    theBattle.Me1.CurrentPokemonList.Add(afterBattle2[i]);
                    if (result[i] == 1)
                    {
                        upName += afterBattle2[i].SpeciesName1 + " get up!";
                        upName += " ";
                    }
                    if (result[i] == 3 || result[i] == 4)
                    {
                        upName += afterBattle2[i].SpeciesName1 + " : evolution!\n";
                    }
                }
                if (upName.Length < 1)
                {
                    afterPlayer2.text = upName + " : get up!";
                }
                else
                {
                    afterPlayer2.text = upName;
                }

                battleInformation = "";
                informationText.text = battleInformation;
                youWin.SetActive(true);
                key1 = 0;
                player1.transform.position = new Vector3(199, 0, 0);
                player2.transform.position = new Vector3(199, 0, 0);

                prehp1 = us.HpCurrent1;
                prehp2 = enemy.HpCurrent1;
                Invoke("delay1", 2);
            }



            if (enemy.HpCurrent1 <= 0 && (poke2.Count >= 2 && ((Pokemon.Pokemon)poke2[1]).HpCurrent1 == ((Pokemon.Pokemon)poke2[1]).HpDefault1))
            {
                enemy = ((Pokemon.Pokemon)poke2[1]);
                player2.transform.position = new Vector3(0, 0, 0);
                player2 = GameObject.Find(enemy.SpeciesName1 + "2");
                nuddle2.fillAmount = 1;
                name2.text = enemy.SpeciesName1;
                enemy_image.sprite = Resources.Load<Sprite>(dic[enemy.SpeciesName1]);
                hp2.text = "Hp: " + enemy.HpCurrent1 + "/" + enemy.HpDefault1;
                Lv2.text = "Lv " + enemy.Lv1.ToString();
                currentPokemon = us;

                prehp1 = us.HpCurrent1;
                prehp2 = enemy.HpCurrent1;
                post2();
            }
            else if (poke2.Count >= 3 && enemy.HpCurrent1 <= 0 && enemy == ((Pokemon.Pokemon)poke2[1]) &&
                ((Pokemon.Pokemon)poke2[2]).HpCurrent1 == ((Pokemon.Pokemon)poke2[2]).HpDefault1)
            {
                enemy = ((Pokemon.Pokemon)poke2[2]);
                player2.transform.position = new Vector3(0, 0, 0);
                player2 = GameObject.Find(enemy.SpeciesName1 + "2");
                nuddle2.fillAmount = 1;
                name2.text = enemy.SpeciesName1;
                enemy_image.sprite = Resources.Load<Sprite>(dic[enemy.SpeciesName1]);
                hp2.text = "Hp: " + enemy.HpCurrent1 + "/" + enemy.HpDefault1;
                Lv2.text = "Lv " + enemy.Lv1.ToString();
                currentPokemon = us;

                prehp1 = us.HpCurrent1;
                prehp2 = enemy.HpCurrent1;
                post2();
            }
            else if (((Pokemon.Pokemon)poke2[poke2.Count - 1]).HpCurrent1 <= 0)
            {
                int[] result = theBattle.BattleEnd(theBattle.Me1, theBattle.You1);
                theBattle.Me1.CurrentPokemonList.Clear();
                for (int i = 0; i < result.Length; i++)
                {
                    theBattle.Me1.CurrentPokemonList.Add(afterBattle1[i]);
                    if (result[i] == 1)
                    {
                        upName += afterBattle1[i].SpeciesName1 + " get up!";
                        upName += " ";
                    }
                    if (result[i] == 3 || result[i] == 4)
                    {
                        upName += afterBattle1[i].SpeciesName1 + " : evolution!\n";
                    }
                }

                if (upName.Length < 1)
                {
                    afterPlayer1.text = upName + " : get up!";
                }
                else
                {
                    afterPlayer1.text = upName;
                }
                prehp1 = us.HpCurrent1;
                prehp2 = enemy.HpCurrent1;

                Debug.Log("This: " + upName);
                battleInformation = "";
                informationText.text = battleInformation;
                meWin.SetActive(true);
                player1.transform.position = new Vector3(199, 0, 0);
                player2.transform.position = new Vector3(199, 0, 0);
                key1 = 0;
                Invoke("delay2", 2);
                /*            gameObject.SetActive(false);*/
            } else if (ifCatch == 1)
            {
                // int[] result = theBattle.BattleEnd(theBattle.Me1, theBattle.You1);
                // theBattle.Me1.CurrentPokemonList.Clear();
                // for (int i = 0; i < result.Length; i++)
                // {
                //     theBattle.Me1.CurrentPokemonList.Add(afterBattle1[i]);
                //     if (result[i] == 1)
                //     {
                //         upName += afterBattle1[i].SpeciesName1 + " get up!";
                //         upName += " ";
                //     }
                //     if (result[i] == 3 || result[i] == 4)
                //     {
                //         upName += afterBattle1[i].SpeciesName1 + " : evolution!\n";
                //     }
                // }
                //
                // if (upName.Length < 1)
                // {
                //     afterPlayer1.text = upName + " : get up!";
                // }
                // else
                // {
                //     afterPlayer1.text = upName;
                // }
                // prehp1 = us.HpCurrent1;
                // prehp2 = enemy.HpCurrent1;
                //
                // Debug.Log("This: " + upName);
                battleInformation = "";
                informationText.text = battleInformation;
                Catch.SetActive(true);
                player1.transform.position = new Vector3(199, 0, 0);
                player2.transform.position = new Vector3(199, 0, 0);
                key1 = 0;
                Invoke("delay4", 2);
                ifCatch = 0;
                /*            gameObject.SetActive(false);*/
            }

        }

    }
    void delay1()
    {
        key1 = 0;
        battleInformation = "";
        upName = "";
        battleControl.infight = new InFight();
        youWin.SetActive(false);
        playPanel.SetActive(true);
        camera1.SetActive(true);
        battlePanel.SetActive(false);
        battleCamera.SetActive(false);
        gameObject.SetActive(false);
    }
    void delay3()
    {
        key1 = 0;
        battleInformation = "";
        upName = "";
        battleControl.infight = new InFight();
        player1.transform.position = new Vector3(199, 0, 0);
        player2.transform.position = new Vector3(199, 0, 0);
        runYes.SetActive(false);
        youWin.SetActive(false);
        playPanel.SetActive(true);
        camera1.SetActive(true);
        battlePanel.SetActive(false);
        battleCamera.SetActive(false);
        gameObject.SetActive(false);
    }
    void delay2()
    {
        key1 = 0;
        battleInformation = "";
        upName = "";
        battleControl.infight = new InFight();
        meWin.SetActive(false);
        playPanel.SetActive(true);
        camera1.SetActive(true);
        battlePanel.SetActive(false);
        battleCamera.SetActive(false);
        gameObject.SetActive(false);
    }
    
    void delay4()
    {
        key1 = 0;
        battleInformation = "";
        upName = "";
        battleControl.infight = new InFight();
        //meWin.SetActive(false);
        Catch.SetActive(false);
        playPanel.SetActive(true);
        camera1.SetActive(true);
        battlePanel.SetActive(false);
        battleCamera.SetActive(false);
        gameObject.SetActive(false);
    }

    void post()
    {
        player1.transform.position = new Vector3(457, 6, -3396);
        player2.transform.position = new Vector3(267, 6,-3397 );
    }
    void post1()
    {
        player1.transform.position = new Vector3(457, 6, -3396);
    }
    void post2()
    {
        player2.transform.position = new Vector3(267, 6, -3397);
    }

}
