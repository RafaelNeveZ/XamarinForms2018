using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Calculadora.Tipos
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Padrao : ContentPage
    {
        
        public Padrao()
        {
            InitializeComponent();
        }
        private void Page_SizeChanged(object sender, EventArgs e)
        {
            ValueNumber.Text = Width + "";
            
        }
    }
}