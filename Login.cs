using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1;

namespace ObjectOrientedGui
{
    public partial class Login : BaseScreen
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text.Equals("admin") && txtPassword.Text.Equals("admin"))
            {
                Home home = new Home();
                this.Hide();
                home.Show();
            }
        }
    }
}
