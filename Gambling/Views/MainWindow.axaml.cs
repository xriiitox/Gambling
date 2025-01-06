using System;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace Gambling.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void Blackjack_OnClick(object? sender, RoutedEventArgs e)
    {
        var bJackWindow = new Blackjack();
        bJackWindow.Show();
        Hide(); // hide menu window, will reappear once blackjack has been closed

        bJackWindow.Closed += ShowMenu; // reopen menu when window closed
    }

    private void ShowMenu(object? sender, EventArgs e)
    {
        Show();
        var oldWindow = sender as Window;
        oldWindow.Closed -= ShowMenu; // just for safety, make sure to not open the menu more than once
    }
}