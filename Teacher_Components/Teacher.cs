using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Csharp_Students_Management.Courses;

namespace Csharp_Students_Management.Teacher_Components
{
    internal class Teacher
    {
        private int id_teacher { get; set; }
        private string name { get; set; }
        private string surname { get; set; }
        private int age { get; set; }
        private string email { get; set; }
        private string password { get; set; }
        private string phone { get; set; }
        private List<Course> courses_taught   { get; set; }

        //constructor with parameters
        public Teacher(int id, string name, string surname, int age, string email, string password, string phone)
        {
            this.id_teacher = id;
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.email = email;
            this.password = password;
            this.phone = phone;
            this.courses_taught = new List<Course>();
        }
        //default constructor
        public Teacher()
        {
            this.id_teacher = 0;
            this.name = string.Empty;
            this.surname = string.Empty;
            this.age = 0;
            this.email = string.Empty;
            this.password = string.Empty;
            this.phone = string.Empty;
            this.courses_taught = new List<Course>();
        }
    }
}
