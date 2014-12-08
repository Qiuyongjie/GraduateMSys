using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Text;
namespace Maticsoft.Web.StudentStatusInfo
{
    public partial class Show : Page
    {        
        		public string strid=""; 
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					strid = Request.Params["id"];
					string XueHao= strid;
					ShowInfo(XueHao);
				}
			}
		}
		
	private void ShowInfo(string XueHao)
	{
		Maticsoft.BLL.StudentStatusInfo bll=new Maticsoft.BLL.StudentStatusInfo();
		Maticsoft.Model.StudentStatusInfo model=bll.GetModel(XueHao);
		this.lblXueHao.Text=model.XueHao;
		this.lblID.Text=model.ID;
		this.lblXueXiao.Text=model.XueXiao;
		this.lblBanJi.Text=model.BanJi;
		this.lblDaoShiGongHao.Text=model.DaoShiGongHao;

	}


    }
}
