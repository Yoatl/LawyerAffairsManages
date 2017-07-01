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
namespace Lawyer_DLL.Model
{
	/// <summary>
	/// case_per:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class case_per
	{
		public case_per()
		{}
		#region Model
		private int _perid;
		private int _caseid;
		private string _perperscat;
		private string _perfullname;
		private string _pergender;
		private int? _peridnumber;
		private string _peraddress;
		private string _pertelephone;
		private string _perremark1;
		private string _perremark2;
		private string _perremark3;
		/// <summary>
		/// auto_increment
		/// </summary>
		public int PerID
		{
			set{ _perid=value;}
			get{return _perid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int CaseID
		{
			set{ _caseid=value;}
			get{return _caseid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PerPersCat
		{
			set{ _perperscat=value;}
			get{return _perperscat;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PerFullName
		{
			set{ _perfullname=value;}
			get{return _perfullname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PerGender
		{
			set{ _pergender=value;}
			get{return _pergender;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? PerIDNumber
		{
			set{ _peridnumber=value;}
			get{return _peridnumber;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PerAddress
		{
			set{ _peraddress=value;}
			get{return _peraddress;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PerTelephone
		{
			set{ _pertelephone=value;}
			get{return _pertelephone;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PerRemark1
		{
			set{ _perremark1=value;}
			get{return _perremark1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PerRemark2
		{
			set{ _perremark2=value;}
			get{return _perremark2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PerRemark3
		{
			set{ _perremark3=value;}
			get{return _perremark3;}
		}
		#endregion Model

	}
}

