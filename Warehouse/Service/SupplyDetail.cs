using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using SqlServerDAL;
namespace Warehouse
{
	/// <summary>
	/// 类SupplyDetail。
	/// </summary>
	public class SupplyDetail
	{
		public SupplyDetail()
		{}
		#region Model
		private string _supplyid;
		private string _barcode;
		private string _normname;
		private decimal? _price;
		private decimal? _summoney;
		private int? _cnt;
		/// <summary>
		/// 
		/// </summary>
		public string SupplyID
		{
			set{ _supplyid=value;}
			get{return _supplyid;}
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
		public decimal? Price
		{
			set{ _price=value;}
			get{return _price;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? SumMoney
		{
			set{ _summoney=value;}
			get{return _summoney;}
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


		#region  成员方法

//        /// <summary>
//        /// 得到一个对象实体
//        /// </summary>
//        public SupplyDetail()
//        {
//            StringBuilder strSql=new StringBuilder();
//            strSql.Append("select SupplyID,Barcode,NormName,Price,SumMoney,Cnt ");
//            strSql.Append(" FROM SupplyDetail ");
//            //strSql.Append(" where 条件);
//            SqlParameter[] parameters = {
//};

//            DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
//            if(ds.Tables[0].Rows.Count>0)
//            {
//                SupplyID=ds.Tables[0].Rows[0]["SupplyID"].ToString();
//                Barcode=ds.Tables[0].Rows[0]["Barcode"].ToString();
//                NormName=ds.Tables[0].Rows[0]["NormName"].ToString();
//                if(ds.Tables[0].Rows[0]["Price"].ToString()!="")
//                {
//                    Price=decimal.Parse(ds.Tables[0].Rows[0]["Price"].ToString());
//                }
//                if(ds.Tables[0].Rows[0]["SumMoney"].ToString()!="")
//                {
//                    SumMoney=decimal.Parse(ds.Tables[0].Rows[0]["SumMoney"].ToString());
//                }
//                if(ds.Tables[0].Rows[0]["Cnt"].ToString()!="")
//                {
//                    Cnt=int.Parse(ds.Tables[0].Rows[0]["Cnt"].ToString());
//                }
//            }
//        }

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists()
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from SupplyDetail");
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
			strSql.Append("insert into SupplyDetail(");
			strSql.Append("SupplyID,Barcode,NormName,Price,SumMoney,Cnt)");
			strSql.Append(" values (");
			strSql.Append("@SupplyID,@Barcode,@NormName,@Price,@SumMoney,@Cnt)");
			SqlParameter[] parameters = {
					new SqlParameter("@SupplyID", SqlDbType.VarChar,50),
					new SqlParameter("@Barcode", SqlDbType.VarChar,50),
					new SqlParameter("@NormName", SqlDbType.VarChar,50),
					new SqlParameter("@Price", SqlDbType.Money,8),
					new SqlParameter("@SumMoney", SqlDbType.Money,8),
					new SqlParameter("@Cnt", SqlDbType.Int,4)};
			parameters[0].Value = SupplyID;
			parameters[1].Value = Barcode;
			parameters[2].Value = NormName;
			parameters[3].Value = Price;
			parameters[4].Value = SumMoney;
			parameters[5].Value = Cnt;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void Update()
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update SupplyDetail set ");
			strSql.Append("SupplyID=@SupplyID,");
			strSql.Append("Barcode=@Barcode,");
			strSql.Append("NormName=@NormName,");
			strSql.Append("Price=@Price,");
			strSql.Append("SumMoney=@SumMoney,");
			strSql.Append("Cnt=@Cnt");
			//strSql.Append(" where 条件);
			SqlParameter[] parameters = {
					new SqlParameter("@SupplyID", SqlDbType.VarChar,50),
					new SqlParameter("@Barcode", SqlDbType.VarChar,50),
					new SqlParameter("@NormName", SqlDbType.VarChar,50),
					new SqlParameter("@Price", SqlDbType.Money,8),
					new SqlParameter("@SumMoney", SqlDbType.Money,8),
					new SqlParameter("@Cnt", SqlDbType.Int,4)};
			parameters[0].Value = SupplyID;
			parameters[1].Value = Barcode;
			parameters[2].Value = NormName;
			parameters[3].Value = Price;
			parameters[4].Value = SumMoney;
			parameters[5].Value = Cnt;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete()
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from SupplyDetail ");
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
			strSql.Append("select  top 1 SupplyID,Barcode,NormName,Price,SumMoney,Cnt ");
			strSql.Append(" FROM SupplyDetail ");
			//strSql.Append(" where 条件);
			SqlParameter[] parameters = {
};

			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				this.SupplyID=ds.Tables[0].Rows[0]["SupplyID"].ToString();
                this.Barcode = ds.Tables[0].Rows[0]["Barcode"].ToString();
                this.NormName = ds.Tables[0].Rows[0]["NormName"].ToString();
				if(ds.Tables[0].Rows[0]["Price"].ToString()!="")
				{
                    this.Price = decimal.Parse(ds.Tables[0].Rows[0]["Price"].ToString());
				}
				if(ds.Tables[0].Rows[0]["SumMoney"].ToString()!="")
				{
                    this.SumMoney = decimal.Parse(ds.Tables[0].Rows[0]["SumMoney"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Cnt"].ToString()!="")
				{
                    this.Cnt = int.Parse(ds.Tables[0].Rows[0]["Cnt"].ToString());
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
			strSql.Append(" FROM SupplyDetail ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		#endregion  成员方法
	}
}

