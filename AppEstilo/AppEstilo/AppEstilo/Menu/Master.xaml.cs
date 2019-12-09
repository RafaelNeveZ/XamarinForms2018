using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppEstilo.Menu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Master : MasterDetailPage
    {
        public Master()
        {
            InitializeComponent();
        }

        private void GoImplicitStyle(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Page.ImplicitStylePage());
            IsPresented = false;
        }

        private void GoExplicttStyle(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Page.ExplicitStylePage());
            IsPresented = false;
        }
        private void GoGlobalStylePage(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Page.GlobalStylePage());
            IsPresented = false;
        }
        private void GoHerancaPage(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Page.HerancaPage());
            IsPresented = false;
        }
        private void GoDynamcyPage(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Page.DynamcyPage());
            IsPresented = false;
        }
    }
}
