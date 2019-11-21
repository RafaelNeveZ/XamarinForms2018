using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2_TipoPaginaXF.TipoPagina.Navigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void MudarParaPage2(object sender, EventArgs args)
        {
            Navigation.PushAsync(new Page2());
        }

        private void ChamarModal(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Modal());
        }
        private void ChamarMaster(object sender, EventArgs e)
        {
            App.Current.MainPage = new MasterPage.Master();
        }
    }
}