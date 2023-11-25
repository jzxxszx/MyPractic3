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
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        public Page2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Answer.Clear();
            if (!int.TryParse(inputA.Text, out int a))
            {
                MessageBox.Show("Введите число!");
            }
            if (!int.TryParse(inputB.Text, out int b))
            {
                MessageBox.Show("Введите число!");
            }
            if (a>b)
            {
                Answer.Text += Math.Min(a, b);
            }
            else
            {
                Answer.Text += Math.Min(a, b);
            }
        }
    }
}
