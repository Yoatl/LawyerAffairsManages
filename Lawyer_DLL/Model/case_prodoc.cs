/**  版本信息模板在安装目录下，可自行修改。
* case_prodoc.cs
*
* 功 能： N/A
* 类 名： case_prodoc
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
	/// case_prodoc:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class case_prodoc
	{
		public case_prodoc()
		{}
		#region Model
		private int _prodocid;
		private int _proid;
		private string _prodocfilepath;
		private string _prodocremark1;
		private string _prodocremark2;
		private string _prodocremark3;
		/// <summary>
		/// auto_increment
		/// </summary>
		public int ProDocID
		{
			set{ _prodocid=value;}
			get{return _prodocid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int ProID
		{
			set{ _proid=value;}
			get{return _proid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ProDocFilePath
		{
			set{ _prodocfilepath=value;}
			get{return _prodocfilepath;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ProDocRemark1
		{
			set{ _prodocremark1=value;}
			get{return _prodocremark1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ProDocRemark2
		{
			set{ _prodocremark2=value;}
			get{return _prodocremark2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ProDocRemark3
		{
			set{ _prodocremark3=value;}
			get{return _prodocremark3;}
		}
		#endregion Model

	}
}

