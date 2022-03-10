using System.Collections;

namespace Pokemon.StatusCondition
{
    public class Burn : StatusCondition//灼伤
    {
        public Burn()
        {
            StatusConditionName = "Burn";
            //处于灼伤状态的宝可梦使用非固定伤害类物理招式的伤害会减半，并在回合结束时损失最大HP的1⁄16。
        }
        
        public override void Immediate(Pokemon pokemon)
        {
            pokemon.AttackCurrent1 /= 2;
        }
        
        public override int AfterAction(Pokemon pokemon)
        {
            pokemon.HpCurrent1 -= pokemon.HpDefault1/16;
            if (pokemon.HpCurrent1 <= 0)
                pokemon.HpCurrent1 = 0;
            return pokemon.HpCurrent1;
        }

        public override void Recover(Pokemon pokemon)
        {
            pokemon.AttackCurrent1 *= 2;
        }
    }
}