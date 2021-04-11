using New_asp_net_core_application.Storage.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace New_asp_net_core_application.Managers.Students
{
    public interface IStudentManager
    {
        Task<ICollection<Student>> GetAll();
        ICollection<Student> GetStudentsByGroup(int groupId);

        Task Delete(int id);

        Task Add(string name, string lastName, int groupId);
    }
}
