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
namespace Maticsoft.Web.StudentGraduateInfo
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
					string ID= strid;
					ShowInfo(ID);
				}
			}
		}
		
	private void ShowInfo(string ID)
	{
		Maticsoft.BLL.StudentGraduateInfo bll=new Maticsoft.BLL.StudentGraduateInfo();
		Maticsoft.Model.StudentGraduateInfo model=bll.GetModel(ID);
		this.lblID.Text=model.ID;
		this.lblXingMing.Text=model.XingMing;
		this.lblXueLi.Text=model.XueLi;
		this.lblRuXueShiJian.Text=model.RuXueShiJian.ToString();
		this.lblBiYeShiJian.Text=model.BiYeShiJian.ToString();
		this.lblBiJiZhengShuHao.Text=model.BiJiZhengShuHao;
		this.lblXueWeiZhengHao.Text=model.XueWeiZhengHao;

	}


    }
}
