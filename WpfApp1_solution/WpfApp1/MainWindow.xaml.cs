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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SumarValoresForma2();
        }

        private void SumarValoresForma1()
        {
            /*var num1Text = document.getElementById("Num1").value;
                        var num2Text = document.getElementById("Num2").value;*/

            var num1Text = Num1.Text;
            var num1 = 0.0;

            if (!TryToGetNumber(num1Text, out num1))
                return;

            var num2Text = Num2.Text;
            var num2 = 0.0;

            if (!TryToGetNumber(num2Text, out num2))
                return;

            var suma = num1 + num2;

            //alert(s);
            MessageBox.Show(suma.ToString());
        }

        private void SumarValoresForma2()
        {
            /*var num1Text = document.getElementById("Num1").value;
                        var num2Text = document.getElementById("Num2").value;*/

            var num1Text = Num1.Text;

            try
            {
                var num1 = GetNumber(num1Text);
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
                return;
            }

            var num2Text = Num2.Text;

            try
            {
                var num2 = GetNumber(num2Text);
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
                return;
            }

            var suma = num1 + num2;

            //alert(s);
            MessageBox.Show(suma.ToString());
        }

        private bool TryToGetNumber(string text, out double value)
        {
            double num1;
            value = 0.0;

            text = text.Replace(".", ",");

            if (!double.TryParse(text, out num1))
            {
                MessageBox.Show($"El texto {text} tiene un formato de número incorrecto.");
                return false;
            }
            else
            {
                value = num1;
                return true;
            }
        }

        private double GetNumber(string text)
        {
            text = text.Replace(".", ",");

            try
            {
                return double.Parse(text);
            }
            catch(Exception e1)
            {
                throw new Exception($"El texto {text} tiene un formato de número incorrecto.");
            }
        }
    }
}
