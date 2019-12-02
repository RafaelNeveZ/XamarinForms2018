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
    public partial class SearchBarPage : ContentPage
    {
        List<String> empresasTI;
        public SearchBarPage()
        {
            InitializeComponent();
            empresasTI = new List<String>();
            empresasTI.Add("Microsoft");
            empresasTI.Add("Apple");
            empresasTI.Add("Alura");
            empresasTI.Add("Oracle");
            empresasTI.Add("IMB");
            empresasTI.Add("SAP");
            empresasTI.Add("Uber");
            empresasTI.Add("99Taxi");
            Preencher(empresasTI);

        }

        private void Preencher(List<String> empresasTI)
        {
            LIstResult.Children.Clear();
            foreach (var emp in empresasTI)
            {
                LIstResult.Children.Add(new Xamarin.Forms.Label { Text = emp });
            }
        }

        private void SB_TextChanged(object sender, TextChangedEventArgs e)
        {
            var resultado = empresasTI.Where(word => word.ToLower().Contains(e.NewTextValue.ToLower())).ToList<String>();
            Preencher(resultado);
        }

        private void SB_SearchButtonPressed(object sender, EventArgs e)
        {
            var resultado = empresasTI.Where(word => word.ToLower().Contains(SB.Text.ToLower())).ToList<String>();
            Preencher(resultado);
        }
    }
}