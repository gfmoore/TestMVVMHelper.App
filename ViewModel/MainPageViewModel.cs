

namespace TestMVVMHelper.ViewModel
{
  public partial class MainPageViewModel : ObservableObject
  {

    [ObservableProperty]
    private string greet = "Hello, Gordon!";

    [ICommand]
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
}
