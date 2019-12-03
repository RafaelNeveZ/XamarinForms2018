using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ControleXF.Controles
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WebViewPage : ContentPage
    {
        public WebViewPage()
        {
            InitializeComponent();

        }


        private void OkBT_Clicked(object sender, EventArgs e)
        {
            if(EndSite.Text != null)
            Navegador.Source = EndSite.Text;
        }

        private void PrBT_Clicked(object sender, EventArgs e)
        {
            if (Navegador.CanGoForward)
                Navegador.GoForward();
        }

        private void VoBT_Clicked(object sender, EventArgs e)
        {
            if (Navegador.CanGoBack)
                Navegador.GoBack();
        }

        private void WebView_Navigated(object sender, WebNavigatedEventArgs e)
        {
            LB_Status.Text = "Finalizado";
        }

        private void WebView_Navigating(object sender, WebNavigatingEventArgs e)
        {
            DisableButtons();
            EndSite.Text = e.Url.ToString();
            LB_Status.Text = "Carregando...";
        }

        public void DisableButtons()
        {
            VoBT.IsEnabled = Navegador.CanGoBack;
            PrBT.IsEnabled = Navegador.CanGoForward;
        }
    }
}