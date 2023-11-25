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
    /// Логика взаимодействия для Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
        public Page3()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Answer.Clear();
            if (!double.TryParse(inputA.Text, out double a))
            {
                MessageBox.Show("Введите число!");
            }
            if (!double.TryParse(inputB.Text, out double b))
            {
                MessageBox.Show("Введите число!");
            }
            if (!double.TryParse(inputC.Text, out double c))
            {
                MessageBox.Show("Введите число!");
            }
            if ((a <= b && b <= c) || ((c <= b && b <= a)))
            {
                Answer.Text += b;
            }
            else

            if ((b<=a && a<=c) || ((b<=a && a<=c)))
            {
                Answer.Text += a;
            }
            else
            {
                Answer.Text += c;
            }
        }
    }
}
