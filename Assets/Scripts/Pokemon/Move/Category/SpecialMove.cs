using System.Collections;

namespace Pokemon.Move.Category
{
    public class SpecialMove : Category
    {
        public SpecialMove()
        {
            CategoryName = "Special Move";
        }
        
        public override void SetCalculative(Pokemon myPokemon, Pokemon yourPokemon)
        {
            CalculativeAttack = myPokemon.SpecialAttackCurrent1;
            CalculativeDefense = yourPokemon.SpecialDefenseCurrent1;
            CalculativeAttackLv = myPokemon.SpecialAttackLv1;
            CalculativeDefenseLv = yourPokemon.SpecialDefenseLv1;
        }
    }
}