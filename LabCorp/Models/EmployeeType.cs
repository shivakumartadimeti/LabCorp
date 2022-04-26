using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace LabCorp.Models
{
    public class EmployeeType
    {
        public int Id { get; set; }
        [DisplayName("Employee Name")]
        public string EmpName { get; set; }
        [DisplayName("Date of Birth")]
        public DateTime DateOfBirth { get; set; }
        public int Age { get; set; }
        [DisplayName("Date of Joining")]
        public DateTime DateofJoining { get; set; }
        [DisplayName("#of Vacations Taken")]
        public float VacationsTaken { get; set; }
        [DisplayName("Job Type")]
        public string JobType { get; set; }
        [DisplayName("Job Title")]
        public string JobTitle { get; set; }

        public int NoWorkingDays { get; set; }
        [DisplayName("Days Worked")]
        public int WorkingDays { get; set; } = 1;
        [DisplayName("#of Vacations")]
        public float Number_Of_Vacation_Days { get; set; }
        [DisplayName("#of Vacations Accumulated")]
        public float Number_Of_Vacation_Accumulated { get; set; }
    }

    public class Hourly_Employees
    {
        public int Id { get; set; }
        [DisplayName("Employee Name")]
        public string EmpName { get; set; }
        [DisplayName("Date of Birth")]
        public DateTime DateOfBirth { get; set; }
        public int Age { get; set; }
        [DisplayName("Date of Joining")]
        public DateTime DateofJoining { get; set; }
        [DisplayName("#of Vacations")]
        public float VacationsTaken { get; set; }
        [DisplayName("Job Type")]
        public string JobType { get; set; }
        [DisplayName("Job Title")]
        public string JobTitle { get; set; }

        public int NoWorkingDays { get; set; } = 260;
        [DisplayName("Days Worked")]
        public int WorkingDays { get; set; } 
        public float Number_Of_Vacation_Days { get; set; } = 10;
    }
    public class Salaried_Employees
    {
        public int Id { get; set; }
        [DisplayName("Employee Name")]
        public string EmpName { get; set; }
        [DisplayName("Date of Birth")]
        public DateTime DateOfBirth { get; set; }
        public int Age { get; set; }
        [DisplayName("Date of Joining")]
        public DateTime DateofJoining { get; set; }
        [DisplayName("#of Vacations")]
        public float VacationsTaken { get; set; }
        [DisplayName("Job Type")]
        public string JobType { get; set; }
        [DisplayName("Job Title")]
        public string JobTitle { get; set; }
        public int NoWorkingDays { get; set; } = 260;
        [DisplayName("Days Worked")]
        public int WorkingDays { get; set; } = 0;
        public float Number_Of_Vacation_Days { get; set; } = 15;
    }

    public class Managers
    {
        public int Id { get; set; }
        [DisplayName("Employee Name")]
        public string EmpName { get; set; }
        [DisplayName("Date of Birth")]
        public DateTime DateOfBirth { get; set; }
        public int Age { get; set; }
        [DisplayName("Date of Joining")]
        public DateTime DateofJoining { get; set; }
        [DisplayName("#of Vacations")]
        public float VacationsTaken { get; set; }
        [DisplayName("Job Type")]
        public string JobType { get; set; }
        [DisplayName("Job Title")]
        public string JobTitle { get; set; }

        public int NoWorkingDays { get; set; } = 260;
        [DisplayName("Days Worked")]
        public int WorkingDays { get; set; } = 0;
        public float Number_Of_Vacation_Days { get; set; } = 30;
    }
}