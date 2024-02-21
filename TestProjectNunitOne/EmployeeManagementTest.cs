using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OurLib;

namespace TestProjectNunitOne
{
    [TestFixture]
    public class EmployeeManagementTest
    {
        EmpMgmt empMgmt;
        [SetUp]
        public void SetUp() { 
        
        }
        [Test]
        public void EmpNotNullTest() 
        { 
            foreach(var emp in EmpMgmt.AllEmps())
            {
                Assert.IsNotNull(emp.Id);
                Assert.IsNotNull(emp.Name);
                Assert.IsNotNull(emp.Designation);
                Assert.IsNotNull(emp.Salary);
            }
        }
    }
}
