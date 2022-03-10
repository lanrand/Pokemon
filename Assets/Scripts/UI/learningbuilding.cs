using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Pokemon;

public class learningbuilding : MonoBehaviour
{
    // Start is called before the first frame update
    public Player.Player player;
    private GameObject page;
    private GameObject[] buttons = new GameObject[6];
    private Dictionary<string, string> dic = new Dictionary<string, string>();
    private int num;
    private GameObject choose;
    private GameObject confirm;
    private int current;
    private GameObject learn;
    private GameObject now;
    private GameObject toLearn;
    private int flag = 0;//0ûѡ��1ѡ��һ����2ѡ������
    private int current_move=0;
    private Pokemon.Move.Move toLearn_move;
    private GameObject[] tolearn_buttons;
    private Text information;

    private void Awake()
    {
        dic.Add("Pikachu", "Sprite Assets/pokemonFace/pika");
        dic.Add("Charmander", "Sprite Assets/pokemonFace/xiaohuo");
        dic.Add("Bulbasaur", "Sprite Assets/pokemonFace/miaowazhongzi");
        dic.Add("Squirtle", "Sprite Assets/pokemonFace/jieni");
        dic.Add("Wartortle", "Sprite Assets/pokemonFace/kami");
        dic.Add("Charmeleon", "Sprite Assets/pokemonFace/huokonglong");
        dic.Add("Grimer", "Sprite Assets/pokemonFace/chouni");
        dic.Add("Ivysaur", "Sprite Assets/pokemonFace/miaowacao");
        dic.Add("Pidgeotto", "Sprite Assets/pokemonFace/bibiniao");
        dic.Add("Pidgey", "Sprite Assets/pokemonFace/bobo");
        dic.Add("Raichu", "Sprite Assets/pokemonFace/leiqiu");
        dic.Add("Pidgeot", "Sprite Assets/pokemonFace/dabiniao");
        dic.Add("Venusaur", "Sprite Assets/pokemonFace/miaowahua");
        dic.Add("Blastoise", "Sprite Assets/pokemonFace/shuijiangui");
        dic.Add("Charizard", "Sprite Assets/pokemonFace/penhuilong");
        dic.Add("Muk", "Sprite Assets/pokemonFace/chouchouni");
        confirm = transform.Find("learningBuilding/learn/confirm").gameObject;
        choose = transform.Find("learningBuilding/choose").gameObject;
        page = transform.Find("learningBuilding").gameObject;
        learn = transform.Find("learningBuilding/learn").gameObject;
        now = transform.Find("learningBuilding/learn/now").gameObject;
        toLearn = transform.Find("learningBuilding/learn/toLearn").gameObject;
        information = transform.Find("learningBuilding/learn/information").GetComponent<Text>();
        int cnt = 0;
        foreach (Transform child in choose.transform)
        {
            if (cnt >= 6)
            {
                break;
            }
            buttons[cnt] = child.gameObject;
            cnt++;
        }
    }


    void first()
    {
        num = player.BackPackPokemon.Count();
        for (int i = 0; i < 6; i++)
        {
            if (i < num)
            {
                buttons[i].SetActive(true);
                Text text = buttons[i].GetComponentInChildren<Text>();
                text.text = player.BackPackPokemon.Pokemon[i].IndividualName1;
                Image image = buttons[i].GetComponent<Image>();
                image.sprite = Resources.Load<Sprite>(dic[player.BackPackPokemon.Pokemon[i].SpeciesName1]);
                switch (i)
                {
                    case 0:
                        buttons[i].GetComponent<Button>().onClick.AddListener(()
                            => {
                                current = 0;
                                learn.SetActive(true);
                                showNow(player.BackPackPokemon.Pokemon[1]);
                                showToLearn(player.BackPackPokemon.Pokemon[1]);
                                setInformation();
                            });
                        break;
                    case 1:
                        buttons[i].GetComponent<Button>().onClick.AddListener(()
                            => {
                                current = 1;
                                showNow(player.BackPackPokemon.Pokemon[1]);
                                showToLearn(player.BackPackPokemon.Pokemon[1]);
                                learn.SetActive(true);
                                setInformation();
                            });
                        break;
                    case 2:
                        buttons[i].GetComponent<Button>().onClick.AddListener(()
                            => {
                                current = 2;
                                showNow(player.BackPackPokemon.Pokemon[2]);
                                showToLearn(player.BackPackPokemon.Pokemon[2]);
                                learn.SetActive(true);
                                setInformation();
                            });
                        break;
                    case 3:
                        buttons[i].GetComponent<Button>().onClick.AddListener(()
                            => {
                                current = 3;
                                showNow(player.BackPackPokemon.Pokemon[3]);
                                showToLearn(player.BackPackPokemon.Pokemon[3]);
                                learn.SetActive(true);
                                setInformation();
                            });
                        break;
                    case 4:
                        buttons[i].GetComponent<Button>().onClick.AddListener(()
                            => {
                                current = 4;
                                showNow(player.BackPackPokemon.Pokemon[4]);
                                showToLearn(player.BackPackPokemon.Pokemon[4]);
                                learn.SetActive(true);
                                setInformation();
                            });
                        break;
                    case 5:
                        buttons[i].GetComponent<Button>().onClick.AddListener(()
                            => {
                                current = 5;
                                showNow(player.BackPackPokemon.Pokemon[5]);
                                showToLearn(player.BackPackPokemon.Pokemon[5]);
                                learn.SetActive(true);
                                setInformation();
                            });
                        break;
                }
            }
            else
            {
                buttons[i].SetActive(false);
            }
        }
    }

    void showNow(Pokemon.Pokemon pkm)
    {
        int cnt = 0;
        foreach(Transform child in now.transform)
        {
            Button button = child.GetComponent<Button>();
            Text text = child.GetComponentInChildren<Text>();
            Pokemon.Move.Move MOVE = pkm.CurrentMoves1[cnt];
            text.fontSize = 30;
            text.text = "Name: "+MOVE.MoveName1+" Power:"+MOVE.Power1+" pp:"+MOVE.PpCurrent1+"/"+MOVE.PpDefault1;
            switch (cnt)
            {
                case 0:
                    button.onClick.AddListener(()
                        => {
                            current_move = 0;
                            if (flag == 0) { flag = 1; }
                            else if (flag == 3) { flag = 0; confirm.SetActive(true); };
                            setInformation();
                        });
                    break;
                case 1:
                    button.onClick.AddListener(()
                        => {
                            current_move = 1;
                            if (flag == 0) { flag = 1; }
                            else if (flag == 3) { flag = 0; confirm.SetActive(true); };
                            setInformation();
                        });
                    break;
                case 2:
                    button.onClick.AddListener(()
                        => {
                            current_move = 2;
                            if (flag == 0) { flag = 1; }
                            else if (flag == 3) { flag = 0; confirm.SetActive(true); };
                            setInformation();
                        });
                    break;
                case 3:
                    button.onClick.AddListener(()
                        => {
                            current_move = 3;
                            if (flag == 0) { flag = 1; }
                            else if (flag == 3) { flag = 0; confirm.SetActive(true); };
                            setInformation();
                        });
                    break;
            }
            cnt++;
        }
    }

    void showToLearn(Pokemon.Pokemon pkm)
    {
        Pokemon.Move.Move[] toLearnlist = new Pokemon.Move.Move[10];
        int cnt = 0;
        foreach(var item in pkm.AllMove1)
        {
            Pokemon.Move.Move temp = (Pokemon.Move.Move)item;
            bool flag = true;
            for(int i = 0; i < 4; i++)
            {
                if (temp.MoveName1.Equals(pkm.CurrentMoves1[i].MoveName1))
                {
                    flag = false;
                    break;
                }
            }
            if (flag)
            {
                toLearnlist[cnt] = temp;
                cnt++;
            }
        }
        tolearn_buttons = new GameObject[cnt];
        Vector3[]_positions = new Vector3[15];
        float x = -500f;
        float y = 200f;
        int index = 0;
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                _positions[index] = new Vector3(x + 400f * j, y - 400f * i, 0);
                index++;
            }
        }
        Clear();
        System.Array.Clear(tolearn_buttons, 0, cnt);
        for (int i = 0; i < cnt; i++)
        {
            tolearn_buttons[i] = new GameObject("MOVEBtn", typeof(Button), typeof(RectTransform), typeof(Image));
            tolearn_buttons[i].transform.SetParent(toLearn.transform);
            tolearn_buttons[i].GetComponent<RectTransform>().anchoredPosition3D = _positions[i];
            tolearn_buttons[i].GetComponent<RectTransform>().sizeDelta = new Vector2(200, 200);

           
            GameObject nameText = new GameObject("nameText", typeof(RectTransform), typeof(Text));
            nameText.transform.SetParent(tolearn_buttons[i].transform);

            nameText.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(0, -30, 0);
            nameText.GetComponent<RectTransform>().sizeDelta = new Vector2(300, 40);
            nameText.GetComponent<Text>().alignment = TextAnchor.MiddleCenter;
            nameText.GetComponent<Text>().font = Font.CreateDynamicFontFromOSFont("Arial", 30);
            nameText.GetComponent<Text>().fontSize = 30;
            nameText.GetComponent<Text>().color = Color.black;
            Pokemon.Move.Move MOVE = toLearnlist[i];
            nameText.GetComponent<Text>().text = "Name: " + MOVE.MoveName1 + " Power:" + MOVE.Power1 + " pp:" + MOVE.PpCurrent1 + "/" + MOVE.PpDefault1;
            ColorBlock cb = new ColorBlock();
            cb.highlightedColor = Color.red;
            tolearn_buttons[i].GetComponent<Button>().colors = cb;
            tolearn_buttons[i].GetComponent<Button>().onClick.AddListener(()
                            => {
                                toLearn_move = MOVE;
                                setInformation();
                                if (flag == 0) { flag = 3; }
                                else if (flag == 1) { flag = 0; confirm.SetActive(true);
                                };
                            });
        }

    }

/*    private void Update()
    {
        Debug.Log(current_move);
    }
*/

    public void Sure()
    {
        Debug.Log(player.BackPackPokemon.Pokemon[current].CurrentMoves1[current_move].MoveName1 + " are replaced with " + toLearn_move.MoveName1);
        player.BackPackPokemon.Pokemon[current].CurrentMoves1[current_move] = toLearn_move;
        showNow(player.BackPackPokemon.Pokemon[current]);
        showToLearn(player.BackPackPokemon.Pokemon[current]);

    }

    public void Clear()
    {
        toLearn = transform.Find("learningBuilding/learn/toLearn").gameObject;
        foreach (Transform item in toLearn.transform)
        {
            GameObject.Destroy(item.gameObject);
        }
    }

    // Update is called once per frame
    private void OnMouseDown()
    {
        if (page.gameObject.activeSelf)
        {
            page.gameObject.SetActive(false);
        }
        else
        {
            // Pokemon.Pokemon add = new Pokemon.Species.Raichu();
            // add.InitialPokemon(55);
            // player.BackPackPokemon.AddPokemon(add);
            page.gameObject.SetActive(true);
            first();
        }
    }

    void setInformation()
    {
        information.fontSize = 30;
        if (toLearn_move == null)
        {
            information.text = player.BackPackPokemon.Pokemon[current].CurrentMoves1[current_move].MoveName1 + " are replaced with ";
        }
        else information.text = player.BackPackPokemon.Pokemon[current].CurrentMoves1[current_move].MoveName1 + " are replaced with " + toLearn_move.MoveName1;
    }
}
