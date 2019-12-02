using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2_Xamarin.Master
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu : MasterDetailPage
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void GoPagePerfil(object sender, EventArgs e)
        {
            Detail = new NavigationPage( new Pages.Perfil());
            IsPresented = false;
        }
        private void GoXamarin(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Pages.Xamarin());
            IsPresented = false;

        }
    }
}