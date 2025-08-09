using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Csharp_Students_Management.Courses;

namespace Csharp_Students_Management.Students_Components
{
    internal class Student
    { 
        private int id_stud { get; set; }
        private string name { get; set; }
        private string surname { get; set; }
        private int age { get; set; }
        private string email { get; set; }
        private string password { get; set; }
        private string phone { get; set; }
        private string city { get; set; }
        private string address { get; set; }
        private string birthDate { get; set; }
        private List<Course> course_enrolled { get; set; }
        private List<Grades> list_of_grades { get; set; }
        private float average_grade { get; set; }

        //constructor with parameters
        public Student(int id, string name, string surname, int age, string email,string password, string phone, string city, string address, string birthDate)
        {
            this.id_stud = id;
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.email = email;
            this.password = password;
            this.phone = phone;
            this.city = city;
            this.address = address;
            this.birthDate = birthDate;
            this.course_enrolled = new List<Course>();
            this.list_of_grades = new List<Grades>();
        }
        //default constructor
        public Student()
        {
            this.id_stud = 0;
            this.name = string.Empty;
            this.surname = string.Empty;
            this.age = 0;
            this.email = string.Empty;
            this.password = string.Empty;
            this.phone = string.Empty;
            this.city = string.Empty;
            this.address = string.Empty;
            this.birthDate = string.Empty;
            this.course_enrolled = new List<Course>();
            this.list_of_grades = new List<Grades>();
        }



    }
}
