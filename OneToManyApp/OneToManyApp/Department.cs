using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OneToManyApp
{
   public class Department
    {
        public string Code { set; get; }
        public string Name { set; get; }
        public List<Student> students { set; get; }

       private int MAX_SIZE = 2;

        public Department(string code, string name):this()
        {
            Code = code;
            Name = name;
           

        }

       public List<Student> GetStudents()
       {
           return students;
       }
        public string AddStudents(Student aStudent)
        {
            if (students.Count < MAX_SIZE)
            {
                students.Add(aStudent);
                return "Student Added";
            }
            else
            {
                return "Overflow";
            }
        }
       public Department()
        {
            students = new List<Student>();
        }
    }
}
