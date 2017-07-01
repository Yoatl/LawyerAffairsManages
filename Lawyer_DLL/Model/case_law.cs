/**  版本信息模板在安装目录下，可自行修改。
* case_law.cs
*
* 功 能： N/A
* 类 名： case_law
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
	/// case_law:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class case_law
	{
		public case_law()
		{}
		#region Model
		private int _lawid;
		private int _caseid;
		private int _userid;
		private string _lawremark1;
		private string _lawremark2;
		private string _lawremark3;
		/// <summary>
		/// auto_increment
		/// </summary>
		public int LawID
		{
			set{ _lawid=value;}
			get{return _lawid;}
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
		public int UserID
		{
			set{ _userid=value;}
			get{return _userid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LawRemark1
		{
			set{ _lawremark1=value;}
			get{return _lawremark1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LawRemark2
		{
			set{ _lawremark2=value;}
			get{return _lawremark2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LawRemark3
		{
			set{ _lawremark3=value;}
			get{return _lawremark3;}
		}
		#endregion Model

	}
}

