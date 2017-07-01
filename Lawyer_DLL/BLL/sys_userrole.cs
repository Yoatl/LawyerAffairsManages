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
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using Lawyer_DLL.Model;
namespace Lawyer_DLL.BLL
{
	/// <summary>
	/// sys_userrole
	/// </summary>
	public partial class sys_userrole
	{
		private readonly Lawyer_DLL.DAL.sys_userrole dal=new Lawyer_DLL.DAL.sys_userrole();
		public sys_userrole()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
			return dal.GetMaxId();
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int UserRoleID)
		{
			return dal.Exists(UserRoleID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Lawyer_DLL.Model.sys_userrole model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Lawyer_DLL.Model.sys_userrole model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int UserRoleID)
		{
			
			return dal.Delete(UserRoleID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string UserRoleIDlist )
		{
			return dal.DeleteList(UserRoleIDlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Lawyer_DLL.Model.sys_userrole GetModel(int UserRoleID)
		{
			
			return dal.GetModel(UserRoleID);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public Lawyer_DLL.Model.sys_userrole GetModelByCache(int UserRoleID)
		{
			
			string CacheKey = "sys_userroleModel-" + UserRoleID;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(UserRoleID);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (Lawyer_DLL.Model.sys_userrole)objModel;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Lawyer_DLL.Model.sys_userrole> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Lawyer_DLL.Model.sys_userrole> DataTableToList(DataTable dt)
		{
			List<Lawyer_DLL.Model.sys_userrole> modelList = new List<Lawyer_DLL.Model.sys_userrole>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Lawyer_DLL.Model.sys_userrole model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = dal.DataRowToModel(dt.Rows[n]);
					if (model != null)
					{
						modelList.Add(model);
					}
				}
			}
			return modelList;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			return dal.GetRecordCount(strWhere);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			return dal.GetListByPage( strWhere,  orderby,  startIndex,  endIndex);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

