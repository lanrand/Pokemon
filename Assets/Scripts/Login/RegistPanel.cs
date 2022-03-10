using UniRx;
using UnityEngine;
using UnityEngine.UI;
using Zenject;
using System.IO;

public class RegistPanel : MonoBehaviour
{
    public TipPanel _tipPanel;
    public LoginPanel _loginPanel;
    public User _user = LoginInstaller._user;

    public string path;
    public string fileName;
    public Archive.User ArchiveUser;
    
    public InputField userName;
    public InputField password01;
    public InputField password02;
    public Button Regist;
    public Button mainMenu;
    void Start()
    {
        //??????
        userName.OnEndEditAsObservable()
            .Subscribe((s => password01.Select()));
        password01.OnEndEditAsObservable()
            .Subscribe((s => password02.Select()));

        var btnClick = Regist.OnClickAsObservable()
            .Select((unit => "??????????????"));
        int k = 0;
        Observable.Merge(btnClick)
            .Subscribe((s =>
            {
                if ((userName.text != null) && (password01.text == password02.text))
                {
                    
                    if(_user._dictionary == null)
                    {
                        k = 1;

                        _tipPanel.Show("Register Sussess!");


                        StreamWriter sw = new StreamWriter("Assets/Scripts/Login/namePsw.txt",true);
                        sw.WriteLine(userName.text);
                        sw.WriteLine(password01.text);
                        sw.Close();
                        AddUser();
                    }
                    else if (_user._dictionary.ContainsKey(userName.text) && k == 0)
                    {
                        _tipPanel.Show("User name is existed!");
                    }
                    else
                    {

                        _tipPanel.Show("Register Sussess!");

                        StreamWriter sw = new StreamWriter("Assets/Scripts/Login/namePsw.txt", true);
                        sw.WriteLine(userName.text);
                        sw.WriteLine(password01.text);
                        sw.Close();
                        AddUser();

                    }
                }
                else
                {
                    _tipPanel.Show("Register Failed!");
                }
            }
                ));
        mainMenu.OnClickAsObservable()
            .Subscribe((unit =>
            {
                gameObject.SetActive(false);
                _loginPanel.gameObject.SetActive(true);
                _tipPanel.gameObject.SetActive(false);
            }));
    }
    public void AddUser()
    {
        path = Application.dataPath + "/Save/" + userName.text;
        Archive.IOHelper.CreateDirectory(path);
        ArchiveUser = new Archive.User(userName.text, password01.text);
        fileName = path + "/Data.sav";
        Debug.Log(fileName);
        Archive.IOHelper.SetData(fileName, ArchiveUser);
    }
}
