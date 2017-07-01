/**  版本信息模板在安装目录下，可自行修改。
* sys_temp.cs
*
* 功 能： N/A
* 类 名： sys_temp
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/7/1 11:35:12   N/A    初版
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
	/// sys_temp:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class sys_temp
	{
		public sys_temp()
		{}
		#region Model
		private int _tempid;
		private string _tempclass;
		private string _tempname;
		private string _tempfile;
		private string _tempeffectiveness;
		private string _tempremark1;
		private string _tempremark2;
		private string _tempremark3;
		/// <summary>
		/// auto_increment
		/// </summary>
		public int TempID
		{
			set{ _tempid=value;}
			get{return _tempid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TempClass
		{
			set{ _tempclass=value;}
			get{return _tempclass;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TempName
		{
			set{ _tempname=value;}
			get{return _tempname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TempFile
		{
			set{ _tempfile=value;}
			get{return _tempfile;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TempEffectiveness
		{
			set{ _tempeffectiveness=value;}
			get{return _tempeffectiveness;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TempRemark1
		{
			set{ _tempremark1=value;}
			get{return _tempremark1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TempRemark2
		{
			set{ _tempremark2=value;}
			get{return _tempremark2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TempRemark3
		{
			set{ _tempremark3=value;}
			get{return _tempremark3;}
		}
		#endregion Model

	}
}

