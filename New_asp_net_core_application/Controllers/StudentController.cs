using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using New_asp_net_core_application.Managers.Students;
using New_asp_net_core_application.Storage;

namespace New_asp_net_core_application.Controllers
{
    public class StudentController : Controller
    {
        private IStudentManager _manager;
        public StudentController(IStudentManager manager)
        {
            _manager = manager;
        }
        public async Task<IActionResult> Index()
        {
            var students = await _manager.GetAll();
            return View(students);
        }

        [HttpPost]
        public async Task<ActionResult> DeleteStudent(int studentid)
        {
            await _manager.Delete(studentid);
            return Redirect(nameof(Index));
        }


        [HttpPost]
        public async Task<ActionResult> AddStudent(string name, string lastName, int groupId)
        {
            await _manager.Add(name, lastName, groupId);
            return Redirect(nameof(Index));
        }

    }
}
