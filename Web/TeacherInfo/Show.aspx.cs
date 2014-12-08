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
namespace Maticsoft.Web.TeacherInfo
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
					string GongHao= strid;
					ShowInfo(GongHao);
				}
			}
		}
		
	private void ShowInfo(string GongHao)
	{
		Maticsoft.BLL.TeacherInfo bll=new Maticsoft.BLL.TeacherInfo();
		Maticsoft.Model.TeacherInfo model=bll.GetModel(GongHao);
		this.lblGongHao.Text=model.GongHao;
		this.lblID.Text=model.ID;
		this.lblXingMing.Text=model.XingMing;
		this.lblGongZuoDanWei.Text=model.GongZuoDanWei;
		this.lblMiMa.Text=model.MiMa;

	}


    }
}
