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
                tbPhonesInfo.Text = string.Format($"Firm:{phone.Name}; Model:{phone.Model}; Cost:{phone.Cost}$; Release year:{phone.ReleaseYear};" +
                    $"Guarantee ending:{phone.GaranteEndingYear}; Battery capacity:{phone.BatteryCapacity} mA/h;",
                    phone.Has3Cameras ? "Має три камери; " : "Не має три камери; ", phone.HasWirelessCharging ? "Є бездротова зарядка; " : "Немає бездротової зарядкиж; \n\n");
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