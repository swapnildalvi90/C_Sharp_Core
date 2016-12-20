using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SimpleLINQ
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataClasses1DataContext dataContext = new DataClasses1DataContext();
            
            //using LINQ query
            GridView1.DataSource = from customer in dataContext.Customers
                                   where customer.MobileNumber == "7208420838"
                                   select customer;
            GridView1.DataBind();

            //using lamda expression
            GridView2.DataSource = dataContext.Availibilities.Where(av => av.HotelId == 5);
            GridView2.DataBind();

            
        }
    }
}