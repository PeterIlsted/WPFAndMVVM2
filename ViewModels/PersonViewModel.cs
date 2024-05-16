using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WPFAndMVVM2.Models;

namespace WPFAndMVVM2.ViewModels
{
    public class PersonViewModel : INotifyPropertyChanged
    {
        private Person person;
		private string _firstName;

		public string FirstName
		{
			get { return _firstName; }
			set 
			{ 
				_firstName = value; 
				OnPropertyChanged(nameof(FirstName));
			}
		}
		private string _lastName;

		public string LastName
		{
			get { return _lastName; }
			set 
			{ 
				_lastName = value;
				OnPropertyChanged(nameof(LastName));
			}
		}
		private int _age;

		public int Age
		{
			get { return _age; }
			set 
			{ 
				_age = value; 
				OnPropertyChanged(nameof(Age));
			}
		}
		private string _phone;

        public event PropertyChangedEventHandler PropertyChanged;
        //public void OnPropertyChanged(string value = null)
        //{
        //    PropertyChangedEventHandler handler = PropertyChanged;
        //    if (handler != null) handler(this, new PropertyChangedEventArgs(value));
        //}

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }


        public string Phone
		{
			get { return _phone; }
			set 
			{ 
				_phone = value;
				OnPropertyChanged(nameof(Phone));
			}
		}
        public PersonViewModel(Person person)
        {
            FirstName = person.FirstName;
			LastName = person.LastName;
			Age = person.Age;
			Phone = person.Phone;
        }
        public PersonViewModel() : this(null) { }
    }
}
