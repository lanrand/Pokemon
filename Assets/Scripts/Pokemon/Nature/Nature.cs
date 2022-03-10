using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Pokemon.Nature
{
    public class Nature
    {
        protected string _natureName;
        protected double _attackCorrection = 0;
        protected double _defenseCorrection;
        protected double _specialAttackCorrection;
        protected double _specialDefenseCorrection;
        protected double _speedCorrection;


        public string NatureName
        {
            get => _natureName;
            //set => _natureName = value;
        }
        
        public double AttackCorrection
        {
            get => _attackCorrection;
            set => _attackCorrection = value;
        }
        
        public double DefenseCorrection
        {
            get => _defenseCorrection;
            set => _defenseCorrection = value;
        }
        
        public double SpecialAttackCorrection
        {
            get => _specialAttackCorrection;
            set => _specialAttackCorrection = value;
        }
        
        public double SpecialDefenseCorrection
        {
            get => _specialDefenseCorrection;
            set => _specialDefenseCorrection = value;
        }
        
        public double SpeedCorrection
        {
            get => _speedCorrection;
            set => _speedCorrection = value;
        }
    }

    
    public class LoadNatureModule
    {
        private Nature _relaxed = new Relaxed();
        private Nature _timid = new Timid();
        private Nature _adamant = new Adamant();
        private Nature _rash = new Rash();
        private Nature _gentle = new Gentle();
        private ArrayList _allNature = new ArrayList();
        private Dictionary<string, Nature> _natureDictionary = new Dictionary<string, Nature>();
    
        public ArrayList AllNature
        {
            get => _allNature;
            set => _allNature = value;
        }
        
        public Dictionary<string, Nature> NatureDictionary
        {
            get => _natureDictionary;
            set => _natureDictionary = value;
        }
    
        public LoadNatureModule()
        {
            _allNature.Add(_relaxed);
            _allNature.Add(_timid);
            _allNature.Add(_adamant);
            _allNature.Add(_rash);
            _allNature.Add(_gentle);
            _natureDictionary.Add(_relaxed.NatureName,_relaxed);
            _natureDictionary.Add(_timid.NatureName,_timid);
            _natureDictionary.Add(_adamant.NatureName,_adamant);
            _natureDictionary.Add(_rash.NatureName,_rash);
            _natureDictionary.Add(_gentle.NatureName,_gentle);
        }
    
        public void SetNature(Pokemon pokemon, Nature nature)
        {
            pokemon.Nature1 = nature;
            pokemon.AttackDefault1 = (int)(pokemon.AttackDefault1 * pokemon.Nature1.AttackCorrection);
            pokemon.DefenseDefault1 = (int)(pokemon.DefenseDefault1 * pokemon.Nature1.DefenseCorrection);
            pokemon.SpecialAttackDefault1 = (int)(pokemon.SpecialAttackDefault1 * pokemon.Nature1.SpecialAttackCorrection);
            pokemon.SpecialDefenseDefault1 = (int)(pokemon.SpecialDefenseDefault1 * pokemon.Nature1.SpecialDefenseCorrection);
            pokemon.SpeedDefault1 = (int)(pokemon.SpeedDefault1 * pokemon.Nature1.SpeedCorrection);
        }
        
        public void SetNatureRandomly(Pokemon pokemon)
        {
            SetNature(pokemon, (Nature)_allNature[Random.Range(0, 5)]);
        }
    
        
        public void ChangeNatureRandomly(Pokemon pokemon)
        {
            string origin = pokemon.Nature1.NatureName;
            while (origin.Equals(pokemon.Nature1.NatureName))
            {
                RestNatureBonus(pokemon);
                SetNatureRandomly(pokemon);
            }
        }
    
        public void RestNatureBonus(Pokemon pokemon)
        {
            pokemon.AttackDefault1 = (int)(pokemon.AttackDefault1 / pokemon.Nature1.AttackCorrection);
            pokemon.DefenseDefault1 = (int)(pokemon.DefenseDefault1 / pokemon.Nature1.DefenseCorrection);
            pokemon.SpecialAttackDefault1 = (int)(pokemon.SpecialAttackDefault1 / pokemon.Nature1.SpecialAttackCorrection);
            pokemon.SpecialDefenseDefault1 = (int)(pokemon.SpecialDefenseDefault1 / pokemon.Nature1.SpecialDefenseCorrection);
            pokemon.SpeedDefault1 = (int)(pokemon.SpeedDefault1 / pokemon.Nature1.SpeedCorrection);
        }
    
    }
}