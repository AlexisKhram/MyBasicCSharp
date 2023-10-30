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
            string[] animals = new[] { "слон", "буйвол", "бегемот", "антилопа", "лев", "леопард" };
            txtOutput.Text = "Решение заданий к уроку 1.11" + Environment.NewLine;
            // Вывод массива
            txtOutput.Text += Environment.NewLine;
            txtOutput.Text += "Вывод массива животных" + Environment.NewLine;
            foreach (string item in animals)
            {
                txtOutput.Text += item + " ";
            }
            txtOutput.Text += Environment.NewLine;
            // Вывод списка
            //var lstAnimals
            List<string> lstAnimals = animals.ToList();
            txtOutput.Text += Environment.NewLine;
            txtOutput.Text += "Вывод списка животных" + Environment.NewLine;
            foreach (string item in lstAnimals)
            {
                txtOutput.Text += item + " ";
            }
            txtOutput.Text += Environment.NewLine;
            lstAnimals.Add("жираф");
            txtOutput.Text += Environment.NewLine;
            txtOutput.Text += "Вывод изменённого списка животных" + Environment.NewLine;
            foreach (string item in lstAnimals)
            {
                txtOutput.Text += item + " ";
            }
            txtOutput.Text += Environment.NewLine;
            txtOutput.Text += Environment.NewLine;
            txtOutput.Text += "Вывод словаря животных" + Environment.NewLine;
            Dictionary<string, string> dicanimals = new Dictionary<string, string>();
            dicanimals.Add("Молочная", "Корова");
            dicanimals.Add("Мясная", "Свинья");
            dicanimals.Add("Шерстяная", "Овца");
            dicanimals.Add("Комнатная", "Собачка");
            foreach (var item in dicanimals)
            {
                txtOutput.Text += item + Environment.NewLine;
            }


        }
    }
}