    using System;
using System.Collections.Generic;
using System.Text;

namespace Utility
{
    #region WriteContent不能为NULL或Empty的异常类
    /// <summary>
    /// WriteText不能为NULL或Empty的异常类
    /// </summary>
    public class WriteContentIsNullOrEmptyException : Exception
    {
        private const string m_Message = "需要写入的内容不能为NULL或空值！";

        /// <summary>
        /// 当需要写入的文本为Null或空时引发的异常
        /// </summary>
        public WriteContentIsNullOrEmptyException()
            : base(m_Message)
        {

        }

        /// <summary>
        /// 当需要写入的文本为Null或空时引发的异常
        /// </summary>
        public WriteContentIsNullOrEmptyException(string message)
            : base(message)
        {

        }

        /// <summary>
        /// 当需要写入的文本为Null或空时引发的异常
        /// </summary>
        public WriteContentIsNullOrEmptyException(string message, Exception ex)
            : base(message, ex)
        {

        }
    }
    #endregion

    #region 读取的FileSize不能大于2M的异常类
    /// <summary>
    /// 读取的FileSize不能大于2M的异常类
    /// </summary>
    public class FileSizeIsGreaterThan2MException : Exception
    {
        private const string m_Message = "读取的文件大小不能大于2M！";

        /// <summary>
        /// 当读取的文件大小大于2M时引发的异常
        /// </summary>
        public FileSizeIsGreaterThan2MException()
            : base(m_Message)
        {

        }

        /// <summary>
        /// 当读取的文件大小大于2M时引发的异常
        /// </summary>
        public FileSizeIsGreaterThan2MException(string message)
            : base(message)
        {

        }

        /// <summary>
        /// 当读取的文件大小大于2M时引发的异常
        /// </summary>
        public FileSizeIsGreaterThan2MException(string message, Exception ex)
            : base(message, ex)
        {

        }
    }
    #endregion


    #region Path不能为NULL或Empty的异常类
    /// <summary>
    /// Path不能为NULL或Empty的异常类
    /// </summary>
    public class PathIsNullOrEmptyException : Exception
    {
        private const string m_Message = "路径不能为NULL或空值！";

        /// <summary>
        /// 当Path为Null或空时引发的异常
        /// </summary>
        public PathIsNullOrEmptyException()
            : base(m_Message)
        {

        }

        /// <summary>
        /// 当Path为Null或空时引发的异常
        /// </summary>
        public PathIsNullOrEmptyException(string message)
            : base(message)
        {

        }

        /// <summary>
        /// 当Path为Null或空时引发的异常
        /// </summary>
        public PathIsNullOrEmptyException(string message, Exception ex)
            : base(message, ex)
        {

        }
    }
    #endregion

    #region Path路径下的文件不存在的异常类
    /// <summary>
    /// Path路径下的文件不存在的异常类
    /// </summary>
    public class PathFileNotExistException : Exception
    {
        private const string m_Message = "Path路径下的文件不存在！";

        /// <summary>
        /// 当Path路径下的文件不存在时引发的异常
        /// </summary>
        public PathFileNotExistException()
            : base(m_Message)
        {

        }

        /// <summary>
        /// 当Path路径下的文件不存在时引发的异常
        /// </summary>
        public PathFileNotExistException(string message)
            : base(message)
        {

        }

        /// <summary>
        /// 当Path路径下的文件不存在时引发的异常
        /// </summary>
        public PathFileNotExistException(string message, Exception ex)
            : base(message, ex)
        {

        }
    }
    #endregion
}
