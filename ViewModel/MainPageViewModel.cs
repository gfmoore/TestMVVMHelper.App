using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace TestMVVMHelper.ViewModel;

public partial class MainPageViewModel : ObservableObject
{
  [ObservableProperty]
  ObservableCollection<String> monkeys = new()
  {
    "Chimp",
    "Gorilla",
    "Orangutan",
    "Gibbon"
  };

  [ObservableProperty]
  string selectedItem;

  [RelayCommand]
  public async void SelectionChanged()
  {
    Console.WriteLine($"Hi {SelectedItem}");

    //await Task.Delay(2000);

    //SelectedItem = null;
  }

  [ObservableProperty]
  private string greet = "Hello, Gordon!";

  [RelayCommand]
  public async void HitMe()
  {
    Console.WriteLine($"Hello");
    Greet = "Hi, friend";

    SelectedItem = null;
  }


}
