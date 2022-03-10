using System.Collections.Generic;
using UnityEngine;

namespace Archive
{
    public class TestSave : MonoBehaviour
    {
        ///
        /// 定义一个测试类
        ///
        void Start()

        {
            //定义存档路径

            string dirpath = Application.persistentDataPath + "/Save";

            dirpath = Application.dataPath + "/Save";
            //创建存档文件夹

            IOHelper.CreateDirectory(dirpath);//new game shi diao yong

            //定义存档文件路径

            string filename = dirpath + "/GameData.sav";

            //Debug.Log(filename);//C:/Users/xiye/AppData/LocalLow/DefaultCompany/GitHubEdition2/Save/GameData.sav
            TestClass t = new TestClass();

            //保存数据

            IOHelper.SetData(filename, t);

            //读取数据

            TestClass t1 = (TestClass) IOHelper.GetData(filename, typeof(TestClass));
            
        }
    }

    public class TestClass

    {
        public string Name = "张三";

        public float Age = 23.0f;

        public int Sex = 1;

        public List<int> Ints = new List<int>()

        {
            1,
            2,
            3
        };
    }
}