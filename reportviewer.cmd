@SET destFolder=.\bin
@XCOPY /I /Y %SYSTEMDRIVE%\WINDOWS\assembly\GAC_MSIL\Microsoft.ReportViewer.ProcessingObjectModel\9.0.0.0__b03f5f7f11d50a3a\Microsoft.ReportViewer.ProcessingObjectModel.dll %destFolder%\
@XCOPY /I /Y %SYSTEMDRIVE%\WINDOWS\assembly\GAC_MSIL\Microsoft.ReportViewer.Common\9.0.0.0__b03f5f7f11d50a3a\Microsoft.ReportViewer.Common.dll %destFolder%\
@XCOPY /I /Y "%SYSTEMDRIVE%\Program Files\Microsoft Visual Studio 9.0\ReportViewer\Microsoft.ReportViewer.WinForms.dll" %destFolder%\
@XCOPY /I /Y "%SYSTEMDRIVE%\Program Files\Microsoft Visual Studio 9.0\ReportViewer\zh-CN" %destFolder%\zh-CN\
@explorer.exe %destFolder%