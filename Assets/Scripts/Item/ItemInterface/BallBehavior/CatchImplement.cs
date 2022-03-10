using System;

namespace Item.ItemInterface.BallBehavior
{
    public class CatchImplement : ICatchingBehavior

    {
        private double _probability; //gai lv

        private Player.Player _player;

        public Player.Player Player
        {
            get => _player;
            set => _player = value;
        }

        public double Probability
        {
            get => _probability;
            set => _probability = value;
        }

        private Pokemon.Pokemon _target; //mu biao

        public Pokemon.Pokemon Target
        {
            get => _target;
            set => _target = value;
        }

        //A = (最大ＨＰ×3 - 当前ＨＰ×2) × 捕获率 × 捕获修正 ÷ (最大ＨＰ × 3) + 状态修正
        //冰冻、睡眠：2×
        //中毒、灼伤、麻痹：1.5×
        public int Catch()
        {
            double b = 1;
            if (_target.StatusCondition1.StatusConditionName1.Equals("Freeze") ||
                _target.StatusCondition1.StatusConditionName1.Equals("Sleep"))
            {
                b = 2;
            }
            else if (_target.StatusCondition1.StatusConditionName1.Equals("Poison") ||
                     _target.StatusCondition1.StatusConditionName1.Equals("Burn") ||
                     _target.StatusCondition1.StatusConditionName1.Equals("Paralysis"))

            {
                b = 1.5;
            }

            double a = (_target.HpDefault1 * 3 - _target.HpCurrent1) * _target.CatchRate1 * _probability /
                       (_target.HpDefault1 * 3);
            double c = a * b;//0-255
            Random rd = new Random();
            int random = rd.Next(256);
            if (random < c)
            {
                //cheng gong!!
                int flag = 0;
                if (_player.BackPackPokemon.Pointer <= 5)
                {
                    _player.BackPackPokemon.AddPokemon(_target);
                }
                else
                {
                    _player.Home.Pokemon.Add(_target);//背包满入库
                }
                // if (flag == 0)
                // {
                //     _player.Home.Pokemon.Add(_target);//背包满入库
                // }

                return 1;
            }
            else
            {
                return 0;
            }
        }

        public void SetProbability(double p)
        {
            this._probability = p;
        }

        public void SetPlayer(Player.Player player)
        {
            this._player = player;
        }

        public void SetTarget(Pokemon.Pokemon pokemon)
        {
            this._target = pokemon;
        }
    }
}