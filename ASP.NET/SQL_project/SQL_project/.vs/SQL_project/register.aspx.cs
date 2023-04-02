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
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Server.Transfer("login.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox2.Text != TextBox3.Text)
            {
                Response.Write("<script language='JavaScript'>alert('2次密碼輸入不一樣!!');</script >");
                TextBox3.Text = "";
                return;
            }
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Database1.mdf;Integrated Security=True;Connect Timeout=30");//連接資料庫
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select * From member", conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);//新增CommBuilder到SqlDataAdapter
            da.InsertCommand = builder.GetInsertCommand();//抓取新增的命令到da
            DataSet ds = new DataSet();
            da.Fill(ds, "member");
         
            DataView dv = new DataView(ds.Tables["member"], "id = '" + TextBox1.Text + "'", "id", DataViewRowState.CurrentRows);

            if (dv.Count != 0)
            {
                Response.Write("<script language='JavaScript'>alert('此身分證號已註冊過!!');</script >");
                TextBox1.Text = "";
                conn.Close();
                conn.Dispose();
            }
            else
            {
                DataRow newRow = ds.Tables["member"].NewRow();//在OrderDetails裡新增一列
                newRow["id"] = TextBox1.Text;
                newRow["name"] = TextBox7.Text;
                newRow["account"] = TextBox8.Text;
                newRow["password"] = TextBox2.Text;
                newRow["phone"] = TextBox4.Text;
                newRow["email"] = TextBox5.Text;            

                ds.Tables["member"].Rows.Add(newRow);//把新增好的新增進去 
                da.Update(ds, "member");//更新同步資料庫
                conn.Close();
                conn.Dispose();
                Response.Write("<script language='JavaScript'>alert('註冊成功!!');</script >");
                Server.Transfer("login.aspx");
            }
        }
    }
}