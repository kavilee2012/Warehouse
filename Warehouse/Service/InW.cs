using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using SqlServerDAL;//Please add references
namespace Warehouse
{
	/// <summary>
	/// 类InW。
	/// </summary>
	[Serializable]
	public partial class InW
	{
		public InW()
		{}
		#region Model
		private int? _id;
		private string _batch;
		private int? _normid;
		private string _barcode;
		/// <summary>
		/// 
		/// </summary>
		public int? ID
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
		public int? NormID
		{
			set{ _normid=value;}
			get{return _normid;}
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
        public InW(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,Batch,NormID,Barcode ");
			strSql.Append(" FROM [InW] ");
			//strSql.Append(" where 条件);
			SqlParameter[] parameters = {
};

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
				if(ds.Tables[0].Rows[0]["NormID"]!=null && ds.Tables[0].Rows[0]["NormID"].ToString()!="")
				{
					this.NormID=int.Parse(ds.Tables[0].Rows[0]["NormID"].ToString());
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
			strSql.Append("select count(1) from [InW]");
			//strSql.Append(" where 条件);

			SqlParameter[] parameters = {
};

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add()
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into [InW] (");
			strSql.Append("ID,Batch,NormID,Barcode)");
			strSql.Append(" values (");
			strSql.Append("@ID,@Batch,@NormID,@Barcode)");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@Batch", SqlDbType.VarChar,50),
					new SqlParameter("@NormID", SqlDbType.Int,4),
					new SqlParameter("@Barcode", SqlDbType.VarChar,100)};
			parameters[0].Value = ID;
			parameters[1].Value = Batch;
			parameters[2].Value = NormID;
			parameters[3].Value = Barcode;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update()
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update [InW] set ");
			strSql.Append("ID=@ID,");
			strSql.Append("Batch=@Batch,");
			strSql.Append("NormID=@NormID,");
			strSql.Append("Barcode=@Barcode");
			//strSql.Append(" where 条件);
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@Batch", SqlDbType.VarChar,50),
					new SqlParameter("@NormID", SqlDbType.Int,4),
					new SqlParameter("@Barcode", SqlDbType.VarChar,100)};
			parameters[0].Value = ID;
			parameters[1].Value = Batch;
			parameters[2].Value = NormID;
			parameters[3].Value = Barcode;

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
		public bool Delete()
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from [InW] ");
			//strSql.Append(" where 条件);
			SqlParameter[] parameters = {
};

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
		public void GetModel()
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,Batch,NormID,Barcode ");
			strSql.Append(" FROM [InW] ");
			//strSql.Append(" where 条件);
			SqlParameter[] parameters = {
};

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
				if(ds.Tables[0].Rows[0]["NormID"]!=null && ds.Tables[0].Rows[0]["NormID"].ToString()!="")
				{
					this.NormID=int.Parse(ds.Tables[0].Rows[0]["NormID"].ToString());
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
			strSql.Append(" FROM [InW] ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		#endregion  Method
	}
}

