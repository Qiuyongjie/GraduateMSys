using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL
{
	/// <summary>
	/// 数据访问类:StudentBasicInfo
	/// </summary>
	public partial class StudentBasicInfo
	{
		public StudentBasicInfo()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from StudentBasicInfo");
			strSql.Append(" where ID=SQL2012ID ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012ID", SqlDbType.Char,18)			};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Maticsoft.Model.StudentBasicInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into StudentBasicInfo(");
			strSql.Append("ID,XingMing,JiGuan,MinZu,ShengYuanDi,ShengRi,XingBie,Tag,TouXiang,MiMa)");
			strSql.Append(" values (");
			strSql.Append("SQL2012ID,SQL2012XingMing,SQL2012JiGuan,SQL2012MinZu,SQL2012ShengYuanDi,SQL2012ShengRi,SQL2012XingBie,SQL2012Tag,SQL2012TouXiang,SQL2012MiMa)");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012ID", SqlDbType.Char,18),
					new SqlParameter("SQL2012XingMing", SqlDbType.NVarChar,20),
					new SqlParameter("SQL2012JiGuan", SqlDbType.NVarChar,20),
					new SqlParameter("SQL2012MinZu", SqlDbType.NVarChar,20),
					new SqlParameter("SQL2012ShengYuanDi", SqlDbType.NVarChar,20),
					new SqlParameter("SQL2012ShengRi", SqlDbType.DateTime),
					new SqlParameter("SQL2012XingBie", SqlDbType.NVarChar,10),
					new SqlParameter("SQL2012Tag", SqlDbType.Int,4),
					new SqlParameter("SQL2012TouXiang", SqlDbType.Image),
					new SqlParameter("SQL2012MiMa", SqlDbType.NVarChar,20)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.XingMing;
			parameters[2].Value = model.JiGuan;
			parameters[3].Value = model.MinZu;
			parameters[4].Value = model.ShengYuanDi;
			parameters[5].Value = model.ShengRi;
			parameters[6].Value = model.XingBie;
			parameters[7].Value = model.Tag;
			parameters[8].Value = model.TouXiang;
			parameters[9].Value = model.MiMa;

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
		public bool Update(Maticsoft.Model.StudentBasicInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update StudentBasicInfo set ");
			strSql.Append("XingMing=SQL2012XingMing,");
			strSql.Append("JiGuan=SQL2012JiGuan,");
			strSql.Append("MinZu=SQL2012MinZu,");
			strSql.Append("ShengYuanDi=SQL2012ShengYuanDi,");
			strSql.Append("ShengRi=SQL2012ShengRi,");
			strSql.Append("XingBie=SQL2012XingBie,");
			strSql.Append("Tag=SQL2012Tag,");
			strSql.Append("TouXiang=SQL2012TouXiang,");
			strSql.Append("MiMa=SQL2012MiMa");
			strSql.Append(" where ID=SQL2012ID ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012XingMing", SqlDbType.NVarChar,20),
					new SqlParameter("SQL2012JiGuan", SqlDbType.NVarChar,20),
					new SqlParameter("SQL2012MinZu", SqlDbType.NVarChar,20),
					new SqlParameter("SQL2012ShengYuanDi", SqlDbType.NVarChar,20),
					new SqlParameter("SQL2012ShengRi", SqlDbType.DateTime),
					new SqlParameter("SQL2012XingBie", SqlDbType.NVarChar,10),
					new SqlParameter("SQL2012Tag", SqlDbType.Int,4),
					new SqlParameter("SQL2012TouXiang", SqlDbType.Image),
					new SqlParameter("SQL2012MiMa", SqlDbType.NVarChar,20),
					new SqlParameter("SQL2012ID", SqlDbType.Char,18)};
			parameters[0].Value = model.XingMing;
			parameters[1].Value = model.JiGuan;
			parameters[2].Value = model.MinZu;
			parameters[3].Value = model.ShengYuanDi;
			parameters[4].Value = model.ShengRi;
			parameters[5].Value = model.XingBie;
			parameters[6].Value = model.Tag;
			parameters[7].Value = model.TouXiang;
			parameters[8].Value = model.MiMa;
			parameters[9].Value = model.ID;

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
			strSql.Append("delete from StudentBasicInfo ");
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
			strSql.Append("delete from StudentBasicInfo ");
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
		public Maticsoft.Model.StudentBasicInfo GetModel(string ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,XingMing,JiGuan,MinZu,ShengYuanDi,ShengRi,XingBie,Tag,TouXiang,MiMa from StudentBasicInfo ");
			strSql.Append(" where ID=SQL2012ID ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012ID", SqlDbType.Char,18)			};
			parameters[0].Value = ID;

			Maticsoft.Model.StudentBasicInfo model=new Maticsoft.Model.StudentBasicInfo();
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
		public Maticsoft.Model.StudentBasicInfo DataRowToModel(DataRow row)
		{
			Maticsoft.Model.StudentBasicInfo model=new Maticsoft.Model.StudentBasicInfo();
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
				if(row["JiGuan"]!=null)
				{
					model.JiGuan=row["JiGuan"].ToString();
				}
				if(row["MinZu"]!=null)
				{
					model.MinZu=row["MinZu"].ToString();
				}
				if(row["ShengYuanDi"]!=null)
				{
					model.ShengYuanDi=row["ShengYuanDi"].ToString();
				}
				if(row["ShengRi"]!=null && row["ShengRi"].ToString()!="")
				{
					model.ShengRi=DateTime.Parse(row["ShengRi"].ToString());
				}
				if(row["XingBie"]!=null)
				{
					model.XingBie=row["XingBie"].ToString();
				}
				if(row["Tag"]!=null && row["Tag"].ToString()!="")
				{
					model.Tag=int.Parse(row["Tag"].ToString());
				}
				if(row["TouXiang"]!=null && row["TouXiang"].ToString()!="")
				{
					model.TouXiang=(byte[])row["TouXiang"];
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
			strSql.Append("select ID,XingMing,JiGuan,MinZu,ShengYuanDi,ShengRi,XingBie,Tag,TouXiang,MiMa ");
			strSql.Append(" FROM StudentBasicInfo ");
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
			strSql.Append(" ID,XingMing,JiGuan,MinZu,ShengYuanDi,ShengRi,XingBie,Tag,TouXiang,MiMa ");
			strSql.Append(" FROM StudentBasicInfo ");
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
			strSql.Append("select count(1) FROM StudentBasicInfo ");
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
			strSql.Append(")AS Row, T.*  from StudentBasicInfo T ");
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
			parameters[0].Value = "StudentBasicInfo";
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

