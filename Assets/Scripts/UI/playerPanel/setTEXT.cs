using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class setTEXT : MonoBehaviour
{
    private Player.Player _player;
    private Text[] list;
    // Start is called before the first frame update
    void Start()
    {
        _player = GameObject.FindWithTag("Player").GetComponent<Player.Player>();
        list = gameObject.GetComponentsInChildren<Text>();
    }

    // Update is called once per frame
    public void show()
    {
        gameObject.SetActive(true);
        _player = GameObject.FindWithTag("Player").GetComponent<Player.Player>();
        list = gameObject.GetComponentsInChildren<Text>();
        for (int i = 0; i < list.Length; i++)
        {
            switch (list[i].name)
            {
                case "name":
                {
                    list[i].text = "Name:" + _player.PlayerName;
                    break;
                }
                case "money":
                {
                    list[i].text = "Money:" + _player.Money;
                    break;
                }
                case "number":
                {
                    list[i].text = "Number of pokemons:" + _player.BackPackPokemon.Count();
                    break;
                }
            }
        }
    }
}
