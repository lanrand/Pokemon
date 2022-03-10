using System.Collections;

namespace Pokemon.StatusCondition
{
    public class Freeze : StatusCondition//冰冻
    {
        public Freeze()
        {
            StatusConditionName = "Freeze";
            //处于冰冻状态的宝可梦只能成功使出解除冰冻状态的招式，使用其他招式时会失败。
            //宝可梦在受到火属性攻击招式攻击时解除冰冻状态.
            //处于冰冻状态的宝可梦在每次行动前有20%几率解除冰冻状态。
        }
    }
}