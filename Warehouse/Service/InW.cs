using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using SqlServerDAL;
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
		private int _id;
		private string _batch;
		private int? _normid;
		private string _barcode;
		private int? _cnt;
        private DateTime _createTime;
        private string _normName;

        public string NormName
        {
            get { return _normName; }
            set { _normName = value; }
        }

        public DateTime CreateTime
        {
            get { return _createTime; }
            set { _createTime = value; }
        }
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
		/// <summary>
		/// 
		/// </summary>
		public int? Cnt
		{
			set{ _cnt=value;}
			get{return _cnt;}
		}
		#endregion Model


		#region  Method

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public InW(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,Batch,NormID,Barcode,Cnt ");
			strSql.Append(" FROM [InW] ");
			strSql.Append(" where Batch=@Batch and ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@Batch", SqlDbType.VarChar,-1),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = Batch;
			parameters[1].Value = ID;

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
				if(ds.Tables[0].Rows[0]["Cnt"]!=null && ds.Tables[0].Rows[0]["Cnt"].ToString()!="")
				{
					this.Cnt=int.Parse(ds.Tables[0].Rows[0]["Cnt"].ToString());
				}
			}
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string Batch)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from [InW]");
			strSql.Append(" where Batch=@Batch and ID=@ID ");

			SqlParameter[] parameters = {
					new SqlParameter("@Batch", SqlDbType.VarChar,-1),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = Batch;
			parameters[1].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add()
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into [InW] (");
			strSql.Append("Batch,NormID,Barcode,Cnt)");
			strSql.Append(" values (");
			strSql.Append("@Batch,@NormID,@Barcode,@Cnt)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Batch", SqlDbType.VarChar,50),
					new SqlParameter("@NormID", SqlDbType.Int,4),
					new SqlParameter("@Barcode", SqlDbType.VarChar,100),
					new SqlParameter("@Cnt", SqlDbType.Int,4)};
			parameters[0].Value = Batch;
			parameters[1].Value = NormID;
			parameters[2].Value = Barcode;
			parameters[3].Value = Cnt;

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
			strSql.Append("update [InW] set ");
			strSql.Append("NormID=@NormID,");
			strSql.Append("Barcode=@Barcode,");
			strSql.Append("Cnt=@Cnt");
			strSql.Append(" where Batch=@Batch and ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@NormID", SqlDbType.Int,4),
					new SqlParameter("@Barcode", SqlDbType.VarChar,100),
					new SqlParameter("@Cnt", SqlDbType.Int,4),
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@Batch", SqlDbType.VarChar,50)};
			parameters[0].Value = NormID;
			parameters[1].Value = Barcode;
			parameters[2].Value = Cnt;
			parameters[3].Value = ID;
			parameters[4].Value = Batch;

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
			strSql.Append("delete from [InW] ");
			strSql.Append(" where Batch=@Batch and ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@Batch", SqlDbType.VarChar,-1),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = Batch;
			parameters[1].Value = ID;

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
		public InW GetModelByBatch(string batch)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select * ");
            strSql.Append(" FROM [InW] A JOIN Norm B ON A.NormID = B.NormID  ");
			strSql.Append(" where Batch=@Batch ");
			SqlParameter[] parameters = {
					new SqlParameter("@Batch", SqlDbType.VarChar,-1)};
            parameters[0].Value = batch;

            return GetOneModel(strSql, parameters);
		}

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public InW GetModelByBarcode(string code)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM [InW] A JOIN Norm B ON A.NormID = B.NormID ");
            strSql.Append(" where Barcode=@Barcode ");
            SqlParameter[] parameters = {
					new SqlParameter("@Barcode", SqlDbType.VarChar,-1)};
            parameters[0].Value = code;

           return GetOneModel(strSql, parameters);
        }

        private InW GetOneModel(StringBuilder strSql, SqlParameter[] parameters)
        {

            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                InW model = new InW();
                if (ds.Tables[0].Rows[0]["ID"] != null && ds.Tables[0].Rows[0]["ID"].ToString() != "")
                {
                    model.ID = int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Batch"] != null)
                {
                    model.Batch = ds.Tables[0].Rows[0]["Batch"].ToString();
                }
                if (ds.Tables[0].Rows[0]["NormID"] != null && ds.Tables[0].Rows[0]["NormID"].ToString() != "")
                {
                    model.NormID = int.Parse(ds.Tables[0].Rows[0]["NormID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Barcode"] != null)
                {
                    model.Barcode = ds.Tables[0].Rows[0]["Barcode"].ToString();
                }
                if (ds.Tables[0].Rows[0]["Cnt"] != null && ds.Tables[0].Rows[0]["Cnt"].ToString() != "")
                {
                    model.Cnt = int.Parse(ds.Tables[0].Rows[0]["Cnt"].ToString());
                }
                if (ds.Tables[0].Rows[0]["CreateTime"] != null && ds.Tables[0].Rows[0]["CreateTime"].ToString() != "")
                {
                    model.CreateTime = DateTime.Parse(ds.Tables[0].Rows[0]["CreateTime"].ToString());
                }
                if (ds.Tables[0].Rows[0]["NormName"] != null && ds.Tables[0].Rows[0]["NormName"].ToString() != "")
                {
                    model.NormName = ds.Tables[0].Rows[0]["NormName"].ToString();
                }
                return model;
            }
            return null;
        }

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select * ");
			strSql.Append(" FROM [InW] A JOIN Norm B ON A.NormID=B.NormID ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		#endregion  Method
	}
}

