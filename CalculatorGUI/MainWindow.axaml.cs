using Avalonia.Controls;
using Avalonia.Interactivity;

namespace CalculatorGUI;

public partial class MainWindow : Window
{
    // private double _currentValue = 0;
    // private double _storedValue = 0;
    // private string _operation = "";
    
    public MainWindow()
    {
        InitializeComponent();
    }
    
    public void OnButtonClick(object sender, RoutedEventArgs e)
    {
        var button = (Button)sender;
        
        string pressedValue = button?.Content?.ToString() ?? "";

        System.Diagnostics.Debug.WriteLine($"You pressed: {pressedValue}");
        
        InputText?.Text = InputText?.Text?.ToString() + $"{pressedValue}";
        
        if (int.TryParse(pressedValue, out int number))
        {
            System.Diagnostics.Debug.WriteLine($"It's a number: {number}");
            if (InputText?.Text?.Length > 1 && InputText?.Text?[0] == '0')
            {
                // 3. One generic exception: Don't remove '0' if the next char is a dot (e.g. "0.5")
                if (InputText.Text[1] != '.')
                {
                    // REMOVE the first character
                    InputText.Text = InputText.Text.Substring(1);
                }
            }
        }
        else
        {
            System.Diagnostics.Debug.WriteLine($"It's an operator: {pressedValue}");

            if (pressedValue == "C")
            {
                InputText?.Text = "0";
            }
        }
        
        
        

        
        
        // TODO: Add your If/Else or Switch logic here to handle numbers vs operators
    }
}





