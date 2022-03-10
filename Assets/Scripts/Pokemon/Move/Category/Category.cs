using UnityEngine;
using UnityEngine.UIElements;

namespace Pokemon.Move.Category
{
    public class Category
    {
        protected string CategoryName;
        protected int CalculativeAttack;
        protected int CalculativeDefense;
        protected int CalculativeAttackLv;
        protected int CalculativeDefenseLv;

        public string CategoryName1
        {
            get => CategoryName;
            set => CategoryName = value;
        }

        public int CalculativeAttack1
        {
            get => CalculativeAttack;
            set => CalculativeAttack = value;
        }

        public int CalculativeDefense1
        {
            get => CalculativeDefense;
            set => CalculativeDefense = value;
        }

        public int CalculativeAttackLv1
        {
            get => CalculativeAttackLv;
            set => CalculativeAttackLv = value;
        }

        public int CalculativeDefenseLv1
        {
            get => CalculativeDefenseLv;
            set => CalculativeDefenseLv = value;
        }

        public virtual void SetCalculative(Pokemon myPokemon, Pokemon yourPokemon)
        {

        }
        
    }
}