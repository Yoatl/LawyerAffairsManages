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
namespace Lawyer_DLL.Model
{
	/// <summary>
	/// case_caseinfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class case_caseinfo
	{
		public case_caseinfo()
		{}
		#region Model
		private int _caseid;
		private int? _entrid;
		private string _casecontractnumber;
		private string _casenumber;
		private string _casedaofqu;
		private string _caseconda;
		private string _casemorda;
		private string _caseoutsdinpri;
		private string _caseoutstin;
		private string _casepenalty;
		private string _caseliqdam;
		private string _caseliticos;
		private string _caselawyerfee;
		private string _casetotal;
		private string _caseremarks;
		private string _casestartup;
		private string _casedealercity;
		private string _casedealername;
		private string _caseconstda;
		private string _caseendofconda;
		private string _casetotper;
		private string _casecomiorepper;
		private string _casecondopay;
		private string _casecontperiod;
		private string _casecontractloanamount;
		private string _caseloanamorat;
		private string _caseloaamorat;
		private string _caseintpen;
		private string _casepri0fthcon;
		private string _caseconinsamo;
		private string _caserecon;
		private string _caseassbra;
		private string _caseassetty;
		private int? _caseassfranum;
		private int? _caselicenplanum;
		private string _caseregicit;
		private string _casemorreg;
		private DateTime? _caselatrepdate;
		private string _casefinalrepamo;
		private string _casepaymet;
		private string _casedrawee;
		private string _caseveliornot;
		private string _caseeffeene;
		private string _caseremark1;
		private string _caseremark2;
		private string _caseremark3;
		/// <summary>
		/// auto_increment
		/// </summary>
		public int CaseID
		{
			set{ _caseid=value;}
			get{return _caseid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? EntrID
		{
			set{ _entrid=value;}
			get{return _entrid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CaseContractNumber
		{
			set{ _casecontractnumber=value;}
			get{return _casecontractnumber;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CaseNumber
		{
			set{ _casenumber=value;}
			get{return _casenumber;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CaseDaOfQu
		{
			set{ _casedaofqu=value;}
			get{return _casedaofqu;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CaseConDa
		{
			set{ _caseconda=value;}
			get{return _caseconda;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CaseMorDa
		{
			set{ _casemorda=value;}
			get{return _casemorda;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CaseOutsDinPri
		{
			set{ _caseoutsdinpri=value;}
			get{return _caseoutsdinpri;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CaseOutstIn
		{
			set{ _caseoutstin=value;}
			get{return _caseoutstin;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CasePenalty
		{
			set{ _casepenalty=value;}
			get{return _casepenalty;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CaseLiqDam
		{
			set{ _caseliqdam=value;}
			get{return _caseliqdam;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CaseLitiCos
		{
			set{ _caseliticos=value;}
			get{return _caseliticos;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CaseLawyerFee
		{
			set{ _caselawyerfee=value;}
			get{return _caselawyerfee;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CaseTotal
		{
			set{ _casetotal=value;}
			get{return _casetotal;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CaseRemarks
		{
			set{ _caseremarks=value;}
			get{return _caseremarks;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Casestartup
		{
			set{ _casestartup=value;}
			get{return _casestartup;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CaseDealerCity
		{
			set{ _casedealercity=value;}
			get{return _casedealercity;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CaseDealerName
		{
			set{ _casedealername=value;}
			get{return _casedealername;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CaseConStDa
		{
			set{ _caseconstda=value;}
			get{return _caseconstda;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CaseEndOfConDa
		{
			set{ _caseendofconda=value;}
			get{return _caseendofconda;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CaseTotPer
		{
			set{ _casetotper=value;}
			get{return _casetotper;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CaseComioRepPer
		{
			set{ _casecomiorepper=value;}
			get{return _casecomiorepper;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CaseConDoPay
		{
			set{ _casecondopay=value;}
			get{return _casecondopay;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CaseContPeriod
		{
			set{ _casecontperiod=value;}
			get{return _casecontperiod;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CaseContractLoanAmount
		{
			set{ _casecontractloanamount=value;}
			get{return _casecontractloanamount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CaseLoanAmoRat
		{
			set{ _caseloanamorat=value;}
			get{return _caseloanamorat;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CaseLoaAmoRat
		{
			set{ _caseloaamorat=value;}
			get{return _caseloaamorat;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CaseIntPen
		{
			set{ _caseintpen=value;}
			get{return _caseintpen;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CasePri0fThCon
		{
			set{ _casepri0fthcon=value;}
			get{return _casepri0fthcon;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CaseConInsAmo
		{
			set{ _caseconinsamo=value;}
			get{return _caseconinsamo;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CaseReCon
		{
			set{ _caserecon=value;}
			get{return _caserecon;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CaseAssBra
		{
			set{ _caseassbra=value;}
			get{return _caseassbra;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CaseAssetTy
		{
			set{ _caseassetty=value;}
			get{return _caseassetty;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? CaseAssFraNum
		{
			set{ _caseassfranum=value;}
			get{return _caseassfranum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? CaseLicenPlaNum
		{
			set{ _caselicenplanum=value;}
			get{return _caselicenplanum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CaseRegiCit
		{
			set{ _caseregicit=value;}
			get{return _caseregicit;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CaseMorReg
		{
			set{ _casemorreg=value;}
			get{return _casemorreg;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? CaseLatRepDate
		{
			set{ _caselatrepdate=value;}
			get{return _caselatrepdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CaseFinalRepAmo
		{
			set{ _casefinalrepamo=value;}
			get{return _casefinalrepamo;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CasePayMet
		{
			set{ _casepaymet=value;}
			get{return _casepaymet;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CaseDrawee
		{
			set{ _casedrawee=value;}
			get{return _casedrawee;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CaseVeLiOrNot
		{
			set{ _caseveliornot=value;}
			get{return _caseveliornot;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CaseEffeEne
		{
			set{ _caseeffeene=value;}
			get{return _caseeffeene;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CaseRemark1
		{
			set{ _caseremark1=value;}
			get{return _caseremark1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CaseRemark2
		{
			set{ _caseremark2=value;}
			get{return _caseremark2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CaseRemark3
		{
			set{ _caseremark3=value;}
			get{return _caseremark3;}
		}
		#endregion Model

	}
}

