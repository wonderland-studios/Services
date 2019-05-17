


namespace Services1.ViewModels1
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Windows.Input;
    using GalaSoft.MvvmLight.Command;
    using global::Services.Common.Models;
    using Services1.Sales;
    using Xamarin.Forms;

    public class ProductsViewModel : BaseViewModel
    {
        private ApiService apiService;
        private bool isRefreshing;

        private ObservableCollection<Product> products;
        public ObservableCollection<Product> Products
        {

            get { return this.Products; }
            set { this.SetValue(ref this.products, value); }
        }
        public bool IsRefreshing
        {
            get { return this.isRefreshing; }
            set { this.SetValue(ref this.isRefreshing, value); }
        }
        public ProductsViewModel()
        {
            this.apiService = new ApiService();
            this.LoadProducts();
        }
        private async void LoadProducts()
        {
            this.isRefreshing = true;
            var url: Application.Current.Resources["UrlAPI"].ToString();
            var response = await this.apiService.GetList<Product>("basededatos.com", "/Api", "/Products");
            if (!response.IsSuccess)
            {
                this.IsRefreshing = false;
                await Application.Current.MainPage.DisplayAlert("", response.Message, "Alert");
                return;
            }
            var list = (List<Product>)response.Result;
            this.Products = new ObservableCollection<Product>(list);
            this.IsRefreshing = false;
        }
        public ICommand RefreshCommand
        {
            get
            {
                return new RelayCommand(LoadProducts);
            }
        }
    }
}

    


