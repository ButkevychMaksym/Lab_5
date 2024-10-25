using System;
using System.Windows;
using System.Windows.Controls;
using WpfApp1.Models;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        // Models for different functionalities
        private CalculatorModel _calculatorModel; // Model for performing calculations
        private AgeCategoryModel _ageCategoryModel; // Model for determining age category
        private MultiplicationTableModel _multiplicationTableModel; // Model for generating multiplication tables

        /// <summary>
        /// Initializes a new instance of the <see cref="MainWindow"/> class.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            // Instantiate the models
            _calculatorModel = new CalculatorModel();
            _ageCategoryModel = new AgeCategoryModel();
            _multiplicationTableModel = new MultiplicationTableModel();
        }

        /// <summary>
        /// Handles the Click event of the calculate button.
        /// Parses input numbers and selected operation, performs the calculation,
        /// and displays the result.
        /// </summary>
        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Parse input numbers from text fields
                double num1 = double.Parse(txtNum1.Text);
                double num2 = double.Parse(txtNum2.Text);
                // Get selected operation from combo box
                string operation = (cmbOperation.SelectedItem as ComboBoxItem).Content.ToString();

                double result;
                // Perform calculation based on the selected operation
                switch (operation)
                {
                    case "+":
                        result = _calculatorModel.Add(num1, num2);
                        break;
                    case "-":
                        result = _calculatorModel.Subtract(num1, num2);
                        break;
                    case "*":
                        result = _calculatorModel.Multiply(num1, num2);
                        break;
                    case "/":
                        result = _calculatorModel.Divide(num1, num2);
                        break;
                    default:
                        throw new InvalidOperationException("Invalid operation");
                }

                // Display the result
                lblCalcResult.Content = $"Result: {result}";
            }
            catch (Exception ex)
            {
                // Show an error message in case of an exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        /// <summary>
        /// Handles the Click event of the age category button.
        /// Parses the age input, retrieves the age category from the model,
        /// and displays it.
        /// </summary>
        private void btnAgeCategory_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Parse age from the input field
                int age = int.Parse(txtAge.Text);
                // Get age category from the model
                string category = _ageCategoryModel.GetCategory(age);
                // Display the age category
                lblAgeCategory.Content = $"Category: {category}";
            }
            catch (Exception ex)
            {
                // Show an error message in case of an exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        /// <summary>
        /// Handles the Click event of the multiplication table button.
        /// Parses the multiplier input, generates the multiplication table from the model,
        /// and displays it.
        /// </summary>
        private void btnMultiplicationTable_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Parse multiplier from the input field
                int number = int.Parse(txtMultiplier.Text);
                // Generate multiplication table from the model
                string table = _multiplicationTableModel.GenerateTable(number);
                // Display the multiplication table
                lblMultiplicationTable.Text = table;
            }
            catch (Exception ex)
            {
                // Show an error message in case of an exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
