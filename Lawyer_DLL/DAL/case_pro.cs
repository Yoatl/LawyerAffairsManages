/**  版本信息模板在安装目录下，可自行修改。
* case_pro.cs
*
* 功 能： N/A
* 类 名： case_pro
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
	/// 数据访问类:case_pro
	/// </summary>
	public partial class case_pro
	{
		public case_pro()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperMySQL.GetMaxID("ProID", "case_pro"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ProID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from case_pro");
			strSql.Append(" where ProID=@ProID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@ProID", MySqlDbType.Int32)
			};
			parameters[0].Value = ProID;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Lawyer_DLL.Model.case_pro model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into case_pro(");
			strSql.Append("CaseID,ProProgCat,ProProgName,ProProgressNotes,ProMail,ProMailingNumber,ProMailStatus,ProWhetherFile,ProEffectiveness,ProRemark1,ProRemark2,ProRemark3)");
			strSql.Append(" values (");
			strSql.Append("@CaseID,@ProProgCat,@ProProgName,@ProProgressNotes,@ProMail,@ProMailingNumber,@ProMailStatus,@ProWhetherFile,@ProEffectiveness,@ProRemark1,@ProRemark2,@ProRemark3)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@CaseID", MySqlDbType.Int32,11),
					new MySqlParameter("@ProProgCat", MySqlDbType.VarChar,255),
					new MySqlParameter("@ProProgName", MySqlDbType.VarChar,255),
					new MySqlParameter("@ProProgressNotes", MySqlDbType.VarChar,255),
					new MySqlParameter("@ProMail", MySqlDbType.VarChar,255),
					new MySqlParameter("@ProMailingNumber", MySqlDbType.Int32,11),
					new MySqlParameter("@ProMailStatus", MySqlDbType.VarChar,255),
					new MySqlParameter("@ProWhetherFile", MySqlDbType.VarChar,255),
					new MySqlParameter("@ProEffectiveness", MySqlDbType.VarChar,255),
					new MySqlParameter("@ProRemark1", MySqlDbType.VarChar,255),
					new MySqlParameter("@ProRemark2", MySqlDbType.VarChar,255),
					new MySqlParameter("@ProRemark3", MySqlDbType.VarChar,255)};
			parameters[0].Value = model.CaseID;
			parameters[1].Value = model.ProProgCat;
			parameters[2].Value = model.ProProgName;
			parameters[3].Value = model.ProProgressNotes;
			parameters[4].Value = model.ProMail;
			parameters[5].Value = model.ProMailingNumber;
			parameters[6].Value = model.ProMailStatus;
			parameters[7].Value = model.ProWhetherFile;
			parameters[8].Value = model.ProEffectiveness;
			parameters[9].Value = model.ProRemark1;
			parameters[10].Value = model.ProRemark2;
			parameters[11].Value = model.ProRemark3;

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
		public bool Update(Lawyer_DLL.Model.case_pro model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update case_pro set ");
			strSql.Append("CaseID=@CaseID,");
			strSql.Append("ProProgCat=@ProProgCat,");
			strSql.Append("ProProgName=@ProProgName,");
			strSql.Append("ProProgressNotes=@ProProgressNotes,");
			strSql.Append("ProMail=@ProMail,");
			strSql.Append("ProMailingNumber=@ProMailingNumber,");
			strSql.Append("ProMailStatus=@ProMailStatus,");
			strSql.Append("ProWhetherFile=@ProWhetherFile,");
			strSql.Append("ProEffectiveness=@ProEffectiveness,");
			strSql.Append("ProRemark1=@ProRemark1,");
			strSql.Append("ProRemark2=@ProRemark2,");
			strSql.Append("ProRemark3=@ProRemark3");
			strSql.Append(" where ProID=@ProID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@CaseID", MySqlDbType.Int32,11),
					new MySqlParameter("@ProProgCat", MySqlDbType.VarChar,255),
					new MySqlParameter("@ProProgName", MySqlDbType.VarChar,255),
					new MySqlParameter("@ProProgressNotes", MySqlDbType.VarChar,255),
					new MySqlParameter("@ProMail", MySqlDbType.VarChar,255),
					new MySqlParameter("@ProMailingNumber", MySqlDbType.Int32,11),
					new MySqlParameter("@ProMailStatus", MySqlDbType.VarChar,255),
					new MySqlParameter("@ProWhetherFile", MySqlDbType.VarChar,255),
					new MySqlParameter("@ProEffectiveness", MySqlDbType.VarChar,255),
					new MySqlParameter("@ProRemark1", MySqlDbType.VarChar,255),
					new MySqlParameter("@ProRemark2", MySqlDbType.VarChar,255),
					new MySqlParameter("@ProRemark3", MySqlDbType.VarChar,255),
					new MySqlParameter("@ProID", MySqlDbType.Int32,10)};
			parameters[0].Value = model.CaseID;
			parameters[1].Value = model.ProProgCat;
			parameters[2].Value = model.ProProgName;
			parameters[3].Value = model.ProProgressNotes;
			parameters[4].Value = model.ProMail;
			parameters[5].Value = model.ProMailingNumber;
			parameters[6].Value = model.ProMailStatus;
			parameters[7].Value = model.ProWhetherFile;
			parameters[8].Value = model.ProEffectiveness;
			parameters[9].Value = model.ProRemark1;
			parameters[10].Value = model.ProRemark2;
			parameters[11].Value = model.ProRemark3;
			parameters[12].Value = model.ProID;

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
		public bool Delete(int ProID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from case_pro ");
			strSql.Append(" where ProID=@ProID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@ProID", MySqlDbType.Int32)
			};
			parameters[0].Value = ProID;

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
		public bool DeleteList(string ProIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from case_pro ");
			strSql.Append(" where ProID in ("+ProIDlist + ")  ");
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
		public Lawyer_DLL.Model.case_pro GetModel(int ProID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ProID,CaseID,ProProgCat,ProProgName,ProProgressNotes,ProMail,ProMailingNumber,ProMailStatus,ProWhetherFile,ProEffectiveness,ProRemark1,ProRemark2,ProRemark3 from case_pro ");
			strSql.Append(" where ProID=@ProID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@ProID", MySqlDbType.Int32)
			};
			parameters[0].Value = ProID;

			Lawyer_DLL.Model.case_pro model=new Lawyer_DLL.Model.case_pro();
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
		public Lawyer_DLL.Model.case_pro DataRowToModel(DataRow row)
		{
			Lawyer_DLL.Model.case_pro model=new Lawyer_DLL.Model.case_pro();
			if (row != null)
			{
				if(row["ProID"]!=null && row["ProID"].ToString()!="")
				{
					model.ProID=int.Parse(row["ProID"].ToString());
				}
				if(row["CaseID"]!=null && row["CaseID"].ToString()!="")
				{
					model.CaseID=int.Parse(row["CaseID"].ToString());
				}
				if(row["ProProgCat"]!=null)
				{
					model.ProProgCat=row["ProProgCat"].ToString();
				}
				if(row["ProProgName"]!=null)
				{
					model.ProProgName=row["ProProgName"].ToString();
				}
				if(row["ProProgressNotes"]!=null)
				{
					model.ProProgressNotes=row["ProProgressNotes"].ToString();
				}
				if(row["ProMail"]!=null)
				{
					model.ProMail=row["ProMail"].ToString();
				}
				if(row["ProMailingNumber"]!=null && row["ProMailingNumber"].ToString()!="")
				{
					model.ProMailingNumber=int.Parse(row["ProMailingNumber"].ToString());
				}
				if(row["ProMailStatus"]!=null)
				{
					model.ProMailStatus=row["ProMailStatus"].ToString();
				}
				if(row["ProWhetherFile"]!=null)
				{
					model.ProWhetherFile=row["ProWhetherFile"].ToString();
				}
				if(row["ProEffectiveness"]!=null)
				{
					model.ProEffectiveness=row["ProEffectiveness"].ToString();
				}
				if(row["ProRemark1"]!=null)
				{
					model.ProRemark1=row["ProRemark1"].ToString();
				}
				if(row["ProRemark2"]!=null)
				{
					model.ProRemark2=row["ProRemark2"].ToString();
				}
				if(row["ProRemark3"]!=null)
				{
					model.ProRemark3=row["ProRemark3"].ToString();
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
			strSql.Append("select ProID,CaseID,ProProgCat,ProProgName,ProProgressNotes,ProMail,ProMailingNumber,ProMailStatus,ProWhetherFile,ProEffectiveness,ProRemark1,ProRemark2,ProRemark3 ");
			strSql.Append(" FROM case_pro ");
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
			strSql.Append("select count(1) FROM case_pro ");
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
				strSql.Append("order by T.ProID desc");
			}
			strSql.Append(")AS Row, T.*  from case_pro T ");
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
			parameters[0].Value = "case_pro";
			parameters[1].Value = "ProID";
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

