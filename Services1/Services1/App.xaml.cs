
using Xamarin.Forms;


namespace Services1
{
    using Views1;
    public partial class App : Application
    {
        //TODO: Replace with *.azurewebsites.net url after deploying backend to Azure
     

        public App()
        {
            InitializeComponent();

          
            MainPage = new NavigationPage (new ProductsPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
