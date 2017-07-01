/**  版本信息模板在安装目录下，可自行修改。
* case_doc.cs
*
* 功 能： N/A
* 类 名： case_doc
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
	/// case_doc:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class case_doc
	{
		public case_doc()
		{}
		#region Model
		private int _docid;
		private int _caseid;
		private string _docnameofdocu;
		private string _docclerdocu;
		private string _docremark1;
		private string _docremark2;
		private string _docremark3;
		/// <summary>
		/// auto_increment
		/// </summary>
		public int DocID
		{
			set{ _docid=value;}
			get{return _docid;}
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
		public string DocNameOFDocu
		{
			set{ _docnameofdocu=value;}
			get{return _docnameofdocu;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DocClerDocu
		{
			set{ _docclerdocu=value;}
			get{return _docclerdocu;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DocRemark1
		{
			set{ _docremark1=value;}
			get{return _docremark1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DocRemark2
		{
			set{ _docremark2=value;}
			get{return _docremark2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DocRemark3
		{
			set{ _docremark3=value;}
			get{return _docremark3;}
		}
		#endregion Model

	}
}

