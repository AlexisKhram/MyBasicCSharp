namespace WinCollApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            string[] animals = new[] { "����", "������", "�������", "��������", "���", "�������" };
            txtOutput.Text = "������� ������� � ����� 1.11" + Environment.NewLine;
            // ����� �������
            txtOutput.Text += Environment.NewLine;
            txtOutput.Text += "����� ������� ��������" + Environment.NewLine;
            foreach (string item in animals)
            {
                txtOutput.Text += item + " ";
            }
            txtOutput.Text += Environment.NewLine;
            // ����� ������
            //var lstAnimals
            List<string> lstAnimals = animals.ToList();
            txtOutput.Text += Environment.NewLine;
            txtOutput.Text += "����� ������ ��������" + Environment.NewLine;
            foreach (string item in lstAnimals)
            {
                txtOutput.Text += item + " ";
            }
            txtOutput.Text += Environment.NewLine;
            lstAnimals.Add("�����");
            txtOutput.Text += Environment.NewLine;
            txtOutput.Text += "����� ���������� ������ ��������" + Environment.NewLine;
            foreach (string item in lstAnimals)
            {
                txtOutput.Text += item + " ";
            }
            /* ��������������� ����� �������
            txtOutput.Text += Environment.NewLine;
            txtOutput.Text += Environment.NewLine;
            txtOutput.Text += "����� ������� ��������" + Environment.NewLine;
            Dictionary<string, string> dicanimals = new Dictionary<string, string>();
            dicanimals.Add("��������", "������");
            dicanimals.Add("������", "������");
            dicanimals.Add("���������", "����");
            dicanimals.Add("���������", "�������");
            foreach (var item in dicanimals)
            {
                txtOutput.Text += item + Environment.NewLine;
            }
            */

        }
    }
}