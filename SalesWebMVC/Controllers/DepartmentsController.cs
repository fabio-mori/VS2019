﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesWebMVC.Models;

namespace SalesWebMVC.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> list = new List<Department> ();

            list.Add(new Department { Id = 1, Nome = "RH" });
            list.Add(new Department { Id = 2, Nome = "Desenvolvimento" });
            list.Add(new Department { Id = 3, Nome = "Suporte" });
            list.Add(new Department { Id = 2, Nome = "Teste" });




            return View(list);
        }
    }
}