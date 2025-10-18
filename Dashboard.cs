namespace Code_NT106.Q14._2_Lab02_24521213
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnBai01_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Bai01().ShowDialog();
            this.Show();
        }

        private void btnBai2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Bai02().ShowDialog();
            this.Show();
        }

        private void btnBai3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Bai03().ShowDialog();
            this.Show();
        }

        private void btnBai4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Bai04().ShowDialog();
            this.Show();
        }

        private void btnBai5_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Bai05().ShowDialog();
            this.Show();
        }

        private void btnBai6_Click(object sender, EventArgs e)
        {

        }

        private void btnBai7_Click(object sender, EventArgs e)
        {

        }
    }
}
