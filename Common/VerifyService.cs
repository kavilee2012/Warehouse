using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Utility
{
    /// <summary>
    /// 验证码生成类
    /// </summary>
    public class VerifyService
    {
        #region attribute

        /// <summary>
        /// 全局随机数生成器
        /// </summary>
        private Random rnd;

        /// <summary>
        /// 构造函数
        /// </summary>
        public VerifyService()
        {
            //生成随机的对象
            rnd = new Random(unchecked((int)DateTime.Now.Ticks));
        }

        #region 基础变量

        /// <summary>
        /// 数字字符
        /// </summary>
        protected const string NumberChars = "0123456789";

        /// <summary>
        /// 小字英文字符
        /// </summary>
        protected const string LowerEnglishChars = "abcdefghijkmnpqrstuvwxyz";

        /// <summary>
        /// 大写英文字符
        /// </summary>
        protected const string UpperEnglishChars = "ABCDEFGHJKLMNOPQRSTUVWXYZ";

        /// <summary>
        /// 中文字符
        /// </summary>
        public string ChineseChars = String.Empty;

        #endregion

        #region 验证码字符相关的属性

        private string _CharsType = "123";
        /// <summary>
        /// 验证码的类型，1为数字，2为小写英文，3为大写英文，4为中文。（默认为数字，小写英文和大写英文组合）[可以任意组合比如数字和小写英文就是12，中文和数字就是14]
        /// </summary>
        public string CharsType
        {
            set { _CharsType = value; }
            get { return _CharsType; }
        }

        private int _Padding = 0;
        /// <summary>
        /// 间隔
        /// </summary>
        public int Padding
        {
            set { _Padding = value; }
            get { return _Padding; }
        }

        private string _FontFamily = "";
        /// <summary>
        /// 设定验证码的固定字体（默认不使用，只有当IsRndFontFamily为false时本设置才有效）
        /// </summary>
        public string FontFamily
        {
            set { _FontFamily = value; }
            get { return _FontFamily; }
        }

        private bool _IsRndFontFamily = false;
        /// <summary>
        /// 是否为每个字符使用随机字体（默认不使用）
        /// </summary>
        public bool IsRndFontFamily
        {
            set { _IsRndFontFamily = value; }
            get { return _IsRndFontFamily; }
        }

        private bool _IsRndBackgroundColor = false;
        /// <summary>
        /// 是否使用随机背景色（默认不使用）
        /// </summary>
        public bool IsRndBackgroundColor
        {
            set { _IsRndBackgroundColor = value; }
            get { return _IsRndBackgroundColor; }
        }

        private bool _IsRndUpDownFluctuate = false;
        /// <summary>
        /// 是否使用上下波动（默认不使用）
        /// </summary>
        public bool IsRndUpDownFluctuate
        {
            set { _IsRndUpDownFluctuate = value; }
            get { return _IsRndUpDownFluctuate; }
        }

        private bool _IsRndLeftRightFluctuate = false;
        /// <summary>
        /// 是否使用左右波动（默认不使用）
        /// </summary>
        public bool IsRndLeftRightFluctuate
        {
            set { _IsRndLeftRightFluctuate = value; }
            get { return _IsRndLeftRightFluctuate; }
        }

        #endregion

        #region 验证码长度相关属性

        private int _Length = 5;
        /// <summary>
        /// 验证码的长度（默认为5）
        /// </summary>
        public int Length
        {
            set { _Length = value; }
            get { return _Length; }
        }

        private int _NumberLength = 0;
        /// <summary>
        /// 验证码中数字所占的位数（默认为随机，即0）
        /// </summary>
        public int NumberLength
        {
            set { _NumberLength = value; }
            get { return _NumberLength; }
        }

        private int _LowerEnglishLength = 0;
        /// <summary>
        /// 验证码中小写英文字符所占的位数（默认为随机，即0）
        /// </summary>
        public int LowerEnglishLength
        {
            set { _LowerEnglishLength = value; }
            get { return _LowerEnglishLength; }
        }

        private int _UpperEnglishLength = 0;
        /// <summary>
        /// 验证码中大写英文字符所占的位数（默认为随机，即0）
        /// </summary>
        public int UpperEnglishLength
        {
            set { _UpperEnglishLength = value; }
            get { return _UpperEnglishLength; }
        }

        private int _ChineseLength = 0;
        /// <summary>
        /// 验证码中中文字符所占的位数（默认为随机，即0）
        /// </summary>
        public int ChineseLength
        {
            set { _ChineseLength = value; }
            get { return _ChineseLength; }
        }

        #endregion

        #region 验证码字体样式相关属性

        private bool _IsRndColor = false;
        /// <summary>
        /// 验证码是否为每个字符使用随机颜色（默认不使用）
        /// </summary>
        public bool IsRndColor
        {
            set { _IsRndColor = value; }
            get { return _IsRndColor; }
        }

        private int FontSize = 15;

        #endregion

        #region 验证码字体特效相关属性

        private bool _IsRotate = false;
        /// <summary>
        /// 字体是否旋转（默认为否）不能与扭曲同用
        /// </summary>
        public bool IsRotate
        {
            get { return _IsRotate; }
            set { _IsRotate = value; }
        }

        private bool _IsContort = false;
        /// <summary>
        /// 字体是否扭曲（默认为否）不能与旋转同用
        /// </summary>
        public bool IsContort
        {
            get { return _IsContort; }
            set { _IsContort = value; }
        }

        #endregion

        #region 验证码噪线相关的属性

        private bool _IsChaos = true;
        /// <summary>
        /// 是否输出噪线（默认输出）
        /// </summary>
        public bool IsChaos
        {
            get { return _IsChaos; }
            set { _IsChaos = value; }
        }

        private int _ChaosNumber = 1;
        /// <summary>
        ///噪线的个数（默认1个噪线）如果ChaosType=1则为2倍
        /// </summary>
        public int ChaosNumber
        {
            get { return _ChaosNumber; }
            set { _ChaosNumber = value; }
        }

        private string _ChaosType = "5";
        /// <summary>
        /// 噪线类型（1为点，2为线，3为方框，4为椭圆，5为贝塞尔样条。默认为5）[可以任意组合比如点和线就是12，方框和椭圆就是34]
        /// </summary>
        public string ChaosType
        {
            get { return _ChaosType; }
            set { _ChaosType = value; }
        }

        #endregion

        #endregion

        #region method

        #region 生成随机验证码
        /// <summary>
        /// 生成随机字符码
        /// </summary>
        /// <returns></returns>
        public string CreateVerifyCode()
        {
            string TempCode = "";

            switch (Convert.ToInt32(CharsType[rnd.Next(0, CharsType.Length)].ToString()))
            {
                case 1://生成指定长度的数字验证码
                    for (int i = 0; i < NumberLength && i < Length; i++)
                    {
                        TempCode += CreateNumberChars();
                    }
                    break;
                case 2://生成指定长度的小写英文验证码
                    for (int j = 0; j < LowerEnglishLength && j < Length; j++)
                    {
                        TempCode += CreateLowerEnChars();
                    }
                    break;
                case 3://生成指定长度的大写英文验证码
                    for (int k = 0; k < UpperEnglishLength && k < Length; k++)
                    {
                        TempCode += CreateUpperEnChars();
                    }
                    break;
                case 4://生成指定长度的中文验证码
                    for (int l = 0; l < ChineseLength && l < Length; l++)
                    {
                        TempCode += CreateZhChars();
                    }
                    break;
                default://随机生成某个类型的验证码
                    for (int m = 0; m < Length; m++)
                    {
                        TempCode += CreateRndChars();
                    }
                    break;
            }

            if (TempCode.Length >= Length)
            {
                SortVerifyCode(TempCode);
            }
            else
            {
                while (Length - TempCode.Length > 0)
                {
                    TempCode += CreateRndChars();
                }

                SortVerifyCode(TempCode);
            }

            return TempCode;
        }

        #endregion

        #region 生成数字字符
        /// <summary>
        /// 生成数字字符
        /// </summary>
        /// <returns></returns>
        protected char CreateNumberChars()
        {
            return NumberChars[rnd.Next(0, NumberChars.Length)];
        }
        #endregion

        #region 生成小写英文字符
        /// <summary>
        /// 生成小写英文字符
        /// </summary>
        /// <returns></returns>
        protected char CreateLowerEnChars()
        {
            return LowerEnglishChars[rnd.Next(0, LowerEnglishChars.Length)];
        }
        #endregion

        #region 生成大写英文字符
        /// <summary>
        /// 生成大写英文字符
        /// </summary>
        /// <returns></returns>
        protected char CreateUpperEnChars()
        {
            return UpperEnglishChars[rnd.Next(0, UpperEnglishChars.Length)];
        }
        #endregion

        #region 生成汉字字符
        /// <summary>
        /// 生成汉字字符
        /// </summary>
        /// <returns></returns>
        protected char CreateZhChars()
        {
            //若提供了汉字集，查询汉字集选取汉字
            if (ChineseChars.Length > 0)
            {
                return ChineseChars[rnd.Next(0, ChineseChars.Length)];
            }
            //若没有提供汉字集，则根据《GB2312简体中文编码表》编码规则构造汉字
            else
            {
                byte[] bytes = new byte[2];

                //第一个字节值在0xb0, 0xf7之间
                bytes[0] = (byte)rnd.Next(0xb0, 0xf8);
                //第二个字节值在0xa1, 0xfe之间
                bytes[1] = (byte)rnd.Next(0xa1, 0xff);

                //根据汉字编码的字节数组解码出中文汉字
                string str1 = Encoding.GetEncoding("gb2312").GetString(bytes);

                return str1[0];
            }
        }
        #endregion

        #region 生成随机类型的字符
        /// <summary>
        /// 生成随机类型的字符
        /// </summary>
        /// <returns></returns>
        protected char CreateRndChars()
        {
            char str = new char();

            switch (Convert.ToInt32(CharsType[rnd.Next(0, CharsType.Length)].ToString()))
            {
                case 1:
                    str = CreateNumberChars();
                    break;
                case 2:
                    if (LowerEnglishLength <= 0)
                    {
                        str = CreateLowerEnChars();
                    }
                    else
                    {
                        str = CreateNumberChars();
                    }
                    break;
                case 3:
                    if (UpperEnglishLength <= 0)
                    {
                        str = CreateUpperEnChars();
                    }
                    else
                    {
                        str = CreateNumberChars();
                    }
                    break;
                case 4:
                    if (ChineseLength <= 0)
                    {
                        str = CreateZhChars();
                    }
                    else
                    {
                        str = CreateNumberChars();
                    }
                    break;
                default:
                    str = CreateNumberChars();
                    break;
            }

            return str;
        }

        #endregion

        #region 对生成的验证码进行随机排列
        /// <summary>
        /// 对生成的验证码进行随机排列
        /// </summary>
        /// <param name="TempCode">验证码</param>
        /// <returns></returns>
        protected string SortVerifyCode(string TempCode)
        {
            string VerifyCode = "";
            for (int i = 0; i < Length; i++)
            {
                int RndIndex = rnd.Next(0, TempCode.Length);
                VerifyCode += TempCode[RndIndex];
                TempCode = TempCode.Remove(RndIndex, 1);
            }

            return VerifyCode;
        }

        #endregion

        #region 获取系统中的所有字体
        /// <summary>
        /// 获取系统中的所有字体
        /// </summary>
        /// <returns></returns>
        private string[] GetSystemFontFamily()
        {
            //获取系统已经安装的字体 
            System.Drawing.Text.InstalledFontCollection MyFont = new System.Drawing.Text.InstalledFontCollection();
            FontFamily[] MyFontFamilies = MyFont.Families;
            string[] SystemFontFamily = new string[MyFontFamilies.Length];
            for (int i = 0; i < MyFontFamilies.Length; i++)
            {
                SystemFontFamily[i] = MyFontFamilies[i].Name;
            }

            return SystemFontFamily;
        }

        #endregion

        #region 产生波形滤镜效果（即扭曲效果）

        private const double PI = 3.1415926535897932384626433832795;
        private const double PI2 = 6.283185307179586476925286766559;

        /// <summary>
        /// 正弦曲线Wave扭曲图片
        /// </summary>
        /// <param name="srcBmp">图片路径</param>
        /// <param name="bXDir">如果扭曲则选择为True</param>
        /// <param name="dMultValue">波形的幅度倍数，越大扭曲的程度越高，一般为3</param>
        /// <param name="dPhase">波形的起始相位，取值区间[0-2*PI)</param>
        /// <returns></returns>
        private Bitmap TwistImage(Bitmap srcBmp, bool bXDir, double dMultValue, double dPhase)
        {
            System.Drawing.Bitmap destBmp = new Bitmap(srcBmp.Width, srcBmp.Height);

            // 将位图背景填充为白色
            Graphics graph = Graphics.FromImage(destBmp);
            graph.FillRectangle(new SolidBrush(Color.White), 0, 0, destBmp.Width, destBmp.Height);
            graph.Dispose();

            double dBaseAxisLen = bXDir ? (double)destBmp.Height : (double)destBmp.Width;

            for (int i = 0; i < destBmp.Width; i++)
            {
                for (int j = 0; j < destBmp.Height; j++)
                {
                    double dx = 0;
                    dx = bXDir ? (PI2 * (double)j) / dBaseAxisLen : (PI2 * (double)i) / dBaseAxisLen;
                    dx += dPhase;
                    double dy = Math.Sin(dx);

                    // 取得当前点的颜色
                    int nOldX = 0, nOldY = 0;
                    nOldX = bXDir ? i + (int)(dy * dMultValue) : i;
                    nOldY = bXDir ? j : j + (int)(dy * dMultValue);

                    System.Drawing.Color color = srcBmp.GetPixel(i, j);
                    if (nOldX >= 0 && nOldX < destBmp.Width
                     && nOldY >= 0 && nOldY < destBmp.Height)
                    {
                        destBmp.SetPixel(nOldX, nOldY, color);
                    }
                }
            }

            return destBmp;
        }

        #region 字体

        #endregion



        #endregion

        #region 生成验证码图片
        /// <summary>
        /// 生成验证码图片
        /// </summary>
        /// <param name="code">验证码</param>
        /// <returns></returns>
        public Bitmap CreateImage(string code)
        {
            int ImgWidth = 0, ImgHeight = 0;

            ImgWidth = code.Length * (FontSize + Padding) + Padding + FontSize;

            ImgHeight = FontSize * 2 + Padding;

            if (IsRotate)
            {
                ImgWidth += 50;
                ImgHeight += 15;
            }

            Bitmap image = new Bitmap(ImgWidth, ImgHeight);
            Graphics g = Graphics.FromImage(image);
            Brush b = null;

            //填充背景色
            if (!IsRndBackgroundColor)
            {
                g.Clear(Color.White);
            }
            else
            {
                g.Clear(Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256)));
            }

            //设置颜色
            Color CodeColor = Color.AliceBlue;
            if (!IsRndColor)
            {
                CodeColor = Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256));
            }

            string[] MyFontFamily = null;
            string CodeFontFamily = "";

            try
            {

                //获取系统的字体
                MyFontFamily = GetSystemFontFamily();

                //设置字体
                if (!IsRndFontFamily)
                {
                    if (FontFamily == string.Empty)
                    {
                        CodeFontFamily = MyFontFamily[0];
                    }
                    else
                    {
                        CodeFontFamily = FontFamily;
                    }
                }

                int Left = 0, Top = 0, TempSizeWidth = 0;

                //随机字体和颜色的验证码字符
                for (int i = 0; i < code.Length; i++)
                {
                    Font f;

                    //设置颜色
                    if (IsRndColor)
                    {
                        CodeColor = Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256));
                    }

                    b = new SolidBrush(CodeColor);

                    //设置字体
                    if (IsRndFontFamily)
                    {
                        CodeFontFamily = MyFontFamily[rnd.Next(0, MyFontFamily.Length)];
                    }

                    try
                    {
                        f = new Font(CodeFontFamily, FontSize, FontStyle.Bold);
                    }
                    catch (ArgumentException)
                    {
                        f = new Font(MyFontFamily[0], FontSize, FontStyle.Bold);
                    }

                    SizeF sizef = g.MeasureString(code[i].ToString(), f);

                    //设置上下波动
                    if (IsRndUpDownFluctuate)
                    {
                        if (sizef.Height - 3 < ImgHeight)
                        {
                            Top = rnd.Next(0, Convert.ToInt32(ImgHeight - sizef.Height + 3));//3是字体高度与图片高度的偏移量
                        }
                        else
                        {
                            Top = 0;
                        }
                    }
                    else
                    {
                        if (sizef.Height - 6 < ImgHeight)
                        {
                            Top = Convert.ToInt32((ImgHeight - sizef.Height + 3) / 2);
                        }
                        else
                        {
                            Top = Convert.ToInt32(ImgHeight - sizef.Height + 3);
                        }
                    }

                    //设置左右波动
                    if (IsRndLeftRightFluctuate)
                    {
                        int TempWidth = ImgWidth / code.Length;
                        int RndCharWidth1 = i * TempWidth;
                        int RndCharWidth2 = (i + 1) * TempWidth - Convert.ToInt32(sizef.Width);

                        if (RndCharWidth1 < 0)
                        {
                            RndCharWidth1 = 0;
                        }

                        if (ImgWidth - RndCharWidth2 < sizef.Width && i == code.Length - 1)
                        {
                            Left = ImgWidth - Convert.ToInt32(sizef.Width);
                        }
                        else
                        {
                            if (RndCharWidth1 > RndCharWidth2)
                            {
                                Left = RndCharWidth1;
                            }
                            else
                            {
                                Left = rnd.Next(RndCharWidth1, RndCharWidth2);
                            }
                        }
                    }
                    else
                    {
                        if (i == 0)
                        {
                            Left = rnd.Next(0, ImgWidth / code.Length + 10);
                            TempSizeWidth = Convert.ToInt32(Left + sizef.Width - 10);
                        }
                        else
                        {
                            Left = TempSizeWidth;
                            TempSizeWidth = Convert.ToInt32(Left + sizef.Width - 10);
                        }
                    }

                    //设置字体旋转
                    if (IsRotate)
                    {
                        int Angle = 0;//旋转的度数

                        if (rnd.Next(0, 2) == 0)
                        {
                            Angle = rnd.Next(5, 46);
                        }
                        else
                        {
                            Angle = rnd.Next(-46, -5);
                        }

                        g.TranslateTransform(i * (ImgWidth - 20) / code.Length + (ImgWidth - 20) / code.Length / 2, (ImgHeight - 10 - sizef.Height) / 2 + 5);

                        g.RotateTransform(Angle);

                        g.DrawString(code[i].ToString(), f, b, 0, 0);

                        g.ResetTransform();
                    }
                    else
                    {
                        g.DrawString(code[i].ToString(), f, b, Left, Top);
                    }
                }

                //给背景添加随机生成的燥线
                if (IsChaos)
                {
                    for (int i = 0; i < ChaosNumber; i++)
                    {
                        //给噪线添加随机颜色
                        Pen pen = new Pen(CodeColor, 2);
                        int x = rnd.Next(ImgWidth);
                        int y = rnd.Next(ImgHeight);
                        int x1 = rnd.Next(image.Width);
                        int y1 = rnd.Next(image.Height);

                        switch (Convert.ToInt32(ChaosType[rnd.Next(0, ChaosType.Length)].ToString()))
                        {
                            case 1:
                                g.DrawRectangle(pen, x, y, 2, 2);
                                g.DrawRectangle(pen, x1, y1, 2, 2);
                                break;
                            case 2:
                                g.DrawLine(pen, x, y, x1, y1);
                                break;
                            case 3:
                                g.DrawRectangle(pen, x, y, x1, y1);
                                break;
                            case 4:
                                g.DrawEllipse(pen, x, y, x1, y1);
                                break;
                            case 5:
                                g.DrawBezier(pen, x, y, x1, y1, x + y, x1 + y1, x + x1, y + y1);
                                break;
                        }
                    }
                }

                //画一个边框 边框颜色为Color.Gainsboro
                g.DrawRectangle(new Pen(Color.Gainsboro, 0), 0, 0, image.Width - 1, image.Height - 1);
                g.Dispose();

                //产生波形
                if (IsContort)
                {
                    image = TwistImage(image, true, 3, 2);
                }

                return image;
            }
            finally
            {
                b.Dispose();
                g.Dispose();
            }
        }
        #endregion

        #endregion
    }
}
