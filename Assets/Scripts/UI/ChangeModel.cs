using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Player;

public class ChangeModel : MonoBehaviour
{

    private Player.Player player;
    private GameObject[] models = new GameObject[12];
    public int number;
    private Dictionary<int, int> dic = new Dictionary<int, int>();
    private Dictionary<string, int> getNumber = new Dictionary<string, int>();
    private Dictionary<string, string> getName = new Dictionary<string, string>();
    // Start is called before the first frame update
    void Start()
    {
        getName.Add("Pikachu", "pikachu");
        getName.Add("Charmander", "xiaohuolong");
        getName.Add("Bulbasaur", "miaowa");
        getName.Add("Squirtle", "jieni");
        getName.Add("Wartortle", "kami");
        getName.Add("Charmeleon", "huokonglong");
        getName.Add("Grimer", "chouni");
        getName.Add("Ivysaur", "miaowacao");
        getName.Add("Pidgeotto", "bibiniao");
        getName.Add("Pidgey", "bobo");
        getName.Add("Raichu", "leiqiu");
        getName.Add("Pidgeot", "dabiniao");
        getName.Add("Venusaur", "miaowahua");
        getName.Add("Blastoise", "shuijiangui");
        getName.Add("Charizard", "penhuilong");
        player = this.GetComponent<Player.Player>();
        number = 0;
        int cnt = 0;
        foreach(Transform child in this.transform)
        {
            if (child.name.Equals("minimap"))
            {
                continue;
            }
            models[cnt] = child.gameObject;
            getNumber.Add(child.name, cnt);
            cnt++;
        }
    }

    public void initModel()
    {
        player = this.GetComponent<Player.Player>();
        dic.Clear();
        for (int i = 0; i < player.BackPackPokemon.Count(); i++)
        {
            dic.Add(i, getNumber[getName[player.BackPackPokemon.Pokemon[i].SpeciesName1]]);
        }
        if (dic.ContainsKey(0))
        {
            models[dic[0]].SetActive(true);
        }
    }

    // Update is called once per frame
    public void change()
    {
        player = this.GetComponent<Player.Player>();
        dic.Clear();
        for (int i = 0; i < player.BackPackPokemon.Count(); i++)
        {
            dic.Add(i, getNumber[getName[player.BackPackPokemon.Pokemon[i].SpeciesName1]]);
        }
/*        foreach (var item in dic)
        {
            Debug.Log(item.Key+" "+item.Value);
        }*/
        models[dic[number]].SetActive(false);
        if (number < player.BackPackPokemon.Count()-1)
        {
            number++;
        }
        else
        {
            number = 0;
        }
        models[dic[number]].SetActive(true);


    }
    public void Refresh()
    {
        player = this.GetComponent<Player.Player>();
        dic.Clear();
        for (int i = 0; i < player.BackPackPokemon.Count(); i++)
        {
            dic.Add(i, getNumber[getName[player.BackPackPokemon.Pokemon[i].SpeciesName1]]);
        }
    }
}
