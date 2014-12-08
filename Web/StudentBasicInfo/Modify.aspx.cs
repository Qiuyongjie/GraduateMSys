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
using Maticsoft.Common;
using LTP.Accounts.Bus;
namespace Maticsoft.Web.StudentBasicInfo
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					string ID= Request.Params["id"];
					ShowInfo(ID);
				}
			}
		}
			
	private void ShowInfo(string ID)
	{
		Maticsoft.BLL.StudentBasicInfo bll=new Maticsoft.BLL.StudentBasicInfo();
		Maticsoft.Model.StudentBasicInfo model=bll.GetModel(ID);
		this.lblID.Text=model.ID;
		this.txtXingMing.Text=model.XingMing;
		this.txtJiGuan.Text=model.JiGuan;
		this.txtMinZu.Text=model.MinZu;
		this.txtShengYuanDi.Text=model.ShengYuanDi;
		this.txtShengRi.Text=model.ShengRi.ToString();
		this.txtXingBie.Text=model.XingBie;
		this.txtTag.Text=model.Tag.ToString();
		this.txtTouXiang.Text=model.TouXiang.ToString();
		this.txtMiMa.Text=model.MiMa;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtXingMing.Text.Trim().Length==0)
			{
				strErr+="姓名不能为空！\\n";	
			}
			if(this.txtJiGuan.Text.Trim().Length==0)
			{
				strErr+="籍贯不能为空！\\n";	
			}
			if(this.txtMinZu.Text.Trim().Length==0)
			{
				strErr+="民族不能为空！\\n";	
			}
			if(this.txtShengYuanDi.Text.Trim().Length==0)
			{
				strErr+="生源地不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtShengRi.Text))
			{
				strErr+="出生日期格式错误！\\n";	
			}
			if(this.txtXingBie.Text.Trim().Length==0)
			{
				strErr+="性别不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtTag.Text))
			{
				strErr+="审核状态格式错误！\\n";	
			}
			if(this.txtMiMa.Text.Trim().Length==0)
			{
				strErr+="密码不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string ID=this.lblID.Text;
			string XingMing=this.txtXingMing.Text;
			string JiGuan=this.txtJiGuan.Text;
			string MinZu=this.txtMinZu.Text;
			string ShengYuanDi=this.txtShengYuanDi.Text;
			DateTime ShengRi=DateTime.Parse(this.txtShengRi.Text);
			string XingBie=this.txtXingBie.Text;
			int Tag=int.Parse(this.txtTag.Text);
			byte[] TouXiang= new UnicodeEncoding().GetBytes(this.txtTouXiang.Text);
			string MiMa=this.txtMiMa.Text;


			Maticsoft.Model.StudentBasicInfo model=new Maticsoft.Model.StudentBasicInfo();
			model.ID=ID;
			model.XingMing=XingMing;
			model.JiGuan=JiGuan;
			model.MinZu=MinZu;
			model.ShengYuanDi=ShengYuanDi;
			model.ShengRi=ShengRi;
			model.XingBie=XingBie;
			model.Tag=Tag;
			model.TouXiang=TouXiang;
			model.MiMa=MiMa;

			Maticsoft.BLL.StudentBasicInfo bll=new Maticsoft.BLL.StudentBasicInfo();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
