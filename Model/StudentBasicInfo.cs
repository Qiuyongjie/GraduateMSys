using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// StudentBasicInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class StudentBasicInfo
	{
		public StudentBasicInfo()
		{}
		#region Model
		private string _id;
		private string _xingming;
		private string _jiguan;
		private string _minzu;
		private string _shengyuandi;
		private DateTime _shengri;
		private string _xingbie;
		private int _tag;
		private byte[] _touxiang;
		private string _mima;
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
		/// 籍贯
		/// </summary>
		public string JiGuan
		{
			set{ _jiguan=value;}
			get{return _jiguan;}
		}
		/// <summary>
		/// 民族
		/// </summary>
		public string MinZu
		{
			set{ _minzu=value;}
			get{return _minzu;}
		}
		/// <summary>
		/// 生源地
		/// </summary>
		public string ShengYuanDi
		{
			set{ _shengyuandi=value;}
			get{return _shengyuandi;}
		}
		/// <summary>
		/// 出生日期
		/// </summary>
		public DateTime ShengRi
		{
			set{ _shengri=value;}
			get{return _shengri;}
		}
		/// <summary>
		/// 性别
		/// </summary>
		public string XingBie
		{
			set{ _xingbie=value;}
			get{return _xingbie;}
		}
		/// <summary>
		/// 审核状态
		/// </summary>
		public int Tag
		{
			set{ _tag=value;}
			get{return _tag;}
		}
		/// <summary>
		/// 照片
		/// </summary>
		public byte[] TouXiang
		{
			set{ _touxiang=value;}
			get{return _touxiang;}
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

