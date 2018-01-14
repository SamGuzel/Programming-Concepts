using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace EnterStudentNames
{
    public partial class EnterStudentNamesForm : Form
    {
        public EnterStudentNamesForm()
        {
            InitializeComponent();
        }

        private void EnterStudentNamesForm_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            txtFirstName.Focus();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter("Names.txt",true))
                {
                    sw.WriteLine(txtFirstName.Text + " " + txtSurname.Text);
                }
                txtFirstName.Clear();
                txtSurname.Clear();
                txtFirstName.Focus();
            }
            catch (System.IO.FileNotFoundException)
            {
                Console.WriteLine("File not found");
            }
            catch (System.IO.IOException ioe)
            {
                Console.WriteLine(ioe.ToString());
            }


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
