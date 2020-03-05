using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using test9.Models;
using test9.ViewModels;

namespace test9.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEmployeeRepository _employeeRepository;

        public HomeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;


        }
        public ViewResult Index()
        {

           var Employee =   _employeeRepository.GetAllEmployee();

            return View(Employee);

        }
        public ViewResult details(int? id)
        {

            HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel() {

                pagetitle = "Welcome Here",
                emp = _employeeRepository.GetEmployee(id??1)


        };

            return  View(homeDetailsViewModel);
        }
    }
}