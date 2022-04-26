using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LabCorp.Models;

namespace LabCorp.Controllers
{
    public class LabCorpController : Controller
    {
        // GET: LabCorp
        public ActionResult Index()
        {
            List<EmployeeType> employeeType = new List<EmployeeType>();
            List<Salaried_Employees> salariedEmployeeType = new List<Salaried_Employees>();
            List<Hourly_Employees> hourly_Employees = new List<Hourly_Employees>();
            List<Managers> managers = new List<Managers>();
            if (Session["EmployeeDetails"] == null)
            {
                //adding items into the list
                salariedEmployeeType.Add(new Salaried_Employees { Age = 32, DateOfBirth = DateTime.Now.AddMonths(-(12 * 32)).AddDays(-10), DateofJoining = DateTime.Now.AddMonths(-10).AddDays(-100), EmpName = "John Doe", Id = 10001, JobTitle = "Software Engineer L1", JobType = "Full Time" });
                salariedEmployeeType.Add(new Salaried_Employees { Age = 33, DateOfBirth = DateTime.Now.AddMonths(-(12 * 33)).AddDays(-20), DateofJoining = DateTime.Now.AddMonths(-11).AddDays(-90), EmpName = "Alex Kim", Id = 10002, JobTitle = "Software Engineer L2", JobType = "Full Time" });
                salariedEmployeeType.Add(new Salaried_Employees { Age = 34, DateOfBirth = DateTime.Now.AddMonths(-(12 * 34)).AddDays(-30), DateofJoining = DateTime.Now.AddMonths(-12).AddDays(-80), EmpName = "Robert Jim", Id = 10003, JobTitle = "Software Engineer L3", JobType = "Full Time" });
                salariedEmployeeType.Add(new Salaried_Employees { Age = 35, DateOfBirth = DateTime.Now.AddMonths(-(12 * 35)).AddDays(-10), DateofJoining = DateTime.Now.AddMonths(-13).AddDays(-70), EmpName = "Thomas Aliison", Id = 10004, JobTitle = "Technical Lead", JobType = "Full Time" });
                salariedEmployeeType.Add(new Salaried_Employees { Age = 36, DateOfBirth = DateTime.Now.AddMonths(-(12 * 36)).AddDays(-10), DateofJoining = DateTime.Now.AddMonths(-14).AddDays(-60), EmpName = "Johnson Mark", Id = 10005, JobTitle = "Software Engineer", JobType = "Full Time" });
                salariedEmployeeType.Add(new Salaried_Employees { Age = 37, DateOfBirth = DateTime.Now.AddMonths(-(12 * 37)).AddDays(-50), DateofJoining = DateTime.Now.AddMonths(-15).AddDays(-50), EmpName = "North East", Id = 10006, JobTitle = "Software Engineer", JobType = "Full Time" });
                salariedEmployeeType.Add(new Salaried_Employees { Age = 38, DateOfBirth = DateTime.Now.AddMonths(-(12 * 38)).AddDays(-60), DateofJoining = DateTime.Now.AddMonths(-16).AddDays(-40), EmpName = "South West", Id = 10007, JobTitle = "Software Engineer", JobType = "Full Time" });
                salariedEmployeeType.Add(new Salaried_Employees { Age = 39, DateOfBirth = DateTime.Now.AddMonths(-(12 * 39)).AddDays(-180), DateofJoining = DateTime.Now.AddMonths(-17).AddDays(-30), EmpName = "Mirinda Soda", Id = 10008, JobTitle = "Software Engineer", JobType = "Full Time" });
                salariedEmployeeType.Add(new Salaried_Employees { Age = 25, DateOfBirth = DateTime.Now.AddMonths(-(12 * 25)).AddDays(-100), DateofJoining = DateTime.Now.AddMonths(-18).AddDays(-90), EmpName = "Dim Dom", Id = 10009, JobTitle = "Quality Tester", JobType = "Full Time" });
                salariedEmployeeType.Add(new Salaried_Employees { Age = 36, DateOfBirth = DateTime.Now.AddMonths(-(12 * 36)).AddDays(-90), DateofJoining = DateTime.Now.AddMonths(-19).AddDays(-60), EmpName = "Jim Jam", Id = 10010, JobTitle = "Jr Quality Tester", JobType = "Full Time" });

                hourly_Employees.Add(new Hourly_Employees { Age = 32, DateOfBirth = DateTime.Now.AddMonths(-(12 * 32)).AddDays(-10), DateofJoining = DateTime.Now.AddMonths(-10).AddDays(-100), EmpName = "John Doe", Id = 10011, JobTitle = "Software Engineer L1", JobType = "Contractor" });
                hourly_Employees.Add(new Hourly_Employees { Age = 33, DateOfBirth = DateTime.Now.AddMonths(-(12 * 33)).AddDays(-20), DateofJoining = DateTime.Now.AddMonths(-11).AddDays(-90), EmpName = "Alex Kim", Id = 10012, JobTitle = "Software Engineer L2", JobType = "Contractor" });
                hourly_Employees.Add(new Hourly_Employees { Age = 34, DateOfBirth = DateTime.Now.AddMonths(-(12 * 34)).AddDays(-30), DateofJoining = DateTime.Now.AddMonths(-12).AddDays(-80), EmpName = "Robert Jim", Id = 10013, JobTitle = "Software Engineer L3", JobType = "Contractor" });
                hourly_Employees.Add(new Hourly_Employees { Age = 35, DateOfBirth = DateTime.Now.AddMonths(-(12 * 35)).AddDays(-10), DateofJoining = DateTime.Now.AddMonths(-13).AddDays(-70), EmpName = "Thomas Aliison", Id = 10014, JobTitle = "Technical Lead", JobType = "Contractor" });
                hourly_Employees.Add(new Hourly_Employees { Age = 36, DateOfBirth = DateTime.Now.AddMonths(-(12 * 36)).AddDays(-10), DateofJoining = DateTime.Now.AddMonths(-14).AddDays(-60), EmpName = "Johnson Mark", Id = 10015, JobTitle = "Manager", JobType = "Contractor" });
                hourly_Employees.Add(new Hourly_Employees { Age = 37, DateOfBirth = DateTime.Now.AddMonths(-(12 * 37)).AddDays(-50), DateofJoining = DateTime.Now.AddMonths(-15).AddDays(-50), EmpName = "North East", Id = 10016, JobTitle = "Project Manager", JobType = "Contractor" });
                hourly_Employees.Add(new Hourly_Employees { Age = 38, DateOfBirth = DateTime.Now.AddMonths(-(12 * 38)).AddDays(-60), DateofJoining = DateTime.Now.AddMonths(-16).AddDays(-40), EmpName = "South West", Id = 10017, JobTitle = "Delivery Manager", JobType = "Contractor" });
                hourly_Employees.Add(new Hourly_Employees { Age = 39, DateOfBirth = DateTime.Now.AddMonths(-(12 * 39)).AddDays(-180), DateofJoining = DateTime.Now.AddMonths(-17).AddDays(-30), EmpName = "Mirinda Soda", Id = 10018, JobTitle = "Resource Manager", JobType = "Contractor" });
                hourly_Employees.Add(new Hourly_Employees { Age = 25, DateOfBirth = DateTime.Now.AddMonths(-(12 * 25)).AddDays(-100), DateofJoining = DateTime.Now.AddMonths(-18).AddDays(-90), EmpName = "Dim Dom", Id = 10019, JobTitle = "Quality Tester", JobType = "Contractor" });
                hourly_Employees.Add(new Hourly_Employees { Age = 36, DateOfBirth = DateTime.Now.AddMonths(-(12 * 36)).AddDays(-90), DateofJoining = DateTime.Now.AddMonths(-19).AddDays(-60), EmpName = "Jim Jam", Id = 10020, JobTitle = "Jr Quality Tester", JobType = "Contractor" });
                hourly_Employees.Add(new Hourly_Employees { Age = 27, DateOfBirth = DateTime.Now.AddMonths(-(12 * 27)).AddDays(-80), DateofJoining = DateTime.Now.AddMonths(-20).AddDays(-8), EmpName = "Rock Joe", Id = 10021, JobTitle = "Test Lead", JobType = "Contractor" });
                hourly_Employees.Add(new Hourly_Employees { Age = 28, DateOfBirth = DateTime.Now.AddMonths(-(12 * 28)).AddDays(-70), DateofJoining = DateTime.Now.AddMonths(-1).AddDays(-90), EmpName = "Joel H", Id = 10022, JobTitle = "Business Analyst", JobType = "Contractor" });

                managers.Add(new Managers { Age = 32, DateOfBirth = DateTime.Now.AddMonths(-(12 * 32)).AddDays(-10), DateofJoining = DateTime.Now.AddMonths(-10).AddDays(-100), EmpName = "John Doe", Id = 10023, JobTitle = "Manager L1", JobType = "Full Time" });
                managers.Add(new Managers { Age = 33, DateOfBirth = DateTime.Now.AddMonths(-(12 * 33)).AddDays(-20), DateofJoining = DateTime.Now.AddMonths(-11).AddDays(-90), EmpName = "Alex Kim", Id = 100024, JobTitle = "Manager L2", JobType = "Full Time" });
                managers.Add(new Managers { Age = 34, DateOfBirth = DateTime.Now.AddMonths(-(12 * 34)).AddDays(-30), DateofJoining = DateTime.Now.AddMonths(-12).AddDays(-80), EmpName = "Robert Jim", Id = 100043, JobTitle = "Manager L3", JobType = "Full Time" });
                managers.Add(new Managers { Age = 35, DateOfBirth = DateTime.Now.AddMonths(-(12 * 35)).AddDays(-10), DateofJoining = DateTime.Now.AddMonths(-13).AddDays(-70), EmpName = "Thomas Aliison", Id = 10044, JobTitle = "Technical Manager", JobType = "Full Time" });
                managers.Add(new Managers { Age = 36, DateOfBirth = DateTime.Now.AddMonths(-(12 * 36)).AddDays(-10), DateofJoining = DateTime.Now.AddMonths(-14).AddDays(-60), EmpName = "Johnson Mark", Id = 10045, JobTitle = "Manager", JobType = "Full Time" });
                managers.Add(new Managers { Age = 37, DateOfBirth = DateTime.Now.AddMonths(-(12 * 37)).AddDays(-50), DateofJoining = DateTime.Now.AddMonths(-15).AddDays(-50), EmpName = "North East", Id = 10046, JobTitle = "Project Manager", JobType = "Full Time" });
                managers.Add(new Managers { Age = 38, DateOfBirth = DateTime.Now.AddMonths(-(12 * 38)).AddDays(-60), DateofJoining = DateTime.Now.AddMonths(-16).AddDays(-40), EmpName = "South West", Id = 10047, JobTitle = "Delivery Manager", JobType = "Full Time" });
                managers.Add(new Managers { Age = 39, DateOfBirth = DateTime.Now.AddMonths(-(12 * 39)).AddDays(-180), DateofJoining = DateTime.Now.AddMonths(-17).AddDays(-30), EmpName = "Mirinda Soda", Id = 10048, JobTitle = "Resource Manager", JobType = "Full Time" });
                managers.Add(new Managers { Age = 25, DateOfBirth = DateTime.Now.AddMonths(-(12 * 25)).AddDays(-100), DateofJoining = DateTime.Now.AddMonths(-18).AddDays(-90), EmpName = "Dim Dom", Id = 10049, JobTitle = "Quality Manager", JobType = "Full Time" });
                managers.Add(new Managers { Age = 36, DateOfBirth = DateTime.Now.AddMonths(-(12 * 36)).AddDays(-90), DateofJoining = DateTime.Now.AddMonths(-19).AddDays(-60), EmpName = "Jim Jam", Id = 10050, JobTitle = "Jr Quality Manager", JobType = "Full Time" });
                managers.Add(new Managers { Age = 27, DateOfBirth = DateTime.Now.AddMonths(-(12 * 27)).AddDays(-80), DateofJoining = DateTime.Now.AddMonths(-20).AddDays(-8), EmpName = "Rock Joe", Id = 10051, JobTitle = "Senior Manager", JobType = "Full Time" });
                managers.Add(new Managers { Age = 28, DateOfBirth = DateTime.Now.AddMonths(-(12 * 28)).AddDays(-70), DateofJoining = DateTime.Now.AddMonths(-1).AddDays(-90), EmpName = "Joel H", Id = 10052, JobTitle = "Business Manager", JobType = "Full Time" });

                employeeType.AddRange(managers.Select(x => new EmployeeType()
                {
                    Age = x.Age,
                    DateOfBirth = x.DateOfBirth,
                    EmpName = x.EmpName,
                    Id = x.Id,
                    DateofJoining = x.DateofJoining,
                    JobTitle = x.JobTitle,
                    JobType = x.JobType,
                    NoWorkingDays = x.NoWorkingDays,
                    Number_Of_Vacation_Days = x.Number_Of_Vacation_Days,
                    VacationsTaken = x.VacationsTaken,
                    WorkingDays = x.WorkingDays
                }).ToList());

                employeeType.AddRange(hourly_Employees.Select(x => new EmployeeType()
                {
                    Age = x.Age,
                    DateOfBirth = x.DateOfBirth,
                    EmpName = x.EmpName,
                    Id = x.Id,
                    DateofJoining = x.DateofJoining,
                    JobTitle = x.JobTitle,
                    JobType = x.JobType,
                    NoWorkingDays = x.NoWorkingDays,
                    Number_Of_Vacation_Days = x.Number_Of_Vacation_Days,
                    VacationsTaken = x.VacationsTaken,
                    WorkingDays = x.WorkingDays
                }).ToList());

                employeeType.AddRange(salariedEmployeeType.Select(x => new EmployeeType()
                {
                    Age = x.Age,
                    DateOfBirth = x.DateOfBirth,
                    EmpName = x.EmpName,
                    Id = x.Id,
                    DateofJoining = x.DateofJoining,
                    JobTitle = x.JobTitle,
                    JobType = x.JobType,
                    NoWorkingDays = x.NoWorkingDays,
                    Number_Of_Vacation_Days = x.Number_Of_Vacation_Days,
                    VacationsTaken = x.VacationsTaken,
                    WorkingDays = x.WorkingDays
                }).ToList());
            }
            else
            {
                //Retrieved the list of employee details. Now I will pass the id into the list (filter) and update the no of working days
                employeeType = (List<EmployeeType>)Session["EmployeeDetails"];
            }
            employeeType = employeeType.OrderBy(x=>x.Id).ToList();

            ViewData["EmployeeDetails"] = employeeType.ToList();
            Session["EmployeeDetails"] = employeeType.ToList();
            return View();
        }

        [HttpPost]
        public ActionResult UpdateEmployeeWorkDetails(int Id, int WorkingDays)
        {
            List<EmployeeType> employeeType = new List<EmployeeType>();
            try
            {
                if (Session["EmployeeDetails"] != null)
                {
                    //Retrieved the list of employee details. Now I will pass the id into the list (filter) and update the no of working days
                    employeeType = (List<EmployeeType>)Session["EmployeeDetails"];
                    foreach (var employee in employeeType)
                    {
                        if (employee.Id == Id)
                        {
                            if (WorkingDays < employee.NoWorkingDays)
                            {
                                employee.WorkingDays = employee.WorkingDays + WorkingDays;

                                if(employee.Number_Of_Vacation_Accumulated < employee.Number_Of_Vacation_Days)
                                    employee.Number_Of_Vacation_Accumulated =  (employee.Number_Of_Vacation_Accumulated + (float)Math.Round(WorkingDays * (employee.Number_Of_Vacation_Days / employee.NoWorkingDays), 2));
                            }
                        }
                    }
                }
                ViewData["EmployeeDetails"] = employeeType.ToList();
                Session["EmployeeDetails"] = ViewData["EmployeeDetails"];
            }
            catch (Exception ex)
            {

            }
            return View("Index");
        }

        public ActionResult UpdateEmployeeVacationDetails(int Id, float VacationsTaken)
        {
            List<EmployeeType> employeeType = new List<EmployeeType>();
            try
            {
                if (Session["EmployeeDetails"] != null)
                {
                    //Retrieved the list of employee details. Now I will pass the id into the list (filter) and update the no of working days
                    employeeType = (List<EmployeeType>)Session["EmployeeDetails"];
                    foreach (var employee in employeeType)
                    {
                        if (employee.Id == Id)
                        {
                            if (employee.VacationsTaken < employee.Number_Of_Vacation_Days)
                            {                                
                                if(employee.Number_Of_Vacation_Accumulated - VacationsTaken > 0)
                                {
                                    employee.VacationsTaken = employee.VacationsTaken + VacationsTaken;
                                    employee.Number_Of_Vacation_Accumulated = employee.Number_Of_Vacation_Accumulated - VacationsTaken;
                                }                               
                                else
                                {
                                    EmployeeType employeeType_1 = new EmployeeType();
                                    employeeType_1 = employeeType.Where(x => x.Id == Id).FirstOrDefault();
                                    ViewData["Message"] = "You don't have enough vacations to take";
                                    return View("UpdateVacationDetails", employeeType_1);
                                }
                            }
                        }
                    }
                }
                ViewData["EmployeeDetails"] = employeeType.ToList();
                Session["EmployeeDetails"] = ViewData["EmployeeDetails"];
            }
            catch (Exception ex)
            {

            }
            return View("Index");
        }

        public ActionResult UpdateWorkDetails(int Id)
        {
            List<EmployeeType> employeeType = new List<EmployeeType>();
            EmployeeType employeeType_1 = new EmployeeType();
            try
            {
                if (Session["EmployeeDetails"] != null)
                {
                    //Retrieved the list of employee details. Now I will pass the id into the list (filter) and update the no of working days
                    employeeType = (List<EmployeeType>)Session["EmployeeDetails"];
                    employeeType_1 = employeeType.Where(x => x.Id == Id).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {

            }
            return View(employeeType_1);
        }

        public ActionResult UpdateVacationDetails(int Id)
        {
            List<EmployeeType> employeeType = new List<EmployeeType>();
            EmployeeType employeeType_1 = new EmployeeType();
            try
            {
                if (Session["EmployeeDetails"] != null)
                {
                    //Retrieved the list of employee details. Now I will pass the id into the list (filter) and update the no of working days
                    employeeType = (List<EmployeeType>)Session["EmployeeDetails"];
                    employeeType_1 = employeeType.Where(x => x.Id == Id).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {

            }
            return View(employeeType_1);
        }
    }
}