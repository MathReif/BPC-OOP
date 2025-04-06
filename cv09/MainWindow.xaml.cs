using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace cv09;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private Calculator calculator = new Calculator();

    private bool isDarkMode = true;

    public MainWindow()
    {
        InitializeComponent();
        Loaded += MainWindow_Loaded; // Apply button styles after full load
        display.Content = calculator.Display;
        pamet.Content = calculator.Pamet;

    }

    private void MainWindow_Loaded(object sender, RoutedEventArgs e)
    {
        var initialStyle = this.FindResource("DarkButton") as Style;
        ApplyStyleToAllButtons(initialStyle);
        ThemeToggleButton.Style = this.FindResource("DarkButton") as Style;
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
        
        calculator.Tlacitko((sender as Button).Content.ToString());
        display.Content = calculator.Display;
        pamet.Content = calculator.Pamet;
        
    }

    private void ThemeToggleButton_Click(object sender, RoutedEventArgs e)
    {
        isDarkMode = !isDarkMode;

        // Colors
        string bgColor = isDarkMode ? "#1e1e1e" : "White";
        string fgColor = isDarkMode ? "White" : "Black";
        string labelBg = isDarkMode ? "#1e1e1e" : "White";
        string memFg = isDarkMode ? "LightGray" : "Gray";

        this.Background = (Brush)new BrushConverter().ConvertFromString(bgColor);
        display.Foreground = (Brush)new BrushConverter().ConvertFromString(fgColor);
        display.Background = (Brush)new BrushConverter().ConvertFromString(labelBg);
        pamet.Foreground = (Brush)new BrushConverter().ConvertFromString(memFg);
        pamet.Background = (Brush)new BrushConverter().ConvertFromString(labelBg);

        ThemeToggleButton.Content = isDarkMode ? "🌙" : "☀️";

        // Button style switch
        var newStyle = this.FindResource(isDarkMode ? "DarkButton" : "LightButton") as Style;
        ApplyStyleToAllButtons(newStyle);
        ThemeToggleButton.Style = newStyle; // ✅ This line makes the toggle match
    }

    // Helper to walk visual tree and apply style
    private void ApplyStyleToAllButtons(Style newStyle)
    {
        void RecurseChildren(DependencyObject parent)
        {
            int count = VisualTreeHelper.GetChildrenCount(parent);
            for (int i = 0; i < count; i++)
            {
                var child = VisualTreeHelper.GetChild(parent, i);

                if (child is Button btn && btn != ThemeToggleButton)
                {
                    btn.Style = newStyle;
                }
                else
                {
                    RecurseChildren(child); // keep searching
                }
            }
        }

        RecurseChildren(this); // start from main window
    }
}