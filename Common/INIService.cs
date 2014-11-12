using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.IO;

namespace Common
{
    public class INIService
    {
        private static string _path = Application.StartupPath + @"\width.ini";
        private string _skinPath = Application.StartupPath + @"\skin.ini";

        public INIService(string skinpath)
        {
            FileStream fs = File.Open(_skinPath, FileMode.OpenOrCreate);
            fs.Close();
        }


        public INIService()
        {
            FileStream fs = File.Open(_path, FileMode.OpenOrCreate);
            fs.Close();
        }


        //声明INI文件的写操作函数 WritePrivateProfileString()
        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);

        //声明INI文件的读操作函数 GetPrivateProfileString()
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

        /// <summary>
        /// 写INI文件
        /// </summary>
        /// <param name="Section">配置目录</param>
        /// <param name="Key">参数 </param>
        /// <param name="Value">值 </param>
        /// <param name="IniPath">路径</param>
        /// <returns></returns>
        public bool IniWriteValue(string Section, string Key, string Value,string Path)
        {
            try
            {
                WritePrivateProfileString(Section, Key, Value, Path);
                
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary> 
        /// 读INI文件 
        /// </summary> 
        /// <param name="Section">配置目录 </param> 
        /// <param name="Key">参数 </param> 
        /// <param name="IniPath">路径 </param> 
        /// <returns>返回值 </returns>
        public string IniReadValue(string Section, string Key, string Path)
        {
            StringBuilder temp = new StringBuilder(255);
            int i = GetPrivateProfileString(Section, Key, "....", temp, 255, Path);
            return temp.ToString();
        }


        /// <summary>
        /// 写选择的皮肤值
        /// </summary>
        /// <param name="Section"></param>
        /// <param name="Key"></param>
        /// <param name="Value"></param>
        /// <returns></returns>
        public bool SkinIniWrite(string Section, string Key, string Value)
        {
            try
            {
                WritePrivateProfileString(Section, Key, Value, _skinPath);

                return true;
            }
            catch
            {
                return false;
            }
        }


        /// <summary>
        /// 取得皮肤值
        /// </summary>
        /// <param name="Section"></param>
        /// <param name="Key"></param>
        /// <returns></returns>
        public string SkinIniRead(string Section, string Key)
        {

            StringBuilder temp = new StringBuilder(255);
            int i = GetPrivateProfileString(Section, Key, "....", temp, 255, _skinPath);
            return temp.ToString();
        }
    }
}
