﻿using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// Products:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Products
	{
		public Products()
		{}
		#region Model
		private int _id;
		private string _name;
		private string _repayremark;
		/// <summary>
		/// 
		/// </summary>
		public int Id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RepayRemark
		{
			set{ _repayremark=value;}
			get{return _repayremark;}
		}
		#endregion Model

	}
}

