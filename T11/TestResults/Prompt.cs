using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestResults
{
    public partial class Prompt : Form
    {
        public Prompt()
        {
            InitializeComponent();
        }
        public string[] Students;

        public int currentStudent = 0;

        private void Prompt_Load(object sender, EventArgs e)
        {
            GetStudents();
            lblStudentName.Text = Students[currentStudent];
            lblCurrentStudent.Text = "" + (currentStudent + 1);
            lblMaxStudents.Text = "" + Students.Length;
            txtPercent.Focus();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            WriteScore(int.Parse(txtPercent.Text), Students[currentStudent]);
            if (currentStudent != Students.Length - 1)
            {
                currentStudent++;
                lblCurrentStudent.Text = "" + (currentStudent + 1);
                lblStudentName.Text = Students[currentStudent];
                txtPercent.Clear();
                txtPercent.Focus();
            }
            else
            {
                txtPercent.ReadOnly = true;
                btnSubmit.Visible = false;
                txtPercent.Text = "no more students";
                lblStudentName.Text = "no more students";
            }

        }
        private void WriteScore(int score, string studentName)
        {
            if (score >= 40)
            {
                using (StreamWriter sw = new StreamWriter("Pass.txt", true))
                {
                    sw.WriteLine(studentName + " : " + score.ToString());
                }
            }
            else
            {
                using (StreamWriter sw = new StreamWriter("Fail.txt", true))
                {
                    sw.WriteLine(studentName + " : " + score.ToString());
                }
            }
        }
        private void GetStudents()
        {
            List<string> students = new List<string>();
            using (StreamReader sr = new StreamReader("Names.txt"))
            {
                string line;
                // Read and display lines from the file until the end of 
                // the file is reached.
                while ((line = sr.ReadLine()) != null)
                {
                    //Console.WriteLine(line);
                    students.Add(line);
                }
            }
            Students = students.ToArray();
        }
    }
}
