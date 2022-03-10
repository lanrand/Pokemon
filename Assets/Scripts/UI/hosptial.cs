using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hosptial : MonoBehaviour
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
        confirm = transform.Find("hospital/confirm").gameObject;
        choose = transform.Find("hospital/choose").gameObject;
        page = transform.Find("hospital").gameObject;
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
                                confirm.SetActive(true);
                            });
                        break;
                    case 1:
                        buttons[i].GetComponent<Button>().onClick.AddListener(()
                            => {
                                current = 1;
                                confirm.SetActive(true);
                            });
                        break;
                    case 2:
                        buttons[i].GetComponent<Button>().onClick.AddListener(()
                            => {
                                current = 2;
                                confirm.SetActive(true);
                            });
                        break;
                    case 3:
                        buttons[i].GetComponent<Button>().onClick.AddListener(()
                            => {
                                current = 3;
                                confirm.SetActive(true);
                            });
                        break;
                    case 4:
                        buttons[i].GetComponent<Button>().onClick.AddListener(()
                            => {
                                current = 4;
                                confirm.SetActive(true);
                            });
                        break;
                    case 5:
                        buttons[i].GetComponent<Button>().onClick.AddListener(()
                            => {
                                current = 5;
                                confirm.SetActive(true);
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

    public void Sure()
    {
        Pokemon.Pokemon pokemon = player.BackPackPokemon.Pokemon[current];
        pokemon.DefaultPokemon(pokemon.Lv1);
        pokemon.StatusCondition1 = new Pokemon.StatusCondition.Normal();
        if (player.Money < 10)
        {
            Debug.Log("fail!");
        }
        else
        {
            player.Money -= 10;
            Debug.Log(pokemon.SpeciesName1+" Healing success!!");
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
            page.gameObject.SetActive(true);
            first();
        }
    }
}
