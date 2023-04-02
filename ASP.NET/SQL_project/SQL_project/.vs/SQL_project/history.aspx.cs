using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Web.Configuration;

namespace WebApplication2
{
    public partial class history : System.Web.UI.Page
    {
        int t = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            Label2.Text = "";
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Database1.mdf;Integrated Security=True;Connect Timeout=30");//連接資料庫
            conn.Open();
            DataSet ds = new DataSet();

            String id = (string)Session["id"];
            SqlDataAdapter da1 = new SqlDataAdapter("Select * From history where id='" + id + "'", conn);
            da1.Fill(ds, "history");
            DataTable dt1 = ds.Tables["history"];


            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                SqlDataAdapter da2 = new SqlDataAdapter("Select * From score where Qid='" + dt1.Rows[i]["Qid"] + "'AND score='" + dt1.Rows[i]["score"] + "'", conn);
                da2.Fill(ds, "score");
                DataTable dt2 = ds.Tables["score"];
                SqlDataAdapter da3 = new SqlDataAdapter("Select * From comments where Cid='" + dt2.Rows[i]["Cid"] + "'", conn);
                da3.Fill(ds, "comments");
                DataTable dt3 = ds.Tables["comments"];
                DateTime dd = DateTime.Parse(dt1.Rows[i]["date"].ToString());

                Label2.Text += (i + 1) + ". 評語:" + dt3.Rows[i]["comments"] + " , 作答時間:" + String.Format("{0:yyyy/MM/dd}", dd) + "<br>";
                t++;
            }
            conn.Dispose();
            conn.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Server.Transfer("web1.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Panel1.Visible = true;
        }

        protected void Button3_Click(object sender, EventArgs e)//刪除
        {
            int index = int.Parse(TextBox1.Text);
            if (index > t || index <= 0)
            {
                Response.Write("<script language='JavaScript'>alert('輸入錯誤!!');</script >");
                return;
            }
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Database1.mdf;Integrated Security=True;Connect Timeout=30");//連接資料庫
            conn.Open();
            DataSet ds = new DataSet();

            String id = (string)Session["id"];
            SqlDataAdapter da = new SqlDataAdapter("Select * From history where id='" + id + "'", conn);
            da.Fill(ds, "history");
            DataTable dt = ds.Tables["history"];

            SqlCommand cmd = new SqlCommand("Delete From history where Hid='" + dt.Rows[index - 1]["Hid"] + "'", conn);
            cmd.ExecuteNonQuery();

            cmd.Dispose();
            conn.Dispose();
            conn.Close();
            Server.Transfer("web1.aspx");
        }
    }
}