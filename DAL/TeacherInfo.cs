using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL
{
	/// <summary>
	/// 数据访问类:TeacherInfo
	/// </summary>
	public partial class TeacherInfo
	{
		public TeacherInfo()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string GongHao)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TeacherInfo");
			strSql.Append(" where GongHao=SQL2012GongHao ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012GongHao", SqlDbType.NVarChar,20)			};
			parameters[0].Value = GongHao;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Maticsoft.Model.TeacherInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TeacherInfo(");
			strSql.Append("GongHao,ID,XingMing,GongZuoDanWei,MiMa)");
			strSql.Append(" values (");
			strSql.Append("SQL2012GongHao,SQL2012ID,SQL2012XingMing,SQL2012GongZuoDanWei,SQL2012MiMa)");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012GongHao", SqlDbType.NVarChar,20),
					new SqlParameter("SQL2012ID", SqlDbType.Char,18),
					new SqlParameter("SQL2012XingMing", SqlDbType.NVarChar,20),
					new SqlParameter("SQL2012GongZuoDanWei", SqlDbType.NVarChar,20),
					new SqlParameter("SQL2012MiMa", SqlDbType.NVarChar,20)};
			parameters[0].Value = model.GongHao;
			parameters[1].Value = model.ID;
			parameters[2].Value = model.XingMing;
			parameters[3].Value = model.GongZuoDanWei;
			parameters[4].Value = model.MiMa;

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
		public bool Update(Maticsoft.Model.TeacherInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TeacherInfo set ");
			strSql.Append("ID=SQL2012ID,");
			strSql.Append("XingMing=SQL2012XingMing,");
			strSql.Append("GongZuoDanWei=SQL2012GongZuoDanWei,");
			strSql.Append("MiMa=SQL2012MiMa");
			strSql.Append(" where GongHao=SQL2012GongHao ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012ID", SqlDbType.Char,18),
					new SqlParameter("SQL2012XingMing", SqlDbType.NVarChar,20),
					new SqlParameter("SQL2012GongZuoDanWei", SqlDbType.NVarChar,20),
					new SqlParameter("SQL2012MiMa", SqlDbType.NVarChar,20),
					new SqlParameter("SQL2012GongHao", SqlDbType.NVarChar,20)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.XingMing;
			parameters[2].Value = model.GongZuoDanWei;
			parameters[3].Value = model.MiMa;
			parameters[4].Value = model.GongHao;

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
		public bool Delete(string GongHao)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TeacherInfo ");
			strSql.Append(" where GongHao=SQL2012GongHao ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012GongHao", SqlDbType.NVarChar,20)			};
			parameters[0].Value = GongHao;

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
		public bool DeleteList(string GongHaolist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TeacherInfo ");
			strSql.Append(" where GongHao in ("+GongHaolist + ")  ");
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
		public Maticsoft.Model.TeacherInfo GetModel(string GongHao)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 GongHao,ID,XingMing,GongZuoDanWei,MiMa from TeacherInfo ");
			strSql.Append(" where GongHao=SQL2012GongHao ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012GongHao", SqlDbType.NVarChar,20)			};
			parameters[0].Value = GongHao;

			Maticsoft.Model.TeacherInfo model=new Maticsoft.Model.TeacherInfo();
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
		public Maticsoft.Model.TeacherInfo DataRowToModel(DataRow row)
		{
			Maticsoft.Model.TeacherInfo model=new Maticsoft.Model.TeacherInfo();
			if (row != null)
			{
				if(row["GongHao"]!=null)
				{
					model.GongHao=row["GongHao"].ToString();
				}
				if(row["ID"]!=null)
				{
					model.ID=row["ID"].ToString();
				}
				if(row["XingMing"]!=null)
				{
					model.XingMing=row["XingMing"].ToString();
				}
				if(row["GongZuoDanWei"]!=null)
				{
					model.GongZuoDanWei=row["GongZuoDanWei"].ToString();
				}
				if(row["MiMa"]!=null)
				{
					model.MiMa=row["MiMa"].ToString();
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
			strSql.Append("select GongHao,ID,XingMing,GongZuoDanWei,MiMa ");
			strSql.Append(" FROM TeacherInfo ");
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
			strSql.Append(" GongHao,ID,XingMing,GongZuoDanWei,MiMa ");
			strSql.Append(" FROM TeacherInfo ");
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
			strSql.Append("select count(1) FROM TeacherInfo ");
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
				strSql.Append("order by T.GongHao desc");
			}
			strSql.Append(")AS Row, T.*  from TeacherInfo T ");
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
			parameters[0].Value = "TeacherInfo";
			parameters[1].Value = "GongHao";
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

