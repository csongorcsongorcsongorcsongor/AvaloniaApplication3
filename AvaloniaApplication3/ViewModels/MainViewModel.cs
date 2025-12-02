using System.Collections.ObjectModel;
using System.Reflection.PortableExecutable;
using AvaloniaApplication3.Models;
using CommunityToolkit.Mvvm.Input;

namespace AvaloniaApplication3.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    private MainModel _mainModel;
    public string Name { get; set; }
    public string Email { get; set; }
    public string Age { get; set; }
    public string Height { get; set; }
    public RelayCommand AddPersonCommand { get; set; }

    public ObservableCollection<Person> People { get; set; }

    public MainViewModel(MainModel model) {
        _mainModel = model;
        _mainModel.CreatedPerson += ModelCreatedPerson;
        People = new ObservableCollection<Person>();
        AddPersonCommand = new RelayCommand(AddPerson);

        for (int i = 0; i < 3; i++)
        {
            _mainModel.GeneratePeople();
        }

    }
    private void ModelCreatedPerson(object? sender, PersonEventArgs args)
    {
        args.Person.DeleteCommand = new RelayCommand(()=>People.Remove(args.Person));
        People.Add(args.Person);
    }
    private void AddPerson()
    {
        Person jani = new Person(Name, Email, Age, Height);
        jani.DeleteCommand = new RelayCommand(() => People.Remove(jani));
        People.Add(jani);
    }
}
