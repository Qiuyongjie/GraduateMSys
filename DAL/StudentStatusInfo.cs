using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL
{
	/// <summary>
	/// 数据访问类:StudentStatusInfo
	/// </summary>
	public partial class StudentStatusInfo
	{
		public StudentStatusInfo()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string XueHao)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from StudentStatusInfo");
			strSql.Append(" where XueHao=SQL2012XueHao ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012XueHao", SqlDbType.NVarChar,10)			};
			parameters[0].Value = XueHao;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Maticsoft.Model.StudentStatusInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into StudentStatusInfo(");
			strSql.Append("XueHao,ID,XueXiao,BanJi,DaoShiGongHao)");
			strSql.Append(" values (");
			strSql.Append("SQL2012XueHao,SQL2012ID,SQL2012XueXiao,SQL2012BanJi,SQL2012DaoShiGongHao)");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012XueHao", SqlDbType.NVarChar,10),
					new SqlParameter("SQL2012ID", SqlDbType.Char,18),
					new SqlParameter("SQL2012XueXiao", SqlDbType.NVarChar,20),
					new SqlParameter("SQL2012BanJi", SqlDbType.NVarChar,20),
					new SqlParameter("SQL2012DaoShiGongHao", SqlDbType.NVarChar,20)};
			parameters[0].Value = model.XueHao;
			parameters[1].Value = model.ID;
			parameters[2].Value = model.XueXiao;
			parameters[3].Value = model.BanJi;
			parameters[4].Value = model.DaoShiGongHao;

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
		public bool Update(Maticsoft.Model.StudentStatusInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update StudentStatusInfo set ");
			strSql.Append("ID=SQL2012ID,");
			strSql.Append("XueXiao=SQL2012XueXiao,");
			strSql.Append("BanJi=SQL2012BanJi,");
			strSql.Append("DaoShiGongHao=SQL2012DaoShiGongHao");
			strSql.Append(" where XueHao=SQL2012XueHao ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012ID", SqlDbType.Char,18),
					new SqlParameter("SQL2012XueXiao", SqlDbType.NVarChar,20),
					new SqlParameter("SQL2012BanJi", SqlDbType.NVarChar,20),
					new SqlParameter("SQL2012DaoShiGongHao", SqlDbType.NVarChar,20),
					new SqlParameter("SQL2012XueHao", SqlDbType.NVarChar,10)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.XueXiao;
			parameters[2].Value = model.BanJi;
			parameters[3].Value = model.DaoShiGongHao;
			parameters[4].Value = model.XueHao;

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
		public bool Delete(string XueHao)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from StudentStatusInfo ");
			strSql.Append(" where XueHao=SQL2012XueHao ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012XueHao", SqlDbType.NVarChar,10)			};
			parameters[0].Value = XueHao;

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
		public bool DeleteList(string XueHaolist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from StudentStatusInfo ");
			strSql.Append(" where XueHao in ("+XueHaolist + ")  ");
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
		public Maticsoft.Model.StudentStatusInfo GetModel(string XueHao)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 XueHao,ID,XueXiao,BanJi,DaoShiGongHao from StudentStatusInfo ");
			strSql.Append(" where XueHao=SQL2012XueHao ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012XueHao", SqlDbType.NVarChar,10)			};
			parameters[0].Value = XueHao;

			Maticsoft.Model.StudentStatusInfo model=new Maticsoft.Model.StudentStatusInfo();
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
		public Maticsoft.Model.StudentStatusInfo DataRowToModel(DataRow row)
		{
			Maticsoft.Model.StudentStatusInfo model=new Maticsoft.Model.StudentStatusInfo();
			if (row != null)
			{
				if(row["XueHao"]!=null)
				{
					model.XueHao=row["XueHao"].ToString();
				}
				if(row["ID"]!=null)
				{
					model.ID=row["ID"].ToString();
				}
				if(row["XueXiao"]!=null)
				{
					model.XueXiao=row["XueXiao"].ToString();
				}
				if(row["BanJi"]!=null)
				{
					model.BanJi=row["BanJi"].ToString();
				}
				if(row["DaoShiGongHao"]!=null)
				{
					model.DaoShiGongHao=row["DaoShiGongHao"].ToString();
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
			strSql.Append("select XueHao,ID,XueXiao,BanJi,DaoShiGongHao ");
			strSql.Append(" FROM StudentStatusInfo ");
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
			strSql.Append(" XueHao,ID,XueXiao,BanJi,DaoShiGongHao ");
			strSql.Append(" FROM StudentStatusInfo ");
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
			strSql.Append("select count(1) FROM StudentStatusInfo ");
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
				strSql.Append("order by T.XueHao desc");
			}
			strSql.Append(")AS Row, T.*  from StudentStatusInfo T ");
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
			parameters[0].Value = "StudentStatusInfo";
			parameters[1].Value = "XueHao";
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

