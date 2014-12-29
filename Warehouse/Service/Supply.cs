using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using SqlServerDAL;
using System.Collections.Generic;
namespace Warehouse
{
	/// <summary>
	/// 类Supply。
	/// </summary>
	public class Supply
	{
		public Supply()
		{}
		#region Model
		private int _id;
		private string _supplyid;
		private string _agentname;
		private decimal _price;
		private string _operator;
		private DateTime _createtime;
		private decimal _sumprice;

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
		public string SupplyID
		{
			set{ _supplyid=value;}
			get{return _supplyid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string AgentName
		{
			set{ _agentname=value;}
			get{return _agentname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal Price
		{
			set{ _price=value;}
			get{return _price;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Operator
		{
			set{ _operator=value;}
			get{return _operator;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime CreateTime
		{
			set{ _createtime=value;}
			get{return _createtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal SumPrice
		{
			set{ _sumprice=value;}
			get{return _sumprice;}
		}
		#endregion Model


		#region  成员方法

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Supply(string SupplyID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select * ");
			strSql.Append(" FROM Supply ");
			strSql.Append(" where SupplyID=@SupplyID ");
			SqlParameter[] parameters = {
					new SqlParameter("@SupplyID", SqlDbType.VarChar,50)};
			parameters[0].Value = SupplyID;

			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["ID"].ToString()!="")
				{
					ID=int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
				}
				SupplyID=ds.Tables[0].Rows[0]["SupplyID"].ToString();
				AgentName=ds.Tables[0].Rows[0]["AgentName"].ToString();
				if(ds.Tables[0].Rows[0]["Price"].ToString()!="")
				{
					Price=decimal.Parse(ds.Tables[0].Rows[0]["Price"].ToString());
				}
				Operator=ds.Tables[0].Rows[0]["Operator"].ToString();
				if(ds.Tables[0].Rows[0]["CreateTime"].ToString()!="")
				{
					CreateTime=DateTime.Parse(ds.Tables[0].Rows[0]["CreateTime"].ToString());
				}
                //if (ds.Tables[0].Rows[0]["InTime"].ToString() != "")
                //{
                //    InTime = DateTime.Parse(ds.Tables[0].Rows[0]["InTime"].ToString());
                //}
				if(ds.Tables[0].Rows[0]["SumPrice"].ToString()!="")
				{
					SumPrice=decimal.Parse(ds.Tables[0].Rows[0]["SumPrice"].ToString());
				}
			}
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string SupplyID,int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Supply");
			strSql.Append(" where SupplyID=@SupplyID and ID=@ID ");

			SqlParameter[] parameters = {
					new SqlParameter("@SupplyID", SqlDbType.VarChar,50),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = SupplyID;
			parameters[1].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
        public int Add(List<SupplyDetail> list)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@SupplyID", SqlDbType.VarChar,50),
					new SqlParameter("@AgentName", SqlDbType.VarChar,50),
					new SqlParameter("@Price", SqlDbType.Money,8),
					new SqlParameter("@Operator", SqlDbType.VarChar,50),
					new SqlParameter("@SumPrice", SqlDbType.Money,8)};
			parameters[0].Value = SupplyID;
			parameters[1].Value = AgentName;
			parameters[2].Value = Price;
			parameters[3].Value = Operator;
			parameters[4].Value = SumPrice;

            List<string> sqlT = new List<string>();
            sqlT.Add("insert into [Supply](SupplyID,AgentName,Price,Operator,SumPrice) values (@SupplyID,@AgentName,@Price,@Operator,@SumPrice);");
            if (list.Count > 0)
            {
                foreach (SupplyDetail s in list)
                {
                    sqlT.Add("INSERT INTO SupplyDetail(SupplyID,Barcode,Normname,Price,SumMoney,Cnt) VALUES(@SupplyID,'" + s.Barcode + "','" + s.NormName + "',@Price," + s.SumMoney + ",1);");
                }
            }
            object obj = DbHelperSQL.NewExecTransaction(sqlT.ToArray(), parameters);
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
		public void Update()
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Supply set ");
			strSql.Append("AgentName=@AgentName,");
			strSql.Append("Price=@Price,");
			strSql.Append("Operator=@Operator,");
			strSql.Append("CreateTime=@CreateTime,");
			strSql.Append("SumPrice=@SumPrice");
			strSql.Append(" where SupplyID=@SupplyID and ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@SupplyID", SqlDbType.VarChar,50),
					new SqlParameter("@AgentName", SqlDbType.VarChar,50),
					new SqlParameter("@Price", SqlDbType.Money,8),
					new SqlParameter("@Operator", SqlDbType.VarChar,50),
					new SqlParameter("@CreateTime", SqlDbType.DateTime),
					new SqlParameter("@SumPrice", SqlDbType.Money,8)};
			parameters[0].Value = ID;
			parameters[1].Value = SupplyID;
			parameters[2].Value = AgentName;
			parameters[3].Value = Price;
			parameters[4].Value = Operator;
			parameters[5].Value = CreateTime;
			parameters[6].Value = SumPrice;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(string SupplyID,int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Supply ");
			strSql.Append(" where SupplyID=@SupplyID and ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@SupplyID", SqlDbType.VarChar,50),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = SupplyID;
			parameters[1].Value = ID;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public void GetModel(string SupplyID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 * ");
			strSql.Append(" FROM Supply ");
			strSql.Append(" where SupplyID=@SupplyID ");
			SqlParameter[] parameters = {
					new SqlParameter("@SupplyID", SqlDbType.VarChar,50)};
			parameters[0].Value = SupplyID;

			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["ID"].ToString()!="")
				{
					this.ID=int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
				}
                this.SupplyID = ds.Tables[0].Rows[0]["SupplyID"].ToString();
                this.AgentName = ds.Tables[0].Rows[0]["AgentName"].ToString();
				if(ds.Tables[0].Rows[0]["Price"].ToString()!="")
				{
                    this.Price = decimal.Parse(ds.Tables[0].Rows[0]["Price"].ToString());
				}
                this.Operator = ds.Tables[0].Rows[0]["Operator"].ToString();
				if(ds.Tables[0].Rows[0]["CreateTime"].ToString()!="")
				{
                    this.CreateTime = DateTime.Parse(ds.Tables[0].Rows[0]["CreateTime"].ToString());
				}
                //if (ds.Tables[0].Rows[0]["InTime"].ToString() != "")
                //{
                //    InTime = DateTime.Parse(ds.Tables[0].Rows[0]["InTime"].ToString());
                //}
				if(ds.Tables[0].Rows[0]["SumPrice"].ToString()!="")
				{
                    this.SumPrice = decimal.Parse(ds.Tables[0].Rows[0]["SumPrice"].ToString());
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
			strSql.Append(" FROM Supply ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}


        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetFilterList(string strSql)
        {
            return DbHelperSQL.Query(strSql.ToString());
        }


        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetPageList(int PageSize, int PageIndex, string strWhere, out int count,out decimal sum)
        {
            if (strWhere.Trim() != "")
            {
                strWhere = " where " + strWhere;
            }

            string strSql = "select TOP " + PageSize + " * FROM [Supply] A ";

            if (PageIndex > 1)
            {
                int sumSize = PageSize * (PageIndex - 1);
                strSql += "WHERE A.SupplyID NOT IN(select TOP " + sumSize + " SupplyID FROM [Supply]" + strWhere + " ORDER BY ID DESC)";
            }
            if (strSql.Contains("NOT IN"))
            {
                strSql += strWhere.Replace("where", "AND") + " ORDER BY A.ID DESC";
            }
            else
            {
                strSql += strWhere + " ORDER BY A.ID DESC";
            }

            string strCnt = "SELECT count(id) FROM Supply A " + strWhere;
            string strSum = "SELECT isnull(sum(SumPrice),0) FROM Supply A " + strWhere;
            

            count = (int)DbHelperSQL.GetSingle(strCnt);
            sum = (decimal)DbHelperSQL.GetSingle(strSum);
            return DbHelperSQL.Query(strSql);
        }

		#endregion  成员方法
	}
}

