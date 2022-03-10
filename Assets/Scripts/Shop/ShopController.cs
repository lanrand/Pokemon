using System;
using Item;
using Item.Ball;
using Item.ItemInterface;
using Item.Medicine;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Shop
{
    public class ShopController : MonoBehaviour
    {
        private Button _potion;
        private Button _greatPotion;
        private Button _elixir;
        private Button _maxElixir;
        private Button _fullHeal;

        private Button _pokeBall;
        private Button _greatBall;
        private Button _masterBall;
        
        Item.Item potion;//buyer 默认为当前玩家
        Item.Item greatPotion;
        Item.Item elixir;
        Item.Item maxElixir;
        Item.Item fullHeal;

        Item.Item pokeBall;
        Item.Item greatBall;
        Item.Item masterBall;
        //private Player.Player _player;
        public void IniShop()
        {
            //_player = GameObject.Find("Pokemon").gameObject.GetComponent<Player.Player>();//mei yong

            //medicine
            _potion = transform.Find("potion").GetComponent<Button>();
            _greatPotion = transform.Find("greatPotion").GetComponent<Button>();
            _elixir = transform.Find("elixir").GetComponent<Button>();
            _maxElixir = transform.Find("maxElixir").GetComponent<Button>();
            _fullHeal = transform.Find("fullHeal").GetComponent<Button>();
            
            //ball
            _pokeBall = transform.Find("pokeBall").GetComponent<Button>();
            _greatBall = transform.Find("greatBall").GetComponent<Button>();
            _masterBall = transform.Find("masterBall").GetComponent<Button>();
            
            
            potion = new Potion();//buyer 默认为当前玩家
            greatPotion = new SuperPotion();
            elixir = new Elixir();
            maxElixir = new MaxElixir();
            fullHeal = new FullHeal();

            pokeBall = new PokeBall();
            greatBall = new GreatBall();
            masterBall = new MasterBall();
            Debug.Log(pokeBall.Cost);
            _potion.onClick.AddListener(() => { potion.Buy();
                RefreshGoods();
            });
            _greatPotion.onClick.AddListener(() => { greatPotion.Buy();
                RefreshGoods();
            });
            _elixir.onClick.AddListener(() => { elixir.Buy();
                RefreshGoods();
            });
            _maxElixir.onClick.AddListener(() => { maxElixir.Buy();
                RefreshGoods();
            });
            _fullHeal.onClick.AddListener(() => { fullHeal.Buy();
                RefreshGoods();
            });
            
            _pokeBall.onClick.AddListener(() => { pokeBall.Buy();
                RefreshGoods();
            });
            _greatBall.onClick.AddListener(() => { greatBall.Buy();
                RefreshGoods();
            });
            _masterBall.onClick.AddListener(() => { masterBall.Buy();
                RefreshGoods();
            });
            //_potion.OnPointerEnter();
            
        }
        public void Start()
        {
            IniShop();
        }

        public void RefreshGoods()
        {
            potion = new Potion();//buyer 默认为当前玩家
            greatPotion = new SuperPotion();
            elixir = new Elixir();
            maxElixir = new MaxElixir();
            fullHeal = new FullHeal();

            pokeBall = new PokeBall();
            greatBall = new GreatBall();
            masterBall = new MasterBall();
        }
        
    }
}