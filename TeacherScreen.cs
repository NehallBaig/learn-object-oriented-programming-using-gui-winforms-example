using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedGui
{
    public partial class TeacherScreen : Screen2
    {
        public TeacherScreen()
        {
            InitializeComponent();
            
        }

        //if i dont override method in child class so parent class method will be executed 

        override
        public void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I am teacher's class Insert method");
        }

        override
        public void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I am teacher's class update method");
        }

        override
        public void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I am teacher's class delete method");
        }
    }
}
