using System;
using System.Collections.Generic;
using System.Text;

namespace Services1.ViewModels1
{
    public class MainViewModel
    {
        public ProductsViewModel Products { get; set; }

        public MainViewModel()
        {
            this.Products = new ProductsViewModel();
        } 
    }
}
