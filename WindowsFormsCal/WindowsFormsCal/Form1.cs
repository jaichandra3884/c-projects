using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsCal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {

            if (Username.Text == "jaichandra" && Password.Text == "2016cse249")
            {
                FORM2 f = new FORM2();
                MessageBox.Show("LOGIN SUCCESSFUL");
                f.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("LOGIN UNSUCCESSFUL");
            }
        }
    }
}
