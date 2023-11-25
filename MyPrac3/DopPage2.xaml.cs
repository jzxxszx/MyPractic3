using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MyPrac3
{
    /// <summary>
    /// Логика взаимодействия для DopPage2.xaml
    /// </summary>
    public partial class DopPage2 : Page
    {
        public DopPage2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Answer.Clear();
            if (!int.TryParse(NumberX.Text, out int x))
            {
                MessageBox.Show("Введите число!");
            }

            if (x >= 10 && x < 100 && x % 2 == 0)
            {
                Answer.Text += "Четное двухзначного числа\n";
            }
            else if (x >= 10 && x < 100 && x % 2 != 0)
            {
                Answer.Text += "Нечетное двухзначного числа\n";
            }
            else if (x >= 100 && x < 1000 && x % 2 == 0)
            {
                Answer.Text += "Четное трехзначого числа\n";
            }
            else if (x >= 100 && x < 1000 & x % 2 != 0)
            {
                Answer.Text += "Нечетное трехзначного числа\n";
            }
            else if (x >= 1 && x < 10 && x % 2 == 0)
            {
                Answer.Text += "Четное однозначного числа\n";
            }
            else
            {
                Answer.Text += "Нечетное однозначного числа\n";
            }
        }
    }
}
