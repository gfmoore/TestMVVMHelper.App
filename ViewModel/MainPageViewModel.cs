namespace TestMVVMHelper.ViewModel;

public partial class MainPageViewModel : ObservableObject
{
  [ObservableProperty]
  ObservableCollection<Monkey> monkeys = new();

  [ObservableProperty]
  private string greet = "Hello, Gordon!";

  public MainPageViewModel()
  {
    GetData();
  }

  public async void GetData()
  {
    HttpClient httpClient = new();
    var response = await httpClient.GetAsync("https://www.montemagno.com/monkeys.json");
    if (response.IsSuccessStatusCode)
    {
      List<Monkey> l = await response.Content.ReadFromJsonAsync<List<Monkey>>();
      Monkeys = new ObservableCollection<Monkey>(l);
    }
  }

  [ObservableProperty]
  Monkey selectedItem;

  [RelayCommand]
  public async void SelectionChanged()
  {
    Console.WriteLine($"Hi {SelectedItem.Name}");

    //await Task.Delay(5000);

    SelectedItem = null;
  }

  //or press the button

  [RelayCommand]
  public void HitMe()
  {
    Console.WriteLine($"Hello {SelectedItem.Name}");
    Greet = "Hi, friend";

    //SelectedItem = null;
    //SelectedItem = Monkeys[0];
    SelectedItem = new Monkey();
  }

}

public class Monkey
{
  public string Name { get; set; }
  public string Location { get; set; }
  public string Details { get; set; }
  public string Image { get; set; }
  public int Population { get; set; }
  public double Latitude { get; set; }
  public double Longitude { get; set; }
}

//ObservableCollection<String> monkeys = new()
//{
//  "Chimp",
//  "Gorilla",
//  "Orangutan",
//  "Gibbon"
//};