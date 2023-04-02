using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Data;

namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Database1.mdf;Integrated Security=True;Connect Timeout=30");//連接資料庫
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select * From member", conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "gogo");
            conn.Close();
            conn.Dispose();

            DataView dv = new DataView(ds.Tables["gogo"], "account = '" + account.Text + "'", "id", DataViewRowState.CurrentRows);
            //查詢有無此帳號
            if (dv.Count != 0)
            {
                string pas = dv[0]["password"].ToString();//取出查詢到的帳號裡的密碼
                if (pas != password.Text)//跟輸入的不一樣
                {
                    Response.Write("<script language='JavaScript'>alert('密碼輸入錯誤!!');</script >");
                }
                else
                {
                    Session["id"] = dv[0]["id"];
                    Response.Redirect("web1.aspx");
                }
            }
            else
            {
                Response.Write("<script language='JavaScript'>alert('此帳號不存在!!');</script >");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("register.aspx");
        }
    }
}