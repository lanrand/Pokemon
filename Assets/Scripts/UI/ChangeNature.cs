using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Pokemon;

public class ChangeNature : MonoBehaviour
{
    public Player.Player player;
    private GameObject page;
    private GameObject[] buttons = new GameObject[6];
    private Dictionary<string, string> dic = new Dictionary<string, string>();
    private int num;
    private GameObject choose;
    private GameObject confirm;
    private int current;
    private GameObject now;
    private GameObject Panel;
    private int flag = 0;//0ûѡ��1ѡ��һ����2ѡ������

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
        choose = transform.Find("page/choose").gameObject;
        page = transform.Find("page").gameObject;
        Panel = transform.Find("page/Panel").gameObject;
        now = transform.Find("page/Panel/now").gameObject;
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
                                showNow(player.BackPackPokemon.Pokemon[0]);
                            });
                        break;
                    case 1:
                        buttons[i].GetComponent<Button>().onClick.AddListener(()
                            => {
                                current = 1;
                                showNow(player.BackPackPokemon.Pokemon[1]);
                            });
                        break;
                    case 2:
                        buttons[i].GetComponent<Button>().onClick.AddListener(()
                            => {
                                current = 2;
                                showNow(player.BackPackPokemon.Pokemon[2]);
                            });
                        break;
                    case 3:
                        buttons[i].GetComponent<Button>().onClick.AddListener(()
                            => {
                                current = 3;
                                showNow(player.BackPackPokemon.Pokemon[3]);
                            });
                        break;
                    case 4:
                        buttons[i].GetComponent<Button>().onClick.AddListener(()
                            => {
                                current = 4;
                                showNow(player.BackPackPokemon.Pokemon[4]);
                            });
                        break;
                    case 5:
                        buttons[i].GetComponent<Button>().onClick.AddListener(()
                            => {
                                current = 5;
                                showNow(player.BackPackPokemon.Pokemon[5]);
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
        Panel.SetActive(true);
        now.SetActive(true);
        Debug.Log(pkm.SpeciesName1);
        now.GetComponent<Image>().sprite = Resources.Load<Sprite>(dic[pkm.SpeciesName1]);
        now.transform.GetComponentInChildren <Text>().text = pkm.Nature1.NatureName;
    }


    public void Sure()
    {
        if (player.Money >= 200)
        {
            Pokemon.Nature.LoadNatureModule loadNatureModule = new Pokemon.Nature.LoadNatureModule();
            loadNatureModule.SetNatureRandomly(player.BackPackPokemon.Pokemon[current]);
            player.Money -= 200;
        }
        else
        {
            Debug.Log("Change Nature fail, money not enough");
        }
        now.transform.GetComponentInChildren<Text>().text = player.BackPackPokemon.Pokemon[current].Nature1.NatureName;
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
}
