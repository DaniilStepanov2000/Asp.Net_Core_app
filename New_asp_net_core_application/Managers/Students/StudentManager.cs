using New_asp_net_core_application.Storage.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using New_asp_net_core_application.Storage;
using Microsoft.EntityFrameworkCore;

namespace New_asp_net_core_application.Managers.Students
{
    public class StudentManager : IStudentManager
    {
        private UniversityContext _context; // общаюсь с базой данных (получаю модели)

        public StudentManager(UniversityContext context)
        {
            _context = context;
        }

        public async Task Add(string name, string lastName, int groupId)
        {
            var student = new Student();
            student.Name = name;
            student.LastName = lastName;
            student.GroupId = groupId;
            await _context.Students.AddAsync(student);
            await _context.SaveChangesAsync();

        }

        public async Task Delete(int id)
        {
            var student = await _context.Students.FirstOrDefaultAsync(st => st.Id == id);
            if (student != null)
            {
                _context.Students.Remove(student);
                await _context.SaveChangesAsync();
            }

        }

        public async Task<ICollection<Student>> GetAll()
        {
            return await _context.Students.Include(st => st.Group).ToListAsync(); ;
        }

        public ICollection<Student> GetStudentsByGroup(int groupId)
        {
            return _context.Students.Where(st => st.Group.Id == groupId).ToList();
        }


    }
}
