using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// TeacherInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TeacherInfo
	{
		public TeacherInfo()
		{}
		#region Model
		private string _gonghao;
		private string _id;
		private string _xingming;
		private string _gongzuodanwei;
		private string _mima;
		/// <summary>
		/// 工号
		/// </summary>
		public string GongHao
		{
			set{ _gonghao=value;}
			get{return _gonghao;}
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
		/// 姓名
		/// </summary>
		public string XingMing
		{
			set{ _xingming=value;}
			get{return _xingming;}
		}
		/// <summary>
		/// 工作单位
		/// </summary>
		public string GongZuoDanWei
		{
			set{ _gongzuodanwei=value;}
			get{return _gongzuodanwei;}
		}
		/// <summary>
		/// 密码
		/// </summary>
		public string MiMa
		{
			set{ _mima=value;}
			get{return _mima;}
		}
		#endregion Model

	}
}

