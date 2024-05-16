using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFAndMVVM2_opg6.Models;

namespace WPFAndMVVM2_opg6.ViewModels
{
    public class ProductViewModel
    {
		private double _price;

		public double Price
		{
			get { return _price; }
			set { _price = value; }
		}
		private string _name;

		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}
		public ProductViewModel(string name, double price)
		{
			Name = name;
			Price = price;
		}

	}
}
