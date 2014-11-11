using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Collections;

namespace SqlServer
{

    /// <summary>
    /// 针对SQL数据库操作的通用类
    /// </summary>
    public class SqlHelper
    {
        public static int ExecuteNonQuery(string cmdText, params SqlParameter[] commandParameters)
        {
            return SqlProvider.ExecuteNonQuery(SqlProvider.CONN_STRING, CommandType.Text, cmdText, commandParameters);
        }

        public static int ExecuteNonQueryByStore(string cmdText, params SqlParameter[] commandParameters)
        {
            return SqlProvider.ExecuteNonQuery(SqlProvider.CONN_STRING, CommandType.StoredProcedure, cmdText, commandParameters);
        }

        public static SqlDataReader ExecuteReader(string cmdText, params SqlParameter[] commandParameters)
        {
            return SqlProvider.ExecuteReader(SqlProvider.CONN_STRING, CommandType.Text, cmdText, commandParameters);
        }

        public static object ExecuteScalar(string cmdText, params SqlParameter[] commandParameters)
        {
            return SqlProvider.ExecuteScalar(SqlProvider.CONN_STRING, CommandType.Text, cmdText, commandParameters);
        }
        public static int ExecuteScalarReInt(string cmdText, params SqlParameter[] commandParameters)
        {
            object o = SqlProvider.ExecuteScalar(SqlProvider.CONN_STRING, CommandType.Text, cmdText, commandParameters);
            if (o != null && o != DBNull.Value)
            {
                return (int)o;
            }
            return 0;
        }
        public static DataSet ExecuteDataSet(string cmdText, params SqlParameter[] commandParameters)
        {
            return SqlProvider.ExecuteDataSet(SqlProvider.CONN_STRING, CommandType.Text, cmdText, commandParameters);
        }

        public static DataTable ExecuteDataTable(string cmdText, params SqlParameter[] commandParameters)
        {
            return ExecuteDataSet(cmdText, commandParameters).Tables[0];
        }
        public static bool ExecTransaction(string[] sqlT)
        {
            return SqlProvider.ExecTransaction(SqlProvider.CONN_STRING, sqlT);
        }

        public static int NewExecTransaction(string[] sqlT, params SqlParameter[] commandParameters)
        {
            return SqlProvider.NewExecTransaction(SqlProvider.CONN_STRING, sqlT, commandParameters);
        }
        public static int NewExecTransaction(string sqlT, params SqlParameter[] commandParameters)
        {
            return SqlProvider.NewExecTransaction(SqlProvider.CONN_STRING,new string []{ sqlT}, commandParameters);
        }
        public static string ExecTransactionReturnString(string[] sqlT, params SqlParameter[] commandParameters)
        {
            return SqlProvider.ExecTransactionReturnString(SqlProvider.CONN_STRING, sqlT, commandParameters);
        }
        public static string ExecTransactionReturnString(string sqlT, params SqlParameter[] commandParameters)
        {
            return SqlProvider.ExecTransactionReturnString(SqlProvider.CONN_STRING,new string []{ sqlT}, commandParameters);
        }
      
        public static int ExecTransactionThrow(string[] sqlT, params SqlParameter[] commandParameters)
        {
            return SqlProvider.ExecTransactionThrow(SqlProvider.CONN_STRING, sqlT, commandParameters);
        }
        public static int ExecTransactionThrow(string sqlT, params SqlParameter[] commandParameters)
        {
            return SqlProvider.ExecTransactionThrow(SqlProvider.CONN_STRING,new string []{ sqlT}, commandParameters);
        }
        public static int ExecTransactionThrow(ArrayList dicSql)
        {
            return SqlProvider.ExecTransactionThrow(SqlProvider.CONN_STRING, dicSql);
        }
    }

}
