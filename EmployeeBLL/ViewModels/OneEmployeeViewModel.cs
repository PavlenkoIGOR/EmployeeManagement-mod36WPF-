﻿using EmployeeManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeBLL.ViewModels
{
    public class OneEmployeeViewModel : IOneEmployeeViewModel
    {
        private Employee _employee;
        public Employee Employee
        {
            get
            {
                return _employee;
            }
            set
            {
                _employee = value;
            }
        }
    }
}
