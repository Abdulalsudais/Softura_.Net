
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ClinicManagement.Models;
using ClinicManagement.DAL;

namespace ClinicManagement.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Validate(Users chk)
        {
            if (ModelState.IsValid)
            {
                ClinicDAL dal = new ClinicDAL();
                int result = dal.CheckUser(chk);
                if (result == 1)
                {
                    return RedirectToAction("Homepage");
                }
                else
                {
                    return Content("Enter the Correct username or password");
                }
            }
            else
            {
                return View("Index");

            }
        }
        public IActionResult Homepage()
        {
            return View();
        }
        public IActionResult Doctoradd()
        {
            return View();
        }
        public IActionResult InsertDoctor(Doctor doctor)
        {
            ClinicDAL DALobj = new ClinicDAL();
            int result = DALobj.AddDoctors(doctor);
            if (result == 1)
            {
                return RedirectToAction("Homepage");
            }
            else
                return View("Doctoradd");
        }
        public IActionResult PatientAdd()
        {
            return View();
        }
        public IActionResult InsertPatient(Patient pati)
        {
            ClinicDAL nobj = new ClinicDAL();
            int result = nobj.AddPatient(pati);
            if (result == 1)
            {
                return RedirectToAction("Homepage");
            }
            return View("PatientAdd");
        }
        public IActionResult Scheduleapp()
        {
            return View();
        }
        public IActionResult Addschedule(Schedules sch)
        {
            ClinicDAL dal = new ClinicDAL();
            int result = dal.Addappoint(sch);
            if (result == 1)
            {
                return RedirectToAction("Homepage");
            }
            else
                return View("Scheduleapp");
        }
        public IActionResult Viewappoint()
        {
            ClinicDAL dal = new ClinicDAL();
            List<Schedules> schedules = new List<Schedules>();
            schedules = dal.Getappointments();
            return View(schedules);
        }
        public IActionResult CancelAppmnt(int id)
        {
            ClinicDAL dal = new ClinicDAL();
            int result = dal.DelSchedule(id);
            if (result == 1)
            {
                return RedirectToAction("Homepage");

            }
            else
            {
                return RedirectToAction("Viewappoint");
            }
        }
        public IActionResult Cncappment()
        {
            return RedirectToAction("Homepage");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
