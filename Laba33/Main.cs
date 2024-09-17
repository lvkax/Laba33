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
                tbPhonesInfo.Text = tbPhonesInfo.Text + string.Format($"\r\n\nFirm:{phone.Name}; Model:{phone.Model}; Cost:{phone.Cost}$; Release year:{phone.ReleaseYear};" +
                    $"Guarantee ending:{phone.GaranteEndingYear}; Battery capacity:{phone.BatteryCapacity} mA/h;") +
                    string.Format(phone.Has3Cameras ? "�� ��� ������; " : "�� �� ��� ������; ") +
                    string.Format(phone.HasWirelessCharging ? "� ���������� �������; " : "���� ���������� �������;");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("��������� ������ ����������?", "��������� ������",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}