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
namespace Maticsoft.Web.StudentStatusInfo
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					string XueHao= Request.Params["id"];
					ShowInfo(XueHao);
				}
			}
		}
			
	private void ShowInfo(string XueHao)
	{
		Maticsoft.BLL.StudentStatusInfo bll=new Maticsoft.BLL.StudentStatusInfo();
		Maticsoft.Model.StudentStatusInfo model=bll.GetModel(XueHao);
		this.lblXueHao.Text=model.XueHao;
		this.txtID.Text=model.ID;
		this.txtXueXiao.Text=model.XueXiao;
		this.txtBanJi.Text=model.BanJi;
		this.txtDaoShiGongHao.Text=model.DaoShiGongHao;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtID.Text.Trim().Length==0)
			{
				strErr+="身份证号不能为空！\\n";	
			}
			if(this.txtXueXiao.Text.Trim().Length==0)
			{
				strErr+="院校不能为空！\\n";	
			}
			if(this.txtBanJi.Text.Trim().Length==0)
			{
				strErr+="班级不能为空！\\n";	
			}
			if(this.txtDaoShiGongHao.Text.Trim().Length==0)
			{
				strErr+="导师工号不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string XueHao=this.lblXueHao.Text;
			string ID=this.txtID.Text;
			string XueXiao=this.txtXueXiao.Text;
			string BanJi=this.txtBanJi.Text;
			string DaoShiGongHao=this.txtDaoShiGongHao.Text;


			Maticsoft.Model.StudentStatusInfo model=new Maticsoft.Model.StudentStatusInfo();
			model.XueHao=XueHao;
			model.ID=ID;
			model.XueXiao=XueXiao;
			model.BanJi=BanJi;
			model.DaoShiGongHao=DaoShiGongHao;

			Maticsoft.BLL.StudentStatusInfo bll=new Maticsoft.BLL.StudentStatusInfo();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
