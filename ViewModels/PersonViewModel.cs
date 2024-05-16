using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WPFAndMVVM2.Controller;
using WPFAndMVVM2.Models;

namespace WPFAndMVVM2.ViewModels
{
    internal class PersonViewModel : ViewModelBase
    {
		PersonRepository personRepository;
		private int _iD;

		public int ID
		{
			get { return _iD; }
			set { _iD = value; }
		}

		private string _firstName = "Specify FirstName";

		public string FirstName
		{
			get { return _firstName; }
			set 
			{ 
				_firstName = value;
				OnPropertyChanged(nameof(FirstName));
			}
		}
		private string _lastName = "Specify LastName";

		public string LastName
		{
			get { return _lastName; }
			set 
			{ 
				_lastName = value;
                OnPropertyChanged(nameof(LastName));
			}
		}
		private int _age = 0;

		public int Age
		{
			get { return _age; }
			set 
			{ 
				_age = value;
                OnPropertyChanged(nameof(Age));
			}
		}
		private string _phone = "Specify Phone";


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
			_iD = person.Id;
        }
        public PersonViewModel() { }
    }
}
