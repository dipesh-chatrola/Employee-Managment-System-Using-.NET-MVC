﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EmployeeManagementSystem.Models
{
    public class EmployeesModel
    {
        public int Employee_ID { get; set; }
        [Required]
        public string Firstname { get; set; }
        [Required]
        public string Lastname { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Mobileno { get; set; }
        [Required]
        public string JoiningDate { get; set; }
        [Required]
        public string Department { get; set; }
        [Required]
        public string Designation { get; set; }
        [Required]
        public string Password { get; set; }


    }
}