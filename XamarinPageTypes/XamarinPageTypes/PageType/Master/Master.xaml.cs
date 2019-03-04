using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinPageTypes.PageType.Navigation;

namespace XamarinPageTypes.PageType.Master
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Master : MasterDetailPage
    {
        public Master()
        {
            InitializeComponent();
        }

        private void ChangePage1(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Page1());
            IsPresented = false;
        }

        private void ChangePage2(object sender, EventArgs args)
        {
            Detail = new Page2();
            IsPresented = false;
        }

        private void ChangeContent(object sender, EventArgs args)
        {
            Detail = new Content();
            IsPresented = false;
        }
    }
}