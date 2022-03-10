using System.Collections.Generic;
using Zenject;
using System.IO;
using UnityEngine;

public class LoginInstaller : MonoInstaller
{
    public LoginPanel _loginPanel;
    public RegistPanel _registPanel;
    public TipPanel _tipPanel;
    public static User _user = new User();

    public override void InstallBindings()
    {
        Container.Bind<LoginPanel>().FromInstance(_loginPanel).AsSingle();
        Container.Bind<RegistPanel>().FromInstance(_registPanel).AsSingle();
        Container.Bind<TipPanel>().FromInstance(_tipPanel).AsSingle();
        Container.Bind<User>().FromInstance(_user);
    }

    // void Start()
    // {
    //     string fileName = Application.dataPath + "/Scripts/Login/namePsw.txt" ;
    //     Debug.Log(fileName);
    //     FileStream streamWriter = new FileStream(fileName,FileMode.OpenOrCreate, FileAccess.ReadWrite);
    //     StreamWriter sw = new StreamWriter(streamWriter);
    //     sw.Close();
    // }
}
public class User
{
    public Dictionary<string, string> _dictionary;
    public User()
    {
        StreamReader sr = new StreamReader("Assets/Scripts/Login/namePsw.txt");
        string content;
        _dictionary = new Dictionary<string, string>();
        int a = 0;
        string name1 = "";
        string psw1 = "";
        while ((content = sr.ReadLine()) != null)
        {
            if (a == 0)
            {
                name1 = content;
            }
            if (a == 1)
            {
                psw1 = content;
            }
            if(a==1)
            {
                a = -1;
                _dictionary.Add(name1, psw1);
            }
            a++;
        }
        ;
    }
}