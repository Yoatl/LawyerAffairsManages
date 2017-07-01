/**  版本信息模板在安装目录下，可自行修改。
* case_prodoc.cs
*
* 功 能： N/A
* 类 名： case_prodoc
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
	/// 数据访问类:case_prodoc
	/// </summary>
	public partial class case_prodoc
	{
		public case_prodoc()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperMySQL.GetMaxID("ProDocID", "case_prodoc"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ProDocID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from case_prodoc");
			strSql.Append(" where ProDocID=@ProDocID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@ProDocID", MySqlDbType.Int32)
			};
			parameters[0].Value = ProDocID;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Lawyer_DLL.Model.case_prodoc model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into case_prodoc(");
			strSql.Append("ProID,ProDocFilePath,ProDocRemark1,ProDocRemark2,ProDocRemark3)");
			strSql.Append(" values (");
			strSql.Append("@ProID,@ProDocFilePath,@ProDocRemark1,@ProDocRemark2,@ProDocRemark3)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@ProID", MySqlDbType.Int32,11),
					new MySqlParameter("@ProDocFilePath", MySqlDbType.VarChar,255),
					new MySqlParameter("@ProDocRemark1", MySqlDbType.VarChar,255),
					new MySqlParameter("@ProDocRemark2", MySqlDbType.VarChar,255),
					new MySqlParameter("@ProDocRemark3", MySqlDbType.VarChar,255)};
			parameters[0].Value = model.ProID;
			parameters[1].Value = model.ProDocFilePath;
			parameters[2].Value = model.ProDocRemark1;
			parameters[3].Value = model.ProDocRemark2;
			parameters[4].Value = model.ProDocRemark3;

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
		public bool Update(Lawyer_DLL.Model.case_prodoc model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update case_prodoc set ");
			strSql.Append("ProID=@ProID,");
			strSql.Append("ProDocFilePath=@ProDocFilePath,");
			strSql.Append("ProDocRemark1=@ProDocRemark1,");
			strSql.Append("ProDocRemark2=@ProDocRemark2,");
			strSql.Append("ProDocRemark3=@ProDocRemark3");
			strSql.Append(" where ProDocID=@ProDocID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@ProID", MySqlDbType.Int32,11),
					new MySqlParameter("@ProDocFilePath", MySqlDbType.VarChar,255),
					new MySqlParameter("@ProDocRemark1", MySqlDbType.VarChar,255),
					new MySqlParameter("@ProDocRemark2", MySqlDbType.VarChar,255),
					new MySqlParameter("@ProDocRemark3", MySqlDbType.VarChar,255),
					new MySqlParameter("@ProDocID", MySqlDbType.Int32,10)};
			parameters[0].Value = model.ProID;
			parameters[1].Value = model.ProDocFilePath;
			parameters[2].Value = model.ProDocRemark1;
			parameters[3].Value = model.ProDocRemark2;
			parameters[4].Value = model.ProDocRemark3;
			parameters[5].Value = model.ProDocID;

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
		public bool Delete(int ProDocID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from case_prodoc ");
			strSql.Append(" where ProDocID=@ProDocID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@ProDocID", MySqlDbType.Int32)
			};
			parameters[0].Value = ProDocID;

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
		public bool DeleteList(string ProDocIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from case_prodoc ");
			strSql.Append(" where ProDocID in ("+ProDocIDlist + ")  ");
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
		public Lawyer_DLL.Model.case_prodoc GetModel(int ProDocID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ProDocID,ProID,ProDocFilePath,ProDocRemark1,ProDocRemark2,ProDocRemark3 from case_prodoc ");
			strSql.Append(" where ProDocID=@ProDocID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@ProDocID", MySqlDbType.Int32)
			};
			parameters[0].Value = ProDocID;

			Lawyer_DLL.Model.case_prodoc model=new Lawyer_DLL.Model.case_prodoc();
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
		public Lawyer_DLL.Model.case_prodoc DataRowToModel(DataRow row)
		{
			Lawyer_DLL.Model.case_prodoc model=new Lawyer_DLL.Model.case_prodoc();
			if (row != null)
			{
				if(row["ProDocID"]!=null && row["ProDocID"].ToString()!="")
				{
					model.ProDocID=int.Parse(row["ProDocID"].ToString());
				}
				if(row["ProID"]!=null && row["ProID"].ToString()!="")
				{
					model.ProID=int.Parse(row["ProID"].ToString());
				}
				if(row["ProDocFilePath"]!=null)
				{
					model.ProDocFilePath=row["ProDocFilePath"].ToString();
				}
				if(row["ProDocRemark1"]!=null)
				{
					model.ProDocRemark1=row["ProDocRemark1"].ToString();
				}
				if(row["ProDocRemark2"]!=null)
				{
					model.ProDocRemark2=row["ProDocRemark2"].ToString();
				}
				if(row["ProDocRemark3"]!=null)
				{
					model.ProDocRemark3=row["ProDocRemark3"].ToString();
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
			strSql.Append("select ProDocID,ProID,ProDocFilePath,ProDocRemark1,ProDocRemark2,ProDocRemark3 ");
			strSql.Append(" FROM case_prodoc ");
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
			strSql.Append("select count(1) FROM case_prodoc ");
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
				strSql.Append("order by T.ProDocID desc");
			}
			strSql.Append(")AS Row, T.*  from case_prodoc T ");
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
			parameters[0].Value = "case_prodoc";
			parameters[1].Value = "ProDocID";
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

