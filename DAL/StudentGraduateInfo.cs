using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL
{
	/// <summary>
	/// 数据访问类:StudentGraduateInfo
	/// </summary>
	public partial class StudentGraduateInfo
	{
		public StudentGraduateInfo()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from StudentGraduateInfo");
			strSql.Append(" where ID=SQL2012ID ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012ID", SqlDbType.Char,18)			};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Maticsoft.Model.StudentGraduateInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into StudentGraduateInfo(");
			strSql.Append("ID,XingMing,XueLi,RuXueShiJian,BiYeShiJian,BiJiZhengShuHao,XueWeiZhengHao)");
			strSql.Append(" values (");
			strSql.Append("SQL2012ID,SQL2012XingMing,SQL2012XueLi,SQL2012RuXueShiJian,SQL2012BiYeShiJian,SQL2012BiJiZhengShuHao,SQL2012XueWeiZhengHao)");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012ID", SqlDbType.Char,18),
					new SqlParameter("SQL2012XingMing", SqlDbType.NVarChar,20),
					new SqlParameter("SQL2012XueLi", SqlDbType.NVarChar,20),
					new SqlParameter("SQL2012RuXueShiJian", SqlDbType.DateTime),
					new SqlParameter("SQL2012BiYeShiJian", SqlDbType.DateTime),
					new SqlParameter("SQL2012BiJiZhengShuHao", SqlDbType.NVarChar,10),
					new SqlParameter("SQL2012XueWeiZhengHao", SqlDbType.NVarChar,10)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.XingMing;
			parameters[2].Value = model.XueLi;
			parameters[3].Value = model.RuXueShiJian;
			parameters[4].Value = model.BiYeShiJian;
			parameters[5].Value = model.BiJiZhengShuHao;
			parameters[6].Value = model.XueWeiZhengHao;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Maticsoft.Model.StudentGraduateInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update StudentGraduateInfo set ");
			strSql.Append("XingMing=SQL2012XingMing,");
			strSql.Append("XueLi=SQL2012XueLi,");
			strSql.Append("RuXueShiJian=SQL2012RuXueShiJian,");
			strSql.Append("BiYeShiJian=SQL2012BiYeShiJian,");
			strSql.Append("BiJiZhengShuHao=SQL2012BiJiZhengShuHao,");
			strSql.Append("XueWeiZhengHao=SQL2012XueWeiZhengHao");
			strSql.Append(" where ID=SQL2012ID ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012XingMing", SqlDbType.NVarChar,20),
					new SqlParameter("SQL2012XueLi", SqlDbType.NVarChar,20),
					new SqlParameter("SQL2012RuXueShiJian", SqlDbType.DateTime),
					new SqlParameter("SQL2012BiYeShiJian", SqlDbType.DateTime),
					new SqlParameter("SQL2012BiJiZhengShuHao", SqlDbType.NVarChar,10),
					new SqlParameter("SQL2012XueWeiZhengHao", SqlDbType.NVarChar,10),
					new SqlParameter("SQL2012ID", SqlDbType.Char,18)};
			parameters[0].Value = model.XingMing;
			parameters[1].Value = model.XueLi;
			parameters[2].Value = model.RuXueShiJian;
			parameters[3].Value = model.BiYeShiJian;
			parameters[4].Value = model.BiJiZhengShuHao;
			parameters[5].Value = model.XueWeiZhengHao;
			parameters[6].Value = model.ID;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from StudentGraduateInfo ");
			strSql.Append(" where ID=SQL2012ID ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012ID", SqlDbType.Char,18)			};
			parameters[0].Value = ID;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from StudentGraduateInfo ");
			strSql.Append(" where ID in ("+IDlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Maticsoft.Model.StudentGraduateInfo GetModel(string ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,XingMing,XueLi,RuXueShiJian,BiYeShiJian,BiJiZhengShuHao,XueWeiZhengHao from StudentGraduateInfo ");
			strSql.Append(" where ID=SQL2012ID ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012ID", SqlDbType.Char,18)			};
			parameters[0].Value = ID;

			Maticsoft.Model.StudentGraduateInfo model=new Maticsoft.Model.StudentGraduateInfo();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Maticsoft.Model.StudentGraduateInfo DataRowToModel(DataRow row)
		{
			Maticsoft.Model.StudentGraduateInfo model=new Maticsoft.Model.StudentGraduateInfo();
			if (row != null)
			{
				if(row["ID"]!=null)
				{
					model.ID=row["ID"].ToString();
				}
				if(row["XingMing"]!=null)
				{
					model.XingMing=row["XingMing"].ToString();
				}
				if(row["XueLi"]!=null)
				{
					model.XueLi=row["XueLi"].ToString();
				}
				if(row["RuXueShiJian"]!=null && row["RuXueShiJian"].ToString()!="")
				{
					model.RuXueShiJian=DateTime.Parse(row["RuXueShiJian"].ToString());
				}
				if(row["BiYeShiJian"]!=null && row["BiYeShiJian"].ToString()!="")
				{
					model.BiYeShiJian=DateTime.Parse(row["BiYeShiJian"].ToString());
				}
				if(row["BiJiZhengShuHao"]!=null)
				{
					model.BiJiZhengShuHao=row["BiJiZhengShuHao"].ToString();
				}
				if(row["XueWeiZhengHao"]!=null)
				{
					model.XueWeiZhengHao=row["XueWeiZhengHao"].ToString();
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,XingMing,XueLi,RuXueShiJian,BiYeShiJian,BiJiZhengShuHao,XueWeiZhengHao ");
			strSql.Append(" FROM StudentGraduateInfo ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" ID,XingMing,XueLi,RuXueShiJian,BiYeShiJian,BiJiZhengShuHao,XueWeiZhengHao ");
			strSql.Append(" FROM StudentGraduateInfo ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM StudentGraduateInfo ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.ID desc");
			}
			strSql.Append(")AS Row, T.*  from StudentGraduateInfo T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012tblName", SqlDbType.VarChar, 255),
					new SqlParameter("SQL2012fldName", SqlDbType.VarChar, 255),
					new SqlParameter("SQL2012PageSize", SqlDbType.Int),
					new SqlParameter("SQL2012PageIndex", SqlDbType.Int),
					new SqlParameter("SQL2012IsReCount", SqlDbType.Bit),
					new SqlParameter("SQL2012OrderType", SqlDbType.Bit),
					new SqlParameter("SQL2012strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "StudentGraduateInfo";
			parameters[1].Value = "ID";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

