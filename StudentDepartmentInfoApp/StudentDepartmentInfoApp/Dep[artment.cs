using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDepartmentInfoApp
{
    public class Department
    {
        public string Code { set; get; }
        public string Name { set; get; }
        private List<Student> students;

        public string AddStudent(Student aStudent)
        {
            if (students.Count<2)
            {
                students.Add(aStudent);
                return "Student Added";
            }
            else
            {
                return "Overflow";
            }
        }

        public Department(string code, string name) : this()
        {
            Code = code;
            Name = name;
        }

        public Department()
        {
            students=new List<Student>();
        }

        public Student[] GetStudents()
        {
            return students.ToArray();
        } 
    }
}
