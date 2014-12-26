using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using SqlServerDAL;//Please add references
namespace Warehouse
{
	/// <summary>
	/// 类Agent。
	/// </summary>
	[Serializable]
	public partial class Agent
	{
		public Agent()
		{}
		#region Model
		private int? _id;
		private string _name;
		private string _contact;
		private string _phone;
		private string _address;
		private string _level;
        private decimal _price;
        private string _tel;
        private string _Fox;

        public string Fox
        {
            get { return _Fox; }
            set { _Fox = value; }
        }

        public string Tel
        {
            get { return _tel; }
            set { _tel = value; }
        }

        public decimal Price
        {
            get { return _price; }
            set { _price = value; }
        }
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
		public string Name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Contact
		{
			set{ _contact=value;}
			get{return _contact;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Phone
		{
			set{ _phone=value;}
			get{return _phone;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Address
		{
			set{ _address=value;}
			get{return _address;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LevelName
		{
			set{ _level=value;}
			get{return _level;}
		}
		#endregion Model


		#region  Method

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Agent(string Name)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select A.*,B.Price ");
            strSql.Append(" FROM [Agent] A JOIN Level B ON A.LevelName = B.LevelName ");
			strSql.Append(" where Name=@Name ");
			SqlParameter[] parameters = {
					new SqlParameter("@Name", SqlDbType.VarChar,-1)};
			parameters[0].Value = Name;

			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["ID"]!=null && ds.Tables[0].Rows[0]["ID"].ToString()!="")
				{
					this.ID=int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Name"]!=null)
				{
					this.Name=ds.Tables[0].Rows[0]["Name"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Contact"]!=null)
				{
					this.Contact=ds.Tables[0].Rows[0]["Contact"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Phone"]!=null)
				{
					this.Phone=ds.Tables[0].Rows[0]["Phone"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Address"]!=null)
				{
					this.Address=ds.Tables[0].Rows[0]["Address"].ToString();
				}
                if (ds.Tables[0].Rows[0]["LevelName"] != null && ds.Tables[0].Rows[0]["LevelName"].ToString() != "")
                {
                    this.LevelName = ds.Tables[0].Rows[0]["LevelName"].ToString();
                }
                if (ds.Tables[0].Rows[0]["Price"] != null && ds.Tables[0].Rows[0]["Price"].ToString() != "")
                {
                    this.Price = decimal.Parse(ds.Tables[0].Rows[0]["Price"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Tel"] != null && ds.Tables[0].Rows[0]["Tel"].ToString() != "")
                {
                    this.Tel = ds.Tables[0].Rows[0]["Tel"].ToString();
                }
                if (ds.Tables[0].Rows[0]["Fox"] != null && ds.Tables[0].Rows[0]["Fox"].ToString() != "")
                {
                    this.Fox = ds.Tables[0].Rows[0]["Fox"].ToString();
                }
			}
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string Name)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from [Agent]");
			strSql.Append(" where Name=@Name ");

			SqlParameter[] parameters = {
					new SqlParameter("@Name", SqlDbType.VarChar,-1)};
			parameters[0].Value = Name;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add()
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into [Agent] (");
            strSql.Append("Name,Contact,Phone,Address,LevelName,Tel,Fox)");
			strSql.Append(" values (");
            strSql.Append("@Name,@Contact,@Phone,@Address,@LevelName,@Tel,@Fox)");
            strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Name", Name),
					new SqlParameter("@Contact", Contact),
					new SqlParameter("@Phone", Phone),
					new SqlParameter("@Address", Address),
                    new SqlParameter("@Tel", Tel),
                    new SqlParameter("@Fox", Fox),
					new SqlParameter("@LevelName",LevelName)};

            object obj = DbHelperSQL.GetSingle(strSql.ToString(), parameters);
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
			strSql.Append("update [Agent] set ");
			strSql.Append("Contact=@Contact,");
			strSql.Append("Phone=@Phone,");
			strSql.Append("Address=@Address,");
            strSql.Append("Tel=@Tel,");
            strSql.Append("Fox=@Fox,");
            strSql.Append("LevelName=@LevelName");
			strSql.Append(" where Name=@Name ");
			SqlParameter[] parameters = {
					new SqlParameter("@Contact", Contact),
					new SqlParameter("@Phone", Phone),
					new SqlParameter("@Address", Address),
					new SqlParameter("@LevelName", LevelName),
					new SqlParameter("@Name", Name),
                    new SqlParameter("@Tel", Tel),
                    new SqlParameter("@Fox", Fox)};

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
		public bool Delete(string Name)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from [Agent] ");
			strSql.Append(" where Name=@Name ");
			SqlParameter[] parameters = {
					new SqlParameter("@Name", SqlDbType.VarChar,-1)};
			parameters[0].Value = Name;

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
		public void GetModel(string Name)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select * ");
            strSql.Append(" FROM [Agent] A JOIN Level B ON A.LevelName = B.LevelName ");
			strSql.Append(" where Name=@Name ");
			SqlParameter[] parameters = {
					new SqlParameter("@Name", SqlDbType.VarChar,-1)};
			parameters[0].Value = Name;

			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["ID"]!=null && ds.Tables[0].Rows[0]["ID"].ToString()!="")
				{
					this.ID=int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Name"]!=null )
				{
					this.Name=ds.Tables[0].Rows[0]["Name"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Contact"]!=null )
				{
					this.Contact=ds.Tables[0].Rows[0]["Contact"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Phone"]!=null )
				{
					this.Phone=ds.Tables[0].Rows[0]["Phone"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Address"]!=null )
				{
					this.Address=ds.Tables[0].Rows[0]["Address"].ToString();
				}
                if (ds.Tables[0].Rows[0]["LevelName"] != null && ds.Tables[0].Rows[0]["LevelName"].ToString() != "")
				{
                    this.LevelName = ds.Tables[0].Rows[0]["LevelName"].ToString();
				}
                if (ds.Tables[0].Rows[0]["Price"] != null && ds.Tables[0].Rows[0]["Price"].ToString() != "")
                {
                    this.Price =decimal.Parse(ds.Tables[0].Rows[0]["Price"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Tel"] != null && ds.Tables[0].Rows[0]["Tel"].ToString() != "")
                {
                    this.Tel = ds.Tables[0].Rows[0]["Tel"].ToString();
                }
                if (ds.Tables[0].Rows[0]["Fox"] != null && ds.Tables[0].Rows[0]["Fox"].ToString() != "")
                {
                    this.Fox = ds.Tables[0].Rows[0]["Fox"].ToString();
                }
			}
		}

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetCbxList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Name ");
            strSql.Append(" FROM [Agent]");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select * ");
            strSql.Append(" FROM [Agent] A JOIN Level L ON A.LevelName=L.LevelName ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}


        /// <summary>
        /// 判断是否已关联
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public bool IsRelation(string name)
        {
            string sql = "SELECT count(ID) FROM Supply WHERE AgentName='" + name + "'";
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


        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetPageList(int PageSize, int PageIndex, string strWhere, out int count)
        {
            string strSql = "";
            if (PageIndex == 1)
            {
                strSql += "select TOP " + PageSize + " * FROM [Agent] A JOIN Level L ON A.LevelName=L.LevelName";
            }
            else
            {
                int sumSize = PageSize * (PageIndex - 1);
                strSql += "select TOP " + PageSize + " * FROM [Agent] A JOIN Level L ON A.LevelName=L.LevelName WHERE A.Name NOT IN(select TOP " + sumSize + " Name FROM [Agent] ORDER BY ID DESC)";
            }
            string strCnt = "SELECT count(id) FROM Agent A JOIN Level L ON A.LevelName=L.LevelName ";
            if (strWhere.Trim() != "")
            {
                strSql += " where " + strWhere;
                strCnt += " where " + strWhere;
            }
            strSql += " ORDER BY A.ID DESC";

            count = (int)DbHelperSQL.GetSingle(strCnt);
            return DbHelperSQL.Query(strSql);
        }

		#endregion  Method
	}
}

