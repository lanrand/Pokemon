using System;
using UnityEngine;
using UnityEngine.UI;

namespace Shop
{
    public class ShopCanvas : MonoBehaviour
    {
        private Button _exit;

        private Player.Player _player;

        private Text _moneyText;
        public void IniExitButton()
        {
            _exit = transform.Find("shopExit").GetComponent<Button>();
            _exit.onClick.AddListener(OnClickExit);
        }

        public void IniMoneyPanel()
        {
            this._player = GameObject.Find("Pokemon").gameObject.GetComponent<Player.Player>();
            this._moneyText = transform.Find("moneyPanel").transform.Find("moneyText").GetComponent<Text>();
            this._moneyText.text = "Package: " + _player.Money;
        }
        public void Start()
        {
            IniExitButton();
            IniMoneyPanel();
        }

        public void UpdateMoneyPanel()
        {
            this._moneyText.text = "Package: " + _player.Money+"$";
        }
        public void Update()
        {
            UpdateMoneyPanel();
        }

        public void OnClickExit()
        {
            this.gameObject.SetActive(false);
        }
        
    }
}