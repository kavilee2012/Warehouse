using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Common;

namespace Warehouse
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(AppThreadException);
            Application.Run(new frmLogin());
        }


        private static void AppThreadException(object source, System.Threading.ThreadExceptionEventArgs e)
        {
            string errorMsg = string.Format("未处理异常: \n{0}\n", e.Exception.Message + "         详细：\n" + e.Exception);
             MyLog.WriteLog(e.Exception);

            MessageBox.Show("\n  发生系统异常!\t\t\n", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
