using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        } 

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("sleep.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("history.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("food.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("stress.aspx");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("heart.aspx");
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Response.Redirect("modify.aspx");
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("login.aspx");
        }
    }
}