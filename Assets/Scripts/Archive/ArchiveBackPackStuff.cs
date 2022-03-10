using System;
using System.Collections.Generic;
using Player;
using Item;

namespace Archive
{
    public class ArchiveBackPackStuff
    {
        private List<string> _stuffList;//ŒÔ∆∑¿∏
        
        private int _kindsOfStuff;
        
        private Dictionary<string, int> _inventory = new Dictionary<string, int>();//<stuff,number>
        
        public ArchiveBackPackStuff()
        {
            this._stuffList = new List<string>();
            _kindsOfStuff = 0;
        }

        public List<string> StuffList
        {
            get => _stuffList;
            set => _stuffList = value;
        }

        public int KindsOfStuff
        {
            get => _kindsOfStuff;
            set => _kindsOfStuff = value;
        }

        public Dictionary<string, int> Inventory
        {
            get => _inventory;
            set => _inventory = value;
        }

        public BackpackStuff ConvertToBackpackStuff()
        {
            BackpackStuff backpackStuff = new BackpackStuff();
            foreach (var VARIABLE in _inventory)
            {
                for (int i = 0; i < VARIABLE.Value; i++)
                {
                    Type t = Type.GetType(VARIABLE.Key);
                    var obj = Activator.CreateInstance(t);
                    
                    backpackStuff.AddStuff((Item.Item)obj);
                }
            }
            return backpackStuff;
        }
    }
}