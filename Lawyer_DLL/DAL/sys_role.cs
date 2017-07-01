﻿/**  版本信息模板在安装目录下，可自行修改。
* sys_role.cs
*
* 功 能： N/A
* 类 名： sys_role
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/7/1 11:35:11   N/A    初版
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
	/// 数据访问类:sys_role
	/// </summary>
	public partial class sys_role
	{
		public sys_role()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperMySQL.GetMaxID("RoleID", "sys_role"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int RoleID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from sys_role");
			strSql.Append(" where RoleID=@RoleID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@RoleID", MySqlDbType.Int32)
			};
			parameters[0].Value = RoleID;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Lawyer_DLL.Model.sys_role model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into sys_role(");
			strSql.Append("RoleName,RoleJurisdiction,RoleEffectiveness,RoleRemark1,RoleRemark2,RoleRemark3)");
			strSql.Append(" values (");
			strSql.Append("@RoleName,@RoleJurisdiction,@RoleEffectiveness,@RoleRemark1,@RoleRemark2,@RoleRemark3)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@RoleName", MySqlDbType.VarChar,255),
					new MySqlParameter("@RoleJurisdiction", MySqlDbType.VarChar,255),
					new MySqlParameter("@RoleEffectiveness", MySqlDbType.VarChar,255),
					new MySqlParameter("@RoleRemark1", MySqlDbType.VarChar,255),
					new MySqlParameter("@RoleRemark2", MySqlDbType.VarChar,255),
					new MySqlParameter("@RoleRemark3", MySqlDbType.VarChar,255)};
			parameters[0].Value = model.RoleName;
			parameters[1].Value = model.RoleJurisdiction;
			parameters[2].Value = model.RoleEffectiveness;
			parameters[3].Value = model.RoleRemark1;
			parameters[4].Value = model.RoleRemark2;
			parameters[5].Value = model.RoleRemark3;

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
		public bool Update(Lawyer_DLL.Model.sys_role model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update sys_role set ");
			strSql.Append("RoleName=@RoleName,");
			strSql.Append("RoleJurisdiction=@RoleJurisdiction,");
			strSql.Append("RoleEffectiveness=@RoleEffectiveness,");
			strSql.Append("RoleRemark1=@RoleRemark1,");
			strSql.Append("RoleRemark2=@RoleRemark2,");
			strSql.Append("RoleRemark3=@RoleRemark3");
			strSql.Append(" where RoleID=@RoleID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@RoleName", MySqlDbType.VarChar,255),
					new MySqlParameter("@RoleJurisdiction", MySqlDbType.VarChar,255),
					new MySqlParameter("@RoleEffectiveness", MySqlDbType.VarChar,255),
					new MySqlParameter("@RoleRemark1", MySqlDbType.VarChar,255),
					new MySqlParameter("@RoleRemark2", MySqlDbType.VarChar,255),
					new MySqlParameter("@RoleRemark3", MySqlDbType.VarChar,255),
					new MySqlParameter("@RoleID", MySqlDbType.Int32,10)};
			parameters[0].Value = model.RoleName;
			parameters[1].Value = model.RoleJurisdiction;
			parameters[2].Value = model.RoleEffectiveness;
			parameters[3].Value = model.RoleRemark1;
			parameters[4].Value = model.RoleRemark2;
			parameters[5].Value = model.RoleRemark3;
			parameters[6].Value = model.RoleID;

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
		public bool Delete(int RoleID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from sys_role ");
			strSql.Append(" where RoleID=@RoleID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@RoleID", MySqlDbType.Int32)
			};
			parameters[0].Value = RoleID;

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
		public bool DeleteList(string RoleIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from sys_role ");
			strSql.Append(" where RoleID in ("+RoleIDlist + ")  ");
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
		public Lawyer_DLL.Model.sys_role GetModel(int RoleID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select RoleID,RoleName,RoleJurisdiction,RoleEffectiveness,RoleRemark1,RoleRemark2,RoleRemark3 from sys_role ");
			strSql.Append(" where RoleID=@RoleID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@RoleID", MySqlDbType.Int32)
			};
			parameters[0].Value = RoleID;

			Lawyer_DLL.Model.sys_role model=new Lawyer_DLL.Model.sys_role();
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
		public Lawyer_DLL.Model.sys_role DataRowToModel(DataRow row)
		{
			Lawyer_DLL.Model.sys_role model=new Lawyer_DLL.Model.sys_role();
			if (row != null)
			{
				if(row["RoleID"]!=null && row["RoleID"].ToString()!="")
				{
					model.RoleID=int.Parse(row["RoleID"].ToString());
				}
				if(row["RoleName"]!=null)
				{
					model.RoleName=row["RoleName"].ToString();
				}
				if(row["RoleJurisdiction"]!=null)
				{
					model.RoleJurisdiction=row["RoleJurisdiction"].ToString();
				}
				if(row["RoleEffectiveness"]!=null)
				{
					model.RoleEffectiveness=row["RoleEffectiveness"].ToString();
				}
				if(row["RoleRemark1"]!=null)
				{
					model.RoleRemark1=row["RoleRemark1"].ToString();
				}
				if(row["RoleRemark2"]!=null)
				{
					model.RoleRemark2=row["RoleRemark2"].ToString();
				}
				if(row["RoleRemark3"]!=null)
				{
					model.RoleRemark3=row["RoleRemark3"].ToString();
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
			strSql.Append("select RoleID,RoleName,RoleJurisdiction,RoleEffectiveness,RoleRemark1,RoleRemark2,RoleRemark3 ");
			strSql.Append(" FROM sys_role ");
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
			strSql.Append("select count(1) FROM sys_role ");
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
				strSql.Append("order by T.RoleID desc");
			}
			strSql.Append(")AS Row, T.*  from sys_role T ");
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
			parameters[0].Value = "sys_role";
			parameters[1].Value = "RoleID";
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

