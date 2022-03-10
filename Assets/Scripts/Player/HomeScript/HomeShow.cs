using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace Player.HomeScript
{
    public class HomeShow : MonoBehaviour
    {
        public changePokemon func;
        public Player player;
        private Text[] list;
        private GameObject[] buttons = new GameObject[6];
        private Dictionary<string, string> dic = new Dictionary<string, string>();
        private int num;
        private int _page = 0;

        private GameObject choose;
        private GameObject show;

        private Button _takeButton;
        // Start is called before the first frame update

        void Awake()
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
        }


        public void first()
        {
            choose = this.transform.Find("choose").gameObject;
            show = this.transform.Find("show").gameObject;
            GameObject text1 = this.transform.Find("show/TXTPanel").gameObject;
            _takeButton = transform.Find("show/StoreButton").GetComponent<Button>();

            int cnt = 0;
            foreach (Transform child in choose.transform)
            {
                if (cnt == 6)
                {
                    break;
                }

                buttons[cnt] = child.gameObject;
                cnt++;
            }

            // /num = player.BackPackPokemon.Count();

            num = player.Home.Pokemon.Count;
            //Debug.Log(num+"!!!!!!!!!!!!!!!!");
            list = text1.GetComponentsInChildren<Text>();
            for (int i = 0; i < 6; i++)
            {
                if (i + _page * 6 < num)
                {
                    buttons[i].SetActive(true);
                    Text text = buttons[i].GetComponentInChildren<Text>();

                    //text.text = player.BackPackPokemon.Pokemon[i].IndividualName1;
                    text.text = ((Pokemon.Pokemon) player.Home.Pokemon[i + _page * 6]).IndividualName1;

                    Image image = buttons[i].GetComponent<Image>();
                    image.sprite =
                        Resources.Load<Sprite>(
                            dic[((Pokemon.Pokemon) player.Home.Pokemon[i + _page * 6]).IndividualName1]);
                    switch (i)
                    {
                        case 0:
                            buttons[i].GetComponent<Button>().onClick.AddListener(()
                                =>
                            {
                                //showPokemon(player.BackPackPokemon.Pokemon[0]);
                                showPokemon((Pokemon.Pokemon)player.Home.Pokemon[0 + _page * 6]);
                                choose.SetActive(false);
                                show.SetActive(true);
                                
                                IniTakeButton((Pokemon.Pokemon)player.Home.Pokemon[0 + _page * 6]);
                                
                                showModel(((Pokemon.Pokemon)player.Home.Pokemon[0 + _page * 6]).IndividualName1);
                            });
                            break;
                        case 1:
                            buttons[i].GetComponent<Button>().onClick.AddListener(()
                                =>
                            {
                                showPokemon((Pokemon.Pokemon)player.Home.Pokemon[1 + _page * 6]);
                                choose.SetActive(false);
                                show.SetActive(true);
                                
                                IniTakeButton((Pokemon.Pokemon)player.Home.Pokemon[1 + _page * 6]);
                                
                                showModel(((Pokemon.Pokemon)player.Home.Pokemon[1 + _page * 6]).IndividualName1);
                            });
                            break;
                        case 2:
                            buttons[i].GetComponent<Button>().onClick.AddListener(()
                                =>
                            {
                                showPokemon((Pokemon.Pokemon)player.Home.Pokemon[2 + _page * 6]);
                                choose.SetActive(false);
                                show.SetActive(true);
                                
                                IniTakeButton((Pokemon.Pokemon)player.Home.Pokemon[2 + _page * 6]);
                                
                                showModel(((Pokemon.Pokemon)player.Home.Pokemon[2 + _page * 6]).IndividualName1);
                            });
                            break;
                        case 3:
                            buttons[i].GetComponent<Button>().onClick.AddListener(()
                                =>
                            {
                                showPokemon((Pokemon.Pokemon)player.Home.Pokemon[3 + _page * 6]);
                                choose.SetActive(false);
                                show.SetActive(true);
                                
                                IniTakeButton((Pokemon.Pokemon)player.Home.Pokemon[3 + _page * 6]);
                                
                                showModel(((Pokemon.Pokemon)player.Home.Pokemon[3 + _page * 6]).IndividualName1);
                            });
                            break;
                        case 4:
                            buttons[i].GetComponent<Button>().onClick.AddListener(()
                                =>
                            {
                                showPokemon((Pokemon.Pokemon)player.Home.Pokemon[4 + _page * 6]);
                                choose.SetActive(false);
                                show.SetActive(true);
                                
                                IniTakeButton((Pokemon.Pokemon)player.Home.Pokemon[4 + _page * 6]);
                                
                                showModel(((Pokemon.Pokemon)player.Home.Pokemon[4 + _page * 6]).IndividualName1);
                            });
                            break;
                        case 5:
                            buttons[i].GetComponent<Button>().onClick.AddListener(()
                                =>
                            {
                                showPokemon((Pokemon.Pokemon)player.Home.Pokemon[5 + _page * 6]);
                                choose.SetActive(false);
                                show.SetActive(true);
                                
                                IniTakeButton((Pokemon.Pokemon)player.Home.Pokemon[5 + _page * 6]);
                                
                                showModel(((Pokemon.Pokemon)player.Home.Pokemon[5 + _page * 6]).IndividualName1);
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

        public void RefreshHome()
        {
            exit();
            first();
        }

        public void exit()
        {
            for (int i = 0; i < 6; i++)
            {
                buttons[i].SetActive(false);
                buttons[i].GetComponent<Button>().onClick.RemoveAllListeners();
                _takeButton.onClick.RemoveAllListeners();
            }
        }

        void showModel(string name)
        {
            switch (name)
            {
                case "Pikachu":
                {
                    func.choPika();
                    break;
                }
                case "Charmander":
                {
                    func.choXiaohuo();
                    break;
                }
                case "Bulbasaur":
                {
                    func.choMiaowazhongzi();
                    break;
                }
                case "Squirtle":
                {
                    func.choJieni();
                    break;
                }
            }
        }

        void showPokemon(Pokemon.Pokemon poke)
        {
            for (int i = 0; i < list.Length; i++)
            {
                switch (list[i].name)
                {
                    case "个体名":
                    {
                        list[i].text = poke.IndividualName1;
                        break;
                    }
                    case "编号":
                    {
                        list[i].text = "No." + poke.Number1 + "";
                        break;
                    }
                    case "属性":
                    {
                        list[i].text = poke.Type1.TypeName;
                        break;
                    }
                    case "性格":
                    {
                        list[i].text = poke.Nature1.NatureName;
                        break;
                    }
                    case "IV":
                    {
                        list[i].text = poke.Iv1 + "";
                        break;
                    }
                    case "LV":
                    {
                        list[i].text = poke.Lv1 + ":" + poke.CurrentExp1 + "/" + poke.ExpNeed1;
                        break;
                    }
                    case "HP":
                    {
                        list[i].text = poke.HpCurrent1 + "/" + poke.HpDefault1;
                        break;
                    }
                    case "攻击":
                    {
                        list[i].text = poke.AttackDefault1 + "";
                        break;
                    }
                    case "防御":
                    {
                        list[i].text = poke.DefenseCurrent1 + "";
                        break;
                    }
                    case "特攻":
                    {
                        list[i].text = poke.SpecialAttackDefault1 + "";
                        break;
                    }
                    case "特防":
                    {
                        list[i].text = poke.SpecialDefenseDefault1 + "";
                        break;
                    }
                    case "速度":
                    {
                        list[i].text = poke.SpeedDefault1 + "";
                        break;
                    }
                    case "状态":
                    {
                        list[i].text = poke.StatusCondition1.StatusConditionName1 + "";
                        break;
                    }
                    case "种族名":
                    {
                        list[i].text = poke.SpeciesName1;
                        break;
                    }
                    case "技能1":
                    {
                        list[i].text = poke.CurrentMoves1[0].MoveName1;
                        break;
                    }
                    case "技能2":
                    {
                        list[i].text = poke.CurrentMoves1[1].MoveName1;
                        break;
                    }
                    case "技能3":
                    {
                        list[i].text = poke.CurrentMoves1[2].MoveName1;
                        break;
                    }
                    case "技能4":
                    {
                        list[i].text = poke.CurrentMoves1[3].MoveName1;
                        break;
                    }
                }
            }
        }

        public void IniTakeButton(Pokemon.Pokemon pokemon)
        {
            Player player = GameObject.Find("Pokemon").GetComponent<Player>();

            _takeButton.onClick.AddListener(() =>
            {
                player.RemoveFromHomeToBag(pokemon);
                RefreshHome();
                Debug.Log("Take:" + pokemon.IndividualName1);
                Debug.Log("Bag pokemon number:" + player.BackPackPokemon.Pointer);
            });
        }
    }
}