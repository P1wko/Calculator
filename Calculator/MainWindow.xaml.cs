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

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ResultText.Text = String.Empty;
            CurrentOperationText.Text = String.Empty;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ResultText.Text = String.Empty;

            var button = sender as Button;
            var currentNumber = button.Name[button.Name.Length - 1];
            CurrentOperationText.Text += currentNumber; 
        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            var operation = CurrentOperationText.Text;

            if(ContainsOperation(operation))
            {
                CurrentOperationText.Text = CalculateResult(operation).ToString();
            }

            CurrentOperationText.Text += "+";
        }

        private void ButtonMinus_Click(object sender, RoutedEventArgs e)
        {
            var operation = CurrentOperationText.Text;

            if (ContainsOperation(operation))
            {
                CurrentOperationText.Text = CalculateResult(operation).ToString();
            }

            CurrentOperationText.Text += "-";
        }

        private void ButtonMultiplie_Click(object sender, RoutedEventArgs e)
        {
            var operation = CurrentOperationText.Text;

            if (ContainsOperation(operation))
            {
                CurrentOperationText.Text = CalculateResult(operation).ToString();
            }

            CurrentOperationText.Text += "*";
        }

        private void ButtonDivide_Click(object sender, RoutedEventArgs e)
        {
            var operation = CurrentOperationText.Text;

            if (ContainsOperation(operation))
            {
                CurrentOperationText.Text = CalculateResult(operation).ToString();
            }

            CurrentOperationText.Text += "/";
        }

        private void ButtonResult_Click(object sender, RoutedEventArgs e)
        {
            var operation = CurrentOperationText.Text;
            ResultText.Text = CalculateResult(operation).ToString();
            CurrentOperationText.Text = String.Empty;
            
        }

        private bool ContainsOperation(string operation)
        {
            return operation.Contains('-') || operation.Contains('/') || operation.Contains('*') || operation.Contains('+');
        }

        private int CalculateResult(string operation)
        {
            if (operation.Contains('+'))
            {
                var elements = operation.Split('+');

                return int.Parse(elements[0]) + int.Parse(elements[1]);
            }
            if (operation.Contains('-'))
            {
                var elements = operation.Split('-');

                return int.Parse(elements[0]) - int.Parse(elements[1]);
            }
            if (operation.Contains('*'))
            {
                var elements = operation.Split('*');

                return int.Parse(elements[0]) * int.Parse(elements[1]);
            }
            if (operation.Contains('/'))
            {
                var elements = operation.Split('/');

                return int.Parse(elements[0]) / int.Parse(elements[1]);
            }
            return 0;
        }
    }
}
