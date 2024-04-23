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
    public partial class Screen2 : BaseScreen
    {
        public Screen2()
        {
            InitializeComponent();
        }

        virtual
        public void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I am parent's class Insert method");
        }

        virtual
        public void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I am parent's class update method");
        }

        virtual
        public void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I am parent's class delete method");
        }

        private void Screen2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();

                Home home = new Home();
                home.Show();
            }
        }
    }
}
