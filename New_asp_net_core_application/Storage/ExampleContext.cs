using New_asp_net_core_application.Storage.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace New_asp_net_core_application.Storage
{
    public class ExampleContext             // Общаюсь с базой данных
    {
        public List<Student> Students;
        public List<Group> Groups;

        public ExampleContext()
        {
         /*   Students = new List<Student>();
            Groups = new List<Group>();


            var group1 = new Group(Guid.NewGuid(), "ИДБ-18-01", "ИТиВС ПО");
            var group2 = new Group(Guid.NewGuid(), "ИДБ-18-02", "ИТиВС ПО");
            var group3 = new Group(Guid.NewGuid(), "ИДБ-18-03", "ИТиВС ПО");
            var group4 = new Group(Guid.NewGuid(), "ИДБ-18-04", "ИТиВС Аналитика");

            Students.Add(new Student(Guid.NewGuid(), "Иванов1", "Иван1", group1));
            Students.Add(new Student(Guid.NewGuid(), "Иванов2", "Иван2", group2));
            Students.Add(new Student(Guid.NewGuid(), "Иванов3", "Иван3", group3));
            Students.Add(new Student(Guid.NewGuid(), "Иванов4", "Иван4", group4));

            Groups.Add(group1);
            Groups.Add(group2);
            Groups.Add(group3);
            Groups.Add(group4);*/



        }


        
    }
}
