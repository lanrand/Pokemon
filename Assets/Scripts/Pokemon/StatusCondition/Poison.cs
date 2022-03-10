using System.Collections;

namespace Pokemon.StatusCondition
{
    public class Poison : StatusCondition//中毒
    {
        public Poison()
        {
            StatusConditionName = "Poison";
            //处于中毒状态的宝可梦会在回合结束时损失最大HP的1⁄8。
        }
        
        public override int AfterAction(Pokemon pokemon)
        {
            pokemon.HpCurrent1 -= pokemon.HpDefault1/8;
            if (pokemon.HpCurrent1 <= 0)
                pokemon.HpCurrent1 = 0;
            return pokemon.HpCurrent1;
        }

    }
}