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
namespace Maticsoft.Web.StudentGraduateInfo
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
			if(this.txtXueLi.Text.Trim().Length==0)
			{
				strErr+="最高学历不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtRuXueShiJian.Text))
			{
				strErr+="入学时间格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtBiYeShiJian.Text))
			{
				strErr+="毕业时间格式错误！\\n";	
			}
			if(this.txtBiJiZhengShuHao.Text.Trim().Length==0)
			{
				strErr+="毕业证号不能为空！\\n";	
			}
			if(this.txtXueWeiZhengHao.Text.Trim().Length==0)
			{
				strErr+="学位证号不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string ID=this.txtID.Text;
			string XingMing=this.txtXingMing.Text;
			string XueLi=this.txtXueLi.Text;
			DateTime RuXueShiJian=DateTime.Parse(this.txtRuXueShiJian.Text);
			DateTime BiYeShiJian=DateTime.Parse(this.txtBiYeShiJian.Text);
			string BiJiZhengShuHao=this.txtBiJiZhengShuHao.Text;
			string XueWeiZhengHao=this.txtXueWeiZhengHao.Text;

			Maticsoft.Model.StudentGraduateInfo model=new Maticsoft.Model.StudentGraduateInfo();
			model.ID=ID;
			model.XingMing=XingMing;
			model.XueLi=XueLi;
			model.RuXueShiJian=RuXueShiJian;
			model.BiYeShiJian=BiYeShiJian;
			model.BiJiZhengShuHao=BiJiZhengShuHao;
			model.XueWeiZhengHao=XueWeiZhengHao;

			Maticsoft.BLL.StudentGraduateInfo bll=new Maticsoft.BLL.StudentGraduateInfo();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
