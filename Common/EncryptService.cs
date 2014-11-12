using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Web.Security;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Common
{
    public class EncryptService
    {
        /// <summary>
        /// MD5加密
        /// </summary>
        /// <param name="Text"></param>
        /// <returns></returns>
        public static string MD5(string text)
        {

            string str = "";

            str = FormsAuthentication.HashPasswordForStoringInConfigFile(text, "MD5");

            return str;
        }

        public static string md5_hash(string path)
        {

            FileStream get_file = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read);
            System.Security.Cryptography.MD5CryptoServiceProvider get_md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
            byte[] hash_byte = get_md5.ComputeHash(get_file);
            string resule = System.BitConverter.ToString(hash_byte);
            resule = resule.Replace("-", "");
            get_file.Close();
            return resule;
        }

        public static string md5_hash(byte[] bytes)
        {
            System.Security.Cryptography.MD5CryptoServiceProvider get_md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
            byte[] hash_byte = get_md5.ComputeHash(bytes);
            string resule = System.BitConverter.ToString(hash_byte);
            resule = resule.Replace("-", "");

            return resule;
        }


        private static byte[] key = ASCIIEncoding.ASCII.GetBytes("qwer/.,m ");
        private static byte[] iv = ASCIIEncoding.ASCII.GetBytes("9ijn6tfc ");

        ///   <summary> 
        ///   DES加密。 
        ///   </summary> 
        ///   <param   name= "inputString "> 输入字符串。 </param> 
        ///   <returns> 加密后的字符串。 </returns> 
        public static string DESEncrypt(string inputString)
        {
            if (inputString.Trim() == string.Empty)
                return " ";
            MemoryStream ms = null;
            CryptoStream cs = null;
            StreamWriter sw = null;

            DESCryptoServiceProvider des = new DESCryptoServiceProvider();
            try
            {
                ms = new MemoryStream();
                cs = new CryptoStream(ms, des.CreateEncryptor(key, iv), CryptoStreamMode.Write);
                sw = new StreamWriter(cs);
                sw.Write(inputString);
                sw.Flush();
                cs.FlushFinalBlock();
                return Convert.ToBase64String(ms.GetBuffer(), 0, (int)ms.Length);
            }
            finally
            {
                if (sw != null) sw.Close();
                if (cs != null) cs.Close();
                if (ms != null) ms.Close();
            }
        }


        ///<summary>
        ///加密配置文件中的ConnectionString节
        ///</summary>
        ///<param name="protect">true为加密，false为解密</param>
        public static void ConnectionStringProtection(bool protect)
        {
            //取得当前程序的执行路径
            string pathName = Application.ExecutablePath;
            // 定义Dpapi提供程序的名称.
            string strProvider = "DataProtectionConfigurationProvider";

            System.Configuration.Configuration oConfiguration = null;
            System.Configuration.ConnectionStringsSection oSection = null;

            try
            {
                // 打开配置文件，并取得connectionStrings配置节.
                oConfiguration =
                        System.Configuration.ConfigurationManager.OpenExeConfiguration(pathName);

                if (oConfiguration != null)
                {
                    bool blnChanged = false;
                    oSection = oConfiguration.GetSection("connectionStrings") as
                        System.Configuration.ConnectionStringsSection;

                    if (oSection != null)
                    {
                        if ((!(oSection.ElementInformation.IsLocked)) && (!(oSection.SectionInformation.IsLocked)))
                        {
                            if (protect)
                            {
                                if (!(oSection.SectionInformation.IsProtected))
                                {
                                    blnChanged = true;
                                    // 加密connectionStrings配置节.
                                    oSection.SectionInformation.ProtectSection(strProvider);
                                }
                            }
                            else
                            {
                                if (oSection.SectionInformation.IsProtected)
                                {
                                    blnChanged = true;
                                    // 解密connectionStrings配置节.
                                    oSection.SectionInformation.UnprotectSection();
                                }
                            }
                        }

                        if (blnChanged)
                        {
                            // 如果connectionStrings配置节被更改，则强制保存它.
                            oSection.SectionInformation.ForceSave = true;
                            // 保存对connectionStrings配置节的更改.
                            oConfiguration.Save();
                        }
                    }
                }
            }
            catch (System.Exception ex)
            {
                throw (ex);
            }
            finally
            {
            }
        }

        ///<summary>
        ///加密配置文件中的AppSettings配置节
        ///</summary>
        ///<param name="protect">true为加密，false为解密</param>
        public static void AppSettingProtection(bool protect)
        {
            //取得当前程序的执行路径
            string pathName = Application.ExecutablePath;
            // Define the Dpapi provider name.
            string strProvider = "DataProtectionConfigurationProvider";

            System.Configuration.Configuration oConfiguration = null;
            System.Configuration.AppSettingsSection oSection = null;

            try
            {
                // Open the configuration file and retrieve the connectionStrings section.
                oConfiguration =
                    System.Configuration.ConfigurationManager.OpenExeConfiguration(pathName);

                if (oConfiguration != null)
                {
                    bool blnChanged = false;
                    oSection = oConfiguration.GetSection("appSettings") as
                        System.Configuration.AppSettingsSection;

                    if (oSection != null)
                    {
                        if ((!(oSection.ElementInformation.IsLocked)) &&
                             (!(oSection.SectionInformation.IsLocked)))
                        {
                            if (protect)
                            {
                                if (!(oSection.SectionInformation.IsProtected))
                                {
                                    blnChanged = true;
                                    // Encrypt the section.
                                    oSection.SectionInformation.ProtectSection(strProvider);
                                }
                            }
                            else
                            {
                                if (oSection.SectionInformation.IsProtected)
                                {
                                    blnChanged = true;
                                    // Remove encryption.
                                    oSection.SectionInformation.UnprotectSection();
                                }
                            }
                        }

                        if (blnChanged)
                        {
                            // Indicates whether the associated configuration section will be saved even   
                            // if it has not been modified.
                            oSection.SectionInformation.ForceSave = true;
                            // Save the current configuration.
                            oConfiguration.Save();
                        }
                    }
                }
            }
            catch (System.Exception ex)
            {
                throw (ex);
            }
            finally
            {
            }

        }


    }
}
