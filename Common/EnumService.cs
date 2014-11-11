using System;
using System.Collections.Generic;
using System.Text;

namespace Utility
{
        #region 匹配的类型
        /// <summary>
        /// 匹配的类型
        /// </summary>
        public enum RegexPattern
        {
            /// <summary>
            /// 手机匹配，对应RegexService.xml里的mobile正则表达式
            /// </summary>
            Mobile,
            /// <summary>
            /// 139邮箱别名匹配，对应RegexService.xml里的mail139alias正则表达式
            /// </summary>
            Mail139Alias,
            /// <summary>
            /// 手机或139邮箱别名匹配，对应RegexService.xml里的mobile139alias正则表达式
            /// </summary>
            Mobile139Alias,
            /// <summary>
            /// 139邮箱密码匹配，对应RegexService.xml里的mailpassword正则表达式
            /// </summary>
            MailPassword,
            /// <summary>
            /// 邮箱地址匹配，对应RegexService.xml里的mailaddress正则表达式
            /// </summary>
            MailAddress,
            /// <summary>
            /// 国内固话或小灵通（带区号）匹配，对应RegexService.xml里的phone正则表达式
            /// </summary>
            ChinaPhone,
            /// <summary>
            /// 中国身份证匹配，对应RegexService.xml里的idcard正则表达式
            /// </summary>
            ChinaIDCard,
            /// <summary>
            /// 邮编匹配，对应RegexService.xml里的zipcode正则表达式
            /// </summary>
            ZipCode,
            /// <summary>
            /// IP地址匹配，对应RegexService.xml里的ipaddress正则表达式
            /// </summary>
            IpAddress,
            /// <summary>
            /// URL匹配，对应RegexService.xml里的url正则表达式
            /// </summary>
            Url,
            /// <summary>
            /// 完整文件名（带扩展名）匹配，对应RegexService.xml里的filename正则表达式
            /// </summary>
            FileName,
            /// <summary>
            /// 物理路径匹配（带完整文件名），对应RegexService.xml里的path正则表达式
            /// </summary>
            Path,
            /// <summary>
            /// 以数字开头，后接逗号+数字的匹配，对应RegexService.xml里的numbercomma正则表达式
            /// </summary>
            NumberComma,
            /// <summary>
            /// 数字匹配，对应RegexService.xml里的number正则表达式
            /// </summary>
            Number,
            /// <summary>
            /// 中文匹配，对应RegexService.xml里的chinese正则表达式
            /// </summary>
            Chinese,
            /// <summary>
            /// 字母（不区分大小写）匹配，对应RegexService.xml里的letter正则表达式
            /// </summary>
            Letter,
            /// <summary>
            /// 以字母开头，后接字母、数字或下划线的匹配，对应RegexService.xml里的letter正则表达式
            /// </summary>
            LetterNumberUnderline,
            /// <summary>
            /// 年月格式yyyyMM，例如200908，对应RegexService.xml里的yyyymm正则表达式
            /// </summary>
            yyyyMM,
            /// <summary>
            /// 匹配全角字符，包括０－９，ａ－ｚ，Ａ－Ｚ的正则表达式，有一个即可
            /// </summary>
            SBCCheck,
            /// <summary>
            /// 匹配发送短信的SpNumber，对应RegexService.xml里的spnumber正则表达式
            /// </summary>
            SpNumber,
            /// <summary>
            /// 验证码匹配，对应RegexService.xml里的verifycode正则表达式
            /// </summary>
            VerifyCode,
            /// <summary>
            /// 日期格式
            /// </summary>
            Date
        }
        #endregion

        //#region
        //public enum ValidateType
        //{ 
        
        //}
        //#endregion

        #region MD5加密的位数
        /// <summary>
        /// MD5加密的位数
        /// </summary>
        public enum MD5Bit
        {
            /// <summary>
            /// 16位MD5加密
            /// </summary>
            Bit16,
            /// <summary>
            /// 32位MD5加密
            /// </summary>
            Bit32
        }
        #endregion
}
