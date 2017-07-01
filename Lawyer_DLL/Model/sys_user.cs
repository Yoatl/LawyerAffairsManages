/**  版本信息模板在安装目录下，可自行修改。
* sys_user.cs
*
* 功 能： N/A
* 类 名： sys_user
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
	/// sys_user:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class sys_user
	{
		public sys_user()
		{}
		#region Model
		private int _userid;
		private string _useraccount;
		private string _userpassword;
		private string _userfullname;
		private string _usertelephone;
		private string _useraddress;
		private DateTime? _userinductiontime;
		private string _usereffectiveness;
		private string _userclass;
		private string _userremark1;
		private string _userremark2;
		private string _userremark3;
		/// <summary>
		/// auto_increment
		/// </summary>
		public int UserID
		{
			set{ _userid=value;}
			get{return _userid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UserAccount
		{
			set{ _useraccount=value;}
			get{return _useraccount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UserPassword
		{
			set{ _userpassword=value;}
			get{return _userpassword;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UserFullName
		{
			set{ _userfullname=value;}
			get{return _userfullname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UserTelephone
		{
			set{ _usertelephone=value;}
			get{return _usertelephone;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UserAddress
		{
			set{ _useraddress=value;}
			get{return _useraddress;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? UserInductionTime
		{
			set{ _userinductiontime=value;}
			get{return _userinductiontime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UserEffectiveness
		{
			set{ _usereffectiveness=value;}
			get{return _usereffectiveness;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UserClass
		{
			set{ _userclass=value;}
			get{return _userclass;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UserRemark1
		{
			set{ _userremark1=value;}
			get{return _userremark1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UserRemark2
		{
			set{ _userremark2=value;}
			get{return _userremark2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UserRemark3
		{
			set{ _userremark3=value;}
			get{return _userremark3;}
		}
		#endregion Model

	}
}

