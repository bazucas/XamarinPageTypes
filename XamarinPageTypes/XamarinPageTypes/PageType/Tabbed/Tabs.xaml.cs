using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinPageTypes.PageType.Tabbed
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Tabs : TabbedPage
    {
        public Tabs()
        {
            InitializeComponent();

            Children.Add(new NavigationPage(new Navigation.Page1()) { Title = "Item 3" });
        }
    }
}