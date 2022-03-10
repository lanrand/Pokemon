using UnityEngine;
using System;
using System.Collections;

namespace Pokemon.State
{
    public class State
    {
        protected string StateName;

        protected int Round;

        public string StateName1
        {
            get => StateName;
            set => StateName = value;
        }

        public int Round1
        {
            get => Round;
            set => Round = value;
        }

        public virtual int AfterAction(Pokemon myPokemon, Pokemon yourPokemon)
        {
            //int: 剩余血量
            return myPokemon.HpCurrent1;
        }
    }
}