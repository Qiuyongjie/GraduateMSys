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
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtID.Text.Trim().Length==0)
			{
				strErr+="身份证号不能为空！\\n";	
			}
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
			string ID=this.txtID.Text;
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
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
