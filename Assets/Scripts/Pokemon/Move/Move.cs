using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace Pokemon.Move
{
    public class Move
    {
        protected string MoveName;

        protected Type.Type Type;

        protected Category.Category Category;

        protected int PpDefault;

        protected int PpCurrent;

        protected int Power;

        protected int Accuracy; //13x/5-5, max900

        protected int Damage;

        protected int C = 0;

        protected int[] EasyToHit = { 16, 8, 4, 3, 2 };

        protected int Priority = 0;

        protected bool Available = true;

        public string MoveName1
        {
            get => MoveName;
            set => MoveName = value;
        }

        public Type.Type Type1
        {
            get => Type;
            set => Type = value;
        }

        public Category.Category Category1
        {
            get => Category;
            set => Category = value;
        }

        public int PpDefault1
        {
            get => PpDefault;
            set => PpDefault = value;
        }

        public int PpCurrent1
        {
            get => PpCurrent;
            set => PpCurrent = value;
        }

        public int Power1
        {
            get => Power;
            set => Power = value;
        }

        public int Accuracy1
        {
            get => Accuracy;
            set => Accuracy = value;
        }

        public int Damage1
        {
            get => Damage;
            set => Damage = value;
        }

        public int C1
        {
            get => C;
            set => C = value;
        }

        public int[] EasyToHit1
        {
            get => EasyToHit;
            set => EasyToHit = value;
        }

        public int Priority1
        {
            get => Priority;
            set => Priority = value;
        }

        public bool Available1
        {
            get => Available;
            set => Available = value;
        }

        //Damage

        public bool AccuracyJudgement(Pokemon myPokemon, Pokemon yourPokemon) //true: 命中 false: “被躲开了！”
        {
            int rd = Random.Range(0, 255);
            if (rd < (Accuracy / 5 * 13 - 5) * myPokemon.AccuracyLv1 * myPokemon.AccuracyCorrect1[myPokemon.AccuracyLv1]
                / (yourPokemon.EvasionLv1 * yourPokemon.AccuracyCorrect1[yourPokemon.EvasionLv1]))
            {
                return true;
            }
            return false;
        }

        public double TypeConsistentEffect(Pokemon myPokemon) //属性一致
        {
            if (myPokemon.Type1.TypeName.Equals(Type.TypeName))
                return 1.5;
            return 1;
        }

        public bool CriticalHit() //true: “击中要害！” false: 普通伤害
        {
            int rd = Random.Range(0, EasyToHit[C]);
            if (rd < 1)
            {
                Damage = (int)(Damage * 1.5);
                return true;
            }
            return false;
        }

        public double SetDamage(Pokemon myPokemon, Pokemon yourPokemon) //2: “效果拔群！” 1: 有效果 0.5: “效果不太好...”
        {
            if (Category.CategoryName1.Equals("Status Move"))
            {
                Damage = 0;
            }
            else
            {

                Category.SetCalculative(myPokemon, yourPokemon);
                Damage = (int)(((2 * myPokemon.Lv1 + 10) * Category.CalculativeAttack1 * myPokemon.StatCorrect1[Category.CalculativeAttackLv1] * Power
                        / (Category.CalculativeDefense1 * yourPokemon.StatCorrect1[Category.CalculativeDefenseLv1] * 250) + 2)
                        * TypeConsistentEffect(myPokemon) * Type.TypeEffect(yourPokemon.Type1) * Random.Range(85, 101) / 100);

                Debug.Log(myPokemon.SpeciesName1+" use " +myPokemon.CurrentUse1.MoveName
                    + " ("+myPokemon.CurrentUse1.Category1.CategoryName1+ ") Damege " + Damage+" blood!");
                battlePVE.battleInformation += myPokemon.SpeciesName1 + " use " + myPokemon.CurrentUse1.MoveName +
                    "\n (" + myPokemon.CurrentUse1.Category1.CategoryName1 + ") Damege "  + Damage + " blood!\n";
                battlePVP.battleInformation += myPokemon.SpeciesName1 + " use " + myPokemon.CurrentUse1.MoveName +
                    "\n (" + myPokemon.CurrentUse1.Category1.CategoryName1 + ") Damege " + Damage + " blood!\n";
            }
            return Type.TypeEffect(yourPokemon.Type1);
        }

        public int CauseDamage(Pokemon pokemon) //int<=0: “xxx被打败了！” 剩余血量
        {
            // “造成xx伤害”
            Debug.Log(pokemon.SpeciesName1 + " lost " + Damage + " blood!");
            battlePVE.battleInformation += pokemon.SpeciesName1 + " lost " + Damage + " blood!\n";
            battlePVP.battleInformation += pokemon.SpeciesName1 + " lost " + Damage + " blood!\n";

            pokemon.HpCurrent1 -= Damage;
            if (pokemon.HpCurrent1 <= 0)
                pokemon.HpCurrent1 = 0;
            return pokemon.HpCurrent1;
        }

        public virtual int[] StatChange(Pokemon myPokemon, Pokemon yourPokemon)
        {
            //0: A 1: D 2: SA 3: SD 4: Speed 5: Accuracy 6: Evasion for myPokemon
            //10: A 11: D 12: SA 13: SD 14: Speed 15: Accuracy 16: Evasion for yourPokemon
            //-2: 大幅下降 -1: 下降了 0: 没有什么变化 1: 提升了 2: 大幅提升
            int[] tmp = { -1, 0 };
            return tmp;
        }

        public virtual int SetStatusCondition(Pokemon myPokemon, Pokemon yourPokemon)
        {
            //0: A 1: D 2: SA 3: SD 4: Speed 5: Accuracy 6: Evasion for myPokemon
            //10: 麻痹 11: 中毒 12: 灼伤 13: 睡眠 14: 寄生种子 15: 束缚 16: 畏缩 for yourPokemon
            if (!yourPokemon.StatusCondition1.StatusConditionName1.Equals("Normal"))
            {
                Debug.Log(yourPokemon.SpeciesName1 + " is " + yourPokemon.StatusCondition1.StatusConditionName1);
                battlePVE.battleInformation += yourPokemon.SpeciesName1 + " is " + yourPokemon.StatusCondition1.StatusConditionName1 + "\n";
                battlePVP.battleInformation += yourPokemon.SpeciesName1 + " is " + yourPokemon.StatusCondition1.StatusConditionName1 + "\n";
            }
            return -1;
        }

        public virtual int SetState(Pokemon myPokemon, Pokemon yourPokemon)
        {
            //0: A 1: D 2: SA 3: SD 4: Speed 5: Accuracy 6: Evasion for myPokemon
            //10: 寄生种子 11: 定身法 12: 畏缩 13: 愤怒 14: 蓄力 15: 束缚 for yourPokemon
            for(int i = 0; i < yourPokemon.CurrentStates1.Count; i++)
            {
                Debug.Log(myPokemon.SpeciesName1 + " is " + ((State.State)yourPokemon.CurrentStates1[i]).StateName1);
/*                battlePVE.battleInformation += myPokemon.SpeciesName1 + " is " + 
                    ((State.State)yourPokemon.CurrentStates1[i]).StateName1 + "\n";
                battlePVP.battleInformation += myPokemon.SpeciesName1 + " is " +
                    ((State.State)yourPokemon.CurrentStates1[i]).StateName1 + "\n";*/
            }
            return -1;
        }
        void delayOpen()
        {

        }
        public virtual int UseMove(Pokemon myPokemon, Pokemon yourPokemon)
        {
            // “xx使用了xx技能！”
            myPokemon.LastUse1 = this;
            PpCurrent--;
            if (PpCurrent <= 0)
            {
                Available = false;
                Debug.Log("The move' pp is zero!");
                battlePVE.battleInformation += "The move' pp is zero!\n";
            }
            if (AccuracyJudgement(myPokemon, yourPokemon)&&Available)
            {
                //if PhysicalMove && yourPokemon.愤怒 
                if (!Category.CategoryName1.Equals("Status Move"))
                {
                    foreach (State.State state in yourPokemon.CurrentStates1)
                    {
                        if (state.StateName1.Equals("Rage"))
                            yourPokemon.AttackLv1++;
                    }
                    yourPokemon.LastReceived1 = this;
                    SetDamage(myPokemon, yourPokemon); //“效果拔群！”
                    if (CriticalHit())
                    {
                        //“击中要害！”
                        Debug.Log(myPokemon.SpeciesName1 + " use " + myPokemon.CurrentUse1.MoveName1 + " hit the needle!");
                        battlePVE.battleInformation += myPokemon.SpeciesName1 + " use "
                            + myPokemon.CurrentUse1.MoveName1 + " Critical Hit!\n";
                        battlePVP.battleInformation += myPokemon.SpeciesName1 + " use "
                            + myPokemon.CurrentUse1.MoveName1 + " Critical Hit!\n";
                    }
                    //“造成xxx伤害！”
                    if (CauseDamage(yourPokemon) <= 0)
                    {
                        Debug.Log(yourPokemon.SpeciesName1 + " is defeated!");
                        battlePVE.battleInformation += yourPokemon.SpeciesName1 + " is defeated!" + "\n";
                        battlePVP.battleInformation += yourPokemon.SpeciesName1 + " is defeated!" + "\n";
                        return 2; //“xx被打败了！”，触发换精灵/游戏结束
                    }
                }
                else
                {

                    battlePVE.battleInformation += myPokemon.SpeciesName1 + " use " + myPokemon.CurrentUse1.MoveName1+"(Status Move)!\n";
                    battlePVP.battleInformation += myPokemon.SpeciesName1 + " use " + myPokemon.CurrentUse1.MoveName1 + "(Status Move)!\n";

                }
                SetState(myPokemon, yourPokemon);
                if (yourPokemon.StatusCondition1.StatusConditionName1.Equals("Normal"))
                {
                    SetStatusCondition(myPokemon, yourPokemon); //“xx灼伤了”
                    yourPokemon.StatusCondition1.Immediate(yourPokemon);
                }
                StatChange(myPokemon, yourPokemon); //“xx攻击力下降了”
                myPokemon.StatLvCorrection();
                yourPokemon.StatLvCorrection();
                Debug.Log("sd " + yourPokemon.HpCurrent1);
                return 0; //回合正常结束，判定自身状态
            }

            Debug.Log(yourPokemon.SpeciesName1+" avoid it！");
            battlePVE.battleInformation += yourPokemon.SpeciesName1 + " avoid it！\n";
            battlePVP.battleInformation += yourPokemon.SpeciesName1 + " avoid it！\n";
            return 1; //“被躲开了！”，回合结束，判定自身状态
        }
    }
}