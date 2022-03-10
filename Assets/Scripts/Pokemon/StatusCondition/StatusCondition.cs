using UnityEngine;
using System;
using System.Collections;

namespace Pokemon.StatusCondition
{
    public class StatusCondition
    {
        protected string StatusConditionName;

        protected int Round;

        public string StatusConditionName1
        {
            get => StatusConditionName;
            set => StatusConditionName = value;
        }

        public int Round1
        {
            get => Round;
            set => Round = value;
        }
        
        public virtual void Immediate(Pokemon pokemon)
        {
            
        }

        public virtual bool BeforeAction(Pokemon pokemon)
        {
            //true: 可以出招 false: 不能出招
            return true;
        }

        public virtual int AfterAction(Pokemon pokemon)
        {
            //int: 剩余血量
            return pokemon.HpCurrent1;
        }
        
        public virtual void Recover(Pokemon pokemon)
        {
            
        }
    }

    
    // public class LoadStatusConditionModule
    // {
    //     private StatusCondition _normal = new StatusCondition("Normal");
    //     private StatusCondition _burn = new StatusCondition("Burn");
    //     private StatusCondition _freeze = new StatusCondition("Freeze");
    //     private StatusCondition _paralysis = new StatusCondition("Paralysis");
    //     private StatusCondition _poison = new StatusCondition("Poison");
    //     private StatusCondition _badlyPoison = new StatusCondition("Badly Poison");
    //     private StatusCondition _sleep = new StatusCondition("Sleep");
    //     
    //     public LoadStatusConditionModule(){}
    //
    // }
}