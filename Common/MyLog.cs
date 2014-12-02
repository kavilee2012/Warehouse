using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;

namespace Common
{
    public class MyLog
    {
        //写日志
        public static void WriteLog(string msg)
        {
            try
            {
                string logPath = Application.StartupPath + @"\MyLog.log";
                System.IO.StreamWriter sw = System.IO.File.AppendText(logPath);
                sw.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss : ") + msg);
                sw.Close();
            }
            catch
            {

            }
        }
    
        //写日志
        public static void WriteLog(Exception  Ex)
        {
            try
            {
                string logPath = Application.StartupPath + @"\MyLog.log";
                System.IO.StreamWriter sw = System.IO.File.AppendText(logPath);
                // //通过如下代码来记录异常详细的信息
                // var trace = new StackTrace(Ex, true).GetFrame(0);
                //string  msg =Ex.ToString ()+ string.Format("文件名:{0},行号:{1},列号:{2}", trace.GetFileName(), trace.GetFileLineNumber(), trace.GetFileColumnNumber());
                sw.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss : ") + Ex.ToString());
                sw.Close();
            }
            catch
            {

            }
        }
    }
}
