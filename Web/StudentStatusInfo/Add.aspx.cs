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
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtXueHao.Text.Trim().Length==0)
			{
				strErr+="学号不能为空！\\n";	
			}
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
			string XueHao=this.txtXueHao.Text;
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
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
