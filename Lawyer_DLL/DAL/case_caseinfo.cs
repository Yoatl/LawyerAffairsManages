/**  版本信息模板在安装目录下，可自行修改。
* case_caseinfo.cs
*
* 功 能： N/A
* 类 名： case_caseinfo
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/7/1 11:35:09   N/A    初版
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
	/// 数据访问类:case_caseinfo
	/// </summary>
	public partial class case_caseinfo
	{
		public case_caseinfo()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperMySQL.GetMaxID("CaseID", "case_caseinfo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int CaseID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from case_caseinfo");
			strSql.Append(" where CaseID=@CaseID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@CaseID", MySqlDbType.Int32)
			};
			parameters[0].Value = CaseID;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Lawyer_DLL.Model.case_caseinfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into case_caseinfo(");
			strSql.Append("EntrID,CaseContractNumber,CaseNumber,CaseDaOfQu,CaseConDa,CaseMorDa,CaseOutsDinPri,CaseOutstIn,CasePenalty,CaseLiqDam,CaseLitiCos,CaseLawyerFee,CaseTotal,CaseRemarks,Casestartup,CaseDealerCity,CaseDealerName,CaseConStDa,CaseEndOfConDa,CaseTotPer,CaseComioRepPer,CaseConDoPay,CaseContPeriod,CaseContractLoanAmount,CaseLoanAmoRat,CaseLoaAmoRat,CaseIntPen,CasePri0fThCon,CaseConInsAmo,CaseReCon,CaseAssBra,CaseAssetTy,CaseAssFraNum,CaseLicenPlaNum,CaseRegiCit,CaseMorReg,CaseLatRepDate,CaseFinalRepAmo,CasePayMet,CaseDrawee,CaseVeLiOrNot,CaseEffeEne,CaseRemark1,CaseRemark2,CaseRemark3)");
			strSql.Append(" values (");
			strSql.Append("@EntrID,@CaseContractNumber,@CaseNumber,@CaseDaOfQu,@CaseConDa,@CaseMorDa,@CaseOutsDinPri,@CaseOutstIn,@CasePenalty,@CaseLiqDam,@CaseLitiCos,@CaseLawyerFee,@CaseTotal,@CaseRemarks,@Casestartup,@CaseDealerCity,@CaseDealerName,@CaseConStDa,@CaseEndOfConDa,@CaseTotPer,@CaseComioRepPer,@CaseConDoPay,@CaseContPeriod,@CaseContractLoanAmount,@CaseLoanAmoRat,@CaseLoaAmoRat,@CaseIntPen,@CasePri0fThCon,@CaseConInsAmo,@CaseReCon,@CaseAssBra,@CaseAssetTy,@CaseAssFraNum,@CaseLicenPlaNum,@CaseRegiCit,@CaseMorReg,@CaseLatRepDate,@CaseFinalRepAmo,@CasePayMet,@CaseDrawee,@CaseVeLiOrNot,@CaseEffeEne,@CaseRemark1,@CaseRemark2,@CaseRemark3)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@EntrID", MySqlDbType.Int32,11),
					new MySqlParameter("@CaseContractNumber", MySqlDbType.VarChar,255),
					new MySqlParameter("@CaseNumber", MySqlDbType.VarChar,255),
					new MySqlParameter("@CaseDaOfQu", MySqlDbType.VarChar,255),
					new MySqlParameter("@CaseConDa", MySqlDbType.VarChar,255),
					new MySqlParameter("@CaseMorDa", MySqlDbType.VarChar,255),
					new MySqlParameter("@CaseOutsDinPri", MySqlDbType.VarChar,255),
					new MySqlParameter("@CaseOutstIn", MySqlDbType.VarChar,255),
					new MySqlParameter("@CasePenalty", MySqlDbType.VarChar,255),
					new MySqlParameter("@CaseLiqDam", MySqlDbType.VarChar,255),
					new MySqlParameter("@CaseLitiCos", MySqlDbType.VarChar,255),
					new MySqlParameter("@CaseLawyerFee", MySqlDbType.VarChar,255),
					new MySqlParameter("@CaseTotal", MySqlDbType.VarChar,255),
					new MySqlParameter("@CaseRemarks", MySqlDbType.VarChar,255),
					new MySqlParameter("@Casestartup", MySqlDbType.VarChar,255),
					new MySqlParameter("@CaseDealerCity", MySqlDbType.VarChar,255),
					new MySqlParameter("@CaseDealerName", MySqlDbType.VarChar,255),
					new MySqlParameter("@CaseConStDa", MySqlDbType.VarChar,255),
					new MySqlParameter("@CaseEndOfConDa", MySqlDbType.VarChar,255),
					new MySqlParameter("@CaseTotPer", MySqlDbType.VarChar,255),
					new MySqlParameter("@CaseComioRepPer", MySqlDbType.VarChar,255),
					new MySqlParameter("@CaseConDoPay", MySqlDbType.VarChar,255),
					new MySqlParameter("@CaseContPeriod", MySqlDbType.VarChar,255),
					new MySqlParameter("@CaseContractLoanAmount", MySqlDbType.VarChar,255),
					new MySqlParameter("@CaseLoanAmoRat", MySqlDbType.VarChar,255),
					new MySqlParameter("@CaseLoaAmoRat", MySqlDbType.VarChar,255),
					new MySqlParameter("@CaseIntPen", MySqlDbType.VarChar,255),
					new MySqlParameter("@CasePri0fThCon", MySqlDbType.VarChar,255),
					new MySqlParameter("@CaseConInsAmo", MySqlDbType.VarChar,255),
					new MySqlParameter("@CaseReCon", MySqlDbType.VarChar,255),
					new MySqlParameter("@CaseAssBra", MySqlDbType.VarChar,255),
					new MySqlParameter("@CaseAssetTy", MySqlDbType.VarChar,255),
					new MySqlParameter("@CaseAssFraNum", MySqlDbType.Int32,11),
					new MySqlParameter("@CaseLicenPlaNum", MySqlDbType.Int32,11),
					new MySqlParameter("@CaseRegiCit", MySqlDbType.VarChar,255),
					new MySqlParameter("@CaseMorReg", MySqlDbType.VarChar,255),
					new MySqlParameter("@CaseLatRepDate", MySqlDbType.DateTime),
					new MySqlParameter("@CaseFinalRepAmo", MySqlDbType.VarChar,255),
					new MySqlParameter("@CasePayMet", MySqlDbType.VarChar,255),
					new MySqlParameter("@CaseDrawee", MySqlDbType.VarChar,255),
					new MySqlParameter("@CaseVeLiOrNot", MySqlDbType.VarChar,255),
					new MySqlParameter("@CaseEffeEne", MySqlDbType.VarChar,255),
					new MySqlParameter("@CaseRemark1", MySqlDbType.VarChar,255),
					new MySqlParameter("@CaseRemark2", MySqlDbType.VarChar,255),
					new MySqlParameter("@CaseRemark3", MySqlDbType.VarChar,255)};
			parameters[0].Value = model.EntrID;
			parameters[1].Value = model.CaseContractNumber;
			parameters[2].Value = model.CaseNumber;
			parameters[3].Value = model.CaseDaOfQu;
			parameters[4].Value = model.CaseConDa;
			parameters[5].Value = model.CaseMorDa;
			parameters[6].Value = model.CaseOutsDinPri;
			parameters[7].Value = model.CaseOutstIn;
			parameters[8].Value = model.CasePenalty;
			parameters[9].Value = model.CaseLiqDam;
			parameters[10].Value = model.CaseLitiCos;
			parameters[11].Value = model.CaseLawyerFee;
			parameters[12].Value = model.CaseTotal;
			parameters[13].Value = model.CaseRemarks;
			parameters[14].Value = model.Casestartup;
			parameters[15].Value = model.CaseDealerCity;
			parameters[16].Value = model.CaseDealerName;
			parameters[17].Value = model.CaseConStDa;
			parameters[18].Value = model.CaseEndOfConDa;
			parameters[19].Value = model.CaseTotPer;
			parameters[20].Value = model.CaseComioRepPer;
			parameters[21].Value = model.CaseConDoPay;
			parameters[22].Value = model.CaseContPeriod;
			parameters[23].Value = model.CaseContractLoanAmount;
			parameters[24].Value = model.CaseLoanAmoRat;
			parameters[25].Value = model.CaseLoaAmoRat;
			parameters[26].Value = model.CaseIntPen;
			parameters[27].Value = model.CasePri0fThCon;
			parameters[28].Value = model.CaseConInsAmo;
			parameters[29].Value = model.CaseReCon;
			parameters[30].Value = model.CaseAssBra;
			parameters[31].Value = model.CaseAssetTy;
			parameters[32].Value = model.CaseAssFraNum;
			parameters[33].Value = model.CaseLicenPlaNum;
			parameters[34].Value = model.CaseRegiCit;
			parameters[35].Value = model.CaseMorReg;
			parameters[36].Value = model.CaseLatRepDate;
			parameters[37].Value = model.CaseFinalRepAmo;
			parameters[38].Value = model.CasePayMet;
			parameters[39].Value = model.CaseDrawee;
			parameters[40].Value = model.CaseVeLiOrNot;
			parameters[41].Value = model.CaseEffeEne;
			parameters[42].Value = model.CaseRemark1;
			parameters[43].Value = model.CaseRemark2;
			parameters[44].Value = model.CaseRemark3;

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
		public bool Update(Lawyer_DLL.Model.case_caseinfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update case_caseinfo set ");
			strSql.Append("EntrID=@EntrID,");
			strSql.Append("CaseContractNumber=@CaseContractNumber,");
			strSql.Append("CaseNumber=@CaseNumber,");
			strSql.Append("CaseDaOfQu=@CaseDaOfQu,");
			strSql.Append("CaseConDa=@CaseConDa,");
			strSql.Append("CaseMorDa=@CaseMorDa,");
			strSql.Append("CaseOutsDinPri=@CaseOutsDinPri,");
			strSql.Append("CaseOutstIn=@CaseOutstIn,");
			strSql.Append("CasePenalty=@CasePenalty,");
			strSql.Append("CaseLiqDam=@CaseLiqDam,");
			strSql.Append("CaseLitiCos=@CaseLitiCos,");
			strSql.Append("CaseLawyerFee=@CaseLawyerFee,");
			strSql.Append("CaseTotal=@CaseTotal,");
			strSql.Append("CaseRemarks=@CaseRemarks,");
			strSql.Append("Casestartup=@Casestartup,");
			strSql.Append("CaseDealerCity=@CaseDealerCity,");
			strSql.Append("CaseDealerName=@CaseDealerName,");
			strSql.Append("CaseConStDa=@CaseConStDa,");
			strSql.Append("CaseEndOfConDa=@CaseEndOfConDa,");
			strSql.Append("CaseTotPer=@CaseTotPer,");
			strSql.Append("CaseComioRepPer=@CaseComioRepPer,");
			strSql.Append("CaseConDoPay=@CaseConDoPay,");
			strSql.Append("CaseContPeriod=@CaseContPeriod,");
			strSql.Append("CaseContractLoanAmount=@CaseContractLoanAmount,");
			strSql.Append("CaseLoanAmoRat=@CaseLoanAmoRat,");
			strSql.Append("CaseLoaAmoRat=@CaseLoaAmoRat,");
			strSql.Append("CaseIntPen=@CaseIntPen,");
			strSql.Append("CasePri0fThCon=@CasePri0fThCon,");
			strSql.Append("CaseConInsAmo=@CaseConInsAmo,");
			strSql.Append("CaseReCon=@CaseReCon,");
			strSql.Append("CaseAssBra=@CaseAssBra,");
			strSql.Append("CaseAssetTy=@CaseAssetTy,");
			strSql.Append("CaseAssFraNum=@CaseAssFraNum,");
			strSql.Append("CaseLicenPlaNum=@CaseLicenPlaNum,");
			strSql.Append("CaseRegiCit=@CaseRegiCit,");
			strSql.Append("CaseMorReg=@CaseMorReg,");
			strSql.Append("CaseLatRepDate=@CaseLatRepDate,");
			strSql.Append("CaseFinalRepAmo=@CaseFinalRepAmo,");
			strSql.Append("CasePayMet=@CasePayMet,");
			strSql.Append("CaseDrawee=@CaseDrawee,");
			strSql.Append("CaseVeLiOrNot=@CaseVeLiOrNot,");
			strSql.Append("CaseEffeEne=@CaseEffeEne,");
			strSql.Append("CaseRemark1=@CaseRemark1,");
			strSql.Append("CaseRemark2=@CaseRemark2,");
			strSql.Append("CaseRemark3=@CaseRemark3");
			strSql.Append(" where CaseID=@CaseID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@EntrID", MySqlDbType.Int32,11),
					new MySqlParameter("@CaseContractNumber", MySqlDbType.VarChar,255),
					new MySqlParameter("@CaseNumber", MySqlDbType.VarChar,255),
					new MySqlParameter("@CaseDaOfQu", MySqlDbType.VarChar,255),
					new MySqlParameter("@CaseConDa", MySqlDbType.VarChar,255),
					new MySqlParameter("@CaseMorDa", MySqlDbType.VarChar,255),
					new MySqlParameter("@CaseOutsDinPri", MySqlDbType.VarChar,255),
					new MySqlParameter("@CaseOutstIn", MySqlDbType.VarChar,255),
					new MySqlParameter("@CasePenalty", MySqlDbType.VarChar,255),
					new MySqlParameter("@CaseLiqDam", MySqlDbType.VarChar,255),
					new MySqlParameter("@CaseLitiCos", MySqlDbType.VarChar,255),
					new MySqlParameter("@CaseLawyerFee", MySqlDbType.VarChar,255),
					new MySqlParameter("@CaseTotal", MySqlDbType.VarChar,255),
					new MySqlParameter("@CaseRemarks", MySqlDbType.VarChar,255),
					new MySqlParameter("@Casestartup", MySqlDbType.VarChar,255),
					new MySqlParameter("@CaseDealerCity", MySqlDbType.VarChar,255),
					new MySqlParameter("@CaseDealerName", MySqlDbType.VarChar,255),
					new MySqlParameter("@CaseConStDa", MySqlDbType.VarChar,255),
					new MySqlParameter("@CaseEndOfConDa", MySqlDbType.VarChar,255),
					new MySqlParameter("@CaseTotPer", MySqlDbType.VarChar,255),
					new MySqlParameter("@CaseComioRepPer", MySqlDbType.VarChar,255),
					new MySqlParameter("@CaseConDoPay", MySqlDbType.VarChar,255),
					new MySqlParameter("@CaseContPeriod", MySqlDbType.VarChar,255),
					new MySqlParameter("@CaseContractLoanAmount", MySqlDbType.VarChar,255),
					new MySqlParameter("@CaseLoanAmoRat", MySqlDbType.VarChar,255),
					new MySqlParameter("@CaseLoaAmoRat", MySqlDbType.VarChar,255),
					new MySqlParameter("@CaseIntPen", MySqlDbType.VarChar,255),
					new MySqlParameter("@CasePri0fThCon", MySqlDbType.VarChar,255),
					new MySqlParameter("@CaseConInsAmo", MySqlDbType.VarChar,255),
					new MySqlParameter("@CaseReCon", MySqlDbType.VarChar,255),
					new MySqlParameter("@CaseAssBra", MySqlDbType.VarChar,255),
					new MySqlParameter("@CaseAssetTy", MySqlDbType.VarChar,255),
					new MySqlParameter("@CaseAssFraNum", MySqlDbType.Int32,11),
					new MySqlParameter("@CaseLicenPlaNum", MySqlDbType.Int32,11),
					new MySqlParameter("@CaseRegiCit", MySqlDbType.VarChar,255),
					new MySqlParameter("@CaseMorReg", MySqlDbType.VarChar,255),
					new MySqlParameter("@CaseLatRepDate", MySqlDbType.DateTime),
					new MySqlParameter("@CaseFinalRepAmo", MySqlDbType.VarChar,255),
					new MySqlParameter("@CasePayMet", MySqlDbType.VarChar,255),
					new MySqlParameter("@CaseDrawee", MySqlDbType.VarChar,255),
					new MySqlParameter("@CaseVeLiOrNot", MySqlDbType.VarChar,255),
					new MySqlParameter("@CaseEffeEne", MySqlDbType.VarChar,255),
					new MySqlParameter("@CaseRemark1", MySqlDbType.VarChar,255),
					new MySqlParameter("@CaseRemark2", MySqlDbType.VarChar,255),
					new MySqlParameter("@CaseRemark3", MySqlDbType.VarChar,255),
					new MySqlParameter("@CaseID", MySqlDbType.Int32,10)};
			parameters[0].Value = model.EntrID;
			parameters[1].Value = model.CaseContractNumber;
			parameters[2].Value = model.CaseNumber;
			parameters[3].Value = model.CaseDaOfQu;
			parameters[4].Value = model.CaseConDa;
			parameters[5].Value = model.CaseMorDa;
			parameters[6].Value = model.CaseOutsDinPri;
			parameters[7].Value = model.CaseOutstIn;
			parameters[8].Value = model.CasePenalty;
			parameters[9].Value = model.CaseLiqDam;
			parameters[10].Value = model.CaseLitiCos;
			parameters[11].Value = model.CaseLawyerFee;
			parameters[12].Value = model.CaseTotal;
			parameters[13].Value = model.CaseRemarks;
			parameters[14].Value = model.Casestartup;
			parameters[15].Value = model.CaseDealerCity;
			parameters[16].Value = model.CaseDealerName;
			parameters[17].Value = model.CaseConStDa;
			parameters[18].Value = model.CaseEndOfConDa;
			parameters[19].Value = model.CaseTotPer;
			parameters[20].Value = model.CaseComioRepPer;
			parameters[21].Value = model.CaseConDoPay;
			parameters[22].Value = model.CaseContPeriod;
			parameters[23].Value = model.CaseContractLoanAmount;
			parameters[24].Value = model.CaseLoanAmoRat;
			parameters[25].Value = model.CaseLoaAmoRat;
			parameters[26].Value = model.CaseIntPen;
			parameters[27].Value = model.CasePri0fThCon;
			parameters[28].Value = model.CaseConInsAmo;
			parameters[29].Value = model.CaseReCon;
			parameters[30].Value = model.CaseAssBra;
			parameters[31].Value = model.CaseAssetTy;
			parameters[32].Value = model.CaseAssFraNum;
			parameters[33].Value = model.CaseLicenPlaNum;
			parameters[34].Value = model.CaseRegiCit;
			parameters[35].Value = model.CaseMorReg;
			parameters[36].Value = model.CaseLatRepDate;
			parameters[37].Value = model.CaseFinalRepAmo;
			parameters[38].Value = model.CasePayMet;
			parameters[39].Value = model.CaseDrawee;
			parameters[40].Value = model.CaseVeLiOrNot;
			parameters[41].Value = model.CaseEffeEne;
			parameters[42].Value = model.CaseRemark1;
			parameters[43].Value = model.CaseRemark2;
			parameters[44].Value = model.CaseRemark3;
			parameters[45].Value = model.CaseID;

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
		public bool Delete(int CaseID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from case_caseinfo ");
			strSql.Append(" where CaseID=@CaseID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@CaseID", MySqlDbType.Int32)
			};
			parameters[0].Value = CaseID;

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
		public bool DeleteList(string CaseIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from case_caseinfo ");
			strSql.Append(" where CaseID in ("+CaseIDlist + ")  ");
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
		public Lawyer_DLL.Model.case_caseinfo GetModel(int CaseID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select CaseID,EntrID,CaseContractNumber,CaseNumber,CaseDaOfQu,CaseConDa,CaseMorDa,CaseOutsDinPri,CaseOutstIn,CasePenalty,CaseLiqDam,CaseLitiCos,CaseLawyerFee,CaseTotal,CaseRemarks,Casestartup,CaseDealerCity,CaseDealerName,CaseConStDa,CaseEndOfConDa,CaseTotPer,CaseComioRepPer,CaseConDoPay,CaseContPeriod,CaseContractLoanAmount,CaseLoanAmoRat,CaseLoaAmoRat,CaseIntPen,CasePri0fThCon,CaseConInsAmo,CaseReCon,CaseAssBra,CaseAssetTy,CaseAssFraNum,CaseLicenPlaNum,CaseRegiCit,CaseMorReg,CaseLatRepDate,CaseFinalRepAmo,CasePayMet,CaseDrawee,CaseVeLiOrNot,CaseEffeEne,CaseRemark1,CaseRemark2,CaseRemark3 from case_caseinfo ");
			strSql.Append(" where CaseID=@CaseID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@CaseID", MySqlDbType.Int32)
			};
			parameters[0].Value = CaseID;

			Lawyer_DLL.Model.case_caseinfo model=new Lawyer_DLL.Model.case_caseinfo();
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
		public Lawyer_DLL.Model.case_caseinfo DataRowToModel(DataRow row)
		{
			Lawyer_DLL.Model.case_caseinfo model=new Lawyer_DLL.Model.case_caseinfo();
			if (row != null)
			{
				if(row["CaseID"]!=null && row["CaseID"].ToString()!="")
				{
					model.CaseID=int.Parse(row["CaseID"].ToString());
				}
				if(row["EntrID"]!=null && row["EntrID"].ToString()!="")
				{
					model.EntrID=int.Parse(row["EntrID"].ToString());
				}
				if(row["CaseContractNumber"]!=null)
				{
					model.CaseContractNumber=row["CaseContractNumber"].ToString();
				}
				if(row["CaseNumber"]!=null)
				{
					model.CaseNumber=row["CaseNumber"].ToString();
				}
				if(row["CaseDaOfQu"]!=null)
				{
					model.CaseDaOfQu=row["CaseDaOfQu"].ToString();
				}
				if(row["CaseConDa"]!=null)
				{
					model.CaseConDa=row["CaseConDa"].ToString();
				}
				if(row["CaseMorDa"]!=null)
				{
					model.CaseMorDa=row["CaseMorDa"].ToString();
				}
				if(row["CaseOutsDinPri"]!=null)
				{
					model.CaseOutsDinPri=row["CaseOutsDinPri"].ToString();
				}
				if(row["CaseOutstIn"]!=null)
				{
					model.CaseOutstIn=row["CaseOutstIn"].ToString();
				}
				if(row["CasePenalty"]!=null)
				{
					model.CasePenalty=row["CasePenalty"].ToString();
				}
				if(row["CaseLiqDam"]!=null)
				{
					model.CaseLiqDam=row["CaseLiqDam"].ToString();
				}
				if(row["CaseLitiCos"]!=null)
				{
					model.CaseLitiCos=row["CaseLitiCos"].ToString();
				}
				if(row["CaseLawyerFee"]!=null)
				{
					model.CaseLawyerFee=row["CaseLawyerFee"].ToString();
				}
				if(row["CaseTotal"]!=null)
				{
					model.CaseTotal=row["CaseTotal"].ToString();
				}
				if(row["CaseRemarks"]!=null)
				{
					model.CaseRemarks=row["CaseRemarks"].ToString();
				}
				if(row["Casestartup"]!=null)
				{
					model.Casestartup=row["Casestartup"].ToString();
				}
				if(row["CaseDealerCity"]!=null)
				{
					model.CaseDealerCity=row["CaseDealerCity"].ToString();
				}
				if(row["CaseDealerName"]!=null)
				{
					model.CaseDealerName=row["CaseDealerName"].ToString();
				}
				if(row["CaseConStDa"]!=null)
				{
					model.CaseConStDa=row["CaseConStDa"].ToString();
				}
				if(row["CaseEndOfConDa"]!=null)
				{
					model.CaseEndOfConDa=row["CaseEndOfConDa"].ToString();
				}
				if(row["CaseTotPer"]!=null)
				{
					model.CaseTotPer=row["CaseTotPer"].ToString();
				}
				if(row["CaseComioRepPer"]!=null)
				{
					model.CaseComioRepPer=row["CaseComioRepPer"].ToString();
				}
				if(row["CaseConDoPay"]!=null)
				{
					model.CaseConDoPay=row["CaseConDoPay"].ToString();
				}
				if(row["CaseContPeriod"]!=null)
				{
					model.CaseContPeriod=row["CaseContPeriod"].ToString();
				}
				if(row["CaseContractLoanAmount"]!=null)
				{
					model.CaseContractLoanAmount=row["CaseContractLoanAmount"].ToString();
				}
				if(row["CaseLoanAmoRat"]!=null)
				{
					model.CaseLoanAmoRat=row["CaseLoanAmoRat"].ToString();
				}
				if(row["CaseLoaAmoRat"]!=null)
				{
					model.CaseLoaAmoRat=row["CaseLoaAmoRat"].ToString();
				}
				if(row["CaseIntPen"]!=null)
				{
					model.CaseIntPen=row["CaseIntPen"].ToString();
				}
				if(row["CasePri0fThCon"]!=null)
				{
					model.CasePri0fThCon=row["CasePri0fThCon"].ToString();
				}
				if(row["CaseConInsAmo"]!=null)
				{
					model.CaseConInsAmo=row["CaseConInsAmo"].ToString();
				}
				if(row["CaseReCon"]!=null)
				{
					model.CaseReCon=row["CaseReCon"].ToString();
				}
				if(row["CaseAssBra"]!=null)
				{
					model.CaseAssBra=row["CaseAssBra"].ToString();
				}
				if(row["CaseAssetTy"]!=null)
				{
					model.CaseAssetTy=row["CaseAssetTy"].ToString();
				}
				if(row["CaseAssFraNum"]!=null && row["CaseAssFraNum"].ToString()!="")
				{
					model.CaseAssFraNum=int.Parse(row["CaseAssFraNum"].ToString());
				}
				if(row["CaseLicenPlaNum"]!=null && row["CaseLicenPlaNum"].ToString()!="")
				{
					model.CaseLicenPlaNum=int.Parse(row["CaseLicenPlaNum"].ToString());
				}
				if(row["CaseRegiCit"]!=null)
				{
					model.CaseRegiCit=row["CaseRegiCit"].ToString();
				}
				if(row["CaseMorReg"]!=null)
				{
					model.CaseMorReg=row["CaseMorReg"].ToString();
				}
				if(row["CaseLatRepDate"]!=null && row["CaseLatRepDate"].ToString()!="")
				{
					model.CaseLatRepDate=DateTime.Parse(row["CaseLatRepDate"].ToString());
				}
				if(row["CaseFinalRepAmo"]!=null)
				{
					model.CaseFinalRepAmo=row["CaseFinalRepAmo"].ToString();
				}
				if(row["CasePayMet"]!=null)
				{
					model.CasePayMet=row["CasePayMet"].ToString();
				}
				if(row["CaseDrawee"]!=null)
				{
					model.CaseDrawee=row["CaseDrawee"].ToString();
				}
				if(row["CaseVeLiOrNot"]!=null)
				{
					model.CaseVeLiOrNot=row["CaseVeLiOrNot"].ToString();
				}
				if(row["CaseEffeEne"]!=null)
				{
					model.CaseEffeEne=row["CaseEffeEne"].ToString();
				}
				if(row["CaseRemark1"]!=null)
				{
					model.CaseRemark1=row["CaseRemark1"].ToString();
				}
				if(row["CaseRemark2"]!=null)
				{
					model.CaseRemark2=row["CaseRemark2"].ToString();
				}
				if(row["CaseRemark3"]!=null)
				{
					model.CaseRemark3=row["CaseRemark3"].ToString();
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
			strSql.Append("select CaseID,EntrID,CaseContractNumber,CaseNumber,CaseDaOfQu,CaseConDa,CaseMorDa,CaseOutsDinPri,CaseOutstIn,CasePenalty,CaseLiqDam,CaseLitiCos,CaseLawyerFee,CaseTotal,CaseRemarks,Casestartup,CaseDealerCity,CaseDealerName,CaseConStDa,CaseEndOfConDa,CaseTotPer,CaseComioRepPer,CaseConDoPay,CaseContPeriod,CaseContractLoanAmount,CaseLoanAmoRat,CaseLoaAmoRat,CaseIntPen,CasePri0fThCon,CaseConInsAmo,CaseReCon,CaseAssBra,CaseAssetTy,CaseAssFraNum,CaseLicenPlaNum,CaseRegiCit,CaseMorReg,CaseLatRepDate,CaseFinalRepAmo,CasePayMet,CaseDrawee,CaseVeLiOrNot,CaseEffeEne,CaseRemark1,CaseRemark2,CaseRemark3 ");
			strSql.Append(" FROM case_caseinfo ");
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
			strSql.Append("select count(1) FROM case_caseinfo ");
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
				strSql.Append("order by T.CaseID desc");
			}
			strSql.Append(")AS Row, T.*  from case_caseinfo T ");
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
			parameters[0].Value = "case_caseinfo";
			parameters[1].Value = "CaseID";
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

