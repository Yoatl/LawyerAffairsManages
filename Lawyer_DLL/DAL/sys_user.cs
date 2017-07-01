/**  版本信息模板在安装目录下，可自行修改。
* sys_user.cs
*
* 功 能： N/A
* 类 名： sys_user
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/7/1 11:35:12   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Lawyer_DLL.DAL
{
	/// <summary>
	/// 数据访问类:sys_user
	/// </summary>
	public partial class sys_user
	{
		public sys_user()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperMySQL.GetMaxID("UserID", "sys_user"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int UserID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from sys_user");
			strSql.Append(" where UserID=@UserID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@UserID", MySqlDbType.Int32)
			};
			parameters[0].Value = UserID;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Lawyer_DLL.Model.sys_user model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into sys_user(");
			strSql.Append("UserAccount,UserPassword,UserFullName,UserTelephone,UserAddress,UserInductionTime,UserEffectiveness,UserClass,UserRemark1,UserRemark2,UserRemark3)");
			strSql.Append(" values (");
			strSql.Append("@UserAccount,@UserPassword,@UserFullName,@UserTelephone,@UserAddress,@UserInductionTime,@UserEffectiveness,@UserClass,@UserRemark1,@UserRemark2,@UserRemark3)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@UserAccount", MySqlDbType.VarChar,255),
					new MySqlParameter("@UserPassword", MySqlDbType.VarChar,255),
					new MySqlParameter("@UserFullName", MySqlDbType.VarChar,255),
					new MySqlParameter("@UserTelephone", MySqlDbType.VarChar,255),
					new MySqlParameter("@UserAddress", MySqlDbType.VarChar,255),
					new MySqlParameter("@UserInductionTime", MySqlDbType.DateTime),
					new MySqlParameter("@UserEffectiveness", MySqlDbType.VarChar,255),
					new MySqlParameter("@UserClass", MySqlDbType.VarChar,255),
					new MySqlParameter("@UserRemark1", MySqlDbType.VarChar,255),
					new MySqlParameter("@UserRemark2", MySqlDbType.VarChar,255),
					new MySqlParameter("@UserRemark3", MySqlDbType.VarChar,255)};
			parameters[0].Value = model.UserAccount;
			parameters[1].Value = model.UserPassword;
			parameters[2].Value = model.UserFullName;
			parameters[3].Value = model.UserTelephone;
			parameters[4].Value = model.UserAddress;
			parameters[5].Value = model.UserInductionTime;
			parameters[6].Value = model.UserEffectiveness;
			parameters[7].Value = model.UserClass;
			parameters[8].Value = model.UserRemark1;
			parameters[9].Value = model.UserRemark2;
			parameters[10].Value = model.UserRemark3;

			int rows=DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
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
		/// 更新一条数据
		/// </summary>
		public bool Update(Lawyer_DLL.Model.sys_user model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update sys_user set ");
			strSql.Append("UserAccount=@UserAccount,");
			strSql.Append("UserPassword=@UserPassword,");
			strSql.Append("UserFullName=@UserFullName,");
			strSql.Append("UserTelephone=@UserTelephone,");
			strSql.Append("UserAddress=@UserAddress,");
			strSql.Append("UserInductionTime=@UserInductionTime,");
			strSql.Append("UserEffectiveness=@UserEffectiveness,");
			strSql.Append("UserClass=@UserClass,");
			strSql.Append("UserRemark1=@UserRemark1,");
			strSql.Append("UserRemark2=@UserRemark2,");
			strSql.Append("UserRemark3=@UserRemark3");
			strSql.Append(" where UserID=@UserID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@UserAccount", MySqlDbType.VarChar,255),
					new MySqlParameter("@UserPassword", MySqlDbType.VarChar,255),
					new MySqlParameter("@UserFullName", MySqlDbType.VarChar,255),
					new MySqlParameter("@UserTelephone", MySqlDbType.VarChar,255),
					new MySqlParameter("@UserAddress", MySqlDbType.VarChar,255),
					new MySqlParameter("@UserInductionTime", MySqlDbType.DateTime),
					new MySqlParameter("@UserEffectiveness", MySqlDbType.VarChar,255),
					new MySqlParameter("@UserClass", MySqlDbType.VarChar,255),
					new MySqlParameter("@UserRemark1", MySqlDbType.VarChar,255),
					new MySqlParameter("@UserRemark2", MySqlDbType.VarChar,255),
					new MySqlParameter("@UserRemark3", MySqlDbType.VarChar,255),
					new MySqlParameter("@UserID", MySqlDbType.Int32,10)};
			parameters[0].Value = model.UserAccount;
			parameters[1].Value = model.UserPassword;
			parameters[2].Value = model.UserFullName;
			parameters[3].Value = model.UserTelephone;
			parameters[4].Value = model.UserAddress;
			parameters[5].Value = model.UserInductionTime;
			parameters[6].Value = model.UserEffectiveness;
			parameters[7].Value = model.UserClass;
			parameters[8].Value = model.UserRemark1;
			parameters[9].Value = model.UserRemark2;
			parameters[10].Value = model.UserRemark3;
			parameters[11].Value = model.UserID;

			int rows=DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
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
		public bool Delete(int UserID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from sys_user ");
			strSql.Append(" where UserID=@UserID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@UserID", MySqlDbType.Int32)
			};
			parameters[0].Value = UserID;

			int rows=DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
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
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string UserIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from sys_user ");
			strSql.Append(" where UserID in ("+UserIDlist + ")  ");
			int rows=DbHelperMySQL.ExecuteSql(strSql.ToString());
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
		public Lawyer_DLL.Model.sys_user GetModel(int UserID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select UserID,UserAccount,UserPassword,UserFullName,UserTelephone,UserAddress,UserInductionTime,UserEffectiveness,UserClass,UserRemark1,UserRemark2,UserRemark3 from sys_user ");
			strSql.Append(" where UserID=@UserID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@UserID", MySqlDbType.Int32)
			};
			parameters[0].Value = UserID;

			Lawyer_DLL.Model.sys_user model=new Lawyer_DLL.Model.sys_user();
			DataSet ds=DbHelperMySQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Lawyer_DLL.Model.sys_user DataRowToModel(DataRow row)
		{
			Lawyer_DLL.Model.sys_user model=new Lawyer_DLL.Model.sys_user();
			if (row != null)
			{
				if(row["UserID"]!=null && row["UserID"].ToString()!="")
				{
					model.UserID=int.Parse(row["UserID"].ToString());
				}
				if(row["UserAccount"]!=null)
				{
					model.UserAccount=row["UserAccount"].ToString();
				}
				if(row["UserPassword"]!=null)
				{
					model.UserPassword=row["UserPassword"].ToString();
				}
				if(row["UserFullName"]!=null)
				{
					model.UserFullName=row["UserFullName"].ToString();
				}
				if(row["UserTelephone"]!=null)
				{
					model.UserTelephone=row["UserTelephone"].ToString();
				}
				if(row["UserAddress"]!=null)
				{
					model.UserAddress=row["UserAddress"].ToString();
				}
				if(row["UserInductionTime"]!=null && row["UserInductionTime"].ToString()!="")
				{
					model.UserInductionTime=DateTime.Parse(row["UserInductionTime"].ToString());
				}
				if(row["UserEffectiveness"]!=null)
				{
					model.UserEffectiveness=row["UserEffectiveness"].ToString();
				}
				if(row["UserClass"]!=null)
				{
					model.UserClass=row["UserClass"].ToString();
				}
				if(row["UserRemark1"]!=null)
				{
					model.UserRemark1=row["UserRemark1"].ToString();
				}
				if(row["UserRemark2"]!=null)
				{
					model.UserRemark2=row["UserRemark2"].ToString();
				}
				if(row["UserRemark3"]!=null)
				{
					model.UserRemark3=row["UserRemark3"].ToString();
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select UserID,UserAccount,UserPassword,UserFullName,UserTelephone,UserAddress,UserInductionTime,UserEffectiveness,UserClass,UserRemark1,UserRemark2,UserRemark3 ");
			strSql.Append(" FROM sys_user ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperMySQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM sys_user ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
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
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.UserID desc");
			}
			strSql.Append(")AS Row, T.*  from sys_user T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperMySQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			MySqlParameter[] parameters = {
					new MySqlParameter("@tblName", MySqlDbType.VarChar, 255),
					new MySqlParameter("@fldName", MySqlDbType.VarChar, 255),
					new MySqlParameter("@PageSize", MySqlDbType.Int32),
					new MySqlParameter("@PageIndex", MySqlDbType.Int32),
					new MySqlParameter("@IsReCount", MySqlDbType.Bit),
					new MySqlParameter("@OrderType", MySqlDbType.Bit),
					new MySqlParameter("@strWhere", MySqlDbType.VarChar,1000),
					};
			parameters[0].Value = "sys_user";
			parameters[1].Value = "UserID";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperMySQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

