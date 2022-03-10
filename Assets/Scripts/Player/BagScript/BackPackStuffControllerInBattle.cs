
using System;
using System.Collections.Generic;
using Item.Ball;
using UnityEngine;
using UnityEngine.Assertions.Must;
using UnityEngine.UI;

namespace Player.BagScript
{
    public class BackPackStuffControllerInBattle : MonoBehaviour
    {
        private Player _player;

        private GameObject[] _buttons;
        
        private Vector3[] _positions;

        private Dictionary<GameObject, Item.Item> _dictionary;
        public void SetGrid()
        {
            int kinds = _player.BackpackStuff.KindsOfStuff;
            _buttons = new GameObject[kinds];
            //做每个物品的格子,设定位置
            for (int i = 0; i < kinds; i++)
            {
                _buttons[i]= new GameObject("StuffBtn",typeof(Button),typeof(RectTransform),typeof(Image));
                _buttons[i].transform.SetParent(this.transform);
                _buttons[i].GetComponent<RectTransform>().anchoredPosition3D = _positions[i];
                _buttons[i].GetComponent<RectTransform>().sizeDelta = new Vector2(80, 80);

                GameObject nameText = new GameObject("nameText", typeof(RectTransform), typeof(Text));
                GameObject numberText = new GameObject("numberText", typeof(RectTransform), typeof(Text));
                nameText.transform.SetParent(_buttons[i].transform);
                numberText.transform.SetParent(_buttons[i].transform);

                nameText.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(0,-50,0);
                nameText.GetComponent<RectTransform>().sizeDelta = new Vector2(300, 30);
                nameText.GetComponent<Text>().fontSize = 20;
                nameText.GetComponent<Text>().alignment = TextAnchor.MiddleCenter;
                nameText.GetComponent<Text>().font = Font.CreateDynamicFontFromOSFont("Arial",20);
                
                numberText.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(20, -20, 0);
                numberText.GetComponent<RectTransform>().sizeDelta = new Vector2(20, 20);
                numberText.GetComponent<Text>().alignment = TextAnchor.MiddleCenter;
                numberText.GetComponent<Text>().fontSize = 16;
                numberText.GetComponent<Text>().fontStyle = FontStyle.Bold;
                numberText.GetComponent<Text>().font = Font.CreateDynamicFontFromOSFont("Arial",16);

            }

            int j = 0;
            foreach (var VARIABLE in _player.BackpackStuff.Inventory)
            {
                Image image = _buttons[j].GetComponent<Image>();
                image.sprite = Resources.Load<Sprite>(VARIABLE.Key.SpritePath1);

                _buttons[j].transform.Find("nameText").gameObject.GetComponent<Text>().text = VARIABLE.Key.Name1;
                _buttons[j].transform.Find("numberText").gameObject.GetComponent<Text>().text = VARIABLE.Value.ToString();
                _dictionary.Add(_buttons[j],VARIABLE.Key);
                j++;
            }
            //Debug.Log("awake");
        }

        public void SetButtonListener()
        {
            foreach (var VARIABLE in _buttons)
            {
                Button btn = VARIABLE.GetComponent<Button>();
                btn.onClick.AddListener(() => {ClickStuff(_dictionary[VARIABLE]);});
            }
        }

        public void ClickStuff(Item.Item item)
        {
            _player.BackpackStuff.DeleteStuff(item);
            Debug.Log("Using "+item.Name1);
            RefreshBag();
            battlePVE battlePve = GameObject.Find("controller1").GetComponent<battlePVE>();
            
            Pokemon.Pokemon myPokemon = battlePVE.us;
            Pokemon.Pokemon yourPokemon = battlePVE.enemy;
            
            if (item.GetType().IsSubclassOf(typeof(Ball)))
            {
                Debug.Log("isBall");
                item.CatchingBehavior1.SetPlayer(_player);
                Debug.Log("Current pokemon pointer:" + _player.BackPackPokemon.Pointer);
            }
            
            int ifCatch = item.UseInBattle(myPokemon: myPokemon, yourPokemon: yourPokemon);
            
            battlePve.bag_op = 0;
            battlePVE.currentFight.Operation = -1;
            battlePVE.op1 = -1;
            battlePve.ifCatch = ifCatch;
            Debug.Log("if catch:" + ifCatch);
            
            transform.parent.transform.Find("BagInBattle").gameObject.SetActive(false);
            battlePve.bag.enabled = true;
            Exit();
        }

        public void RefreshBag()
        {
            for (int i = 0; i < _buttons.Length; i++)
            {
                Destroy(_buttons[i]);
            }
            Array.Clear(_buttons,0,_buttons.Length);
            IniBag();
        }

        public void IniBag()
        {
            this._player = GameObject.Find("Pokemon").gameObject.GetComponent<Player>();
            SetGrid();
            SetButtonListener();
        }

        public void Exit()
        {
            for (int i = 0; i < _buttons.Length; i++)
            {
                Destroy(_buttons[i]);
            }
            Array.Clear(_buttons,0,_buttons.Length);
        }

        public void Awake()
        {
            _dictionary = new Dictionary<GameObject, Item.Item>();
            
            _positions = new Vector3[15];
            float x = -1214f;
            float y = -359f;
            int index = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    _positions[index] = new Vector3(x + 156f * j, y - 113f * i, 0);
                    index++;
                }
            }
        }

        public void Start()
        {
            
        }
    }
}