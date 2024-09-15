namespace Laba33
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

        }

        private void btnAddPhone_Click(object sender, EventArgs e)
        {
            Phone phone = new Phone();
            fPhone fp = new fPhone(phone);

            if (fp.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = string.Format("амамоам");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Припинити роботу застосунку?", "Припинити роботу",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}