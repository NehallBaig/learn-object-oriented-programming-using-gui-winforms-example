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
    public partial class Home : BaseScreen
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnTeacher_Click(object sender, EventArgs e)
        {
            TeacherScreen teacherScreen = new TeacherScreen();
            this.Hide();
            teacherScreen.Show();
        }
    }
}
