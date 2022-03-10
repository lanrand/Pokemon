using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using Newtonsoft.Json;
using UnityEngine;

namespace Archive
{
    public static class IOHelper

    {
        ///
        /// 判断文件是否存在
        ///
        public static bool IsFileExists(string fileName)

        {
            return File.Exists(fileName);
        }

        ///
        /// 判断文件夹是否存在
        ///
        public static bool IsDirectoryExists(string fileName)

        {
            return Directory.Exists(fileName);
        }

        ///
        /// 创建一个文本文件
        ///
        /// 文件路径
        /// 文件内容
        public static void CreateFile(string fileName, string content)

        {
            StreamWriter streamWriter = File.CreateText(fileName);

            streamWriter.Write(content);

            streamWriter.Close();
        }

        ///
        /// 创建一个文件夹
        ///
        public static void CreateDirectory(string fileName)

        {
            //文件夹存在则返回

            if (IsDirectoryExists(fileName))

                return;

            Directory.CreateDirectory(fileName);
        }

        public static void SetData(string fileName, object pObject)

        {
            //将对象序列化为字符串

            string toSave = SerializeObject(pObject);

            //对字符串进行加密,32位加密密钥

            //toSave = RijndaelEncrypt(toSave, "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");

            StreamWriter streamWriter = File.CreateText(fileName);
            Debug.Log("asdasdasd");
            streamWriter.Write(toSave);

            streamWriter.Close();
        }

        public static object GetData(string fileName, Type pType)

        {
            StreamReader streamReader = File.OpenText(fileName);

            string data = streamReader.ReadToEnd();

            //对数据进行解密，32位解密密钥

            //data = RijndaelDecrypt(data, "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");

            streamReader.Close();

            return DeserializeObject(data, pType);
        }

        ///
        /// Rijndael加密算法
        ///
        /// 待加密的明文
        /// 密钥,长度可以为:64位(byte[8]),128位(byte[16]),192位(byte[24]),256位(byte[32])
        /// iv向量,长度为128(byte[16])
        ///
        private static string RijndaelEncrypt(string pString, string pKey)

        {
            //密钥

            byte[] keyArray = UTF8Encoding.UTF8.GetBytes(pKey);

            //待加密明文数组

            byte[] toEncryptArray = UTF8Encoding.UTF8.GetBytes(pString);

            //Rijndael解密算法

            RijndaelManaged rDel = new RijndaelManaged();

            rDel.Key = keyArray;

            rDel.Mode = CipherMode.ECB;

            rDel.Padding = PaddingMode.PKCS7;

            ICryptoTransform cTransform = rDel.CreateEncryptor();

            //返回加密后的密文

            byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);

            return Convert.ToBase64String(resultArray, 0, resultArray.Length);
        }

        ///
        /// ijndael解密算法
        ///
        /// 待解密的密文
        /// 密钥,长度可以为:64位(byte[8]),128位(byte[16]),192位(byte[24]),256位(byte[32])
        /// iv向量,长度为128(byte[16])
        ///
        private static String RijndaelDecrypt(string pString, string pKey)

        {
            //解密密钥

            byte[] keyArray = UTF8Encoding.UTF8.GetBytes(pKey);

            //待解密密文数组

            byte[] toEncryptArray = Convert.FromBase64String(pString);

            //Rijndael解密算法

            RijndaelManaged rDel = new RijndaelManaged();

            rDel.Key = keyArray;

            rDel.Mode = CipherMode.ECB;

            rDel.Padding = PaddingMode.PKCS7;

            ICryptoTransform cTransform = rDel.CreateDecryptor();

            //返回解密后的明文

            byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);

            return UTF8Encoding.UTF8.GetString(resultArray);
        }

        ///
        /// 将一个对象序列化为字符串
        ///
        /// The object.
        /// 对象
        /// 对象类型
        private static string SerializeObject(object pObject)

        {
            //序列化后的字符串

            string serializedString = string.Empty;

            //使用http://Json.Net进行序列化

            //serializedString = JsonConvert.SerializeObject(pObject);
            serializedString =
                JsonConvert.SerializeObject(pObject, Formatting.Indented,
                    new JsonSerializerSettings() {TypeNameHandling = TypeNameHandling.All});

            return serializedString;
        }

        ///
        /// 将一个字符串反序列化为对象
        ///
        /// The object.
        /// 字符串
        /// 对象类型
        private static object DeserializeObject(string pString, Type pType)

        {
            //反序列化后的对象

            object deserializedObject = null;

            //使用http://Json.Net进行反序列化

            //deserializedObject = JsonConvert.DeserializeObject(pString, pType);
            deserializedObject = JsonConvert.DeserializeObject(pString, pType, new JsonSerializerSettings()
            {
                TypeNameHandling = TypeNameHandling.Auto
            });
            //deserializedObject = JsonConvert.DeserializeObject(pString, pType, new MyJsonConverter());
            
            
            return deserializedObject;
        }
    }
}