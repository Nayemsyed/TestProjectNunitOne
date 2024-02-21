using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurLib
{
    public class EmpMgmt
    {
        static List<Emp> list = new List<Emp>()
        {
            new Emp(){Id=1,Name="Syed",Designation="HR",Salary=78000},
            new Emp(){Id=2,Name="Siri",Designation="Developer",Salary=67000},
            new Emp(){Id=3,Name="Nisha",Designation="Manager",Salary=45000},
            new Emp(){Id=4,Name="Divya",Designation="HR",Salary=56000},
            new Emp(){Id=5,Name="Sony",Designation="Tester",Salary=72000},
            new Emp(){Id=6,Name="Sama",Designation="HR",Salary=42000},

        };
        public static List<Emp> AllEmps()
        {
            return list;
        }
        public static List<Emp>EmpById(int id)
        {
            List<Emp> searchList=list.FindAll(emp=>emp.Id==id);
            return searchList;
        }
    }
}
