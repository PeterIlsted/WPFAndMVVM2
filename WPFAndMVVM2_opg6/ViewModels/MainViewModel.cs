using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFAndMVVM2_opg6.Controller;
using WPFAndMVVM2_opg6.Models;

namespace WPFAndMVVM2_opg6.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private ObservableCollection<ProductViewModel> _productsVM;
        public ObservableCollection<ProductViewModel> ProductsVM 
        {
            get {  return _productsVM; }
            set 
            {  
                _productsVM = value;
                OnPropertyChanged(nameof(ProductsVM));
            } 
        }
        ProductViewModel Product;
        private ProductRepo productRepo = new ProductRepo();

        public MainViewModel() 
        { 
            ProductsVM = new ObservableCollection<ProductViewModel>();
            foreach (var product in productRepo.GetProducts()) 
            {
                Product = new ProductViewModel(product.Name, product.Price);
                ProductsVM.Add(Product);
            }
        }
    }
}
