
using Newtonsoft.Json;
using Player;

namespace Archive
{
    public class ArchivePlayer
    {
        private string _playerName;

        private int _money;


        private Home _home = new Home();

        public string PlayerName
        {
            get => _playerName;
            set => _playerName = value;
        }

        public int Money
        {
            get => _money;
            set => _money = value;
        }

        public Pokemon.Pokemon[] CurrentPokemonList
        {
            get => _currentPokemonList;
            set => _currentPokemonList = value;
        }

        public float SpeedMove
        {
            get => speed_move;
            set => speed_move = value;
        }

        public Home Home
        {
            get => _home;
            set => _home = value;
        }

        public ArchiveBackPackStuff BackpackStuff
        {
            get => _backpackStuff;
            set => _backpackStuff = value;
        }

        public BackPackPokemon BackPackPokemon
        {
            get => _backPackPokemon;
            set => _backPackPokemon = value;
        }

        private ArchiveBackPackStuff _backpackStuff;

        private BackPackPokemon _backPackPokemon;

        private Pokemon.Pokemon[] _currentPokemonList = new Pokemon.Pokemon[3]; 
        
        public float speed_move;

    }
}