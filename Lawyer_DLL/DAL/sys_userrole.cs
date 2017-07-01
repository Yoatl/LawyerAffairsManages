/**  版本信息模板在安装目录下，可自行修改。
* sys_userrole.cs
*
* 功 能： N/A
* 类 名： sys_userrole
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
	/// 数据访问类:sys_userrole
	/// </summary>
	public partial class sys_userrole
	{
		public sys_userrole()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperMySQL.GetMaxID("UserRoleID", "sys_userrole"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int UserRoleID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from sys_userrole");
			strSql.Append(" where UserRoleID=@UserRoleID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@UserRoleID", MySqlDbType.Int32)
			};
			parameters[0].Value = UserRoleID;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Lawyer_DLL.Model.sys_userrole model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into sys_userrole(");
			strSql.Append("UserID,RoleID,UserRoleModification,UserRoleRemark1,UserRoleRemark2,UserRoleRemark3)");
			strSql.Append(" values (");
			strSql.Append("@UserID,@RoleID,@UserRoleModification,@UserRoleRemark1,@UserRoleRemark2,@UserRoleRemark3)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@UserID", MySqlDbType.Int32,11),
					new MySqlParameter("@RoleID", MySqlDbType.Int32,11),
					new MySqlParameter("@UserRoleModification", MySqlDbType.VarChar,255),
					new MySqlParameter("@UserRoleRemark1", MySqlDbType.VarChar,255),
					new MySqlParameter("@UserRoleRemark2", MySqlDbType.VarChar,255),
					new MySqlParameter("@UserRoleRemark3", MySqlDbType.VarChar,255)};
			parameters[0].Value = model.UserID;
			parameters[1].Value = model.RoleID;
			parameters[2].Value = model.UserRoleModification;
			parameters[3].Value = model.UserRoleRemark1;
			parameters[4].Value = model.UserRoleRemark2;
			parameters[5].Value = model.UserRoleRemark3;

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
		public bool Update(Lawyer_DLL.Model.sys_userrole model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update sys_userrole set ");
			strSql.Append("UserID=@UserID,");
			strSql.Append("RoleID=@RoleID,");
			strSql.Append("UserRoleModification=@UserRoleModification,");
			strSql.Append("UserRoleRemark1=@UserRoleRemark1,");
			strSql.Append("UserRoleRemark2=@UserRoleRemark2,");
			strSql.Append("UserRoleRemark3=@UserRoleRemark3");
			strSql.Append(" where UserRoleID=@UserRoleID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@UserID", MySqlDbType.Int32,11),
					new MySqlParameter("@RoleID", MySqlDbType.Int32,11),
					new MySqlParameter("@UserRoleModification", MySqlDbType.VarChar,255),
					new MySqlParameter("@UserRoleRemark1", MySqlDbType.VarChar,255),
					new MySqlParameter("@UserRoleRemark2", MySqlDbType.VarChar,255),
					new MySqlParameter("@UserRoleRemark3", MySqlDbType.VarChar,255),
					new MySqlParameter("@UserRoleID", MySqlDbType.Int32,10)};
			parameters[0].Value = model.UserID;
			parameters[1].Value = model.RoleID;
			parameters[2].Value = model.UserRoleModification;
			parameters[3].Value = model.UserRoleRemark1;
			parameters[4].Value = model.UserRoleRemark2;
			parameters[5].Value = model.UserRoleRemark3;
			parameters[6].Value = model.UserRoleID;

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
		public bool Delete(int UserRoleID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from sys_userrole ");
			strSql.Append(" where UserRoleID=@UserRoleID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@UserRoleID", MySqlDbType.Int32)
			};
			parameters[0].Value = UserRoleID;

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
		public bool DeleteList(string UserRoleIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from sys_userrole ");
			strSql.Append(" where UserRoleID in ("+UserRoleIDlist + ")  ");
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
		public Lawyer_DLL.Model.sys_userrole GetModel(int UserRoleID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select UserRoleID,UserID,RoleID,UserRoleModification,UserRoleRemark1,UserRoleRemark2,UserRoleRemark3 from sys_userrole ");
			strSql.Append(" where UserRoleID=@UserRoleID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@UserRoleID", MySqlDbType.Int32)
			};
			parameters[0].Value = UserRoleID;

			Lawyer_DLL.Model.sys_userrole model=new Lawyer_DLL.Model.sys_userrole();
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
		public Lawyer_DLL.Model.sys_userrole DataRowToModel(DataRow row)
		{
			Lawyer_DLL.Model.sys_userrole model=new Lawyer_DLL.Model.sys_userrole();
			if (row != null)
			{
				if(row["UserRoleID"]!=null && row["UserRoleID"].ToString()!="")
				{
					model.UserRoleID=int.Parse(row["UserRoleID"].ToString());
				}
				if(row["UserID"]!=null && row["UserID"].ToString()!="")
				{
					model.UserID=int.Parse(row["UserID"].ToString());
				}
				if(row["RoleID"]!=null && row["RoleID"].ToString()!="")
				{
					model.RoleID=int.Parse(row["RoleID"].ToString());
				}
				if(row["UserRoleModification"]!=null)
				{
					model.UserRoleModification=row["UserRoleModification"].ToString();
				}
				if(row["UserRoleRemark1"]!=null)
				{
					model.UserRoleRemark1=row["UserRoleRemark1"].ToString();
				}
				if(row["UserRoleRemark2"]!=null)
				{
					model.UserRoleRemark2=row["UserRoleRemark2"].ToString();
				}
				if(row["UserRoleRemark3"]!=null)
				{
					model.UserRoleRemark3=row["UserRoleRemark3"].ToString();
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
			strSql.Append("select UserRoleID,UserID,RoleID,UserRoleModification,UserRoleRemark1,UserRoleRemark2,UserRoleRemark3 ");
			strSql.Append(" FROM sys_userrole ");
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
			strSql.Append("select count(1) FROM sys_userrole ");
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
				strSql.Append("order by T.UserRoleID desc");
			}
			strSql.Append(")AS Row, T.*  from sys_userrole T ");
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
			parameters[0].Value = "sys_userrole";
			parameters[1].Value = "UserRoleID";
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

