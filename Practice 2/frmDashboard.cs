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
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            int time = System.DateTime.Now.ToLocalTime().Hour;
            if (time >= 0) label1.Text = "Good morning, " + Program.strCurrentSession + "!";
            if (time >= 12) label1.Text = "Good afternoon, " + Program.strCurrentSession + "!";
            if (time >= 20) label1.Text = "Good night, " + Program.strCurrentSession + "!";
        }
    }
}
