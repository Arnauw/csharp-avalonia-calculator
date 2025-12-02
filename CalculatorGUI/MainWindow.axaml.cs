using Avalonia.Controls;
using Avalonia.Interactivity;

namespace CalculatorGUI;

public partial class MainWindow : Window
{
    private double Add(double a, double b) => a + b;
    private double Subtract(double a, double b) => a - b;
    private double Multiply(double a, double b) => a * b;
    private double Modulo(double a, double b) => a % b;

    private double Divide(double a, double b)
    {
        if (b == 0) return 0;
        return a / b;
    }


    public MainWindow()
    {
        InitializeComponent();
    }
    
    public void OnButtonClick(object sender, RoutedEventArgs e)
    {
        if (InputText.Text == null) InputText.Text = "0";
        if (ResultText.Text == null) ResultText.Text = "0";
        
        var button = (Button)sender;

        string pressedValue = button?.Content?.ToString() ?? "";

        System.Diagnostics.Debug.WriteLine($"You pressed: {pressedValue}");

        // TestText.Text = "TEST";

        if (int.TryParse(pressedValue, out int number))
        {
            System.Diagnostics.Debug.WriteLine($"It's a number: {number}");

            InputText.Text += $"{pressedValue}";

            if ((InputText.Text.Length > 1 && InputText.Text[0] == '0'))
            {
                if (InputText.Text[1] is not ('.' or '÷' or '×' or '-' or '+' or '%'))
                {
                    InputText.Text = InputText.Text.Substring(1);
                    // TestText.Text = "we're in the condition";
                }
            }
        }
        else
        {
            System.Diagnostics.Debug.WriteLine($"It's an operator: {pressedValue}");

            if (pressedValue == "C")
            {
                InputText.Text = "0";
                ResultText.Text = "0";
            }

            if (pressedValue == "AC")
            {
                InputText.Text = "0";
                ResultText.Text = "0";
            }

            if (pressedValue is "." or "÷" or "×" or "-" or "+" or "%")
            {
                char[] operators = { '+', '-', '×', '÷', '%' };

                char lastInputChar = InputText.Text[^1];
                
                if (InputText.Text.IndexOfAny(operators) != -1)
                {
                    return;
                }

                InputText.Text += $"{pressedValue}";
            }

            if (pressedValue == "=")
            {
                char[] operators = { '+', '-', '×', '÷', '%' };
                int operatorIndex = InputText.Text.IndexOfAny(operators);
                char operatorChar = InputText.Text[operatorIndex];
                string leftValue = InputText.Text.Substring(0, operatorIndex);
                string rightValue = InputText.Text.Substring(operatorIndex + 1);

                // TestText.Text = $"leftPart={leftValue} rightPart={rightValue} operator={operatorChar}";

                if (double.TryParse(leftValue, out double num1) &&
                    double.TryParse(rightValue, out double num2))
                {
                    double result = operatorChar switch
                    {
                        '+' => Add(num1, num2),
                        '-' => Subtract(num1, num2),
                        '×' => Multiply(num1, num2),
                        '÷' => Divide(num1, num2),
                        '%' => Modulo(num1, num2),
                        _ => 0
                    };
                    
                    ResultText.Text = $"{result}";
                }
            }
        }
    }
}