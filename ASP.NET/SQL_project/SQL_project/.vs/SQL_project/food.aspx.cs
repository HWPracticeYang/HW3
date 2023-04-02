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
    public partial class food : System.Web.UI.Page
    {
        Label[] label = new Label[10];
        RadioButtonList[] rbl = new RadioButtonList[10];
        String name = "飲食";
        int qid = 0;
        protected void Page_Load(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Database1.mdf;Integrated Security=True;Connect Timeout=30");//連接資料庫
            conn.Open();
            SqlDataAdapter da1 = new SqlDataAdapter("Select * From question", conn);
            SqlDataAdapter da2 = new SqlDataAdapter("Select * From [question_list]", conn);
            DataSet ds = new DataSet();
            da1.Fill(ds, "question");
            da2.Fill(ds, "question_list");
            DataView dv1 = new DataView(ds.Tables["question"], "name = '" + name + "'", "name", DataViewRowState.CurrentRows);

            if (dv1.Count != 0)
            {
                qid = int.Parse(dv1[0]["Qid"].ToString());
            }
            DataView dv2 = new DataView(ds.Tables["question_list"], "Qid = '" + qid + "'", "Qid", DataViewRowState.CurrentRows);

            for (int i = 0; i < label.Length; i++)
            {
                label[i] = new Label();
                label[i].ID = "label" + i.ToString();
                label[i].Text = (i + 1) + "." + dv2[i]["question"].ToString();

                rbl[i] = new RadioButtonList();
                rbl[i].ID = "rbl" + i.ToString();

                for (int j = 0; j < 4; j++)
                {
                    ListItem li = new ListItem();
                    String choose = "choose" + (j + 1);
                    li.Text = dv2[i][choose].ToString();
                    li.Value = (j + 1).ToString();
                    rbl[i].Items.Add(li);
                }

                Panel2.Controls.Add(label[i]);
                Panel2.Controls.Add(new LiteralControl("<br>"));
                Panel2.Controls.Add(rbl[i]);
                Panel2.Controls.Add(new LiteralControl("<br>"));
            }

            conn.Close();
            conn.Dispose();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Button3.Visible = true;
            Button1.Visible = false;
            Button2.Visible = false;
            int total = 0;
            for (int i = 0; i < rbl.Length; i++)
            {
                total += int.Parse(rbl[i].SelectedValue);
            }
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Database1.mdf;Integrated Security=True;Connect Timeout=30");//連接資料庫
            conn.Open();

            SqlDataAdapter da1 = new SqlDataAdapter("Select * From score where Qid='" + qid + "'AND score='" + total + "'", conn);
            DataSet ds = new DataSet();
            da1.Fill(ds, "score");
            DataTable dt1 = ds.Tables["score"];

            SqlDataAdapter da2 = new SqlDataAdapter("Select * From comments where Cid='" + dt1.Rows[0]["Cid"] + "'", conn);
            da2.Fill(ds, "comments");
            DataTable dt2 = ds.Tables["comments"];

            conn.Dispose();
            conn.Close();
            save(total);
            final.Text = "評語:" + dt2.Rows[0]["comments"];

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Server.Transfer("web1.aspx");
        }

        public void save(int total)
        {
            String mid = Session["id"].ToString();
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Database1.mdf;Integrated Security=True;Connect Timeout=30");//連接資料庫
            conn.Open();
            SqlCommand cmd = new SqlCommand("Insert into history(id,Qid,score,date)Values('" + mid + "','" + qid + "','" + total + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "')", conn);
            cmd.ExecuteNonQuery();
            conn.Dispose();
            conn.Close();
            cmd.Dispose();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Server.Transfer("web1.aspx");
        }
    }
}