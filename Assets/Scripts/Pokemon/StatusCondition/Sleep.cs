using System.Collections;
using UnityEngine;

namespace Pokemon.StatusCondition
{
    public class Sleep : StatusCondition//冰冻
    {
        public Sleep()
        {
            StatusConditionName = "Sleep";
            Round = Random.Range(2, 5);
            //持续时间2-4回合。处于睡眠状态的宝可梦每次行动后睡眠状态的持续回合就会减少1。
        }

        public override bool BeforeAction(Pokemon pokemon)
        {
            if (Round > 0)
            {
                Round--;
                return false;
            }
            pokemon.StatusCondition1 = new Normal();
            return true;
        }

    }
}