using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using SqlServerDAL;//Please add references
namespace Warehouse
{
	/// <summary>
	/// 类Norm。
	/// </summary>
	[Serializable]
	public partial class Norm
	{
		public Norm()
		{}
		#region Model
		private int _normid;
		private string _normname;
		/// <summary>
		/// 
		/// </summary>
		public int NormID
		{
			set{ _normid=value;}
			get{return _normid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string NormName
		{
			set{ _normname=value;}
			get{return _normname;}
		}
		#endregion Model


		#region  Method

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Norm(int NormID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select NormID,NormName ");
			strSql.Append(" FROM [Norm] ");
			strSql.Append(" where NormID=@NormID ");
			SqlParameter[] parameters = {
					new SqlParameter("@NormID", SqlDbType.Int,4)};
			parameters[0].Value = NormID;

			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["NormID"]!=null && ds.Tables[0].Rows[0]["NormID"].ToString()!="")
				{
					this.NormID=int.Parse(ds.Tables[0].Rows[0]["NormID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["NormName"]!=null)
				{
					this.NormName=ds.Tables[0].Rows[0]["NormName"].ToString();
				}
			}
		}

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{

		return DbHelperSQL.GetMaxID("NormID", "Norm"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string name)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from [Norm]");
			strSql.Append(" where NormName=@NormName");

            SqlParameter[] parameters = {
					new SqlParameter("@NormName", name)};

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add()
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into [Norm] (");
			strSql.Append("NormName)");
			strSql.Append(" values (");
			strSql.Append("@NormName)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@NormName", SqlDbType.VarChar,50)};
			parameters[0].Value = NormName;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update()
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update [Norm] set ");
			strSql.Append("NormName=@NormName");
			strSql.Append(" where NormID=@NormID ");
			SqlParameter[] parameters = {
					new SqlParameter("@NormName", SqlDbType.VarChar,50),
					new SqlParameter("@NormID", SqlDbType.Int,4)};
			parameters[0].Value = NormName;
			parameters[1].Value = NormID;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int NormID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from [Norm] ");
			strSql.Append(" where NormID=@NormID ");
			SqlParameter[] parameters = {
					new SqlParameter("@NormID", SqlDbType.Int,4)};
			parameters[0].Value = NormID;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public void GetModel(int NormID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select NormID,NormName ");
			strSql.Append(" FROM [Norm] ");
			strSql.Append(" where NormID=@NormID ");
			SqlParameter[] parameters = {
					new SqlParameter("@NormID", SqlDbType.Int,4)};
			parameters[0].Value = NormID;

			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["NormID"]!=null && ds.Tables[0].Rows[0]["NormID"].ToString()!="")
				{
					this.NormID=int.Parse(ds.Tables[0].Rows[0]["NormID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["NormName"]!=null )
				{
					this.NormName=ds.Tables[0].Rows[0]["NormName"].ToString();
				}
			}
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select * ");
			strSql.Append(" FROM [Norm] ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		#endregion  Method
	}
}

