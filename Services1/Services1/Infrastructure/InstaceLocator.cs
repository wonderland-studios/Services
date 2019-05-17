
namespace Services1.Infrastructure
{
    using ViewModels1;
   public class InstaceLocator
    {
        public MainViewModel Main { get; set; }

        public InstaceLocator()
        {
            this.Main = new MainViewModel();
        }

    }
}
