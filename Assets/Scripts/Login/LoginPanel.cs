using System;
using System.IO;
using UniRx;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

public class LoginPanel : MonoBehaviour
{
    public InputField userName;
    public InputField password;
    public Button LoginBtn;
    public Button RegistBtn;
    public User _user = LoginInstaller._user;

    public Archive.User ArchiveUser;
    public string fileName;
    
    public TipPanel _tipPanel;
    public RegistPanel _registPanel;

    public GameObject welcome;
    void Start()
    {
        // string fileName = Application.dataPath + "/Scripts/Login/namePsw.txt" ;
        // Debug.Log(fileName);
        // FileStream streamWriter = new FileStream(fileName,FileMode.OpenOrCreate, FileAccess.ReadWrite);
        // StreamWriter sw = new StreamWriter(streamWriter);
        // sw.Close();
        //????????????????????????????????
        userName.OnEndEditAsObservable()
            .Subscribe((s =>
                password.Select()));
        //??????????????????????????????? ????????????
        var enterDownStream = password.OnEndEditAsObservable()
            .Select((s => "????????????"));
        var loginBtnStream = LoginBtn.OnClickAsObservable()
            .Select((unit => "????????????????????"));

        Observable.Merge(enterDownStream, loginBtnStream)
            .Subscribe((s =>
            {
                _user = new User();
                if (LoginCheak(userName.text, password.text))
                {
                    ReadArchive();
                    SetAccountController();
                    GameObject.Find("Pokemon").gameObject.GetComponent<Player.Player>().PlayerName = userName.text;
                    userName.text = String.Empty;
                    password.text = String.Empty;
                    
                    gameObject.SetActive(false);
                    _tipPanel.gameObject.SetActive(false);
                    welcome.SetActive(true);
                    //??????
                    
                }
                else
                {
                    userName.text = String.Empty;
                    password.text = String.Empty;
                    _tipPanel.gameObject.SetActive(true);
                    _tipPanel.Show("Login Failed!");
                }
            }));
        RegistBtn.OnClickAsObservable()
            .Subscribe((unit =>
            {
                userName.text = String.Empty;
                password.text = String.Empty;
                gameObject.SetActive(false);
                _tipPanel.gameObject.SetActive(false);
                _registPanel.gameObject.SetActive(true);
            }));
    }

    public bool LoginCheak(string username, string password)
    {
        bool isOK = false;
        if(_user._dictionary == null)
        {
            return false;
        }
       else if (_user._dictionary.ContainsKey(username))
        {
            if (_user._dictionary[username] == password)
            {
                isOK = true;
            }
        }
        return isOK;
    }
    public void ReadArchive()
    {
        fileName = Application.dataPath + "/Save/" + userName.text + "/Data.sav" ;
        ArchiveUser = (Archive.User) Archive.IOHelper.GetData(fileName, typeof(Archive.User));
    //     Debug.Log(ArchiveUser.Account);
    //     Debug.Log(ArchiveUser.Password);
    //     Debug.Log(ArchiveUser.Archives.ArchivePlayer.BackPackPokemon.Pointer);
    }

    public void SetAccountController()
    {
        AccountController.AccountController accountController =
            GameObject.Find("AccountController").GetComponent<AccountController.AccountController>();
        accountController.User = ArchiveUser;
        //accountController.CurrentArchive = (Archive.Archive)ArchiveUser.Archives[0];
    }

}