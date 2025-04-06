using Microsoft.Data.Sqlite;
using PassManager.Views;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace PassManager.ViewModels;


public class MainViewModel : ViewModelBase
{

    public string Header => "Манагер";
    private Data _selectedData;
    public Data SelectedData
    {
        get => _selectedData;
        set
        {
            _selectedData = value;
            OnPropertyChanged(nameof(SelectedData));
        }
    }
    public ObservableCollection<Data> Datac { get; }
 
    public MainViewModel()
    {

        Datac = new ObservableCollection<Data>();
        Datac.Add(new Data("Neil", "Armstrong", "123"));    
      // Datac = new ObservableCollection<Data>(Data);
        Datac.CollectionChanged += (s, e) => OnPropertyChanged(nameof(Datac));
    }

    public event PropertyChangedEventHandler PropertyChanged;

    protected void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    public class Data
    {
        public string Site { get; set; }
        public string Login { get; set; }

        public string Password { get; set; }
        public Data(string site, string login, string password)
        {
            Site = site;
            Login = login;
            Password = password;

        }
    }

}
