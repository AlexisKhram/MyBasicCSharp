namespace WinOopApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            // textOutput.Text = "Hello, World!";
            textOutput.Text = "Решение задания к уроку 1.10" + Environment.NewLine;
            textOutput.Text += Environment.NewLine;
            /*
            // Инкапсуляция 

            Person p1 = new Person("Иван", "Петров", "И" );
            Person p2 = new Person("Ольга","Ивановна", "Сергеева", "О", "И");

            textOutput.Text += p1.FirstName + Environment.NewLine;
            textOutput.Text += p2.FirstName + Environment.NewLine;

            textOutput.Text += Environment.NewLine;
            textOutput.Text += p1.GetFullName() + Environment.NewLine;
            textOutput.Text += p2.GetFullName() + Environment.NewLine;

            textOutput.Text += Environment.NewLine;
            textOutput.Text += p1.GetShortName() + Environment.NewLine;
            textOutput.Text += p2.GetShortName() + Environment.NewLine;
          
            // Наследование
            textOutput.Text+= Environment.NewLine;
            Driver p3 = new Driver("Пётр", "Иванович", "Кузнецов", "П", "И", "12345");
            textOutput.Text += p3.GetFullName() + Environment.NewLine;
            textOutput.Text += p3.GetInfo() + Environment.NewLine;

            // Полиморфизм
            textOutput.Text += Environment.NewLine;
            Person[] persons = new Person[] { p1, p2, p3 };
            foreach (Person person in persons)
            {
                textOutput.Text += person.GetInfo() + Environment.NewLine; 
            }
            */
            /*
            Divide1(8, 2);
            textOutput.Text += Environment.NewLine;
            Divide2(8, 2);
            Divide2(8, 0);
            textOutput.Text += Environment.NewLine;
            Divide3(8, 2);
            Divide3(8, 0);
            textOutput.Text += Environment.NewLine;
            Divide4(8, 2);
            Divide4(8, 0);
            textOutput.Text += Environment.NewLine;
            Divide5(8, 2);
            Divide5(8, 0);
            textOutput.Text += Environment.NewLine;
            Divide6(8, 2);
            Divide6(8, 0);
            textOutput.Text += Environment.NewLine;
            */
            /*
            int[] arr1 = { 27, 35, 42, 2, 4, 78 };
            int imass;
            imass = 3;
            Elemmass1(arr1, imass);
            imass = 8;
            Elemmass1(arr1, imass);
            textOutput.Text += Environment.NewLine;
            imass = 1;
            Elemmass2(arr1, imass);
            imass = 8;
            Elemmass2(arr1, imass);
            */
            string[] colors = { "красный", "синий", "зелёный", "жёлтый" };
            string mycolor = "синий";
            Choose1(colors, mycolor);
            textOutput.Text += Environment.NewLine;
            mycolor = "серобуромалиновый";
            Choose1(colors, mycolor);

            /*
            try
            {
                Divide7(8, 0);
            }
            catch (Exception exc)
            {
                textOutput.Text += exc.Message + Environment.NewLine;
            }
            textOutput.Text += Environment.NewLine;
            try
            {
                TestFunction();
            }
            catch (Exception exc)
            {
                textOutput.Text += exc.Message + Environment.NewLine;
            }
            textOutput.Text += Environment.NewLine;
            */

        }
        /*
        void Divide1(int a, int b)
        {
            textOutput.Text += (a / b).ToString() + Environment.NewLine;
        }
        void Divide2(int a, int b)
        {
            if (b != 0)
            {
                textOutput.Text += (a / b).ToString() + Environment.NewLine;
            }
            else
            {
                textOutput.Text += "Деление на 0!" + Environment.NewLine;
            }
        }
        void Divide3(int a, int b)
        {
            try
            {
                textOutput.Text += (a / b).ToString() + Environment.NewLine;
            }
            catch (Exception e)
            {
                textOutput.Text += "Деление на 0!" + Environment.NewLine;
            }
        }
        void Divide4(int a, int b)
        {
            try
            {
                textOutput.Text += (a / b).ToString() + Environment.NewLine;
            }
            catch (Exception e)
            {
                textOutput.Text += e.Message + Environment.NewLine;
            }
        }
        void Divide5(int a, int b)
        {
            try
            {
                textOutput.Text += (a / b).ToString() + Environment.NewLine;
            }
            catch (DivideByZeroException e)
            {
                textOutput.Text += e.Message + Environment.NewLine;
            }
            catch (Exception e)
            {
                textOutput.Text += e.Message + Environment.NewLine;
            }
        }
        void Divide6(int a, int b)
        {
            try
            {
                textOutput.Text += (a / b).ToString() + Environment.NewLine;
            }
            catch (Exception e)
            {
                textOutput.Text += e.Message + Environment.NewLine;
            }
            finally
            {
                textOutput.Text += "Выполнение завершено." + Environment.NewLine;
            }
        }
        void Divide7(int a, int b)
        {
            try
            {
                textOutput.Text += (a / b).ToString() + Environment.NewLine;
            }
            catch (Exception e)
            {
                textOutput.Text += e.Message + Environment.NewLine;
                throw;
            }
        }
        void TestFunction()
        {
            throw new ApplicationException("Тестовое исключение");
        }
        */
        /*
        void Elemmass1(int[] array1, int indi)
        {
            try
            {
                textOutput.Text += "Элемент массива arr1[" + indi.ToString() + "] = " + array1[indi]+ Environment.NewLine;
            
            //textOutput.Text += (a / b).ToString() + Environment.NewLine;
            }
            catch 
            {
                textOutput.Text += "Индекс массива за границей диапазона (0 - 5)!" + Environment.NewLine;
            }
        }

        void Elemmass2(int[] array1, int indi)
        {
            try
            {
                textOutput.Text += "Элемент массива arr1[" + indi.ToString() + "] = " + array1[indi] + Environment.NewLine;
            }
            catch (Exception e)
            {
                textOutput.Text += e.Message + Environment.NewLine;
            }
        }
        */
        void Choose1(string[] cols, string col)
        {
            try
            {
                int i = 0;
                foreach (string item in cols)
                {
                    if (item == col)
                    {
                        textOutput.Text += "Цвет " + item + Environment.NewLine;
                        break;
                    }
                    i++;
                }
                if (i >= cols.Length)
                {
                    int a = 1; int b = 0;
                    int c = a / b;
                }
  
            }
            catch
            {
                textOutput.Text += "Выбран бесцветный колер. " + Environment.NewLine;
            }
            finally
            { textOutput.Text += "Выбор цветов закончен. " + Environment.NewLine; }
        }
    }

}