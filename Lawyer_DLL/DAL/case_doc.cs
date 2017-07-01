/**  版本信息模板在安装目录下，可自行修改。
* case_doc.cs
*
* 功 能： N/A
* 类 名： case_doc
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/7/1 11:35:10   N/A    初版
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
	/// 数据访问类:case_doc
	/// </summary>
	public partial class case_doc
	{
		public case_doc()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperMySQL.GetMaxID("DocID", "case_doc"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int DocID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from case_doc");
			strSql.Append(" where DocID=@DocID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@DocID", MySqlDbType.Int32)
			};
			parameters[0].Value = DocID;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Lawyer_DLL.Model.case_doc model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into case_doc(");
			strSql.Append("CaseID,DocNameOFDocu,DocClerDocu,DocRemark1,DocRemark2,DocRemark3)");
			strSql.Append(" values (");
			strSql.Append("@CaseID,@DocNameOFDocu,@DocClerDocu,@DocRemark1,@DocRemark2,@DocRemark3)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@CaseID", MySqlDbType.Int32,11),
					new MySqlParameter("@DocNameOFDocu", MySqlDbType.VarChar,255),
					new MySqlParameter("@DocClerDocu", MySqlDbType.VarChar,255),
					new MySqlParameter("@DocRemark1", MySqlDbType.VarChar,255),
					new MySqlParameter("@DocRemark2", MySqlDbType.VarChar,255),
					new MySqlParameter("@DocRemark3", MySqlDbType.VarChar,255)};
			parameters[0].Value = model.CaseID;
			parameters[1].Value = model.DocNameOFDocu;
			parameters[2].Value = model.DocClerDocu;
			parameters[3].Value = model.DocRemark1;
			parameters[4].Value = model.DocRemark2;
			parameters[5].Value = model.DocRemark3;

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
		public bool Update(Lawyer_DLL.Model.case_doc model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update case_doc set ");
			strSql.Append("CaseID=@CaseID,");
			strSql.Append("DocNameOFDocu=@DocNameOFDocu,");
			strSql.Append("DocClerDocu=@DocClerDocu,");
			strSql.Append("DocRemark1=@DocRemark1,");
			strSql.Append("DocRemark2=@DocRemark2,");
			strSql.Append("DocRemark3=@DocRemark3");
			strSql.Append(" where DocID=@DocID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@CaseID", MySqlDbType.Int32,11),
					new MySqlParameter("@DocNameOFDocu", MySqlDbType.VarChar,255),
					new MySqlParameter("@DocClerDocu", MySqlDbType.VarChar,255),
					new MySqlParameter("@DocRemark1", MySqlDbType.VarChar,255),
					new MySqlParameter("@DocRemark2", MySqlDbType.VarChar,255),
					new MySqlParameter("@DocRemark3", MySqlDbType.VarChar,255),
					new MySqlParameter("@DocID", MySqlDbType.Int32,10)};
			parameters[0].Value = model.CaseID;
			parameters[1].Value = model.DocNameOFDocu;
			parameters[2].Value = model.DocClerDocu;
			parameters[3].Value = model.DocRemark1;
			parameters[4].Value = model.DocRemark2;
			parameters[5].Value = model.DocRemark3;
			parameters[6].Value = model.DocID;

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
		public bool Delete(int DocID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from case_doc ");
			strSql.Append(" where DocID=@DocID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@DocID", MySqlDbType.Int32)
			};
			parameters[0].Value = DocID;

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
		public bool DeleteList(string DocIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from case_doc ");
			strSql.Append(" where DocID in ("+DocIDlist + ")  ");
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
		public Lawyer_DLL.Model.case_doc GetModel(int DocID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select DocID,CaseID,DocNameOFDocu,DocClerDocu,DocRemark1,DocRemark2,DocRemark3 from case_doc ");
			strSql.Append(" where DocID=@DocID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@DocID", MySqlDbType.Int32)
			};
			parameters[0].Value = DocID;

			Lawyer_DLL.Model.case_doc model=new Lawyer_DLL.Model.case_doc();
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
		public Lawyer_DLL.Model.case_doc DataRowToModel(DataRow row)
		{
			Lawyer_DLL.Model.case_doc model=new Lawyer_DLL.Model.case_doc();
			if (row != null)
			{
				if(row["DocID"]!=null && row["DocID"].ToString()!="")
				{
					model.DocID=int.Parse(row["DocID"].ToString());
				}
				if(row["CaseID"]!=null && row["CaseID"].ToString()!="")
				{
					model.CaseID=int.Parse(row["CaseID"].ToString());
				}
				if(row["DocNameOFDocu"]!=null)
				{
					model.DocNameOFDocu=row["DocNameOFDocu"].ToString();
				}
				if(row["DocClerDocu"]!=null)
				{
					model.DocClerDocu=row["DocClerDocu"].ToString();
				}
				if(row["DocRemark1"]!=null)
				{
					model.DocRemark1=row["DocRemark1"].ToString();
				}
				if(row["DocRemark2"]!=null)
				{
					model.DocRemark2=row["DocRemark2"].ToString();
				}
				if(row["DocRemark3"]!=null)
				{
					model.DocRemark3=row["DocRemark3"].ToString();
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
			strSql.Append("select DocID,CaseID,DocNameOFDocu,DocClerDocu,DocRemark1,DocRemark2,DocRemark3 ");
			strSql.Append(" FROM case_doc ");
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
			strSql.Append("select count(1) FROM case_doc ");
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
				strSql.Append("order by T.DocID desc");
			}
			strSql.Append(")AS Row, T.*  from case_doc T ");
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
			parameters[0].Value = "case_doc";
			parameters[1].Value = "DocID";
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

