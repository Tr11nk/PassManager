using Avalonia.Controls;
using Avalonia.Interactivity;
using Microsoft.Data.Sqlite;
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
                    var viewModel = DataContext as MainViewModel;
                    var newLine = new MainViewModel.Data("mail.ru", "gow", "adwa");
                    using (var connection = new SqliteConnection()) 
                    {
                        connection.Open();
                        SqliteCommand command = connection.CreateCommand();
                        command.CommandText= 
                            @"
                                INSERT INTO People (Site, Login, Password)
                                VALUES ($firstName, $lastName, $age);
                            ";

                    }
                        viewModel.Datac.Add(newLine);
                        
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
                    var viewModel = DataContext as MainViewModel;
                    if (viewModel.SelectedData != null)
                    {
                        viewModel.Datac.Remove(viewModel.SelectedData);
                    }
                    break;
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
