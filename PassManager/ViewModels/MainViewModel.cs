using PassManager.Views;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace PassManager.ViewModels;


public class MainViewModel : ViewModelBase
{
    public string Header => "Манагер";

    public ObservableCollection<Person> People { get; }

    public MainViewModel()
    {
        var people = new List<Person>
    {
        new Person("Neil", "Armstrong","123"),
        new Person("Neil", "Armstrong","123")
        };
        People = new ObservableCollection<Person>(people);
        People.CollectionChanged += (s, e) => OnPropertyChanged(nameof(People));
    }

    public event PropertyChangedEventHandler PropertyChanged;

    protected void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    public class Person
    {
        public string Site { get; set; }
        public string Login { get; set; }

        public string Password { get; set; }
        public Person(string firstName, string lastName, string password)
        {
            Site = firstName;
            Login = lastName;
            Password = password;

        }
    }

}
