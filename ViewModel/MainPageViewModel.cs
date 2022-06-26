using CommunityToolkit.Mvvm.Input;

namespace TestMVVMHelper.ViewModel;

public partial class MainPageViewModel : ObservableObject
{

  [ObservableProperty]
  private string greet = "Hello, Gordon!";

  [RelayCommand]
  public async void HitMe()
  {
    Console.WriteLine($"Hello");
    Greet = "Hi, friend";
  }

  //public ICommand HitMeCommand => new Command<Object>(async (Object e) =>
  //{
  //  Console.WriteLine($"Hello");
  //  Greet = "Hi friend";
  //});

}
