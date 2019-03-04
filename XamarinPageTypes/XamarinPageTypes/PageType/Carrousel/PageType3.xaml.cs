using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinPageTypes.PageType.Navigation;

namespace XamarinPageTypes.PageType.Carrousel
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageType3 : ContentPage
    {
        public PageType3()
        {
            InitializeComponent();
        }

        private void ChangePage(object sender, EventArgs args)
        {
            //Application.Current.MainPage = new NavigationPage(new Page1()) {BarBackgroundColor = Color.Aqua};
            Application.Current.MainPage = new Tabbed.Tabs();
        }
    }
}