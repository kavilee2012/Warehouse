using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace Common
{
    public class BarcodeService
    {
        /// <summary>
        /// 调用TSC打印机打印
        /// </summary>
        /// <param name="title">打印的标题</param>
        /// <param name="barCode">打印的条码编号</param>
        public static void TSC(string barCode)
        {
            //// 打开 打印机 端口.
            //TSCLIB_DLL.openport("TSC TTP-244 Plus");
            //// 设置标签 宽度、高度 等信息.
            //// 宽 94mm  高 25mm
            //// 速度为4
            //// 字体浓度为8
            //// 使用垂直間距感測器(gap sensor)
            //// 两个标签之间的  间距为 3.5mm
            //TSCLIB_DLL.setup("57", "50", "4", "8", "0", "3.5", "0");
            //// 清除缓冲信息
            //TSCLIB_DLL.clearbuffer();
            //// 发送 TSPL 指令.
            //// 设置 打印的方向.
            ////TSCLIB_DLL.sendcommand("DIRECTION 1");
            ////string command = "QRCODE 176,70,L,6,A,0,M2,S3,\"" + (barCode + DateTime.Now.ToString("yyyyMMddHHmmssff")) + "\"";
            ////TSCLIB_DLL.sendcommand(command);
            //// 打印文本信息.
            //// 在 (176, 16) 的坐标上
            //// 字体高度为34
            //// 旋转的角度为 0 度
            //// 2 表示 粗体.
            //// 文字没有下划线.
            //// 字体为 黑体.
            //// 打印的内容为：title
            ////TSCLIB_DLL.windowsfont(176, 16, 34, 0, 2, 0, "宋体", title);
            //// 打印条码.
            //// 在 (176, 66) 的坐标上
            //// 以 Code39 的条码方式
            //// 条码高度 130
            //// 打印条码的同时，还打印条码的文本信息.
            //// 旋转的角度为 0 度
            //// 条码 宽 窄 比例因子为 7:12
            //// 条码内容为:barCode
            //TSCLIB_DLL.barcode("300", "100", "128", "100", "1", "0", "7", "12", barCode);
            //// 打印.
            //TSCLIB_DLL.printlabel("1", "1");
            //// 关闭 打印机 端口
            //TSCLIB_DLL.closeport();

            //TSCLIB_DLL.about();                                                                 //Show the DLL version
            TSCLIB_DLL.openport("TSC TTP-244 Plus");                                           //Open specified printer driver
            TSCLIB_DLL.setup("40", "30", "4", "12", "0", "2", "0");                           //Setup the media size and sensor type info
            TSCLIB_DLL.clearbuffer();                                                           //Clear image buffer
            TSCLIB_DLL.barcode("50", "50", "128", "100", "1", "0", "2", "2", barCode); //Drawing barcode
            //TSCLIB_DLL.printerfont("100", "250", "3", "0", "1", "1", "Print Font Test");        //Drawing printer font
            //TSCLIB_DLL.windowsfont(100, 300, 24, 0, 0, 0, "ARIAL", "Windows Arial Font Test");  //Draw windows font
            //TSCLIB_DLL.downloadpcx("UL.PCX", "UL.PCX");                                         //Download PCX file into printer
            // TSCLIB_DLL.sendcommand("PUTPCX 100,400,\"UL.PCX\"");                                //Drawing PCX graphic
            TSCLIB_DLL.printlabel("1", "1");                                                    //Print labels
            TSCLIB_DLL.closeport();

        }
    }

    public class TSCLIB_DLL
    {
        [DllImport("TSCLIB.dll", EntryPoint = "about")]
        public static extern int about();

        [DllImport("TSCLIB.dll", EntryPoint = "openport")]
        public static extern int openport(string printername);

        [DllImport("TSCLIB.dll", EntryPoint = "barcode")]
        public static extern int barcode(string x, string y, string type,
                    string height, string readable, string rotation,
                    string narrow, string wide, string code);

        [DllImport("TSCLIB.dll", EntryPoint = "clearbuffer")]
        public static extern int clearbuffer();

        [DllImport("TSCLIB.dll", EntryPoint = "closeport")]
        public static extern int closeport();

        [DllImport("TSCLIB.dll", EntryPoint = "downloadpcx")]
        public static extern int downloadpcx(string filename, string image_name);

        [DllImport("TSCLIB.dll", EntryPoint = "formfeed")]
        public static extern int formfeed();

        [DllImport("TSCLIB.dll", EntryPoint = "nobackfeed")]
        public static extern int nobackfeed();

        [DllImport("TSCLIB.dll", EntryPoint = "printerfont")]
        public static extern int printerfont(string x, string y, string fonttype,
                        string rotation, string xmul, string ymul,
                        string text);

        [DllImport("TSCLIB.dll", EntryPoint = "printlabel")]
        public static extern int printlabel(string set, string copy);

        [DllImport("TSCLIB.dll", EntryPoint = "sendcommand")]
        public static extern int sendcommand(string printercommand);

        [DllImport("TSCLIB.dll", EntryPoint = "setup")]
        public static extern int setup(string width, string height,
                  string speed, string density,
                  string sensor, string vertical,
                  string offset);

        [DllImport("TSCLIB.dll", EntryPoint = "windowsfont")]
        public static extern int windowsfont(int x, int y, int fontheight,
                        int rotation, int fontstyle, int fontunderline,
                        string szFaceName, string content);

    }
}
