using Item.ItemInterface.BallBehavior;
using Item.ItemInterface.BuyBehavior;
using Item.ItemInterface.HpBehavior;
using Item.ItemInterface.PpBehavior;
using Item.ItemInterface.StatusBehavior;
using UnityEngine;

/*
 * item使用说明
 * 使用药品前先set target
 * 使用ball前先set target 再set当前player
 */

namespace Item
{
    public class Item
    {
        protected string Name;
        
        protected int Id;
        
        protected IHpBehavior HpBehavior;

        protected IPpBehavior PpBehavior;

        protected IStatusBehavior StatusBehavior;

        protected ICatchingBehavior CatchingBehavior = new NotBall();
        
        private int _number = 2;

        private int _cost;

        protected string Discreption;

        protected string SpritePath;

        public string SpritePath1
        {
            get => SpritePath;
            set => SpritePath = value;
        }

        public string Discreption1
        {
            get => Discreption;
            set => Discreption = value;
        }

        public ICatchingBehavior CatchingBehavior1
        {
            get => CatchingBehavior;
            set => CatchingBehavior = value;
        }
        

        public IStatusBehavior StatusBehavior1
        {
            get => StatusBehavior;
            set => StatusBehavior = value;
        }

        protected IBuyingBehavior BuyingBehavior;
        


        public IBuyingBehavior BuyingBehavior1
        {
            get => BuyingBehavior;
            set => BuyingBehavior = value;
        }

        public int Cost
        {
            get => _cost;
            set => _cost = value;
        }
        private Pokemon.Pokemon _target;

        public IHpBehavior HpBehavior1
        {
            get => HpBehavior;
            set => HpBehavior = value;
        }

        public Pokemon.Pokemon Target
        {
            get => _target;
            set => _target = value;
        }

        public int Number
        {
            get => _number;
            set => _number = value;
        }

        public string Name1
        {
            get => Name;
            set => Name = value;
        }

        public int Id1
        {
            get => Id;
            set => Id = value;
        }

        public void Use()
        {
            if (_number > 0)
            {
                Debug.Log("Empty");
            }
            else
            {
                this.HpBehavior.ChangeHp();
                this.PpBehavior.PpChange();
                this.StatusBehavior.StatusChange();
                this.CatchingBehavior.Catch();
                _number--;
            }
        }
        
        //战斗时使用 传入自己和对方pokemon 不需要setTarget
        public int UseInBattle(Pokemon.Pokemon myPokemon, Pokemon.Pokemon yourPokemon)
        {
            int id = 0;

                this.HpBehavior.SetTarget(myPokemon);
                this.PpBehavior.SetTarget(myPokemon);
                this.StatusBehavior.SetTarget(myPokemon);
                this.CatchingBehavior.SetTarget(yourPokemon);

                this.HpBehavior.ChangeHp();
                this.PpBehavior.PpChange();
                this.StatusBehavior.StatusChange(); 
                id = this.CatchingBehavior.Catch();

                return id;
        }

        public void Buy()
        {
            this.BuyingBehavior1.Buying();
        }
    }
}