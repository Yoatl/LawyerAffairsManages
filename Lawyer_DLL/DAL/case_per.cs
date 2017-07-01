/**  版本信息模板在安装目录下，可自行修改。
* case_per.cs
*
* 功 能： N/A
* 类 名： case_per
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
	/// 数据访问类:case_per
	/// </summary>
	public partial class case_per
	{
		public case_per()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperMySQL.GetMaxID("PerID", "case_per"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int PerID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from case_per");
			strSql.Append(" where PerID=@PerID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@PerID", MySqlDbType.Int32)
			};
			parameters[0].Value = PerID;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Lawyer_DLL.Model.case_per model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into case_per(");
			strSql.Append("CaseID,PerPersCat,PerFullName,PerGender,PerIDNumber,PerAddress,PerTelephone,PerRemark1,PerRemark2,PerRemark3)");
			strSql.Append(" values (");
			strSql.Append("@CaseID,@PerPersCat,@PerFullName,@PerGender,@PerIDNumber,@PerAddress,@PerTelephone,@PerRemark1,@PerRemark2,@PerRemark3)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@CaseID", MySqlDbType.Int32,11),
					new MySqlParameter("@PerPersCat", MySqlDbType.VarChar,255),
					new MySqlParameter("@PerFullName", MySqlDbType.VarChar,255),
					new MySqlParameter("@PerGender", MySqlDbType.VarChar,255),
					new MySqlParameter("@PerIDNumber", MySqlDbType.Int32,11),
					new MySqlParameter("@PerAddress", MySqlDbType.VarChar,255),
					new MySqlParameter("@PerTelephone", MySqlDbType.VarChar,255),
					new MySqlParameter("@PerRemark1", MySqlDbType.VarChar,255),
					new MySqlParameter("@PerRemark2", MySqlDbType.VarChar,255),
					new MySqlParameter("@PerRemark3", MySqlDbType.VarChar,255)};
			parameters[0].Value = model.CaseID;
			parameters[1].Value = model.PerPersCat;
			parameters[2].Value = model.PerFullName;
			parameters[3].Value = model.PerGender;
			parameters[4].Value = model.PerIDNumber;
			parameters[5].Value = model.PerAddress;
			parameters[6].Value = model.PerTelephone;
			parameters[7].Value = model.PerRemark1;
			parameters[8].Value = model.PerRemark2;
			parameters[9].Value = model.PerRemark3;

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
		public bool Update(Lawyer_DLL.Model.case_per model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update case_per set ");
			strSql.Append("CaseID=@CaseID,");
			strSql.Append("PerPersCat=@PerPersCat,");
			strSql.Append("PerFullName=@PerFullName,");
			strSql.Append("PerGender=@PerGender,");
			strSql.Append("PerIDNumber=@PerIDNumber,");
			strSql.Append("PerAddress=@PerAddress,");
			strSql.Append("PerTelephone=@PerTelephone,");
			strSql.Append("PerRemark1=@PerRemark1,");
			strSql.Append("PerRemark2=@PerRemark2,");
			strSql.Append("PerRemark3=@PerRemark3");
			strSql.Append(" where PerID=@PerID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@CaseID", MySqlDbType.Int32,11),
					new MySqlParameter("@PerPersCat", MySqlDbType.VarChar,255),
					new MySqlParameter("@PerFullName", MySqlDbType.VarChar,255),
					new MySqlParameter("@PerGender", MySqlDbType.VarChar,255),
					new MySqlParameter("@PerIDNumber", MySqlDbType.Int32,11),
					new MySqlParameter("@PerAddress", MySqlDbType.VarChar,255),
					new MySqlParameter("@PerTelephone", MySqlDbType.VarChar,255),
					new MySqlParameter("@PerRemark1", MySqlDbType.VarChar,255),
					new MySqlParameter("@PerRemark2", MySqlDbType.VarChar,255),
					new MySqlParameter("@PerRemark3", MySqlDbType.VarChar,255),
					new MySqlParameter("@PerID", MySqlDbType.Int32,10)};
			parameters[0].Value = model.CaseID;
			parameters[1].Value = model.PerPersCat;
			parameters[2].Value = model.PerFullName;
			parameters[3].Value = model.PerGender;
			parameters[4].Value = model.PerIDNumber;
			parameters[5].Value = model.PerAddress;
			parameters[6].Value = model.PerTelephone;
			parameters[7].Value = model.PerRemark1;
			parameters[8].Value = model.PerRemark2;
			parameters[9].Value = model.PerRemark3;
			parameters[10].Value = model.PerID;

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
		public bool Delete(int PerID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from case_per ");
			strSql.Append(" where PerID=@PerID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@PerID", MySqlDbType.Int32)
			};
			parameters[0].Value = PerID;

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
		public bool DeleteList(string PerIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from case_per ");
			strSql.Append(" where PerID in ("+PerIDlist + ")  ");
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
		public Lawyer_DLL.Model.case_per GetModel(int PerID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select PerID,CaseID,PerPersCat,PerFullName,PerGender,PerIDNumber,PerAddress,PerTelephone,PerRemark1,PerRemark2,PerRemark3 from case_per ");
			strSql.Append(" where PerID=@PerID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@PerID", MySqlDbType.Int32)
			};
			parameters[0].Value = PerID;

			Lawyer_DLL.Model.case_per model=new Lawyer_DLL.Model.case_per();
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
		public Lawyer_DLL.Model.case_per DataRowToModel(DataRow row)
		{
			Lawyer_DLL.Model.case_per model=new Lawyer_DLL.Model.case_per();
			if (row != null)
			{
				if(row["PerID"]!=null && row["PerID"].ToString()!="")
				{
					model.PerID=int.Parse(row["PerID"].ToString());
				}
				if(row["CaseID"]!=null && row["CaseID"].ToString()!="")
				{
					model.CaseID=int.Parse(row["CaseID"].ToString());
				}
				if(row["PerPersCat"]!=null)
				{
					model.PerPersCat=row["PerPersCat"].ToString();
				}
				if(row["PerFullName"]!=null)
				{
					model.PerFullName=row["PerFullName"].ToString();
				}
				if(row["PerGender"]!=null)
				{
					model.PerGender=row["PerGender"].ToString();
				}
				if(row["PerIDNumber"]!=null && row["PerIDNumber"].ToString()!="")
				{
					model.PerIDNumber=int.Parse(row["PerIDNumber"].ToString());
				}
				if(row["PerAddress"]!=null)
				{
					model.PerAddress=row["PerAddress"].ToString();
				}
				if(row["PerTelephone"]!=null)
				{
					model.PerTelephone=row["PerTelephone"].ToString();
				}
				if(row["PerRemark1"]!=null)
				{
					model.PerRemark1=row["PerRemark1"].ToString();
				}
				if(row["PerRemark2"]!=null)
				{
					model.PerRemark2=row["PerRemark2"].ToString();
				}
				if(row["PerRemark3"]!=null)
				{
					model.PerRemark3=row["PerRemark3"].ToString();
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
			strSql.Append("select PerID,CaseID,PerPersCat,PerFullName,PerGender,PerIDNumber,PerAddress,PerTelephone,PerRemark1,PerRemark2,PerRemark3 ");
			strSql.Append(" FROM case_per ");
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
			strSql.Append("select count(1) FROM case_per ");
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
				strSql.Append("order by T.PerID desc");
			}
			strSql.Append(")AS Row, T.*  from case_per T ");
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
			parameters[0].Value = "case_per";
			parameters[1].Value = "PerID";
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

