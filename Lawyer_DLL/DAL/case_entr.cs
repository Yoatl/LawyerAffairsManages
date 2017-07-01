/**  版本信息模板在安装目录下，可自行修改。
* case_entr.cs
*
* 功 能： N/A
* 类 名： case_entr
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
	/// 数据访问类:case_entr
	/// </summary>
	public partial class case_entr
	{
		public case_entr()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperMySQL.GetMaxID("EntrID", "case_entr"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int EntrID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from case_entr");
			strSql.Append(" where EntrID=@EntrID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@EntrID", MySqlDbType.Int32)
			};
			parameters[0].Value = EntrID;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Lawyer_DLL.Model.case_entr model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into case_entr(");
			strSql.Append("CaseContractNumber,EntrFullName,EntrFullPhone,EntrFullPost,EntrFullAddress,EntrCommName,EntrCommPhone,EntrCommPost,EntrCommAddress,EntrGuarName,EntrGuarPhone,EntrGuarPost,EntrGuarAddress,EntrOriginalHTDate,EntrAFCSendingDate,EntrASendDate,EntrRemark1,EntrRemark2,EntrRemark3)");
			strSql.Append(" values (");
			strSql.Append("@CaseContractNumber,@EntrFullName,@EntrFullPhone,@EntrFullPost,@EntrFullAddress,@EntrCommName,@EntrCommPhone,@EntrCommPost,@EntrCommAddress,@EntrGuarName,@EntrGuarPhone,@EntrGuarPost,@EntrGuarAddress,@EntrOriginalHTDate,@EntrAFCSendingDate,@EntrASendDate,@EntrRemark1,@EntrRemark2,@EntrRemark3)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@CaseContractNumber", MySqlDbType.VarChar,255),
					new MySqlParameter("@EntrFullName", MySqlDbType.VarChar,255),
					new MySqlParameter("@EntrFullPhone", MySqlDbType.VarChar,255),
					new MySqlParameter("@EntrFullPost", MySqlDbType.VarChar,255),
					new MySqlParameter("@EntrFullAddress", MySqlDbType.VarChar,255),
					new MySqlParameter("@EntrCommName", MySqlDbType.VarChar,255),
					new MySqlParameter("@EntrCommPhone", MySqlDbType.VarChar,255),
					new MySqlParameter("@EntrCommPost", MySqlDbType.VarChar,255),
					new MySqlParameter("@EntrCommAddress", MySqlDbType.VarChar,255),
					new MySqlParameter("@EntrGuarName", MySqlDbType.VarChar,255),
					new MySqlParameter("@EntrGuarPhone", MySqlDbType.VarChar,255),
					new MySqlParameter("@EntrGuarPost", MySqlDbType.VarChar,255),
					new MySqlParameter("@EntrGuarAddress", MySqlDbType.VarChar,255),
					new MySqlParameter("@EntrOriginalHTDate", MySqlDbType.DateTime),
					new MySqlParameter("@EntrAFCSendingDate", MySqlDbType.DateTime),
					new MySqlParameter("@EntrASendDate", MySqlDbType.DateTime),
					new MySqlParameter("@EntrRemark1", MySqlDbType.VarChar,255),
					new MySqlParameter("@EntrRemark2", MySqlDbType.VarChar,255),
					new MySqlParameter("@EntrRemark3", MySqlDbType.VarChar,255)};
			parameters[0].Value = model.CaseContractNumber;
			parameters[1].Value = model.EntrFullName;
			parameters[2].Value = model.EntrFullPhone;
			parameters[3].Value = model.EntrFullPost;
			parameters[4].Value = model.EntrFullAddress;
			parameters[5].Value = model.EntrCommName;
			parameters[6].Value = model.EntrCommPhone;
			parameters[7].Value = model.EntrCommPost;
			parameters[8].Value = model.EntrCommAddress;
			parameters[9].Value = model.EntrGuarName;
			parameters[10].Value = model.EntrGuarPhone;
			parameters[11].Value = model.EntrGuarPost;
			parameters[12].Value = model.EntrGuarAddress;
			parameters[13].Value = model.EntrOriginalHTDate;
			parameters[14].Value = model.EntrAFCSendingDate;
			parameters[15].Value = model.EntrASendDate;
			parameters[16].Value = model.EntrRemark1;
			parameters[17].Value = model.EntrRemark2;
			parameters[18].Value = model.EntrRemark3;

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
		public bool Update(Lawyer_DLL.Model.case_entr model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update case_entr set ");
			strSql.Append("CaseContractNumber=@CaseContractNumber,");
			strSql.Append("EntrFullName=@EntrFullName,");
			strSql.Append("EntrFullPhone=@EntrFullPhone,");
			strSql.Append("EntrFullPost=@EntrFullPost,");
			strSql.Append("EntrFullAddress=@EntrFullAddress,");
			strSql.Append("EntrCommName=@EntrCommName,");
			strSql.Append("EntrCommPhone=@EntrCommPhone,");
			strSql.Append("EntrCommPost=@EntrCommPost,");
			strSql.Append("EntrCommAddress=@EntrCommAddress,");
			strSql.Append("EntrGuarName=@EntrGuarName,");
			strSql.Append("EntrGuarPhone=@EntrGuarPhone,");
			strSql.Append("EntrGuarPost=@EntrGuarPost,");
			strSql.Append("EntrGuarAddress=@EntrGuarAddress,");
			strSql.Append("EntrOriginalHTDate=@EntrOriginalHTDate,");
			strSql.Append("EntrAFCSendingDate=@EntrAFCSendingDate,");
			strSql.Append("EntrASendDate=@EntrASendDate,");
			strSql.Append("EntrRemark1=@EntrRemark1,");
			strSql.Append("EntrRemark2=@EntrRemark2,");
			strSql.Append("EntrRemark3=@EntrRemark3");
			strSql.Append(" where EntrID=@EntrID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@CaseContractNumber", MySqlDbType.VarChar,255),
					new MySqlParameter("@EntrFullName", MySqlDbType.VarChar,255),
					new MySqlParameter("@EntrFullPhone", MySqlDbType.VarChar,255),
					new MySqlParameter("@EntrFullPost", MySqlDbType.VarChar,255),
					new MySqlParameter("@EntrFullAddress", MySqlDbType.VarChar,255),
					new MySqlParameter("@EntrCommName", MySqlDbType.VarChar,255),
					new MySqlParameter("@EntrCommPhone", MySqlDbType.VarChar,255),
					new MySqlParameter("@EntrCommPost", MySqlDbType.VarChar,255),
					new MySqlParameter("@EntrCommAddress", MySqlDbType.VarChar,255),
					new MySqlParameter("@EntrGuarName", MySqlDbType.VarChar,255),
					new MySqlParameter("@EntrGuarPhone", MySqlDbType.VarChar,255),
					new MySqlParameter("@EntrGuarPost", MySqlDbType.VarChar,255),
					new MySqlParameter("@EntrGuarAddress", MySqlDbType.VarChar,255),
					new MySqlParameter("@EntrOriginalHTDate", MySqlDbType.DateTime),
					new MySqlParameter("@EntrAFCSendingDate", MySqlDbType.DateTime),
					new MySqlParameter("@EntrASendDate", MySqlDbType.DateTime),
					new MySqlParameter("@EntrRemark1", MySqlDbType.VarChar,255),
					new MySqlParameter("@EntrRemark2", MySqlDbType.VarChar,255),
					new MySqlParameter("@EntrRemark3", MySqlDbType.VarChar,255),
					new MySqlParameter("@EntrID", MySqlDbType.Int32,10)};
			parameters[0].Value = model.CaseContractNumber;
			parameters[1].Value = model.EntrFullName;
			parameters[2].Value = model.EntrFullPhone;
			parameters[3].Value = model.EntrFullPost;
			parameters[4].Value = model.EntrFullAddress;
			parameters[5].Value = model.EntrCommName;
			parameters[6].Value = model.EntrCommPhone;
			parameters[7].Value = model.EntrCommPost;
			parameters[8].Value = model.EntrCommAddress;
			parameters[9].Value = model.EntrGuarName;
			parameters[10].Value = model.EntrGuarPhone;
			parameters[11].Value = model.EntrGuarPost;
			parameters[12].Value = model.EntrGuarAddress;
			parameters[13].Value = model.EntrOriginalHTDate;
			parameters[14].Value = model.EntrAFCSendingDate;
			parameters[15].Value = model.EntrASendDate;
			parameters[16].Value = model.EntrRemark1;
			parameters[17].Value = model.EntrRemark2;
			parameters[18].Value = model.EntrRemark3;
			parameters[19].Value = model.EntrID;

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
		public bool Delete(int EntrID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from case_entr ");
			strSql.Append(" where EntrID=@EntrID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@EntrID", MySqlDbType.Int32)
			};
			parameters[0].Value = EntrID;

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
		public bool DeleteList(string EntrIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from case_entr ");
			strSql.Append(" where EntrID in ("+EntrIDlist + ")  ");
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
		public Lawyer_DLL.Model.case_entr GetModel(int EntrID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select EntrID,CaseContractNumber,EntrFullName,EntrFullPhone,EntrFullPost,EntrFullAddress,EntrCommName,EntrCommPhone,EntrCommPost,EntrCommAddress,EntrGuarName,EntrGuarPhone,EntrGuarPost,EntrGuarAddress,EntrOriginalHTDate,EntrAFCSendingDate,EntrASendDate,EntrRemark1,EntrRemark2,EntrRemark3 from case_entr ");
			strSql.Append(" where EntrID=@EntrID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@EntrID", MySqlDbType.Int32)
			};
			parameters[0].Value = EntrID;

			Lawyer_DLL.Model.case_entr model=new Lawyer_DLL.Model.case_entr();
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
		public Lawyer_DLL.Model.case_entr DataRowToModel(DataRow row)
		{
			Lawyer_DLL.Model.case_entr model=new Lawyer_DLL.Model.case_entr();
			if (row != null)
			{
				if(row["EntrID"]!=null && row["EntrID"].ToString()!="")
				{
					model.EntrID=int.Parse(row["EntrID"].ToString());
				}
				if(row["CaseContractNumber"]!=null)
				{
					model.CaseContractNumber=row["CaseContractNumber"].ToString();
				}
				if(row["EntrFullName"]!=null)
				{
					model.EntrFullName=row["EntrFullName"].ToString();
				}
				if(row["EntrFullPhone"]!=null)
				{
					model.EntrFullPhone=row["EntrFullPhone"].ToString();
				}
				if(row["EntrFullPost"]!=null)
				{
					model.EntrFullPost=row["EntrFullPost"].ToString();
				}
				if(row["EntrFullAddress"]!=null)
				{
					model.EntrFullAddress=row["EntrFullAddress"].ToString();
				}
				if(row["EntrCommName"]!=null)
				{
					model.EntrCommName=row["EntrCommName"].ToString();
				}
				if(row["EntrCommPhone"]!=null)
				{
					model.EntrCommPhone=row["EntrCommPhone"].ToString();
				}
				if(row["EntrCommPost"]!=null)
				{
					model.EntrCommPost=row["EntrCommPost"].ToString();
				}
				if(row["EntrCommAddress"]!=null)
				{
					model.EntrCommAddress=row["EntrCommAddress"].ToString();
				}
				if(row["EntrGuarName"]!=null)
				{
					model.EntrGuarName=row["EntrGuarName"].ToString();
				}
				if(row["EntrGuarPhone"]!=null)
				{
					model.EntrGuarPhone=row["EntrGuarPhone"].ToString();
				}
				if(row["EntrGuarPost"]!=null)
				{
					model.EntrGuarPost=row["EntrGuarPost"].ToString();
				}
				if(row["EntrGuarAddress"]!=null)
				{
					model.EntrGuarAddress=row["EntrGuarAddress"].ToString();
				}
				if(row["EntrOriginalHTDate"]!=null && row["EntrOriginalHTDate"].ToString()!="")
				{
					model.EntrOriginalHTDate=DateTime.Parse(row["EntrOriginalHTDate"].ToString());
				}
				if(row["EntrAFCSendingDate"]!=null && row["EntrAFCSendingDate"].ToString()!="")
				{
					model.EntrAFCSendingDate=DateTime.Parse(row["EntrAFCSendingDate"].ToString());
				}
				if(row["EntrASendDate"]!=null && row["EntrASendDate"].ToString()!="")
				{
					model.EntrASendDate=DateTime.Parse(row["EntrASendDate"].ToString());
				}
				if(row["EntrRemark1"]!=null)
				{
					model.EntrRemark1=row["EntrRemark1"].ToString();
				}
				if(row["EntrRemark2"]!=null)
				{
					model.EntrRemark2=row["EntrRemark2"].ToString();
				}
				if(row["EntrRemark3"]!=null)
				{
					model.EntrRemark3=row["EntrRemark3"].ToString();
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
			strSql.Append("select EntrID,CaseContractNumber,EntrFullName,EntrFullPhone,EntrFullPost,EntrFullAddress,EntrCommName,EntrCommPhone,EntrCommPost,EntrCommAddress,EntrGuarName,EntrGuarPhone,EntrGuarPost,EntrGuarAddress,EntrOriginalHTDate,EntrAFCSendingDate,EntrASendDate,EntrRemark1,EntrRemark2,EntrRemark3 ");
			strSql.Append(" FROM case_entr ");
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
			strSql.Append("select count(1) FROM case_entr ");
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
				strSql.Append("order by T.EntrID desc");
			}
			strSql.Append(")AS Row, T.*  from case_entr T ");
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
			parameters[0].Value = "case_entr";
			parameters[1].Value = "EntrID";
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

