using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public string[] inputArray;
        public string sumResult, productResult;

        public Form1()
        {
            InitializeComponent();
        }
        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            // считываем введенный пользователем массив чисел
            string[] inputArray = textBoxArray.Text.Split(' ');

            // забираем из класса calculation результаты
            Calculation n1 = new Calculation();
            Calculation n2 = new Calculation();

            n1.GetSumResult(inputArray);
            n2.GetSumResult(inputArray);


            string s1 = n1.GetSumResult(inputArray);

            string s2 = n2.GetProductResult(inputArray);

            MessageBox.Show("Сумма положительных элементов: " + s1 + "; произведение чисел между минимальным и максимальным: " + s2);


        }
    }
}
