﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFAndMVVM2_opg6.Models
{
    internal class Product
    {
		private int _id;

		public int ID
		{
			get { return _id; }
			set { _id = value; }
		}

		private string _name;

		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

		private string _productType;

		public string ProductType
		{
			get { return _productType; }
			set { _productType = value; }
		}
		private double _price;

		public double Price
		{
			get { return _price; }
			set { _price = value; }
		}

	}
}
