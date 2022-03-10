using System;
using System.Collections;
using System.Collections.Generic;
using Archive;
using Newtonsoft.Json;
using Item;
using UnityEngine;

namespace Player
{
    using Pokemon;
    public class BackpackStuff
    {
        //[JsonIgnore]
        private List<Item.Item> _stuffList;//物品栏
        
        private int _kindsOfStuff;
        
        private Dictionary<Item.Item, int> _inventory = new Dictionary<Item.Item, int>();//<stuff,number>
        
        public void AddStuff(Item.Item item)//请一律使用此方法添加物品
        {
            int flag = 0;
            foreach (Item.Item key in _inventory.Keys)
            {
                if (item.Id1 == key.Id1)
                {
                    _inventory[key]++;
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
            {
                _inventory.Add(item,1);
                _kindsOfStuff++;
            }

            _stuffList.Add(item);
        }

        public void DeleteStuff(Item.Item item)
        {
            int flag = 0;
            foreach (var Key in _inventory.Keys)
            {
                if (item.Id1 == Key.Id1)
                {
                    _inventory[Key]--;
                    flag = 1;
                    if (_inventory[Key] == 0)
                    {
                        _inventory.Remove(Key);
                        _kindsOfStuff--;
                    }
                    _stuffList.Remove(Key);
                    break;
                }
            }
        }
        // public ArrayList StuffList
        // {
        //     get => _stuffList;
        //     set => _stuffList = value;
        // }
        
        public BackpackStuff()
        {
            this._stuffList = new List<Item.Item>();
            _kindsOfStuff = 0;
        }

        public int KindsOfStuff
        {
            get => _kindsOfStuff;
            set => _kindsOfStuff = value;
        }

        public Dictionary<Item.Item, int> Inventory
        {
            get => _inventory;
            set => _inventory = value;
        }

        public ArchiveBackPackStuff ConvertToArchiveBackPackStuff()
        {
            ArchiveBackPackStuff archiveBackPackStuff = new ArchiveBackPackStuff();
            archiveBackPackStuff.KindsOfStuff = this._kindsOfStuff;
            foreach (var VARIABLE in _stuffList)
            {
                archiveBackPackStuff.StuffList.Add(VARIABLE.GetType().FullName);
            }
            foreach (var VARIABLE in _inventory)
            {
                archiveBackPackStuff.Inventory.Add(VARIABLE.Key.GetType().FullName,VARIABLE.Value);
            }

            return archiveBackPackStuff;
        }
    }
}