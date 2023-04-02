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
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String mid = Session["id"].ToString();
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Database1.mdf;Integrated Security=True;Connect Timeout=30");//連接資料庫
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select * From member where id ='" + mid + "'", conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "member");
            DataTable dt = ds.Tables["member"];
            TextBox1.Text = dt.Rows[0]["id"].ToString();
            TextBox7.Text = dt.Rows[0]["name"].ToString();
            TextBox8.Text = dt.Rows[0]["account"].ToString();

            conn.Close();
            conn.Dispose();
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox2.Text != TextBox3.Text)
            {
                Response.Write("<script language='JavaScript'>alert('2次密碼輸入不一樣!!');</script >");
                TextBox3.Text = "";
                return;
            }
            String mid = Session["id"].ToString();
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Database1.mdf;Integrated Security=True;Connect Timeout=30");//連接資料庫
            conn.Open();
            SqlCommand cmd = new SqlCommand("Update member Set password='" + TextBox3.Text + "',phone='" + TextBox4.Text + "',email='" + TextBox5.Text + "'Where id='" + mid + "'", conn);
            cmd.ExecuteNonQuery();

            conn.Close();
            conn.Dispose();
            cmd.Dispose();
            Server.Transfer("web1.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Server.Transfer("web1.aspx");
        }
    }
}