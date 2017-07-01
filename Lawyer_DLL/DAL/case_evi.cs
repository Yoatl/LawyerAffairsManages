/**  版本信息模板在安装目录下，可自行修改。
* case_evi.cs
*
* 功 能： N/A
* 类 名： case_evi
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
	/// 数据访问类:case_evi
	/// </summary>
	public partial class case_evi
	{
		public case_evi()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperMySQL.GetMaxID("EviID", "case_evi"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int EviID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from case_evi");
			strSql.Append(" where EviID=@EviID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@EviID", MySqlDbType.Int32)
			};
			parameters[0].Value = EviID;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Lawyer_DLL.Model.case_evi model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into case_evi(");
			strSql.Append("CaseID,EviNameOfEvide,EviEvideDocu,EviRemark1,EviRemark2,EviRemark3)");
			strSql.Append(" values (");
			strSql.Append("@CaseID,@EviNameOfEvide,@EviEvideDocu,@EviRemark1,@EviRemark2,@EviRemark3)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@CaseID", MySqlDbType.Int32,11),
					new MySqlParameter("@EviNameOfEvide", MySqlDbType.VarChar,255),
					new MySqlParameter("@EviEvideDocu", MySqlDbType.VarChar,255),
					new MySqlParameter("@EviRemark1", MySqlDbType.VarChar,255),
					new MySqlParameter("@EviRemark2", MySqlDbType.VarChar,255),
					new MySqlParameter("@EviRemark3", MySqlDbType.VarChar,255)};
			parameters[0].Value = model.CaseID;
			parameters[1].Value = model.EviNameOfEvide;
			parameters[2].Value = model.EviEvideDocu;
			parameters[3].Value = model.EviRemark1;
			parameters[4].Value = model.EviRemark2;
			parameters[5].Value = model.EviRemark3;

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
		public bool Update(Lawyer_DLL.Model.case_evi model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update case_evi set ");
			strSql.Append("CaseID=@CaseID,");
			strSql.Append("EviNameOfEvide=@EviNameOfEvide,");
			strSql.Append("EviEvideDocu=@EviEvideDocu,");
			strSql.Append("EviRemark1=@EviRemark1,");
			strSql.Append("EviRemark2=@EviRemark2,");
			strSql.Append("EviRemark3=@EviRemark3");
			strSql.Append(" where EviID=@EviID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@CaseID", MySqlDbType.Int32,11),
					new MySqlParameter("@EviNameOfEvide", MySqlDbType.VarChar,255),
					new MySqlParameter("@EviEvideDocu", MySqlDbType.VarChar,255),
					new MySqlParameter("@EviRemark1", MySqlDbType.VarChar,255),
					new MySqlParameter("@EviRemark2", MySqlDbType.VarChar,255),
					new MySqlParameter("@EviRemark3", MySqlDbType.VarChar,255),
					new MySqlParameter("@EviID", MySqlDbType.Int32,10)};
			parameters[0].Value = model.CaseID;
			parameters[1].Value = model.EviNameOfEvide;
			parameters[2].Value = model.EviEvideDocu;
			parameters[3].Value = model.EviRemark1;
			parameters[4].Value = model.EviRemark2;
			parameters[5].Value = model.EviRemark3;
			parameters[6].Value = model.EviID;

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
		public bool Delete(int EviID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from case_evi ");
			strSql.Append(" where EviID=@EviID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@EviID", MySqlDbType.Int32)
			};
			parameters[0].Value = EviID;

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
		public bool DeleteList(string EviIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from case_evi ");
			strSql.Append(" where EviID in ("+EviIDlist + ")  ");
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
		public Lawyer_DLL.Model.case_evi GetModel(int EviID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select EviID,CaseID,EviNameOfEvide,EviEvideDocu,EviRemark1,EviRemark2,EviRemark3 from case_evi ");
			strSql.Append(" where EviID=@EviID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@EviID", MySqlDbType.Int32)
			};
			parameters[0].Value = EviID;

			Lawyer_DLL.Model.case_evi model=new Lawyer_DLL.Model.case_evi();
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
		public Lawyer_DLL.Model.case_evi DataRowToModel(DataRow row)
		{
			Lawyer_DLL.Model.case_evi model=new Lawyer_DLL.Model.case_evi();
			if (row != null)
			{
				if(row["EviID"]!=null && row["EviID"].ToString()!="")
				{
					model.EviID=int.Parse(row["EviID"].ToString());
				}
				if(row["CaseID"]!=null && row["CaseID"].ToString()!="")
				{
					model.CaseID=int.Parse(row["CaseID"].ToString());
				}
				if(row["EviNameOfEvide"]!=null)
				{
					model.EviNameOfEvide=row["EviNameOfEvide"].ToString();
				}
				if(row["EviEvideDocu"]!=null)
				{
					model.EviEvideDocu=row["EviEvideDocu"].ToString();
				}
				if(row["EviRemark1"]!=null)
				{
					model.EviRemark1=row["EviRemark1"].ToString();
				}
				if(row["EviRemark2"]!=null)
				{
					model.EviRemark2=row["EviRemark2"].ToString();
				}
				if(row["EviRemark3"]!=null)
				{
					model.EviRemark3=row["EviRemark3"].ToString();
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
			strSql.Append("select EviID,CaseID,EviNameOfEvide,EviEvideDocu,EviRemark1,EviRemark2,EviRemark3 ");
			strSql.Append(" FROM case_evi ");
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
			strSql.Append("select count(1) FROM case_evi ");
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
				strSql.Append("order by T.EviID desc");
			}
			strSql.Append(")AS Row, T.*  from case_evi T ");
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
			parameters[0].Value = "case_evi";
			parameters[1].Value = "EviID";
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

