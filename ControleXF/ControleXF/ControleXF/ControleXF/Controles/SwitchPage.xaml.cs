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
    public partial class SwitchPage : ContentPage
    {
        public SwitchPage()
        {
            InitializeComponent();
            L1.Text = DateTime.Now.ToString("HH:mm") + " - true";
        }

        private void S1_Toggled(object sender, ToggledEventArgs e)
        {
            if (e.Value)
            {
                S2.IsToggled = false;
                L1.Text = DateTime.Now.ToString("HH:mm") + " - " + e.Value;
                L2.Text = "false";
            }
            else
            {
                S2.IsToggled = true;
                L1.Text = "false";
                L2.Text = DateTime.Now.ToString("HH:mm") + " - " + e.Value;     

            }
        }

        private void S2_Toggled(object sender, ToggledEventArgs e)
        {
            if (e.Value)
            {
                S1.IsToggled = false;
                L1.Text = "False";
                L2.Text = DateTime.Now.ToString("HH:mm") + " - " + e.Value;

            }
            else
            {
                S1.IsToggled = true;
                L1.Text = DateTime.Now.ToString("HH:mm") + " - " + e.Value;
                L2.Text = "False";

            }
        }
    }
}