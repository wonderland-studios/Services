﻿

namespace Services1.Helpers
{
    using Interfaces;
    using Resources;
    using Xamarin.Forms;

    public static class Languages
    {
        static Languages()
        {
            var ci = DependencyService.Get<ILocalize>().GetCurrentCultureInfo();
            Resource.Culture = ci;
            DependencyService.Get<ILocalize>().SetLocale(ci);
        }

        public static string Accept
        {
            get { return Resource.Accept; }
        }
        public static string Error
        {
            get { return Resource.Error; }
        }
        public static string PleaseOnInternet
        {
            get { return Resource.PleaseOnInternet; }
        }
        public static string NoInternet
        {
            get { return Resource.NoInternet; }
        }
        public static string Products
        {
            get { return Resource.Products; }
        }
    }
}