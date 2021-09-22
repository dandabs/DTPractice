using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = "user";
            string password = "pass";
            if (tbxUsername.Text == username && tbxPassword.Text == password)
            {
                Program.strCurrentSession = username;
                new frmDashboard().Show();
                this.Hide();
            } else
            {
                MessageBox.Show("Incorrect username and/or password, please try again.", "Error");
            }
        }
    }
}
