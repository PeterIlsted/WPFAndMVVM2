using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using WPFAndMVVM2.Models;
using WPFAndMVVM2.Controller;
using System.Windows.Input;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WPFAndMVVM2.ViewModels
{
    internal class MainViewModel : ViewModelBase
    {
        
        private PersonRepository personRepo = new PersonRepository();

        // Implement the rest of this MainViewModel class below to 
        // establish the foundation for data binding !
        public ObservableCollection<PersonViewModel> PersonVM {  get; set; }
        private PersonViewModel _selectedPerson;
        public PersonViewModel selectedPerson
        {
            get { return _selectedPerson; }
            set
            {
                if (value != _selectedPerson)
                {
                    if (_selectedPerson != null)
                        personRepo.Update(selectedPerson.ID, selectedPerson.FirstName, selectedPerson.LastName, selectedPerson.Age, selectedPerson.Phone);
                    _selectedPerson = value;

                    //personRepo.Update(selectedPerson.ID, selectedPerson.FirstName, selectedPerson.LastName, selectedPerson.Age, selectedPerson.Phone);
                    OnPropertyChanged();
                }
            }

        }

        public MainViewModel()
        {
            PersonVM = new ObservableCollection<PersonViewModel>();
            foreach (var person in personRepo.GetAll())
            {
                PersonVM.Add(new PersonViewModel(person));
                
            }

        }
        
        public void AddDefaultPerson()
        {
            personRepo.NewPerson();
            foreach (var person in personRepo.GetAll())
            {
                foreach (var person2 in PersonVM)
                {
                    if (person.FirstName == person2.FirstName)
                        continue;
                    else selectedPerson = new PersonViewModel(person);

                }
            }
            PersonVM.Add(selectedPerson);
            OnPropertyChanged();
        }
        public void DeleteSelectedPerson()
        {
            int id = selectedPerson.ID;
            
            PersonVM.Remove(selectedPerson);
            personRepo.Remove(id);
            OnPropertyChanged();
        }
    }
}
