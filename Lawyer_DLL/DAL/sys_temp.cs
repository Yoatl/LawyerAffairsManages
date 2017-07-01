/**  版本信息模板在安装目录下，可自行修改。
* sys_temp.cs
*
* 功 能： N/A
* 类 名： sys_temp
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
	/// 数据访问类:sys_temp
	/// </summary>
	public partial class sys_temp
	{
		public sys_temp()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperMySQL.GetMaxID("TempID", "sys_temp"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int TempID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from sys_temp");
			strSql.Append(" where TempID=@TempID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@TempID", MySqlDbType.Int32)
			};
			parameters[0].Value = TempID;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Lawyer_DLL.Model.sys_temp model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into sys_temp(");
			strSql.Append("TempClass,TempName,TempFile,TempEffectiveness,TempRemark1,TempRemark2,TempRemark3)");
			strSql.Append(" values (");
			strSql.Append("@TempClass,@TempName,@TempFile,@TempEffectiveness,@TempRemark1,@TempRemark2,@TempRemark3)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@TempClass", MySqlDbType.VarChar,255),
					new MySqlParameter("@TempName", MySqlDbType.VarChar,255),
					new MySqlParameter("@TempFile", MySqlDbType.VarChar,255),
					new MySqlParameter("@TempEffectiveness", MySqlDbType.VarChar,255),
					new MySqlParameter("@TempRemark1", MySqlDbType.VarChar,255),
					new MySqlParameter("@TempRemark2", MySqlDbType.VarChar,255),
					new MySqlParameter("@TempRemark3", MySqlDbType.VarChar,255)};
			parameters[0].Value = model.TempClass;
			parameters[1].Value = model.TempName;
			parameters[2].Value = model.TempFile;
			parameters[3].Value = model.TempEffectiveness;
			parameters[4].Value = model.TempRemark1;
			parameters[5].Value = model.TempRemark2;
			parameters[6].Value = model.TempRemark3;

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
		public bool Update(Lawyer_DLL.Model.sys_temp model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update sys_temp set ");
			strSql.Append("TempClass=@TempClass,");
			strSql.Append("TempName=@TempName,");
			strSql.Append("TempFile=@TempFile,");
			strSql.Append("TempEffectiveness=@TempEffectiveness,");
			strSql.Append("TempRemark1=@TempRemark1,");
			strSql.Append("TempRemark2=@TempRemark2,");
			strSql.Append("TempRemark3=@TempRemark3");
			strSql.Append(" where TempID=@TempID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@TempClass", MySqlDbType.VarChar,255),
					new MySqlParameter("@TempName", MySqlDbType.VarChar,255),
					new MySqlParameter("@TempFile", MySqlDbType.VarChar,255),
					new MySqlParameter("@TempEffectiveness", MySqlDbType.VarChar,255),
					new MySqlParameter("@TempRemark1", MySqlDbType.VarChar,255),
					new MySqlParameter("@TempRemark2", MySqlDbType.VarChar,255),
					new MySqlParameter("@TempRemark3", MySqlDbType.VarChar,255),
					new MySqlParameter("@TempID", MySqlDbType.Int32,10)};
			parameters[0].Value = model.TempClass;
			parameters[1].Value = model.TempName;
			parameters[2].Value = model.TempFile;
			parameters[3].Value = model.TempEffectiveness;
			parameters[4].Value = model.TempRemark1;
			parameters[5].Value = model.TempRemark2;
			parameters[6].Value = model.TempRemark3;
			parameters[7].Value = model.TempID;

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
		public bool Delete(int TempID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from sys_temp ");
			strSql.Append(" where TempID=@TempID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@TempID", MySqlDbType.Int32)
			};
			parameters[0].Value = TempID;

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
		public bool DeleteList(string TempIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from sys_temp ");
			strSql.Append(" where TempID in ("+TempIDlist + ")  ");
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
		public Lawyer_DLL.Model.sys_temp GetModel(int TempID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select TempID,TempClass,TempName,TempFile,TempEffectiveness,TempRemark1,TempRemark2,TempRemark3 from sys_temp ");
			strSql.Append(" where TempID=@TempID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@TempID", MySqlDbType.Int32)
			};
			parameters[0].Value = TempID;

			Lawyer_DLL.Model.sys_temp model=new Lawyer_DLL.Model.sys_temp();
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
		public Lawyer_DLL.Model.sys_temp DataRowToModel(DataRow row)
		{
			Lawyer_DLL.Model.sys_temp model=new Lawyer_DLL.Model.sys_temp();
			if (row != null)
			{
				if(row["TempID"]!=null && row["TempID"].ToString()!="")
				{
					model.TempID=int.Parse(row["TempID"].ToString());
				}
				if(row["TempClass"]!=null)
				{
					model.TempClass=row["TempClass"].ToString();
				}
				if(row["TempName"]!=null)
				{
					model.TempName=row["TempName"].ToString();
				}
				if(row["TempFile"]!=null)
				{
					model.TempFile=row["TempFile"].ToString();
				}
				if(row["TempEffectiveness"]!=null)
				{
					model.TempEffectiveness=row["TempEffectiveness"].ToString();
				}
				if(row["TempRemark1"]!=null)
				{
					model.TempRemark1=row["TempRemark1"].ToString();
				}
				if(row["TempRemark2"]!=null)
				{
					model.TempRemark2=row["TempRemark2"].ToString();
				}
				if(row["TempRemark3"]!=null)
				{
					model.TempRemark3=row["TempRemark3"].ToString();
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
			strSql.Append("select TempID,TempClass,TempName,TempFile,TempEffectiveness,TempRemark1,TempRemark2,TempRemark3 ");
			strSql.Append(" FROM sys_temp ");
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
			strSql.Append("select count(1) FROM sys_temp ");
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
				strSql.Append("order by T.TempID desc");
			}
			strSql.Append(")AS Row, T.*  from sys_temp T ");
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
			parameters[0].Value = "sys_temp";
			parameters[1].Value = "TempID";
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

