using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Gambling.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    public string Greeting { get; } = "GAMBLING";

    public ObservableCollection<Card> deck { get; } = new(Card.Deck);
}