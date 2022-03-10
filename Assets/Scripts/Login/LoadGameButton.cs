using UnityEngine;
using UnityEngine.UI;

namespace Login
{
    public class LoadGameButton : MonoBehaviour
    {
        public ChangeModel change;
        private Archive.User _user;

        public void Start()
        {
            this.GetComponent<Button>().onClick.AddListener(LoadArchive);
        }

        public void LoadArchive()
        {
            _user = GameObject.Find("AccountController").GetComponent<AccountController.AccountController>().User;
            Archive.Archive archive = _user.Archives;
            Player.Player player = GameObject.Find("Pokemon").GetComponent<Player.Player>();
            player.speed_move = 20;
            player.Money = archive.ArchivePlayer.Money;
            player.PlayerName = archive.ArchivePlayer.PlayerName;
            player.BackpackStuff = archive.ArchivePlayer.BackpackStuff.ConvertToBackpackStuff();
            player.BackPackPokemon = archive.ArchivePlayer.BackPackPokemon;
            player.Home = archive.ArchivePlayer.Home;
            change.initModel();
            //Debug.Log(archive.ArchivePlayer.BackPackPokemon.ToString());
            //Debug.Log(player.BackPackPokemon.ToString());
        }
    }
}