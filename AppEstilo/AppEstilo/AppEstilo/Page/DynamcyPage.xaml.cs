using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppEstilo.Page
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DynamcyPage : ContentPage
    {
        public DynamcyPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            this.Resources["LblColor"] = Color.Magenta;
            this.Resources["Lbl"] = this.Resources["NewLbl"];

        }
    }
}