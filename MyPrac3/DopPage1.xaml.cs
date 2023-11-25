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
    /// Логика взаимодействия для DopPage1.xaml
    /// </summary>
    public partial class DopPage1 : Page
    {
        public DopPage1()
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

            if (x < 0 && x % 2 == 0)
            {
                Answer.Text += "«отрицательное четное число»\n";
            }
            else if (x == 0)
            {
                Answer.Text += "«нулевое число»\n";
            }
            else if (x > 0 && x % 2 == 0)
            {
                Answer.Text += "«положительное четное число»\n";
            }
            else if (x < 0 && x % 2 != 0)
            {
                Answer.Text += "«отрицательное нечетное число»\n";
            }
            else
            {
                Answer.Text += "«положительное нечетное число»\n";
            }
        }
    }
}
