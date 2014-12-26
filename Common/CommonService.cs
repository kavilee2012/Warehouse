using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.IO;
using System.IO.Compression;
using System.Data;
using SqlServerDAL;
using System.Data.SqlClient;
using SqlServer;

namespace Common
{
    public class CommonService
    {
        /// <summary>
        /// 转全角的函数(SBC case)
        /// </summary>
        /// <param name="input">任意字符串</param>
        /// <returns>全角字符串</returns>
        ///<remarks>
        ///全角空格为12288,半角空格为32
        ///其他字符半角(33-126)与全角(65281-65374)的对应关系是：均相差65248
        ///</remarks>        
        public string ToSBC(string input)
        {
            //半角转全角：
            char[] c = input.ToCharArray();
            for (int i = 0; i < c.Length; i++)
            {
                if (c[i] == 32)
                {
                    c[i] = (char)12288;
                    continue;
                }
                if (c[i] < 127)
                    c[i] = (char)(c[i] + 65248);
            }
            return new string(c);
        }

        /// <summary>
        /// 获取本机IP
        /// </summary>
        /// <returns></returns>
        public static List<string> GetLocIPAddress()
        {
            List<string> locAddress = new List<string>();
            try
            {
                string HostName = Dns.GetHostName();
                IPHostEntry MyEntry = Dns.GetHostEntry(HostName);

                foreach (IPAddress ipadd in MyEntry.AddressList)
                {
                    if (!ipadd.IsIPv6LinkLocal)
                    {
                        locAddress.Add(ipadd.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MyLog.WriteLog(ex);
            }
            return locAddress;
        }



        /// <summary>
        /// 解压ZIP
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns></returns>
        private static byte[] DecompressZIP(byte[] data)
        {
            try
            {
                MemoryStream ms = new MemoryStream(data);
                Stream zipStream = null;
                zipStream = new GZipStream(ms, CompressionMode.Decompress);
                byte[] dc_data = null;
                dc_data = EtractBytesFormStream(zipStream, data.Length);
                return dc_data;
            }
            catch
            {
                return null;
            }
        }
        private static byte[] EtractBytesFormStream(Stream zipStream, int dataBlock)
        {
            try
            {
                byte[] data = null;
                int totalBytesRead = 0;
                while (true)
                {
                    Array.Resize(ref data, totalBytesRead + dataBlock + 1);
                    int bytesRead = zipStream.Read(data, totalBytesRead, dataBlock);
                    if (bytesRead == 0)
                    {
                        break;
                    }
                    totalBytesRead += bytesRead;
                }
                Array.Resize(ref data, totalBytesRead);
                return data;
            }
            catch
            {
                return null;
            }
        }

        public static DataTable GeneralDataTable()
        {
            DataTable tblDatas = new DataTable("Datas");
            tblDatas.Columns.Add("ID", Type.GetType("System.Int32"));
            tblDatas.Columns[0].AutoIncrement = true;
            tblDatas.Columns[0].AutoIncrementSeed = 1;
            tblDatas.Columns[0].AutoIncrementStep = 1;

            tblDatas.Columns.Add("列一", Type.GetType("System.String"));
            tblDatas.Columns.Add("列二", Type.GetType("System.String"));
            tblDatas.Columns.Add("列三", Type.GetType("System.String"));

            tblDatas.Rows.Add(new object[] { null, "a", "b", "c" });
            tblDatas.Rows.Add(new object[] { null, "a", "b", "c" });
            tblDatas.Rows.Add(new object[] { null, "a", "b", "c" });
            tblDatas.Rows.Add(new object[] { null, "a", "b", "c" });
            tblDatas.Rows.Add(new object[] { null, "a", "b", "c" });

            return tblDatas;

        }


        public static DateTime GetServerTime()
        {
            string sql = "SELECT GETDATE()";
            object obj = DbHelperSQL.GetSingle(sql);
            if (obj != DBNull.Value && obj != null)
            {
                return Convert.ToDateTime(obj);
            }
            else
            {
                return DateTime.Now;
            }
        }


        /// <summary>
        /// 获取参数值
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static string GetParamValue(string name)
        {
            string sql = "SELECT ArgValue FROM Argument WHERE ArgName=@paramname";
            SqlParameter[] pas = new SqlParameter[]
            {
            new SqlParameter("@paramname",name)
            };
            object rows = SqlHelper.ExecuteScalar(sql, pas);
            if (rows != System.DBNull.Value)
            {
                return rows.ToString();
            }
            else
            {
                return " ";
            }

        }


        /// <summary>
        /// 设置参数名
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool SetParamName(string name, string value)
        {
            string sql = "UPDATE Argument Set ArgValue=@paramvalue WHERE ArgName=@paramname";
            SqlParameter[] pas = new SqlParameter[]
            {
            new SqlParameter("@paramvalue",SqlDbType.Text),
            new SqlParameter("@paramname",SqlDbType.VarChar,150)
            };
            pas[0].Value = value;
            pas[1].Value = name;
            int rows = SqlHelper.ExecuteNonQuery(sql, pas);
            return (rows > 0);
        }

    }
}
