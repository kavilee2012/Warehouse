using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Configuration;


namespace Common
{
    public class FactoryService
    {
        //public static Entity.CarWebService.DealListService CreateWebService()
        //{
        //    //OperateINI ini = new OperateINI();
        //    //string _iniName = ini.IniReadValue("UNAME", "userName", Application.StartupPath + @"\webServicePwd.ini");
        //    //string _iniPwd = ini.IniReadValue("UPWD", "pwd", Application.StartupPath + @"\webServicePwd.ini");

        //    //int _webNameAndPwd = int.Parse((_iniName.Trim() + _iniPwd.Trim())) / 2;

        //    Entity.CarWebService.DealListService dlService = new Entity.CarWebService.DealListService();
        //    System.Net.ServicePointManager.Expect100Continue = false;
        //    Entity.CarWebService.MySoapHeader myHeader = new Entity.CarWebService.MySoapHeader();

        //    myHeader.UserName = "dexian_*@";// + _webNameAndPwd.ToString();
        //    myHeader.PassWord = "cms_9*5$7web99";// + _webNameAndPwd.ToString();

        //    dlService.MySoapHeaderValue = myHeader;


        //    if (Global._webShop!=null&&!CommonService.IsNullOrEmpty (Global._webShop.DXServerIP))
        //    {
        //        dlService.Url = WebMethod.ReplaceIp(dlService.Url, Global._webShop.DXServerIP);
        //    }
        //    return dlService;

        //}
        //public static AutoUpdateService CreateAutoUpdateService()
        //{
        //    AutoUpdateService AutoUpdateService = new AutoUpdateService();
           

        //    if (Global._webShop != null && !CommonService.IsNullOrEmpty(Global._webShop.DXServerIP))
        //    {
        //        AutoUpdateService.Url = WebMethod.ReplaceIp(AutoUpdateService.Url, Global._webShop.DXServerIP);
        //    }
        //    return AutoUpdateService;
        //}
    }
}
