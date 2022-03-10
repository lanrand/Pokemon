using Player;
using UnityEngine;

namespace Archive
{
    public class Archive
    {
        private int _id;
        
        private string _path;

        //private Player.Player _player;
        private ArchivePlayer _archivePlayer;

        public string Path
        {
            get => _path;
            set => _path = value;
        }

        public ArchivePlayer ArchivePlayer
        {
            get => _archivePlayer;
            set => _archivePlayer = value;
        }


        public int ID
        {
            get => _id;
            set => _id = value;
        }
        //wo zhun bei xie gou zao fang fa
        public Archive(string playerName)
        {
            this._archivePlayer = new ArchivePlayer();
            this._archivePlayer.PlayerName = playerName;
            this._archivePlayer.speed_move = 40;
            //this._archivePlayer.Home = new Home();
            this._archivePlayer.Money = 500;
            this._archivePlayer.BackpackStuff = new ArchiveBackPackStuff();
            this._archivePlayer.BackPackPokemon = new BackPackPokemon();
        }
    }
}