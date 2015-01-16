using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using SqlServerDAL; 
namespace Warehouse
{
	/// <summary>
	/// 类InWDetail。
	/// </summary>
	public class InWDetail
	{
		public InWDetail()
		{}
		#region Model
		private string _batchid;
		private string _barcode;
		private string _normname;
		private int? _cnt;
		private string _createtime;
        private int _length;
        private int _printCnt;

        public int PrintCnt
        {
            get { return _printCnt; }
            set { _printCnt = value; }
        }

        public int Length
        {
            get { return _length; }
            set { _length = value; }
        }

		/// <summary>
		/// 
		/// </summary>
		public string BatchID
		{
			set{ _batchid=value;}
			get{return _batchid;}
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
		public string NormName
		{
			set{ _normname=value;}
			get{return _normname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Cnt
		{
			set{ _cnt=value;}
			get{return _cnt;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CreateTime
		{
			set{ _createtime=value;}
			get{return _createtime;}
		}
		#endregion Model


		#region  成员方法


		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public static bool Exists(string barcode)
		{
			StringBuilder strSql=new StringBuilder();
            strSql.Append("select count(1) from InWDetail where Barcode='" + barcode + "'");

			return DbHelperSQL.Exists(strSql.ToString());
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add()
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into InWDetail(");
			strSql.Append("BatchID,Barcode,NormName,Cnt,CreateTime)");
			strSql.Append(" values (");
			strSql.Append("@BatchID,@Barcode,@NormName,@Cnt,@CreateTime)");
			SqlParameter[] parameters = {
					new SqlParameter("@BatchID", SqlDbType.VarChar,50),
					new SqlParameter("@Barcode", SqlDbType.VarChar,50),
					new SqlParameter("@NormName", SqlDbType.VarChar,50),
					new SqlParameter("@Cnt", SqlDbType.Int,4),
					new SqlParameter("@CreateTime", SqlDbType.VarChar,50)};
			parameters[0].Value = BatchID;
			parameters[1].Value = Barcode;
			parameters[2].Value = NormName;
			parameters[3].Value = Cnt;
			parameters[4].Value = CreateTime;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void Update()
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update InWDetail set ");
			strSql.Append("BatchID=@BatchID,");
			strSql.Append("Barcode=@Barcode,");
			strSql.Append("NormName=@NormName,");
			strSql.Append("Cnt=@Cnt,");
			strSql.Append("CreateTime=@CreateTime");
			//strSql.Append(" where 条件);
			SqlParameter[] parameters = {
					new SqlParameter("@BatchID", SqlDbType.VarChar,50),
					new SqlParameter("@Barcode", SqlDbType.VarChar,50),
					new SqlParameter("@NormName", SqlDbType.VarChar,50),
					new SqlParameter("@Cnt", SqlDbType.Int,4),
					new SqlParameter("@CreateTime", SqlDbType.VarChar,50)};
			parameters[0].Value = BatchID;
			parameters[1].Value = Barcode;
			parameters[2].Value = NormName;
			parameters[3].Value = Cnt;
			parameters[4].Value = CreateTime;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}



		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete()
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from InWDetail ");
			//strSql.Append(" where 条件);
			SqlParameter[] parameters = {
};

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public void GetModel()
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 BatchID,Barcode,NormName,Cnt,CreateTime ");
			strSql.Append(" FROM InWDetail ");
			//strSql.Append(" where 条件);
			SqlParameter[] parameters = {
};

			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				this.BatchID=ds.Tables[0].Rows[0]["BatchID"].ToString();
                this.Barcode = ds.Tables[0].Rows[0]["Barcode"].ToString();
                this.NormName = ds.Tables[0].Rows[0]["NormName"].ToString();
				if(ds.Tables[0].Rows[0]["Cnt"].ToString()!="")
				{
                    this.Cnt = int.Parse(ds.Tables[0].Rows[0]["Cnt"].ToString());
				}
                this.CreateTime = ds.Tables[0].Rows[0]["CreateTime"].ToString();
			}
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select * ");
			strSql.Append(" FROM InWDetail ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
            strSql.Append(" order by barcode asc");
			return DbHelperSQL.Query(strSql.ToString());
		}


        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void UpdatePrintCnt(string barcode)
        {
            SqlParameter[] parameters = {
					new SqlParameter("@Barcode", barcode)};
            string strSql = "update InWDetail set PrintCnt=isnull(PrintCnt,0)+1 where Barcode=@Barcode";
            DbHelperSQL.ExecuteSql(strSql, parameters);
        }

		#endregion  成员方法
	}
}

