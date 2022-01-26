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

        public void forfun()
        {
            int type;
            double full_price;
            int count;
            bool entries_visited_indicator = false;
            bool days_visited_indicator = false;
            DateTime current_date =DateTime.Today;
            DateTime previous_date;
            switch (type) {
            case 1:
                double price = full_price;
            break;

            case 2:
             //example = 4 hour per day
                 for (int i = 1; i <= 4; i++)
                  {
                        int Totalparkinghoursperday =+ 1;
                  }
                  MessageBox.Show("Limit has reached", "Warning");
            break;

            case 3:
             //example = 10 days per month
            int n = getentitleNumberofDays; //example 10 
                    if (n > 0 && previous_date != current_date)
                    {
                        if (days_visited_indicator == false)
                        {
                            n = n - 1;
                            // update Days deduct by 1 to database;
                            // stored previous visit date
                            previous_date = current_date;
                            days_visited_indicator = true;

                        }
                    }
             break;

            case 4:
             //example = 10 entries per month
               int n = getentitleNumberofEntries; //example 10 
                if (n > 0 && entries_visited_indicator == false)
                {
                    n = n- 1;
                    // update Entries deduct by 1 to database;
                    entries_visited_indicator = true;
                }
                 break;
            }


}