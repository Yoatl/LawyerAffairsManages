/**  版本信息模板在安装目录下，可自行修改。
* sys_role.cs
*
* 功 能： N/A
* 类 名： sys_role
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
	/// sys_role:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class sys_role
	{
		public sys_role()
		{}
		#region Model
		private int _roleid;
		private string _rolename;
		private string _rolejurisdiction;
		private string _roleeffectiveness;
		private string _roleremark1;
		private string _roleremark2;
		private string _roleremark3;
		/// <summary>
		/// auto_increment
		/// </summary>
		public int RoleID
		{
			set{ _roleid=value;}
			get{return _roleid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RoleName
		{
			set{ _rolename=value;}
			get{return _rolename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RoleJurisdiction
		{
			set{ _rolejurisdiction=value;}
			get{return _rolejurisdiction;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RoleEffectiveness
		{
			set{ _roleeffectiveness=value;}
			get{return _roleeffectiveness;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RoleRemark1
		{
			set{ _roleremark1=value;}
			get{return _roleremark1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RoleRemark2
		{
			set{ _roleremark2=value;}
			get{return _roleremark2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RoleRemark3
		{
			set{ _roleremark3=value;}
			get{return _roleremark3;}
		}
		#endregion Model

	}
}

