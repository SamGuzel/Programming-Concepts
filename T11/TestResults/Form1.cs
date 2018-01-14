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
    public partial class TestResults : Form
    {
        public TestResults()
        {
            InitializeComponent();
        }
        

        private void TestResults_Load(object sender, EventArgs e)
        {
            this.Hide();
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

            Prompt Prom = new Prompt();
            Prom.Students = students.ToArray();
        }
    }
}
