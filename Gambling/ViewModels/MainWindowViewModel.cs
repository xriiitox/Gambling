using System.Collections.Generic;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Gambling.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    public string Greeting => "GAMBLING";

    // for future reference: [ObservableProperty] automatically creates a public field
    // e.g. the below line creates _car (private) and Car (public)
    // can be used for a Deck later?
    // [ObservableProperty] private Card _car = Card.GetCardFromDeck();
}