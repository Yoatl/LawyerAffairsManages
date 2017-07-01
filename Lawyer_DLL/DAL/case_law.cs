/**  版本信息模板在安装目录下，可自行修改。
* case_law.cs
*
* 功 能： N/A
* 类 名： case_law
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
	/// 数据访问类:case_law
	/// </summary>
	public partial class case_law
	{
		public case_law()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperMySQL.GetMaxID("LawID", "case_law"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int LawID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from case_law");
			strSql.Append(" where LawID=@LawID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@LawID", MySqlDbType.Int32)
			};
			parameters[0].Value = LawID;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Lawyer_DLL.Model.case_law model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into case_law(");
			strSql.Append("CaseID,UserID,LawRemark1,LawRemark2,LawRemark3)");
			strSql.Append(" values (");
			strSql.Append("@CaseID,@UserID,@LawRemark1,@LawRemark2,@LawRemark3)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@CaseID", MySqlDbType.Int32,11),
					new MySqlParameter("@UserID", MySqlDbType.Int32,11),
					new MySqlParameter("@LawRemark1", MySqlDbType.VarChar,255),
					new MySqlParameter("@LawRemark2", MySqlDbType.VarChar,255),
					new MySqlParameter("@LawRemark3", MySqlDbType.VarChar,255)};
			parameters[0].Value = model.CaseID;
			parameters[1].Value = model.UserID;
			parameters[2].Value = model.LawRemark1;
			parameters[3].Value = model.LawRemark2;
			parameters[4].Value = model.LawRemark3;

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
		public bool Update(Lawyer_DLL.Model.case_law model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update case_law set ");
			strSql.Append("CaseID=@CaseID,");
			strSql.Append("UserID=@UserID,");
			strSql.Append("LawRemark1=@LawRemark1,");
			strSql.Append("LawRemark2=@LawRemark2,");
			strSql.Append("LawRemark3=@LawRemark3");
			strSql.Append(" where LawID=@LawID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@CaseID", MySqlDbType.Int32,11),
					new MySqlParameter("@UserID", MySqlDbType.Int32,11),
					new MySqlParameter("@LawRemark1", MySqlDbType.VarChar,255),
					new MySqlParameter("@LawRemark2", MySqlDbType.VarChar,255),
					new MySqlParameter("@LawRemark3", MySqlDbType.VarChar,255),
					new MySqlParameter("@LawID", MySqlDbType.Int32,10)};
			parameters[0].Value = model.CaseID;
			parameters[1].Value = model.UserID;
			parameters[2].Value = model.LawRemark1;
			parameters[3].Value = model.LawRemark2;
			parameters[4].Value = model.LawRemark3;
			parameters[5].Value = model.LawID;

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
		public bool Delete(int LawID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from case_law ");
			strSql.Append(" where LawID=@LawID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@LawID", MySqlDbType.Int32)
			};
			parameters[0].Value = LawID;

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
		public bool DeleteList(string LawIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from case_law ");
			strSql.Append(" where LawID in ("+LawIDlist + ")  ");
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
		public Lawyer_DLL.Model.case_law GetModel(int LawID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select LawID,CaseID,UserID,LawRemark1,LawRemark2,LawRemark3 from case_law ");
			strSql.Append(" where LawID=@LawID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@LawID", MySqlDbType.Int32)
			};
			parameters[0].Value = LawID;

			Lawyer_DLL.Model.case_law model=new Lawyer_DLL.Model.case_law();
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
		public Lawyer_DLL.Model.case_law DataRowToModel(DataRow row)
		{
			Lawyer_DLL.Model.case_law model=new Lawyer_DLL.Model.case_law();
			if (row != null)
			{
				if(row["LawID"]!=null && row["LawID"].ToString()!="")
				{
					model.LawID=int.Parse(row["LawID"].ToString());
				}
				if(row["CaseID"]!=null && row["CaseID"].ToString()!="")
				{
					model.CaseID=int.Parse(row["CaseID"].ToString());
				}
				if(row["UserID"]!=null && row["UserID"].ToString()!="")
				{
					model.UserID=int.Parse(row["UserID"].ToString());
				}
				if(row["LawRemark1"]!=null)
				{
					model.LawRemark1=row["LawRemark1"].ToString();
				}
				if(row["LawRemark2"]!=null)
				{
					model.LawRemark2=row["LawRemark2"].ToString();
				}
				if(row["LawRemark3"]!=null)
				{
					model.LawRemark3=row["LawRemark3"].ToString();
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
			strSql.Append("select LawID,CaseID,UserID,LawRemark1,LawRemark2,LawRemark3 ");
			strSql.Append(" FROM case_law ");
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
			strSql.Append("select count(1) FROM case_law ");
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
				strSql.Append("order by T.LawID desc");
			}
			strSql.Append(")AS Row, T.*  from case_law T ");
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
			parameters[0].Value = "case_law";
			parameters[1].Value = "LawID";
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

