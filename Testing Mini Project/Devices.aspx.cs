using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace Testing_Mini_Project
{

    public partial class Devices : System.Web.UI.Page
    {
        string path = "Data Source=ALFREDDESKTOP;Initial Catalog=Mini Project; Integrated Security=True";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adpt;
        DataTable dt;
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                
            } 
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void display()
        {
            dt = new DataTable();
            con.Open();
            adpt = new SqlDataAdapter("Select * From Device", con);
            adpt.Fill(dt);
            //dataGridView1
            con.Close();
        }
    }
}