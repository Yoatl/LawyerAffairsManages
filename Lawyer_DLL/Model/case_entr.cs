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
namespace Lawyer_DLL.Model
{
	/// <summary>
	/// case_entr:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class case_entr
	{
		public case_entr()
		{}
		#region Model
		private int _entrid;
		private string _casecontractnumber;
		private string _entrfullname;
		private string _entrfullphone;
		private string _entrfullpost;
		private string _entrfulladdress;
		private string _entrcommname;
		private string _entrcommphone;
		private string _entrcommpost;
		private string _entrcommaddress;
		private string _entrguarname;
		private string _entrguarphone;
		private string _entrguarpost;
		private string _entrguaraddress;
		private DateTime? _entroriginalhtdate;
		private DateTime? _entrafcsendingdate;
		private DateTime? _entrasenddate;
		private string _entrremark1;
		private string _entrremark2;
		private string _entrremark3;
		/// <summary>
		/// auto_increment
		/// </summary>
		public int EntrID
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
		public string EntrFullName
		{
			set{ _entrfullname=value;}
			get{return _entrfullname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string EntrFullPhone
		{
			set{ _entrfullphone=value;}
			get{return _entrfullphone;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string EntrFullPost
		{
			set{ _entrfullpost=value;}
			get{return _entrfullpost;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string EntrFullAddress
		{
			set{ _entrfulladdress=value;}
			get{return _entrfulladdress;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string EntrCommName
		{
			set{ _entrcommname=value;}
			get{return _entrcommname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string EntrCommPhone
		{
			set{ _entrcommphone=value;}
			get{return _entrcommphone;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string EntrCommPost
		{
			set{ _entrcommpost=value;}
			get{return _entrcommpost;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string EntrCommAddress
		{
			set{ _entrcommaddress=value;}
			get{return _entrcommaddress;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string EntrGuarName
		{
			set{ _entrguarname=value;}
			get{return _entrguarname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string EntrGuarPhone
		{
			set{ _entrguarphone=value;}
			get{return _entrguarphone;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string EntrGuarPost
		{
			set{ _entrguarpost=value;}
			get{return _entrguarpost;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string EntrGuarAddress
		{
			set{ _entrguaraddress=value;}
			get{return _entrguaraddress;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? EntrOriginalHTDate
		{
			set{ _entroriginalhtdate=value;}
			get{return _entroriginalhtdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? EntrAFCSendingDate
		{
			set{ _entrafcsendingdate=value;}
			get{return _entrafcsendingdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? EntrASendDate
		{
			set{ _entrasenddate=value;}
			get{return _entrasenddate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string EntrRemark1
		{
			set{ _entrremark1=value;}
			get{return _entrremark1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string EntrRemark2
		{
			set{ _entrremark2=value;}
			get{return _entrremark2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string EntrRemark3
		{
			set{ _entrremark3=value;}
			get{return _entrremark3;}
		}
		#endregion Model

	}
}

