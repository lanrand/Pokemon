using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Pokemon.Move;
using Pokemon.State;
using UnityEngine;
using Debug = UnityEngine.Debug;


namespace Battle
{
    public class

        Battle
    {
        protected InFight Me;

        protected InFight You;

        protected InFight Former;//先手

        protected InFight Latter;//后手

        protected int Round;//回合数

        public InFight Me1
        {
            get => Me;
            set => Me = value;
        }

        public InFight You1
        {
            get => You;
            set => You = value;
        }

        public InFight Former1
        {
            get => Former;
            set => Former = value;
        }

        public InFight Latter1
        {
            get => Latter;
            set => Latter = value;
        }

        public int Round1
        {
            get => Round;
            set => Round = value;
        }


        public void SetOpponent()////////
        {
            Me.Opponent = You;
            You.Opponent = Me;
        }

        public void SetCurrentPokemonList(InFight player, int pack)////////
        {
            if (player.CurrentPokemonList.Count < 3)
                player.CurrentPokemonList.Add(player.BackPackPokemon.Pokemon[pack]);
        }

        public void SetCurrentPokemon(InFight player)
        {
            player.CurrentPokemon = (Pokemon.Pokemon)player.CurrentPokemonList[player.Death];
        }

        public bool SetCurrentUseMove(InFight player, int move)////////true: 出招 false: 不出招   move或跳过
        {
            if (player.Operation == 3)
            {
                for (int i = 0; i < player.CurrentPokemon.CurrentStates1.Count; i++)
                {
                    if (((State)player.CurrentPokemon.CurrentStates1[i]).StateName1.Equals("Stockpile"))
                    {
                        player.CurrentPokemon.CurrentUse1 = ((Stockpile)player.CurrentPokemon.CurrentStates1[i]).Foco1;
                        return true;
                    }
                }
                return false;
            }
            return true;
        }


        public bool SetComputerMove(InFight computer)
        {
            for (int i = 0; i < computer.CurrentPokemon.CurrentStates1.Count; i++)
            {
                if (((State)computer.CurrentPokemon.CurrentStates1[i]).StateName1.Equals("Stockpile"))
                {
                    computer.Operation = 3;
                    computer.CurrentPokemon.CurrentUse1 = ((Stockpile)computer.CurrentPokemon.CurrentStates1[i]).Foco1;
                    return true;
                }
            }

            ArrayList availableMove = new ArrayList();
            for (int i = 0; i < computer.CurrentPokemon.CurrentMoves1.Length; i++)
            {
                if (computer.CurrentPokemon.CurrentMoves1[i].Available1 == true &&
                    computer.CurrentPokemon.CurrentMoves1[i].PpCurrent1 > 0)
                    availableMove.Add(computer.CurrentPokemon.CurrentMoves1[i]);
            }

            if (availableMove.Count == 0)
            {
                computer.Operation = 3;
                return false;
            }

            int rd = Random.Range(0, availableMove.Count);
            computer.CurrentPokemon.CurrentUse1 = (Move)availableMove[rd];
            computer.Operation = 2;
            return true;
        }


        public void SetItem(InFight player, Item.Item item)//bag
        {
            player.Item = item;
        }


        public void SetFormerLatter()
        {
            if (Me.Operation < You.Operation && You.Operation + Me.Operation < 5)
            {
                Former = Me;
                Latter = You;
            }
            else if (Me.Operation > You.Operation && You.Operation + Me.Operation < 5)
            {
                Former = You;
                Latter = Me;
            }
            else
            {
                if (You.Operation + Me.Operation >= 4)
                {
                    if (Me.CurrentPokemon.CurrentUse1.Priority1 > You.CurrentPokemon.CurrentUse1.Priority1)
                    {
                        Former = Me;
                        Latter = You;
                    }
                    else if (Me.CurrentPokemon.CurrentUse1.Priority1 < You.CurrentPokemon.CurrentUse1.Priority1)
                    {
                        Former = You;
                        Latter = Me;
                    }
                    else
                    {
                        if (Me.CurrentPokemon.SpeedCurrent1 * Me.CurrentPokemon.StatCorrect1[Me.CurrentPokemon.SpeedLv1]
                            > You.CurrentPokemon.SpeedCurrent1 * You.CurrentPokemon.StatCorrect1[You.CurrentPokemon.SpeedLv1])
                        {
                            Former = Me;
                            Latter = You;
                        }
                        else if (Me.CurrentPokemon.SpeedCurrent1 * Me.CurrentPokemon.StatCorrect1[Me.CurrentPokemon.SpeedLv1]
                                 < You.CurrentPokemon.SpeedCurrent1 * You.CurrentPokemon.StatCorrect1[You.CurrentPokemon.SpeedLv1])
                        {
                            Former = You;
                            Latter = Me;
                        }
                        else
                        {
                            int tmp = Random.Range(0, 2);
                            if (tmp == 0)
                            {
                                Former = Me;
                                Latter = You;
                            }
                            else
                            {
                                Former = You;
                                Latter = Me;
                            }
                        }
                    }
                }
                else
                {
                    Former = Me;
                    Latter = You;
                }
            }
        }

        public void OneRound()
        {
            SetFormerLatter();
            Operation(Former);
            AfterAction(Former);
            Operation(Latter);
            AfterAction(Latter);
        }

        public bool Operation(InFight player)
        {
            switch (player.Operation)
            {
                case 0:
                    //Escape
                    int ranExit = Random.Range(0, 10);
                    if (ranExit < 6)
                    {
                        battlePVP.ifExit = 1;
                        battlePVE.ifExit = 1;
                    }
                    break;
                case 1:
                    return Bag(player);
                case 2:
                    return Fight(player);
                case -1:
                    /*return Fight(player);//跳过*/
                    return true;
                default:
                    break;
            }
            return true;
        }

        public bool AfterAction(InFight player)
        {
            int resultHp = player.CurrentPokemon.StatusCondition1.AfterAction(player.CurrentPokemon);
            if (resultHp == 0)
            {
                PokemonDefeat(player);
                return false;
            }
            for (int i = 0; i < player.CurrentPokemon.CurrentStates1.Count; i++)
            {
                UnityEngine.Debug.Log(player.CurrentPokemon.CurrentStates1[i]);
                resultHp = 
                    ((State)player.CurrentPokemon.CurrentStates1[i]).AfterAction(player.CurrentPokemon, player.Opponent.CurrentPokemon);
                if (resultHp == 0)
                {
                    PokemonDefeat(player);
                    return false;
                }
            }
            return true;
        }


        public bool Fight(InFight player)//true: 正常结束 false: 一方死亡
        {
/*            UnityEngine.Debug.Log("FightUse1: " + player.CurrentPokemon.CurrentUse1.MoveName1);*/
            if (player == Latter)
            {
                for (int i = 0; i < player.CurrentPokemon.CurrentStates1.Count; i++)
                {
                    if (((State)player.CurrentPokemon.CurrentStates1[i]).StateName1.Equals("Flinch"))
                        return true;
                }
            }
/*            UnityEngine.Debug.Log("FightUse2: " + player.CurrentPokemon.CurrentUse1.MoveName1);*/
            if (player.CurrentPokemon.StatusCondition1.BeforeAction(player.CurrentPokemon))
            {

                int result = player.CurrentPokemon.CurrentUse1.UseMove(player.CurrentPokemon, player.Opponent.CurrentPokemon);
                if (result == 1)
                {
                    //被躲开了！
                    return true;
                }

                if (result == 2)
                {
                    PokemonDefeat(player);
                    return false;
                }
            }
            return true;
        }

        public bool Bag(InFight player) //1: 抓到了，结束游戏
        {
            int result = player.Item.UseInBattle(player.CurrentPokemon, player.Opponent.CurrentPokemon);
            return result == 0;
        }

        public bool Escape(InFight player)
        {
            for (int i = 0; i < player.CurrentPokemon.CurrentStates1.Count; i++)
            {
                if (((State)player.CurrentPokemon.CurrentStates1[i]).StateName1.Equals("Bound"))
                    return false;
            }
            return true;
        }

        public bool PokemonDefeat(InFight player)//true: 游戏继续 false: 游戏结束
        {
            player.Death++;
            if (player.Death < player.CurrentPokemonList.Count)
            {
                SetCurrentPokemon(player);
                return true;
            }
            return true;
        }

        public int[] BattleEnd(InFight winner, InFight loser)//0:不升级 1:升级 2:有新技能不进化 3:无新技能进化 4:有新技能进化 
        {
            int experienceForWinner = 0;
            int experienceForLoser = 0;
            for (int i = 0; i < loser.Death; i++)
                experienceForWinner += (((Pokemon.Pokemon)loser.CurrentPokemonList[i]).Experience()+5);
            experienceForWinner /= winner.CurrentPokemonList.Count;
            experienceForWinner += ((Pokemon.Pokemon)winner.CurrentPokemonList[0]).Lv1 + 7;
            
            Debug.Log(winner.CurrentPokemonList.Count);
            
            for (int i = 0; i < winner.Death; i++)
                experienceForLoser += (((Pokemon.Pokemon)winner.CurrentPokemonList[i]).Experience() + 3);
            experienceForLoser /= loser.CurrentPokemonList.Count;
            experienceForLoser += ((Pokemon.Pokemon)loser.CurrentPokemonList[0]).Lv1+3;

            int[] result1 = new int[winner.CurrentPokemonList.Count];
            int[] result2 = new int[loser.CurrentPokemonList.Count];
            Pokemon.Pokemon[] pokemon1 = new Pokemon.Pokemon[winner.CurrentPokemonList.Count];
            Pokemon.Pokemon[] pokemon2 = new Pokemon.Pokemon[loser.CurrentPokemonList.Count];
            for (int i = 0; i < winner.CurrentPokemonList.Count; i++)
            {
                battlePVE.upName += ((Pokemon.Pokemon)winner.CurrentPokemonList[i]).SpeciesName1 + " get "+ 
                    experienceForWinner+" exp!\n";
                battlePVP.upName += ((Pokemon.Pokemon)winner.CurrentPokemonList[i]).SpeciesName1 + " get " +
                    experienceForWinner + " exp!\n";
                (result1[i], pokemon1[i]) = ((Pokemon.Pokemon)winner.CurrentPokemonList[i]).Settlement(experienceForWinner);
                UnityEngine.Debug.Log(pokemon1[i]);
                ((Pokemon.Pokemon)winner.CurrentPokemonList[i]).Restore();
            }
            for (int i = 0; i < loser.CurrentPokemonList.Count; i++)
            {
                battlePVE.upName += ((Pokemon.Pokemon)loser.CurrentPokemonList[i]).SpeciesName1 + " get " +
                    experienceForLoser + " exp!\n";

                battlePVP.upName += ((Pokemon.Pokemon)loser.CurrentPokemonList[i]).SpeciesName1 + " get " +
                    experienceForLoser + " exp!\n";
                (result2[i], pokemon2[i]) = ((Pokemon.Pokemon)loser.CurrentPokemonList[i]).Settlement(experienceForLoser);
                ((Pokemon.Pokemon)loser.CurrentPokemonList[i]).Restore();
            }
            
            for (int i = 0; i < loser.CurrentPokemonList.Count; i++)
            {
                (result2[i], pokemon2[i]) = ((Pokemon.Pokemon)loser.CurrentPokemonList[i]).Settlement(experienceForLoser);
                ((Pokemon.Pokemon)loser.CurrentPokemonList[i]).Restore();
            }
            
            battlePVP.afterBattle1 = pokemon1;
            battlePVP.afterBattle2 = pokemon2;
            battlePVE.afterBattle1 = pokemon1;
            battlePVE.afterBattle2 = pokemon2;
            return result1;
        }

    }
}