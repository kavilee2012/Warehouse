using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using SqlServerDAL;
using System.Collections.Generic;
using System.Collections;
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
		private int _cnt;
        private DateTime _createTime;
        private string _normName;
        private string _operator;
        private DateTime _inTime;
        private decimal _sumPrice;
        private int _bigCnt;
        private int _machine;
        private int _length;
        private decimal _price;

        public decimal Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public int Length
        {
            get { return _length; }
            set { _length = value; }
        }

        public int Machine
        {
            get { return _machine; }
            set { _machine = value; }
        }

        public int BigCnt
        {
            get { return _bigCnt; }
            set { _bigCnt = value; }
        }

        public decimal SumPrice
        {
            get { return _sumPrice; }
            set { _sumPrice = value; }
        }

        public DateTime InTime
        {
            get { return _inTime; }
            set { _inTime = value; }
        }

        public string Operator
        {
            get { return _operator; }
            set { _operator = value; }
        }

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
		public int Cnt
		{
			set{ _cnt=value;}
			get{return _cnt;}
		}
		#endregion Model


		#region  Method

        ///// <summary>
        ///// 得到一个对象实体
        ///// </summary>
        //public InW(int ID)
        //{
        //    StringBuilder strSql=new StringBuilder();
        //    strSql.Append("select * ");
        //    strSql.Append(" FROM [InW] ");
        //    strSql.Append(" where Batch=@Batch and ID=@ID ");
        //    SqlParameter[] parameters = {
        //            new SqlParameter("@Batch", Batch),
        //            new SqlParameter("@ID", ID)};

        //    DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
        //    if(ds.Tables[0].Rows.Count>0)
        //    {
        //        if(ds.Tables[0].Rows[0]["ID"]!=null && ds.Tables[0].Rows[0]["ID"].ToString()!="")
        //        {
        //            this.ID=int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
        //        }
        //        if(ds.Tables[0].Rows[0]["Batch"]!=null)
        //        {
        //            this.Batch=ds.Tables[0].Rows[0]["Batch"].ToString();
        //        }
        //        if (ds.Tables[0].Rows[0]["NormName"] != null && ds.Tables[0].Rows[0]["NormName"].ToString() != "")
        //        {
        //            this.NormName = ds.Tables[0].Rows[0]["NormName"].ToString();
        //        }
        //        if(ds.Tables[0].Rows[0]["Barcode"]!=null)
        //        {
        //            this.Barcode=ds.Tables[0].Rows[0]["Barcode"].ToString();
        //        }
        //        if(ds.Tables[0].Rows[0]["Cnt"]!=null && ds.Tables[0].Rows[0]["Cnt"].ToString()!="")
        //        {
        //            this.Cnt=int.Parse(ds.Tables[0].Rows[0]["Cnt"].ToString());
        //        }
        //        if (ds.Tables[0].Rows[0]["BigCnt"] != null && ds.Tables[0].Rows[0]["BigCnt"].ToString() != "")
        //        {
        //            this.BigCnt = int.Parse(ds.Tables[0].Rows[0]["BigCnt"].ToString());
        //        }
        //        if (ds.Tables[0].Rows[0]["Machine"] != null && ds.Tables[0].Rows[0]["Machine"].ToString() != "")
        //        {
        //            this.Machine = int.Parse(ds.Tables[0].Rows[0]["Machine"].ToString());
        //        }
        //        if (ds.Tables[0].Rows[0]["Length"] != null && ds.Tables[0].Rows[0]["Length"].ToString() != "")
        //        {
        //            this.Length = int.Parse(ds.Tables[0].Rows[0]["Length"].ToString());
        //        }
        //    }
        //}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string Batch)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from [InW]");
			strSql.Append(" where Batch=@Batch ");

			SqlParameter[] parameters = {
					new SqlParameter("@Batch", Batch)};

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(List<string> list)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@Batch", Batch),
					new SqlParameter("@NormName", NormName),
					new SqlParameter("@Barcode", Barcode),
					new SqlParameter("@Cnt", Cnt),
                    new SqlParameter("@BigCnt", BigCnt),
                    new SqlParameter("@Machine", Machine),
                    new SqlParameter("@Length", Length),
                    new SqlParameter("@InTime", InTime),
                    new SqlParameter("@Operator", Operator)};

            List<string> sqlT = new List<string>();
            sqlT.Add("insert into [InW] (Batch,NormName,Barcode,BigCnt,Cnt,Operator,InTime,Machine,Length) values (@Batch,@NormName,@Barcode,@BigCnt,@Cnt,@Operator,@InTime,@Machine,@Length);");
            if (list.Count > 0)
            {
                foreach (string s in list)
                {
                    sqlT.Add("INSERT INTO InWDetail(BatchID,Barcode,Normname,Cnt,PrintCnt,Length) VALUES(@Batch,'" + s + "',@NormName,1,0,@Length);");
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
		public bool Update()
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update [InW] set ");
            strSql.Append("NormName=@NormName,");
			strSql.Append("Barcode=@Barcode,");
			strSql.Append("Cnt=@Cnt");
			strSql.Append(" where Batch=@Batch and ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@NormName", SqlDbType.VarChar,50),
					new SqlParameter("@Barcode", SqlDbType.VarChar,100),
					new SqlParameter("@Cnt", SqlDbType.Int,4),
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@Batch", SqlDbType.VarChar,50)};
            parameters[0].Value = NormName;
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
		public int Delete(string batch)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@Batch", batch)};

             List<string> sqlT = new List<string>();
             sqlT.Add("delete from [InW] where Batch=@Batch;");
             sqlT.Add("delete from [InWDetail] WHERE BatchID=@Batch");


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


        ///// <summary>
        ///// 得到一个对象实体
        ///// </summary>
        //public InW GetModelByBatch(string batch)
        //{
        //    StringBuilder strSql=new StringBuilder();
        //    strSql.Append("select * ");
        //    strSql.Append(" FROM [InW]");
        //    strSql.Append(" where Batch=@Batch ");
        //    SqlParameter[] parameters = {
        //            new SqlParameter("@Batch", batch)};

        //    return GetOneModel(strSql, parameters);
        //}

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public InW GetModelByBarcode(string code)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * FROM InWDetail");// strSql.Append(" FROM [InW] A JOIN InWDetail B ON A.Batch=B.BatchID");
            strSql.Append(" where Barcode=@Barcode ");
            SqlParameter[] parameters = {
					new SqlParameter("@Barcode", code)};

           return GetOneModel(strSql, parameters);
        }

        private InW GetOneModel(StringBuilder strSql, SqlParameter[] parameters)
        {

            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                InW model = new InW();
                //if (ds.Tables[0].Rows[0]["ID"] != null && ds.Tables[0].Rows[0]["ID"].ToString() != "")
                //{
                //    model.ID = int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
                //}
                if (ds.Tables[0].Rows[0]["BatchID"] != null)
                {
                    model.Batch = ds.Tables[0].Rows[0]["BatchID"].ToString();
                }
                //if (ds.Tables[0].Rows[0]["NormID"] != null && ds.Tables[0].Rows[0]["NormID"].ToString() != "")
                //{
                //    model.NormID = int.Parse(ds.Tables[0].Rows[0]["NormID"].ToString());
                //}
                if (ds.Tables[0].Rows[0]["Barcode"] != null)
                {
                    model.Barcode = ds.Tables[0].Rows[0]["Barcode"].ToString();
                }
                //if (ds.Tables[0].Rows[0]["BigCnt"] != null && ds.Tables[0].Rows[0]["BigCnt"].ToString() != "")
                //{
                //    model.BigCnt = int.Parse(ds.Tables[0].Rows[0]["BigCnt"].ToString());
                //}
                //if (ds.Tables[0].Rows[0]["Machine"] != null && ds.Tables[0].Rows[0]["Machine"].ToString() != "")
                //{
                //    model.Machine = int.Parse(ds.Tables[0].Rows[0]["Machine"].ToString());
                //}
                if (ds.Tables[0].Rows[0]["Length"] != null && ds.Tables[0].Rows[0]["Length"].ToString() != "")
                {
                    model.Length = int.Parse(ds.Tables[0].Rows[0]["Length"].ToString());
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
                //if (ds.Tables[0].Rows[0]["Operator"] != null && ds.Tables[0].Rows[0]["Operator"].ToString() != "")
                //{
                //    model.Operator = ds.Tables[0].Rows[0]["Operator"].ToString();
                //}
                //if (ds.Tables[0].Rows[0]["InTime"] != null && ds.Tables[0].Rows[0]["InTime"].ToString() != "")
                //{
                //    model.InTime = DateTime.Parse(ds.Tables[0].Rows[0]["InTime"].ToString());
                //}
                return model;
            }
            return null;
        }

        ///// <summary>
        ///// 获得数据列表
        ///// </summary>
        //public DataSet GetList(string strWhere)
        //{
        //    StringBuilder strSql=new StringBuilder();
        //    strSql.Append("select * ");
        //    strSql.Append(" FROM [InW]");
        //    if(strWhere.Trim()!="")
        //    {
        //        strSql.Append(" where "+strWhere);
        //    }
        //    strSql.Append(" order by id desc");
        //    return DbHelperSQL.Query(strSql.ToString());
        //}


        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetPageList(int PageSize, int PageIndex, string strWhere, out int count)
        {
            string strSql = "";
            if (PageIndex == 1)
            {
                strSql += "select TOP " + PageSize + " * FROM [InW] A";
            }
            else
            {
                int sumSize = PageSize * (PageIndex - 1);
                strSql += "select TOP " + PageSize + " * FROM [InW] A WHERE Batch NOT IN(select TOP " + sumSize + " Batch FROM [InW] ORDER BY ID DESC)";
            }
            string strCnt = "SELECT count(id) FROM InW ";
            if (strWhere.Trim() != "")
            {
                strSql += " where " + strWhere;
                strCnt += " where " + strWhere;
            }
            strSql += " ORDER BY A.ID DESC";

            count = (int)DbHelperSQL.GetSingle(strCnt);
            return DbHelperSQL.Query(strSql);
        }


        /// <summary>
        /// 判断是否已关联
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public bool IsRelation(string batchID)
        {
            string sql = "SELECT Count(Barcode) FROM SupplyDetail where Barcode IN (SELECT Barcode FROM InWDetail WHERE BatchID='" + batchID + "')";
            int obj = (int)DbHelperSQL.GetSingle(sql);
            if (obj > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

		#endregion  Method
	}
}

