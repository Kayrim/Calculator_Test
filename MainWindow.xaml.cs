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

namespace Calculator_Test
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static double valueResult = 0;
        static string operationSelect = "";
        static bool opClick = false;


        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (TextboxResult.Text == "0" || opClick==true)
                TextboxResult.Clear();
            Button button = (Button)sender;
            TextboxResult.Text = TextboxResult.Text + button.Content;
            opClick = false;

        }

        private void OperatorClick(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            operationSelect = button.Content.ToString();
            valueResult = Double.Parse(TextboxResult.Text);
            labelHistory.Content = valueResult + " " + operationSelect;
            opClick = true;

        }

        private void ResultDisplay(object sender, RoutedEventArgs e)
        {

            switch (operationSelect)
            {
                case "+": TextboxResult.Text = (valueResult + Double.Parse(TextboxResult.Text)).ToString();
                    break;
                case "-":
                    TextboxResult.Text = (valueResult - Double.Parse(TextboxResult.Text)).ToString();
                    break;
                case "*":
                    TextboxResult.Text = (valueResult * Double.Parse(TextboxResult.Text)).ToString();
                    break;
                case "/":
                    TextboxResult.Text = (valueResult / Double.Parse(TextboxResult.Text)).ToString();
                    break;


            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            TextboxResult.Text = "0";
            valueResult = 0;
        }
    }
}
