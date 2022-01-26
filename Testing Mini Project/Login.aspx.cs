using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Testing_Mini_Project
{
    public partial class _Login : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_login_b_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }

    }
}