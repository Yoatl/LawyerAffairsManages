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
namespace Lawyer_DLL.Model
{
	/// <summary>
	/// case_pro:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class case_pro
	{
		public case_pro()
		{}
		#region Model
		private int _proid;
		private int _caseid;
		private string _proprogcat;
		private string _proprogname;
		private string _proprogressnotes;
		private string _promail;
		private int? _promailingnumber;
		private string _promailstatus;
		private string _prowhetherfile;
		private string _proeffectiveness;
		private string _proremark1;
		private string _proremark2;
		private string _proremark3;
		/// <summary>
		/// auto_increment
		/// </summary>
		public int ProID
		{
			set{ _proid=value;}
			get{return _proid;}
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
		public string ProProgCat
		{
			set{ _proprogcat=value;}
			get{return _proprogcat;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ProProgName
		{
			set{ _proprogname=value;}
			get{return _proprogname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ProProgressNotes
		{
			set{ _proprogressnotes=value;}
			get{return _proprogressnotes;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ProMail
		{
			set{ _promail=value;}
			get{return _promail;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ProMailingNumber
		{
			set{ _promailingnumber=value;}
			get{return _promailingnumber;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ProMailStatus
		{
			set{ _promailstatus=value;}
			get{return _promailstatus;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ProWhetherFile
		{
			set{ _prowhetherfile=value;}
			get{return _prowhetherfile;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ProEffectiveness
		{
			set{ _proeffectiveness=value;}
			get{return _proeffectiveness;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ProRemark1
		{
			set{ _proremark1=value;}
			get{return _proremark1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ProRemark2
		{
			set{ _proremark2=value;}
			get{return _proremark2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ProRemark3
		{
			set{ _proremark3=value;}
			get{return _proremark3;}
		}
		#endregion Model

	}
}

