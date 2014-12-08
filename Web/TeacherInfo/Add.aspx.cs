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
namespace Maticsoft.Web.TeacherInfo
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtGongHao.Text.Trim().Length==0)
			{
				strErr+="工号不能为空！\\n";	
			}
			if(this.txtID.Text.Trim().Length==0)
			{
				strErr+="身份证号不能为空！\\n";	
			}
			if(this.txtXingMing.Text.Trim().Length==0)
			{
				strErr+="姓名不能为空！\\n";	
			}
			if(this.txtGongZuoDanWei.Text.Trim().Length==0)
			{
				strErr+="工作单位不能为空！\\n";	
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
			string GongHao=this.txtGongHao.Text;
			string ID=this.txtID.Text;
			string XingMing=this.txtXingMing.Text;
			string GongZuoDanWei=this.txtGongZuoDanWei.Text;
			string MiMa=this.txtMiMa.Text;

			Maticsoft.Model.TeacherInfo model=new Maticsoft.Model.TeacherInfo();
			model.GongHao=GongHao;
			model.ID=ID;
			model.XingMing=XingMing;
			model.GongZuoDanWei=GongZuoDanWei;
			model.MiMa=MiMa;

			Maticsoft.BLL.TeacherInfo bll=new Maticsoft.BLL.TeacherInfo();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
