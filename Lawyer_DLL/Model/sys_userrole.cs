/**  版本信息模板在安装目录下，可自行修改。
* sys_userrole.cs
*
* 功 能： N/A
* 类 名： sys_userrole
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
	/// sys_userrole:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class sys_userrole
	{
		public sys_userrole()
		{}
		#region Model
		private int _userroleid;
		private int _userid;
		private int _roleid;
		private string _userrolemodification;
		private string _userroleremark1;
		private string _userroleremark2;
		private string _userroleremark3;
		/// <summary>
		/// auto_increment
		/// </summary>
		public int UserRoleID
		{
			set{ _userroleid=value;}
			get{return _userroleid;}
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
		public int RoleID
		{
			set{ _roleid=value;}
			get{return _roleid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UserRoleModification
		{
			set{ _userrolemodification=value;}
			get{return _userrolemodification;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UserRoleRemark1
		{
			set{ _userroleremark1=value;}
			get{return _userroleremark1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UserRoleRemark2
		{
			set{ _userroleremark2=value;}
			get{return _userroleremark2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UserRoleRemark3
		{
			set{ _userroleremark3=value;}
			get{return _userroleremark3;}
		}
		#endregion Model

	}
}

