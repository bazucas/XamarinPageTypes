using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinPageTypes.PageType.Navigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void ChangePageTwo(object sender, EventArgs args)
        {
            Navigation.PushAsync(new Page2());
        }

        private void CallModal(object sender, EventArgs args)
        {
            Navigation.PushModalAsync(new Modal());
        }

        private void CallMaster(object sender, EventArgs args)
        {
            Application.Current.MainPage = new Master.Master();
        }
    }
}