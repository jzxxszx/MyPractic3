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
using static System.Math;

namespace MyPrac3
{
    /// <summary>
    /// Логика взаимодействия для Page5.xaml
    /// </summary>
    public partial class Page5 : Page
    {
        public Page5()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
                if (!double.TryParse(NumberX.Text, out double x))
                {
                    MessageBox.Show("Введите число!");
                }
                if (!double.TryParse(NumberY.Text, out double y))
                {
                    MessageBox.Show("Введите число!");
                }

                if (x <= 0 && x >= -23 && y <= x)
                {
                    Answer.Text += "Точка M попадает в область D";
                }
                else
                {
                    Answer.Text += "Точка M не попадает в область D";
                }
            }
        }
}
