namespace LSPU_dventure
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        //options
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Options opt = new Options();
            opt.ShowDialog();
            this.Close();
        }
        //About us
        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            AboutUs abt = new AboutUs();
            abt.ShowDialog();
            this.Close();
        }

        private void startbutton2_Click(object sender, EventArgs e)
        {

        }

        private void exitbutton5_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to exit?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        
    }
}
