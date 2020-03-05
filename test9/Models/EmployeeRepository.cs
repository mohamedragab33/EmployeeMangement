using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test9.Models
{
    public class EmployeeRepository : IEmployeeRepository
    {

        private List<Employee> _employeesList;
        public EmployeeRepository()
        {
            _employeesList = new List<Employee>() {

            new Employee (){ ID=1 ,name="mohamed",Email="moha.ragab33@gmail.com",Department="programming" },
                        new Employee (){ ID=2 ,name="ragab",Email="moha.ragab33@gmail.com",Department="programming" },

            new Employee (){ ID=3 ,name="atia",Email="moha.ragab33@gmail.com",Department="programming" },


            };
        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            return _employeesList; 
        }

        public Employee GetEmployee(int ID)
        {
            return _employeesList.FirstOrDefault(e => e.ID==ID);
        }
    }
}
