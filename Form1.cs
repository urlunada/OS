using System;
using System.Windows.Forms;
using FormulaDll;  // Подключаем нашу DLL

namespace Task5_dll
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Чтение данных из полей ввода
                double a = double.Parse(txtA.Text);
                double b = double.Parse(txtB.Text);

                // 2. ВЫЗОВ ФУНКЦИИ ИЗ DLL 
                // Обращаемся к статическому методу Calculator.Calculate
                // DLL выполняет вычисления и возвращает результат
                double result = Calculator.Calculate(a, b);

                // 3. Вывод результата с 2 знаками после запятой
                lblResult.Text = "Гипотенуза: " + result.ToString("F2");
            }
            catch
            {
                // Обработка ошибок (если ввели не числа)
                MessageBox.Show("Введите корректные числа!");
            }
        }
    }
}