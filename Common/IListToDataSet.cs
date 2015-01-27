using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace Common
{
    public class IListToDataSet
    {
        /// <summary>
        /// Ilist 转换成 DataSet
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public static DataSet ConvertToDataSet<T>(IList<T> i_objlist)
        {
            if (i_objlist == null || i_objlist.Count <= 0)
            {
                return null;
            }

            DataSet ds = new DataSet();
            DataTable dt = new DataTable(typeof(T).Name);
            DataColumn column;
            DataRow row;

            System.Reflection.PropertyInfo[] myPropertyInfo = typeof(T).GetProperties(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance);

            foreach (T t in i_objlist)
            {
                if (t == null)
                {
                    continue;
                }

                row = dt.NewRow();

                for (int i = 0, j = myPropertyInfo.Length; i < j; i++)
                {
                    System.Reflection.PropertyInfo pi = myPropertyInfo[i];

                    string name = pi.Name;

                    if (dt.Columns[name] == null)
                    {
                        if (pi.PropertyType.UnderlyingSystemType.ToString() == "System.Nullable`1[System.DateTime]")//针对DataTime?类型
                        {
                            column = new DataColumn(name, typeof(DateTime));
                            dt.Columns.Add(column);

                            if (pi.GetValue(t, null) != null)
                                row[name] = pi.GetValue(t, null);
                            else
                                row[name] = System.DBNull.Value;
                        }
                        else
                        {
                            column = new DataColumn(name, pi.PropertyType);
                            dt.Columns.Add(column);
                            row[name] = pi.GetValue(t, null);
                        }
                    }
                    else
                    {
                        if (pi.PropertyType.UnderlyingSystemType.ToString() == "System.Nullable`1[System.DateTime]")//针对DataTime?类型
                        {

                            if (pi.GetValue(t, null) != null)
                                row[name] = pi.GetValue(t, null);
                            else
                                row[name] = System.DBNull.Value;
                        }
                        else
                        {

                            row[name] = pi.GetValue(t, null);
                        }
                    }


                }

                dt.Rows.Add(row);
            }

            ds.Tables.Add(dt);

            return ds;
        }

        /// <summary>
        /// Ilist 转换成 DataTable
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public static DataTable ConvertToDataTable<T>(IList<T> i_objlist)
        {
            if (i_objlist == null || i_objlist.Count <= 0)
            {
                return null;
            }
            DataTable dt = new DataTable(typeof(T).Name);
            DataColumn column;
            DataRow row;

            System.Reflection.PropertyInfo[] myPropertyInfo = typeof(T).GetProperties(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance);

            foreach (T t in i_objlist)
            {
                if (t == null)
                {
                    continue;
                }

                row = dt.NewRow();

                for (int i = 0, j = myPropertyInfo.Length; i < j; i++)
                {
                    System.Reflection.PropertyInfo pi = myPropertyInfo[i];

                    string name = pi.Name;

                    if (dt.Columns[name] == null)
                    {
                        if (pi.PropertyType.UnderlyingSystemType.ToString() == "System.Nullable`1[System.DateTime]")//针对DataTime?类型
                        {
                            column = new DataColumn(name, typeof(DateTime));
                            dt.Columns.Add(column);

                            if (pi.GetValue(t, null) != null)
                                row[name] = pi.GetValue(t, null);
                            else
                                row[name] = System.DBNull.Value;
                        }
                        else
                        {
                            column = new DataColumn(name, pi.PropertyType);
                            dt.Columns.Add(column);
                            row[name] = pi.GetValue(t, null);
                        }
                    }
                    else
                    {
                        if (pi.PropertyType.UnderlyingSystemType.ToString() == "System.Nullable`1[System.DateTime]")//针对DataTime?类型
                        {

                            if (pi.GetValue(t, null) != null)
                                row[name] = pi.GetValue(t, null);
                            else
                                row[name] = System.DBNull.Value;
                        }
                        else
                        {

                            row[name] = pi.GetValue(t, null);
                        }
                    }
                }

                dt.Rows.Add(row);
            }
            return dt;
        }

    }
}
