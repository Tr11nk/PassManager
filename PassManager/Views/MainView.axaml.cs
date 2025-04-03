using Avalonia.Controls;
using Avalonia.Interactivity;
using PassManager.ViewModels;
using System.Diagnostics;

namespace PassManager.Views;

public partial class MainView : UserControl
{
    public MainView()
    {
        InitializeComponent();
        //DataContext = new MainViewModel();
    }
    private void Button_cl(object sender, RoutedEventArgs e)

    {
        var button = (sender as Button)!;
        switch (button.Name)
        {
            case "Button_Add":
                {
                    Debug.WriteLine("Add");
                    var viewModel = (MainViewModel)DataContext;
                    var newPerson = new MainViewModel.Person("mail.ru", "gow", "adwa");
                    viewModel.People.Add(newPerson);
                }
                break;
            case "Button_Edit":
                {
                    Debug.WriteLine("Edit");
                }
                break;
            case "Button_Del":
                {
                    Debug.WriteLine("Del");
                }
                break;
            case "Button_List":
                {
                    Debug.WriteLine("list");

                }
                break;
            default:
                {
                    button.Content = "No clue which Button you are!";
                }
                break;
        }

    }

}
