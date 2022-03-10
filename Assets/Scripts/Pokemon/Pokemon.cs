using System;
using System.Collections;
using System.Collections.Generic;
using Pokemon.Move;
using Pokemon.Nature;
using Pokemon.Species;
using Pokemon.StatusCondition;
using Pokemon.Type;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Pokemon
{
    public class Pokemon 
    {
        //Stat能力
        
        protected int HpCurrent;
        protected int HpDefault;
        protected int AttackCurrent;
        protected int AttackDefault;
        protected int DefenseCurrent;
        protected int DefenseDefault;
        protected int SpecialAttackCurrent;
        protected int SpecialAttackDefault;
        protected int SpecialDefenseCurrent;
        protected int SpecialDefenseDefault;
        protected int SpeedCurrent;
        protected int SpeedDefault;

        protected int AttackLv = 6;
        protected int DefenseLv = 6;
        protected int SpecialAttackLv = 6;
        protected int SpecialDefenseLv = 6;
        protected int SpeedLv = 6;
        protected int AccuracyLv = 6;//命中率
        protected int EvasionLv = 6;//闪避率
        protected double[] StatCorrect = {0.25, 0.29, 0.33, 0.4, 0.5, 0.67, 1, 1.5, 2, 2.5, 3, 3.5, 4};
        protected double[] AccuracyCorrect = {0.33, 0.38, 0.43, 0.5, 0.6, 0.75, 1, 1.33, 1.67, 2, 2.33, 2.67, 3};

        //Species种族
        
        protected int Number;
        protected string SpeciesName;
        protected Type.Type Type;//属性
        protected Dictionary<int, Move.Move> LvMove = new Dictionary<int, Move.Move>();//这个宝可梦能学的技能列表
        protected int[] SpeciesStrength = new int[6];//种族值，血攻防特特速
        protected ExpSpeed.ExpSpeed ExpSpeed;//经验累积速度
        protected int BasicExperience;//基础经验值
        protected int CatchRate;//捕获率
        protected int EvolutionLv;
        protected int MinLv;//最低等级

        //Individual个体

        protected string IndividualName;
        protected Nature.Nature Nature;//性格
        protected int Iv;//个体值0-31
        protected int Lv;
        protected int CurrentExp;//当前经验
        protected int ExpNeed;//到下一级所需经验
        protected ArrayList AllMove = new ArrayList();
        
        //Move技能
        
        protected Move.Move[] CurrentMoves = new Move.Move[4];//当前Move列表
        protected Move.Move CurrentUse;//当前使用的技能
        protected Move.Move LastUse;//上一次使用的技能
        protected Move.Move LastReceived;//上一次受到的技能
        protected StatusCondition.StatusCondition StatusCondition = new StatusCondition.Normal();//异常状态，只能同时存在一个
        protected ArrayList CurrentStates = new ArrayList();//状态变化，可以共存，string


        //get set
        
        public int HpCurrent1
        {
            get => HpCurrent;
            set => HpCurrent = value;
        }
        public int HpDefault1
        {
            get => HpDefault;
            set => HpDefault = value;
        }
        public int AttackCurrent1
        {
            get => AttackCurrent;
            set => AttackCurrent = value;
        }
        public int AttackDefault1
        {
            get => AttackDefault;
            set => AttackDefault = value;
        }
        public int DefenseCurrent1
        {
            get => DefenseCurrent;
            set => DefenseCurrent = value;
        }
        public int DefenseDefault1
        {
            get => DefenseDefault;
            set => DefenseDefault = value;
        }
        public int SpecialAttackCurrent1
        {
            get => SpecialAttackCurrent;
            set => SpecialAttackCurrent = value;
        }
        public int SpecialAttackDefault1
        {
            get => SpecialAttackDefault;
            set => SpecialAttackDefault = value;
        }
        public int SpecialDefenseCurrent1
        {
            get => SpecialDefenseCurrent;
            set => SpecialDefenseCurrent = value;
        }
        public int SpecialDefenseDefault1
        {
            get => SpecialDefenseDefault;
            set => SpecialDefenseDefault = value;
        }
        public int SpeedCurrent1
        {
            get => SpeedCurrent;
            set => SpeedCurrent = value;
        }
        public int SpeedDefault1
        {
            get => SpeedDefault;
            set => SpeedDefault = value;
        }

        public int AttackLv1
        {
            get => AttackLv;
            set => AttackLv = value;
        }
        public int DefenseLv1
        {
            get => DefenseLv;
            set => DefenseLv = value;
        }
        public int SpecialAttackLv1
        {
            get => SpecialAttackLv;
            set => SpecialAttackLv = value;
        }
        public int SpecialDefenseLv1
        {
            get => SpecialDefenseLv;
            set => SpecialDefenseLv = value;
        }
        public int SpeedLv1
        {
            get => SpeedLv;
            set => SpeedLv = value;
        }
        public int AccuracyLv1
        {
            get => AccuracyLv;
            set => AccuracyLv = value;
        }
        public int EvasionLv1
        {
            get => EvasionLv;
            set => EvasionLv = value;
        }
        public double[] StatCorrect1
        {
            get => StatCorrect;
            set => StatCorrect = value;
        }
        public double[] AccuracyCorrect1
        {
            get => AccuracyCorrect;
            set => AccuracyCorrect = value;
        }

        public int Number1
        {
            get => Number;
            set => Number = value;
        }

        public string SpeciesName1
        {
            get => SpeciesName;
            set => SpeciesName = value;
        }
        
        public ArrayList AllMove1
        {
            get => AllMove;
            set => AllMove = value;
        }

        public Dictionary<int, Move.Move> LvMove1
        {
            get => LvMove;
            set => LvMove = value;
        }

        public int[] SpeciesStrength1
        {
            get => SpeciesStrength;
            set => SpeciesStrength = value;
        }

        public Type.Type Type1
        {
            get => Type;
            set => Type = value;
        }

        public ExpSpeed.ExpSpeed ExpSpeed1
        {
            get => ExpSpeed;
            set => ExpSpeed = value;
        }
        
        public int BasicExperience1
        {
            get => BasicExperience;
            set => BasicExperience = value;
        }


        public int CatchRate1
        {
            get => CatchRate;
            set => CatchRate = value;
        }
        
        public int EvolutionLv1
        {
            get => EvolutionLv;
            set => EvolutionLv = value;
        }

        public int MinLv1
        {
            get => MinLv;
            set => MinLv = value;
        }

        public string IndividualName1
        {
            get => IndividualName;
            set => IndividualName = value;
        }

        public Nature.Nature Nature1
        {
            get => Nature;
            set => Nature = value;
        }

        public int Iv1
        {
            get => Iv;
            set => Iv = value;
        }

        public int Lv1
        {
            get => Lv;
            set => Lv = value;
        }

        public int CurrentExp1
        {
            get => CurrentExp;
            set => CurrentExp = value;
        }

        public int ExpNeed1
        {
            get => ExpNeed;
            set => ExpNeed = value;
        }

        public Move.Move[] CurrentMoves1
        {
            get => CurrentMoves;
            set => CurrentMoves = value;
        }

        public Move.Move CurrentUse1
        {
            get => CurrentUse;
            set => CurrentUse = value;
        }

        public Move.Move LastUse1
        {
            get => LastUse;
            set => LastUse = value;
        }

        public Move.Move LastReceived1
        {
            get => LastReceived;
            set => LastReceived = value;
        }

        public ArrayList CurrentStates1
        {
            get => CurrentStates;
            set => CurrentStates = value;
        }

        public StatusCondition.StatusCondition StatusCondition1
        {
            get => StatusCondition;
            set => StatusCondition = value;
        }


        //Default Calculation
        
        public void HpCalculate()
        {
            HpDefault = ((SpeciesStrength[0] * 2 + Iv) * Lv) / 100 + 10 + Lv;
        }
        public void AttackCalculate()
        {
            AttackDefault = (int)((((SpeciesStrength[1] * 2 + Iv) * Lv) / 100 + 5) * Nature.AttackCorrection);
        }
        public void DefenseCalculate()
        {
            DefenseDefault = (int)((((SpeciesStrength[2] * 2 + Iv) * Lv) / 100 + 5) * Nature.DefenseCorrection);
        }
        public void SpecialAttackCalculate()
        {
            SpecialAttackDefault = (int)((((SpeciesStrength[3] * 2 + Iv) * Lv) / 100 + 5) * Nature.SpecialAttackCorrection);
        }
        public void SpecialDefenseCalculate()
        {
            SpecialDefenseDefault = (int)((((SpeciesStrength[4] * 2 + Iv) * Lv) / 100 + 5) * Nature.SpecialDefenseCorrection);
        }
        public void SpeedCalculate()
        {
            SpeedDefault = (int)((((SpeciesStrength[1] * 2 + Iv) * Lv) / 100 + 5) * Nature.SpeedCorrection);
        }
        
        public void StatLvCorrection()
        {
            if (AttackLv > 12)
                AttackLv = 12;
            if (AttackLv < 0)
                AttackLv = 0;
            if (DefenseLv > 12)
                DefenseLv = 12;
            if (DefenseLv < 0)
                DefenseLv = 0;
            if (SpecialAttackLv > 12)
                SpecialAttackLv = 12;
            if (SpecialAttackLv < 0)
                SpecialAttackLv = 0;
            if (SpecialDefenseLv> 12)
                SpecialDefenseLv = 12;
            if (SpecialDefenseLv < 0)
                SpecialDefenseLv = 0;
            if (SpeedLv > 12)
                SpeedLv = 12;
            if (SpeedLv < 0)
                SpeedLv = 0;
            if (AccuracyLv > 12)
                AccuracyLv = 12;
            if (AccuracyLv < 0)
                AccuracyLv = 0;
            if (EvasionLv > 12)
                EvasionLv = 12;
            if (EvasionLv < 0)
                EvasionLv = 0;
        }

        public virtual Pokemon Evolution()
        {
            return null;
        }


        public void DefaultPokemon(int lv) //初始化新宝可梦
        {
            Lv = lv;
            HpCalculate();
            AttackCalculate();
            DefenseCalculate();
            SpecialAttackCalculate();
            SpecialDefenseCalculate();
            SpeedCalculate();
            HpCurrent = HpDefault;
            AttackCurrent = AttackDefault;
            DefenseCurrent = DefenseDefault;
            SpecialAttackCurrent = SpecialAttackDefault;
            SpecialDefenseCurrent = SpecialDefenseDefault;
            SpeedCurrent = SpeedDefault;
        }

        public void InitialPokemon(int lv)/////////////////////////////////
        {
            IndividualName = SpeciesName;
            LoadNatureModule natureModule = new LoadNatureModule();
            natureModule.SetNatureRandomly(this);
            Iv = Random.Range(0, 32);
            Lv = lv;
            DefaultPokemon(lv);
            CurrentExp = 0;
            ExpNeed = ExpSpeed.ExpAccumulate[lv];
            SetAllMove();
            SetMoveRandomly();
        }

        public void SetAllMove()
        {
            AllMove.Clear();
            foreach (int key in LvMove.Keys)
            {
                if(key <= Lv)
                    AllMove.Add(LvMove[key]);
            }
        }

        public void SetMoveRandomly()
        {
            for (int j = 0; j < 4; j++)
                CurrentMoves[j] = new Move.Move();
            ArrayList tmp = new ArrayList();
            foreach (Move.Move move in AllMove)
                tmp.Add(move);
            int i = 0;
            while (tmp.Count > 0 && i < 4)
            {
                int rd = Random.Range(0, tmp.Count);
                CurrentMoves[i] = (Move.Move)tmp[rd];
                tmp.Remove(tmp[rd]);
                i++;
            }
        }
        
        //战斗结算
        public (int,Pokemon) Settlement(int experience)
        {
            CurrentExp += experience;
            return Upgrade();
        }

        public void Restore()
        {
            DefenseLv = 6;
            SpecialAttackLv = 6;
            SpecialDefenseLv = 6;
            SpeedLv = 6;
            AccuracyLv = 6;
            EvasionLv = 6;
            CurrentUse = null;
            LastUse = null;
            LastReceived = null;
            CurrentStates.Clear();
        }

        public (int,Pokemon) Upgrade() //0:不升级 1:升级 2:有新技能不进化 3:无新技能进化 4:有新技能进化 
        {
            if (CurrentExp >= ExpNeed)
            {
                int originalMove = AllMove.Count;
                while (CurrentExp >= ExpNeed)
                {
                    Lv++;
                    CurrentExp -= ExpNeed;
                    ExpNeed = ExpSpeed.ExpAccumulate[Lv] - ExpSpeed.ExpAccumulate[Lv - 1];
                }

                if (Lv < EvolutionLv)
                {
                    DefaultPokemon(Lv);
                    StatusCondition = new StatusCondition.Normal();
                    SetAllMove();
                    if (AllMove.Count > originalMove)
                        return (2,this);
                    return (1,this);
                }
                else
                {
                    Pokemon newPokemon = EvolutionTrigger(Lv);
                    if (AllMove.Count > originalMove)
                        return (4,newPokemon);
                    return (3,newPokemon);
                }
            }

            return (0,this);
        }


        public Pokemon EvolutionTrigger(int lv)
        {
            Pokemon newPokemon = this.Evolution();
            newPokemon.Nature1 = this.Nature;
            newPokemon.DefaultPokemon(lv);
            newPokemon.IndividualName1 = this.IndividualName;
            newPokemon.Iv1 = this.Iv;
            newPokemon.CurrentExp1 = CurrentExp;
            newPokemon.SetAllMove();
            return newPokemon;
        }

        public int Experience()
        {
            return (int)(1.5 * 1.5 * Lv * BasicExperience / 7);
        }
        
        
    }

    public class LoadPokemonModule
    {
        private Pokemon _bulbasaur = new Bulbasaur();
        private Pokemon _ivysaur = new Ivysaur();
        private Pokemon _venusaur = new Venusaur();
        private Pokemon _charmander = new Charmander();
        private Pokemon _charmeleon = new Charmeleon();
        private Pokemon _charizard = new Charizard();
        private Pokemon _squirtle = new Squirtle();
        private Pokemon _wartortle = new Wartortle();
        private Pokemon _blastoise = new Blastoise();
        private Pokemon _pidgey = new Pidgey();
        private Pokemon _pidgeotto = new Pidgeotto();
        private Pokemon _pidgeot = new Pidgeot();
        private Pokemon _pikachu = new Pikachu();
        private Pokemon _raichu = new Raichu();
        private Pokemon _grimer = new Grimer();
        private Pokemon _muk = new Muk();
        private ArrayList _allPokemon = new ArrayList();

        public LoadPokemonModule()
        {
            _allPokemon.Add(_bulbasaur);
            _allPokemon.Add(_ivysaur);
            _allPokemon.Add(_venusaur);
            _allPokemon.Add(_charmander);
            _allPokemon.Add(_charmeleon);
            _allPokemon.Add(_charizard);
            _allPokemon.Add(_squirtle);
            _allPokemon.Add(_wartortle);
            _allPokemon.Add(_blastoise);
            _allPokemon.Add(_pidgey);
            _allPokemon.Add(_pidgeotto);
            _allPokemon.Add(_pidgeot);
            _allPokemon.Add(_pikachu);
            _allPokemon.Add(_raichu);
            _allPokemon.Add(_grimer);
            _allPokemon.Add(_muk);
        }

        public Pokemon SetPokemonRandomly(int lv)
        {
            ArrayList pokemonAvailable = new ArrayList();
            for (int i = 0; i < _allPokemon.Count; i++)
            {
                if (((Pokemon)_allPokemon[i]).MinLv1 <= lv && lv < ((Pokemon)_allPokemon[i]).EvolutionLv1)
                {
                    pokemonAvailable.Add(_allPokemon[i]);
                }
            }
            int rd = Random.Range(0, pokemonAvailable.Count);
            return (Pokemon)pokemonAvailable[rd];
        }

    }
}
