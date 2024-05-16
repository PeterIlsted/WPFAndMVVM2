using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using WPFAndMVVM2.Models;
using System.Windows.Input;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WPFAndMVVM2.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        
        private PersonRepository personRepo = new PersonRepository();

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

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
                    _selectedPerson = value;
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
        //public void OnPropertyChanged(PersonViewModel personVM)
        //{
        //    PropertyChangedEventHandler handler = PropertyChanged;
        //    if (handler != null) handler(this, new PropertyChangedEventArgs(personVM));
        //}
    }
}
