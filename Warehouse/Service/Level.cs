using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using SqlServerDAL;//Please add references
namespace Warehouse
{
	/// <summary>
	/// 类Level。
	/// </summary>
	[Serializable]
	public partial class Level
	{
		public Level()
		{}
		#region Model
		private int _levelid;
		private string _levelname;
		/// <summary>
		/// 
		/// </summary>
		public int LevelID
		{
			set{ _levelid=value;}
			get{return _levelid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LevelName
		{
			set{ _levelname=value;}
			get{return _levelname;}
		}
		#endregion Model


		#region  Method

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Level(int LevelID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select LevelID,LevelName ");
			strSql.Append(" FROM [Level] ");
			strSql.Append(" where LevelID=@LevelID ");
			SqlParameter[] parameters = {
					new SqlParameter("@LevelID", SqlDbType.Int,4)};
			parameters[0].Value = LevelID;

			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["LevelID"]!=null && ds.Tables[0].Rows[0]["LevelID"].ToString()!="")
				{
					this.LevelID=int.Parse(ds.Tables[0].Rows[0]["LevelID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["LevelName"]!=null)
				{
					this.LevelName=ds.Tables[0].Rows[0]["LevelName"].ToString();
				}
			}
		}

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{

		return DbHelperSQL.GetMaxID("LevelID", "Level"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string name)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from [Level]");
            strSql.Append(" where LevelName=@LevelName ");

			SqlParameter[] parameters = {
					new SqlParameter("@LevelName",name)};

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add()
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into [Level] (");
			strSql.Append("LevelName)");
			strSql.Append(" values (");
			strSql.Append("@LevelName)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@LevelName", SqlDbType.VarChar,50)};
			parameters[0].Value = LevelName;

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
			strSql.Append("update [Level] set ");
			strSql.Append("LevelName=@LevelName");
			strSql.Append(" where LevelID=@LevelID ");
			SqlParameter[] parameters = {
					new SqlParameter("@LevelName", SqlDbType.VarChar,50),
					new SqlParameter("@LevelID", SqlDbType.Int,4)};
			parameters[0].Value = LevelName;
			parameters[1].Value = LevelID;

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
		public bool Delete(int LevelID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from [Level] ");
			strSql.Append(" where LevelID=@LevelID ");
			SqlParameter[] parameters = {
					new SqlParameter("@LevelID", SqlDbType.Int,4)};
			parameters[0].Value = LevelID;

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
		public void GetModel(int LevelID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select LevelID,LevelName ");
			strSql.Append(" FROM [Level] ");
			strSql.Append(" where LevelID=@LevelID ");
			SqlParameter[] parameters = {
					new SqlParameter("@LevelID", SqlDbType.Int,4)};
			parameters[0].Value = LevelID;

			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["LevelID"]!=null && ds.Tables[0].Rows[0]["LevelID"].ToString()!="")
				{
					this.LevelID=int.Parse(ds.Tables[0].Rows[0]["LevelID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["LevelName"]!=null )
				{
					this.LevelName=ds.Tables[0].Rows[0]["LevelName"].ToString();
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
			strSql.Append(" FROM [Level] ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		#endregion  Method
	}
}

