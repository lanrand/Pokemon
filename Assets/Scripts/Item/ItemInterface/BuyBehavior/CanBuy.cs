using UnityEngine;

namespace Item.ItemInterface.BuyBehavior
{
    public class CanBuy: IBuyingBehavior
    {
        private Player.Player _buyer;
        private Item _goods;

        public Player.Player Buyer
        {
            get => _buyer;
            set => _buyer = value;
        }

        public Item Goods
        {
            get => _goods;
            set => _goods = value;
        }

        public void Buying()
        {
            if (_buyer.Money >= _goods.Cost)
            {
                _buyer.Money -= _goods.Cost;
                _buyer.BackpackStuff.AddStuff(_goods);
                Debug.Log("Buy Successfully!");
            }
            else
            {
                Debug.Log("Not enough money!");
            }
        }

        public CanBuy(Item goods)
        {
            this._goods = goods;
            this._buyer = GameObject.Find("Pokemon").gameObject.GetComponent<Player.Player>();
        }
    }
}