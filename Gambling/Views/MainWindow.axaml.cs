using Avalonia.Controls;

namespace Gambling.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        Card.ShuffleDeck();
    }
}