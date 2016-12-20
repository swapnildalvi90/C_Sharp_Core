/*
 Extension methods are static methods of static classes
 * Extension methods are used to add new functionality into already existing Types without creating nre derived types
 */



using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExtensionMethod
{
    public static class StringHelper
    {
        public static List<Employee> ChangeCaseOfFirstLetter(this List<Employee> empList)
        {
           // List<Employee> ConvertedEmpList = new List<Employee>();
            foreach (Employee emp in empList)
            {
               char[] name = emp.EmpName.ToCharArray();
               name[0] = Char.IsUpper(name[0]) ? Char.ToLower(name[0]) : Char.ToUpper(name[0]);
               emp.EmpName =new String(name);
            }

            return empList;
        }
    }
}