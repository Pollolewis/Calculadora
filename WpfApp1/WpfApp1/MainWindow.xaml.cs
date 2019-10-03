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
            //var num1Text = document.getElementById("Num1").value;
            //var num2Text = document.getElementById("Num2").value;

            var num1Text = Num1.Text;
            var num2Text = Num2.Text;

            var s = "num1: " + num1Text + " num2: " + num2Text;

            //alert(s);
            MessageBox.Show(s);
        }
    }
}
