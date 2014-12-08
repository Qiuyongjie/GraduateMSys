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
namespace Maticsoft.Web.StudentBasicInfo
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
		Maticsoft.BLL.StudentBasicInfo bll=new Maticsoft.BLL.StudentBasicInfo();
		Maticsoft.Model.StudentBasicInfo model=bll.GetModel(ID);
		this.lblID.Text=model.ID;
		this.lblXingMing.Text=model.XingMing;
		this.lblJiGuan.Text=model.JiGuan;
		this.lblMinZu.Text=model.MinZu;
		this.lblShengYuanDi.Text=model.ShengYuanDi;
		this.lblShengRi.Text=model.ShengRi.ToString();
		this.lblXingBie.Text=model.XingBie;
		this.lblTag.Text=model.Tag.ToString();
		this.lblTouXiang.Text=model.TouXiang.ToString();
		this.lblMiMa.Text=model.MiMa;

	}


    }
}
