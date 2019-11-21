using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2_TipoPaginaXF.TipoPagina.MasterPage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Master : MasterDetailPage
    {
        public Master()
        {
            InitializeComponent();
            
        }

        private void MudarPage1(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Navigation.Page1());
            IsPresented = false;
        }
        private void MudarPage2(object sender, EventArgs e)
        {
            Detail = new Navigation.Page2();
            IsPresented = false;

        }
        private void MudarConteudo(object sender, EventArgs e)
        {
            Detail = new Conteudo();
            IsPresented = false;

        }
    }
}