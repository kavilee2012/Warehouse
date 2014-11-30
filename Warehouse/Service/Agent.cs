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
		private int? _level;
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
		public int? Level
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
			strSql.Append("select ID,Name,Contact,Phone,Address,Level ");
			strSql.Append(" FROM [Agent] ");
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
				if(ds.Tables[0].Rows[0]["Level"]!=null && ds.Tables[0].Rows[0]["Level"].ToString()!="")
				{
					this.Level=int.Parse(ds.Tables[0].Rows[0]["Level"].ToString());
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
		public void Add()
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into [Agent] (");
			strSql.Append("ID,Name,Contact,Phone,Address,Level)");
			strSql.Append(" values (");
			strSql.Append("@ID,@Name,@Contact,@Phone,@Address,@Level)");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@Name", SqlDbType.VarChar,50),
					new SqlParameter("@Contact", SqlDbType.VarChar,50),
					new SqlParameter("@Phone", SqlDbType.VarChar,50),
					new SqlParameter("@Address", SqlDbType.VarChar,200),
					new SqlParameter("@Level", SqlDbType.Int,4)};
			parameters[0].Value = ID;
			parameters[1].Value = Name;
			parameters[2].Value = Contact;
			parameters[3].Value = Phone;
			parameters[4].Value = Address;
			parameters[5].Value = Level;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update()
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update [Agent] set ");
			strSql.Append("ID=@ID,");
			strSql.Append("Contact=@Contact,");
			strSql.Append("Phone=@Phone,");
			strSql.Append("Address=@Address,");
			strSql.Append("Level=@Level");
			strSql.Append(" where Name=@Name ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@Contact", SqlDbType.VarChar,50),
					new SqlParameter("@Phone", SqlDbType.VarChar,50),
					new SqlParameter("@Address", SqlDbType.VarChar,200),
					new SqlParameter("@Level", SqlDbType.Int,4),
					new SqlParameter("@Name", SqlDbType.VarChar,50)};
			parameters[0].Value = ID;
			parameters[1].Value = Contact;
			parameters[2].Value = Phone;
			parameters[3].Value = Address;
			parameters[4].Value = Level;
			parameters[5].Value = Name;

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
			strSql.Append("select ID,Name,Contact,Phone,Address,Level ");
			strSql.Append(" FROM [Agent] ");
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
				if(ds.Tables[0].Rows[0]["Level"]!=null && ds.Tables[0].Rows[0]["Level"].ToString()!="")
				{
					this.Level=int.Parse(ds.Tables[0].Rows[0]["Level"].ToString());
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
			strSql.Append(" FROM [Agent] ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		#endregion  Method
	}
}

