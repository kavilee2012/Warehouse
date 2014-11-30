using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using SqlServerDAL;//Please add references
namespace Warehouse
{
	/// <summary>
	/// 类OutW。
	/// </summary>
	[Serializable]
	public partial class OutW
	{
		public OutW()
		{}
		#region Model
		private int _id;
		private string _batch;
		private string _agent;
		private string _barcode;
		/// <summary>
		/// 
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Batch
		{
			set{ _batch=value;}
			get{return _batch;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Agent
		{
			set{ _agent=value;}
			get{return _agent;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Barcode
		{
			set{ _barcode=value;}
			get{return _barcode;}
		}
		#endregion Model


		#region  Method

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public OutW(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,Batch,Agent,Barcode ");
			strSql.Append(" FROM [OutW] ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["ID"]!=null && ds.Tables[0].Rows[0]["ID"].ToString()!="")
				{
					this.ID=int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Batch"]!=null)
				{
					this.Batch=ds.Tables[0].Rows[0]["Batch"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Agent"]!=null)
				{
					this.Agent=ds.Tables[0].Rows[0]["Agent"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Barcode"]!=null)
				{
					this.Barcode=ds.Tables[0].Rows[0]["Barcode"].ToString();
				}
			}
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists()
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from [OutW]");
			strSql.Append(" where ID=@ID ");

			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add()
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into [OutW] (");
			strSql.Append("Batch,Agent,Barcode)");
			strSql.Append(" values (");
			strSql.Append("@Batch,@Agent,@Barcode)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Batch", SqlDbType.VarChar,50),
					new SqlParameter("@Agent", SqlDbType.VarChar,50),
					new SqlParameter("@Barcode", SqlDbType.VarChar,100)};
			parameters[0].Value = Batch;
			parameters[1].Value = Agent;
			parameters[2].Value = Barcode;

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
			strSql.Append("update [OutW] set ");
			strSql.Append("Batch=@Batch,");
			strSql.Append("Agent=@Agent,");
			strSql.Append("Barcode=@Barcode");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@Batch", SqlDbType.VarChar,50),
					new SqlParameter("@Agent", SqlDbType.VarChar,50),
					new SqlParameter("@Barcode", SqlDbType.VarChar,100),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = Batch;
			parameters[1].Value = Agent;
			parameters[2].Value = Barcode;
			parameters[3].Value = ID;

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
		public bool Delete(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from [OutW] ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

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
		public void GetModel(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,Batch,Agent,Barcode ");
			strSql.Append(" FROM [OutW] ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["ID"]!=null && ds.Tables[0].Rows[0]["ID"].ToString()!="")
				{
					this.ID=int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Batch"]!=null )
				{
					this.Batch=ds.Tables[0].Rows[0]["Batch"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Agent"]!=null )
				{
					this.Agent=ds.Tables[0].Rows[0]["Agent"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Barcode"]!=null )
				{
					this.Barcode=ds.Tables[0].Rows[0]["Barcode"].ToString();
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
			strSql.Append(" FROM [OutW] ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		#endregion  Method
	}
}

