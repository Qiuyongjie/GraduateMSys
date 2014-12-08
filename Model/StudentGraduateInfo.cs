using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// StudentGraduateInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class StudentGraduateInfo
	{
		public StudentGraduateInfo()
		{}
		#region Model
		private string _id;
		private string _xingming;
		private string _xueli;
		private DateTime _ruxueshijian;
		private DateTime _biyeshijian;
		private string _bijizhengshuhao;
		private string _xueweizhenghao;
		/// <summary>
		/// 身份证号
		/// </summary>
		public string ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 姓名
		/// </summary>
		public string XingMing
		{
			set{ _xingming=value;}
			get{return _xingming;}
		}
		/// <summary>
		/// 最高学历
		/// </summary>
		public string XueLi
		{
			set{ _xueli=value;}
			get{return _xueli;}
		}
		/// <summary>
		/// 入学时间
		/// </summary>
		public DateTime RuXueShiJian
		{
			set{ _ruxueshijian=value;}
			get{return _ruxueshijian;}
		}
		/// <summary>
		/// 毕业时间
		/// </summary>
		public DateTime BiYeShiJian
		{
			set{ _biyeshijian=value;}
			get{return _biyeshijian;}
		}
		/// <summary>
		/// 毕业证号
		/// </summary>
		public string BiJiZhengShuHao
		{
			set{ _bijizhengshuhao=value;}
			get{return _bijizhengshuhao;}
		}
		/// <summary>
		/// 学位证号
		/// </summary>
		public string XueWeiZhengHao
		{
			set{ _xueweizhenghao=value;}
			get{return _xueweizhenghao;}
		}
		#endregion Model

	}
}

