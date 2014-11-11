using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Security.Cryptography;

namespace Utility
{
    public class FileService
    {
        #region 写文件
        ///<summary>
        /// 写文件，每次写一行，文件不存在时自动创建，存在时在后面追加。
        ///</summary>
        ///<param name="writeContent">要写入的内容</param>
        ///<param name="path">写入的路径（包含文件名的完整路径）</param>
        public static void Write(string writeContent, string path)
        {
            if (string.IsNullOrEmpty(writeContent))
            {
                throw new WriteContentIsNullOrEmptyException();
            }

            if (string.IsNullOrEmpty(path))
            {
                throw new PathIsNullOrEmptyException();
            }

            using (FileStream fs = new FileStream(path, FileMode.Append, FileAccess.Write, FileShare.ReadWrite))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine(writeContent);
                    sw.Close();
                }
                fs.Close();
            }
        }
        #endregion

        #region 读文件
        /// <summary>
        /// 读文件--不能读取大于2M的文件
        /// </summary>
        /// <param name="path">读取的文件的路径（包含文件名的完整路径）</param>
        /// <returns>文件的内容</returns>
        public static string Read(string path)
        {
            if (string.IsNullOrEmpty(path))
            {
                throw new PathIsNullOrEmptyException();
            }

            FileInfo fi = new FileInfo(path);

            if (!fi.Exists)
            {
                throw new FileNotFoundException();
            }

            if (fi.Length > 2048000)
            {
                throw new FileSizeIsGreaterThan2MException();
            }

            string readContent = string.Empty;

            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    readContent = sr.ReadToEnd();
                    sr.Close();
                }
                fs.Close();
            }

            return readContent;
        }
        #endregion



        #region 文件的MD5值
        /// <summary>
        /// 文件的MD5值
        /// </summary>
        /// <param name="path">文件的绝对路径（完整物理路径）</param>
        /// <returns>文件的MD5值</returns>
        public static string FileMD5Encrypt(string path)
        {
            if (string.IsNullOrEmpty(path))
            {
                throw new PathIsNullOrEmptyException();
            }

            if (!File.Exists(path))
            {
                throw new PathFileNotExistException();
            }

            byte[] bMd5Data = null;

            using (FileStream encryptFile = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                bMd5Data = MD5.Create().ComputeHash(encryptFile);
                encryptFile.Close();
            }

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < bMd5Data.Length; i++)
            {
                sb.Append(bMd5Data[i].ToString("x2"));
            }

            return sb.ToString();
        }
        #endregion

        #region 文件的SHA1值
        /// <summary>
        /// 文件的SHA1值
        /// </summary>
        /// <param name="path">文件的绝对路径（完整物理路径）</param>
        /// <returns>文件的SHA1值</returns>
        public static string FileSHA1Encrypt(string path)
        {
            if (string.IsNullOrEmpty(path))
            {
                throw new PathIsNullOrEmptyException();
            }

            if (!File.Exists(path))
            {
                throw new PathFileNotExistException();
            }

            byte[] bSHA1Data = null;

            using (FileStream encryptFile = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                bSHA1Data = SHA1.Create().ComputeHash(encryptFile);
                encryptFile.Close();
            }

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < bSHA1Data.Length; i++)
            {
                sb.Append(bSHA1Data[i].ToString("x2"));
            }
            return sb.ToString();
        }
        #endregion
    }
}
