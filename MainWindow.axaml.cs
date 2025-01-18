using Avalonia.Controls;
using Avalonia.Interactivity;

namespace CharacterParser;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    public void ClickEvent(object sender, RoutedEventArgs args)
    {
        string parsedText = Parser.Parse(search.Text ?? string.Empty);
        symbol.Text = parsedText;
        unicode.Text = parsedText;
        hexcode.Text = parsedText;
    }
}