namespace WinFormsApp1
{
    public partial class BaseScreen : Form
    {
        public BaseScreen()
        {
            InitializeComponent();
        }

        private void BaseScreen_Load(object sender, EventArgs e)
        {
            // Maximize the form
            //this.WindowState = FormWindowState.Maximized;

            this.StartPosition = FormStartPosition.CenterScreen;

        }
    }
}
