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
namespace Lawyer_DLL.Model
{
	/// <summary>
	/// case_evi:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class case_evi
	{
		public case_evi()
		{}
		#region Model
		private int _eviid;
		private int _caseid;
		private string _evinameofevide;
		private string _evievidedocu;
		private string _eviremark1;
		private string _eviremark2;
		private string _eviremark3;
		/// <summary>
		/// auto_increment
		/// </summary>
		public int EviID
		{
			set{ _eviid=value;}
			get{return _eviid;}
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
		public string EviNameOfEvide
		{
			set{ _evinameofevide=value;}
			get{return _evinameofevide;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string EviEvideDocu
		{
			set{ _evievidedocu=value;}
			get{return _evievidedocu;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string EviRemark1
		{
			set{ _eviremark1=value;}
			get{return _eviremark1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string EviRemark2
		{
			set{ _eviremark2=value;}
			get{return _eviremark2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string EviRemark3
		{
			set{ _eviremark3=value;}
			get{return _eviremark3;}
		}
		#endregion Model

	}
}

