using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;

namespace SqlServer
{
    public class DBService
    {
        public static bool backupDB(string strdbname, string strfilename)
        {
            string conStr = ConfigurationManager.AppSettings["SqlConString"].ToString();
            string[] con = conStr.Split(';');
            int nameIndex = con[2].IndexOf('=') + 1;
            string username = con[2].Substring(nameIndex, con[2].Length - nameIndex);
            int pwdIndex = con[3].IndexOf('=') + 1;
            string pwd = con[3].Substring(pwdIndex, con[3].Length - pwdIndex);
            int ipIndex = con[0].IndexOf('=') + 1;
            string ip = con[0].Substring(ipIndex, con[0].Length - ipIndex);

            string server = ip;
            string uid = username;
            string password = pwd;


            SQLDMO.SQLServer svr = new SQLDMO.SQLServerClass();
            try
            {
                svr.Connect(server, uid, password);
                SQLDMO.Backup bak = new SQLDMO.BackupClass();
                bak.Action = 0;
                bak.Initialize = true;

                //SQLDMO.BackupSink_PercentCompleteEventHandler pceh = new SQLDMO.BackupSink_PercentCompleteEventHandler(step); 
                //bak.PercentComplete += pceh; 
                bak.Files = strfilename;
                bak.Database = "CarSecretary";
                bak.SQLBackup(svr);
                return true;
            }
            catch (Exception ex)
            {
                //CarLog.WriteLog(ex.Message);
                //MessageBox.Show("备份数据库失败,请确保没有其他用户使用数据库!!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            finally
            {
                svr.DisConnect();
            }
        }

    }
}
