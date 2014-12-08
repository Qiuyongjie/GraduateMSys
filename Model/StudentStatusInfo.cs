using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// StudentStatusInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class StudentStatusInfo
	{
		public StudentStatusInfo()
		{}
		#region Model
		private string _xuehao;
		private string _id;
		private string _xuexiao;
		private string _banji;
		private string _daoshigonghao;
		/// <summary>
		/// 学号
		/// </summary>
		public string XueHao
		{
			set{ _xuehao=value;}
			get{return _xuehao;}
		}
		/// <summary>
		/// 身份证号
		/// </summary>
		public string ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 院校
		/// </summary>
		public string XueXiao
		{
			set{ _xuexiao=value;}
			get{return _xuexiao;}
		}
		/// <summary>
		/// 班级
		/// </summary>
		public string BanJi
		{
			set{ _banji=value;}
			get{return _banji;}
		}
		/// <summary>
		/// 导师工号
		/// </summary>
		public string DaoShiGongHao
		{
			set{ _daoshigonghao=value;}
			get{return _daoshigonghao;}
		}
		#endregion Model

	}
}

