using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExtensionMethod
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Employee> empList = new List<Employee>();
            empList.Add(new Employee { EmpId = 1, EmpName = "Swapnil", Gender = "Male" });
            empList.Add(new Employee { EmpId = 2, EmpName = "Sudhakar", Gender = "Male" });
            empList.Add(new Employee { EmpId = 3, EmpName = "Dalvi", Gender = "Male" });
            empList.Add(new Employee { EmpId = 4, EmpName = "Amar", Gender = "Female" });
            empList.Add(new Employee { EmpId = 5, EmpName = "Akbar", Gender = "Female" });
            empList.Add(new Employee { EmpId = 6, EmpName = "Anthony", Gender = "Female" });

            empList = empList.ChangeCaseOfFirstLetter(); //this is extension method which is written in StringHelper
            GridView1.DataSource = empList;
            GridView1.DataBind();
            
        }
    }
}