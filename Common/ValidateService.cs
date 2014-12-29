using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Common
{
    public static class ValidateService
    {
        #region IsNotEmpty验证是否为空
        /// <summary>
        /// IsNotEmpty验证是否为空
        /// </summary>
        public static bool IsNotEmpty(object obj)
        {
            Regex rg = new Regex(@".?[^\s　]+");
            Match mc = rg.Match(obj.ToString());
            return (mc.Success);
        }
        #endregion

        #region IsEnglish验证是否为英文字符
        /// <summary>
        /// IsEnglish验证是否为英文字符
        /// </summary>
        public static bool IsEnglish(object obj)
        {
            Regex rg = new Regex(@"^[a-zA-Z]$");
            Match mc = rg.Match(obj.ToString());
            return (mc.Success);
        }
        #endregion

        #region IsChinese验证是否为中文字符
        /// <summary>
        /// IsChinese验证是否为中文字符
        /// </summary>
        public static bool IsChinese(object obj)
        {
            Regex rg = new Regex(@"^[\u0391-\uFFE5]+$");
            Match mc = rg.Match(obj.ToString());
            return (mc.Success);
        }
        #endregion

        #region CheckDate是否为有效的日期格式
        /// <summary>
        /// CheckDate是否为有效的日期格式
        /// </summary>
        public static bool CheckDate(object obj)
        {
            //try
            //{
            //    DateTime time = Convert.ToDateTime(obj);
            //    return true;
            //}
            //catch
            //{
            //    return false;
            //}
            Regex rg = new Regex(@"^\d{4}[-]\d{2}[-]\d{2}[ ]\d{2}[:]\d{2}[:]\d{2}\w*");
            Match mc = rg.Match(obj.ToString());
            return (mc.Success);
        }
        #endregion

        #region CheckEmail是否为有效的邮箱格式
        /// <summary>
        /// CheckEmail是否为有效的邮箱格式
        /// </summary>
        public static bool CheckEmail(object obj)
        {
            Regex rg = new Regex(@"^\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$");
            Match mc = rg.Match(obj.ToString());
            return (mc.Success);
        }
        #endregion

        #region CheckUrl是否为有效的超链接格式
        /// <summary>
        /// CheckUrl是否为有效的超链接格式
        /// </summary>
        public static bool CheckUrl(object obj)
        {
            Regex rg = new Regex(@"^(http|https|ftp)\://[a-zA-Z0-9\-\.]+\.[a-zA-Z]{2,3}(:[a-zA-Z0-9]*)?/?([a-zA-Z0-9\-\._\?\,\'/\\\+&%\$#\=~])*$");
            Match mc = rg.Match(obj.ToString());
            return (mc.Success);
        }
        #endregion

        #region CheckPhone是否为有效的电话号码
        /// <summary>
        /// 例如：XXX-XXXXXXX
        /// </summary>
        public static bool CheckPhone(object obj)
        {
            Regex rg = new Regex(@"^((\(\d{2,3}\))|(\d{3}\-))?(\(0\d{2,3}\)|0\d{2,3}-)?[1-9]\d{6,7}(\-\d{1,4})?$");
            Match mc = rg.Match(obj.ToString());
            return (mc.Success);
        }
        #endregion

        #region CheckMobile是否为有效的手机号码
        /// <summary>
        /// CheckMobile是否为有效的手机号码
        /// </summary>
        public static bool CheckMobile(object obj)
        {
            Regex rg = new Regex(@"^((\(\d{2,3}\))|(\d{3}\-))?((13\d{9})|(159\d{8}))$");
            Match mc = rg.Match(obj.ToString());
            return (mc.Success);
        }
        #endregion

        #region CheckIP是否为有效的IP地址
        /// <summary>
        /// CheckIP是否为有效的IP地址
        /// </summary>
        public static bool CheckIP(object obj)
        {
            Regex rg = new Regex(@"^(0|[1-9]\d?|[0-1]\d{2}|2[0-4]\d|25[0-5]).(0|[1-9]\d?|[0-1]\d{2}|2[0-4]\d|25[0-5]).(0|[1-9]\d?|[0-1]\d{2}|2[0-4]\d|25[0-5]).(0|[1-9]\d?|[0-1]\d{2}|2[0-4]\d|25[0-5])$");
            Match mc = rg.Match(obj.ToString());
            return (mc.Success);
        }
        #endregion

        #region CheckZipCode是否为有效的邮政编码
        /// <summary>
        /// CheckZipCode是否为有效的邮政编码
        /// </summary>
        public static bool CheckZipCode(object obj)
        {
            Regex rg = new Regex(@"^[1-9]\d{5}$");
            Match mc = rg.Match(obj.ToString());
            return (mc.Success);
        }
        #endregion

        #region CheckIdCard是否为有效的身份证号码
        /// <summary>
        /// CheckIdCard是否为有效的身份证号码
        /// </summary>
        public static bool CheckIdCard(object obj)
        {
            Regex rg = new Regex(@"(^\d{15}$)|(^\d{17}[0-9Xx]$)");
            Match mc = rg.Match(obj.ToString());
            return (mc.Success);
        }
        #endregion

        #region CheckQQ是否为有效的QQ号码
        /// <summary>
        /// CheckQQ是否为有效的QQ号码
        /// </summary>
        public static bool CheckQQ(object obj)
        {
            Regex rg = new Regex(@"^[1-9]\d{4,10}$");
            Match mc = rg.Match(obj.ToString());
            return (mc.Success);
        }
        #endregion

        #region CheckMSN是否为有效的MSN帐户
        /// <summary>
        /// CheckMSN是否为有效的MSN帐户
        /// </summary>
        public static bool CheckMSN(object obj)
        {
            Regex rg = new Regex(@"^\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$");
            Match mc = rg.Match(obj.ToString());
            return (mc.Success);
        }
        #endregion

        #region IsNumber验证是不是数字
        /// <summary>
        /// IsNumber验证是不是数字
        /// </summary>
        public static bool IsNumber(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            Regex rg = new Regex(@"^[-\+]?\d+(\.\d+)?$");
            Match mc = rg.Match(obj.ToString());
            return (mc.Success);
        }
        #endregion

        #region IsNumber验证是不是纯数字
        /// <summary>
        /// IsNumber验证是不是数字
        /// </summary>
        public static bool IsAllNumber(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            Regex rg = new Regex(@"^[0-9]*$");
            Match mc = rg.Match(obj.ToString());
            return (mc.Success);
        }
        #endregion

        #region IsDoubleNumber验证是不是两位小数字
        /// <summary>
        /// IsNumber验证是不是数字
        /// </summary>
        public static bool IsDoubleNumber(object obj)
        {
            Regex rg = new Regex(@"^[-\+]?[0-9]+(\.[0-9]*)?$");
            Match mc = rg.Match(obj.ToString());
            return (mc.Success);
        }
        /// <summary>
        /// IsNumber验证是不是正数
        /// </summary>
        public static bool IsUnsignedDoubleNumber(object obj)
        {
            Regex rg = new Regex(@"^[\+]?\d+(\.\d*)?$");
            Match mc = rg.Match(obj.ToString());
            return (mc.Success);
        }
        #endregion

        #region IsInteger验证是不是整数
        /// <summary>
        /// IsInteger验证是不是整数
        /// </summary>
        public static bool IsInteger(object obj)
        {
            Regex rg = new Regex(@"^-?\d+$");
            Match mc = rg.Match(obj.ToString());
            return (mc.Success);
        }
        #endregion

        #region IsUnsignedInteger验证是不是正整数
        /// <summary>
        /// IsUnsignedInteger验证是不是正整数
        /// </summary>
        public static bool IsUnsignedInteger(object obj)
        {
            Regex rg = new Regex(@"^[0-9]*[1-9][0-9]*$");
            Match mc = rg.Match(obj.ToString());
            return (mc.Success);
        }
        #endregion

        #region IsSignedInteger验证是不是负整数
        /// <summary>
        /// IsSignedInteger验证是不是负整数
        /// </summary>
        public static bool IsSignedInteger(object obj)
        {
            Regex rg = new Regex(@"^-[0-9]*[1-9][0-9]*$");
            Match mc = rg.Match(obj.ToString());
            return (mc.Success);
        }
        #endregion  

        #region IsCarNumber验证车牌号
        /// <summary>
        /// 验证车牌号
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static bool IsCarNumber(object obj)
        {
            //Regex rg = new Regex(@"^[\u4e00-\u9fa5]{1}[a-zA-Z]{1}[a-zA-Z_0-9]{4}[a-zA-Z_0-9_\u4e00-\u9fa5]$");
            Regex rg = new Regex(@"^[\u4e00-\u9fa5]{1}[a-np-zA-NP-Z]{1}[a-zA-Z_0-9]{4}([a-zA-Z_0-9]{1}|[\u4e00-\u9fa5])$");
            Match mc = rg.Match(obj.ToString());
            char [] specialchar={'警','学','使','试','港','澳'};
            return (mc.Success) && obj.ToString().LastIndexOfAny (specialchar )<0;
        }
        #endregion

        #region IsEngineNumber验证发动机号
        /// <summary>
        /// 验证车牌号
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static bool IsEngineNumber(object obj)
        {
            Regex rg = new Regex(@"^\w{4,30}");
            Match mc = rg.Match(obj.ToString());
            return (mc.Success);
        }
        #endregion

        #region IsLogoSize
        /// <summary>
        /// 验LOGO图片大小
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static bool IsLogoSize(object obj,string type)
        {
            int x = Convert.ToInt32(obj);
            if (type == "w")
            {
                if (x >= 30 && x <= 160)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            if(type=="y")
            {
                if (x >= 30 && x <= 90)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
        #endregion


    
    }
}
