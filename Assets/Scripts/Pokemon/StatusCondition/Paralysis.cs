using System.Collections;
using UnityEngine;

namespace Pokemon.StatusCondition
{
    public class Paralysis : StatusCondition//麻痹
    {
        public Paralysis()
        {
            StatusConditionName = "Paralysis";
            //处于麻痹状态的宝可梦速度会减半，并且在使用招式时有40%几率无法行动。
        }

        public override void Immediate(Pokemon pokemon)
        {
            pokemon.SpeedCurrent1 /= 2;
        }

        public override bool BeforeAction(Pokemon pokemon)
        {
            if (Random.Range(0, 10) < 4)
                return false;
            return true;
        }

        public override void Recover(Pokemon pokemon)
        {
            pokemon.SpeedCurrent1 *= 2;
        }
    }
}