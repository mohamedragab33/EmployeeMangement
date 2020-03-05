using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test9.Models
{
  public  interface IEmployeeRepository
    {
        Employee GetEmployee(int ID);
        IEnumerable<Employee> GetAllEmployee();
    }
}
