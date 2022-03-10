using System.Collections;

namespace Pokemon.Move.Category
{
    public class PhysicalMove : Category
    {
        public PhysicalMove()
        {
            CategoryName = "Physical Move";
        }
        
        public override void SetCalculative(Pokemon myPokemon, Pokemon yourPokemon)
        {
            CalculativeAttack = myPokemon.AttackCurrent1;
            CalculativeDefense = yourPokemon.DefenseCurrent1;
            CalculativeAttackLv = myPokemon.AttackLv1;
            CalculativeDefenseLv = yourPokemon.DefenseLv1;
        }
    }
}