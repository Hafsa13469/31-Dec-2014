using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OneToManyApp
{
  
    public partial class StudentEntryUI : Form
    {
        public Department aDepartment;
        public StudentEntryUI()
        {
            InitializeComponent();
        }

        private void deptSaveButton_Click(object sender, EventArgs e)
        {
            aDepartment = new Department(deptCodeTextBox.Text,deptNameTextBox.Text);
            MessageBox.Show("Department Saved");

        }

        private void studentSaveButton_Click(object sender, EventArgs e)
        {
            Student aStudent = new Student(studentRegNoTextBox.Text, studentNameTextBox.Text, emailTextBox.Text);
            //aDepartment.Students.Add(aStudent);
            string msg = aDepartment.AddStudents(aStudent);
            MessageBox.Show(msg);
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            string info = "Code: " + aDepartment.Code + "Name: " + aDepartment.Name + "\n";
            info += "Student Reg No:\tName\tEmail\n";
            foreach(Student aStudent in aDepartment.GetStudents())
            {
                string aRow = aStudent.RegNo + "\t\t" + aStudent.Name + "\t\t" + aStudent.Email + "\n";
                info += aRow;
            }
            MessageBox.Show(info);
        }
    }
}
