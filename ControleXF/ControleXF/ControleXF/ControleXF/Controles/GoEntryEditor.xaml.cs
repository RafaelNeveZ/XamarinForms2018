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
    public partial class GoEntryEditor : ContentPage
    {
        public GoEntryEditor()
        {
            InitializeComponent();
            TxtIdade.TextChanged += delegate (object sender, TextChangedEventArgs args)
            {
                Lbl_Duplicado.Text = args.NewTextValue;
            };

            TxtComentario.Completed += delegate (object sender, EventArgs args)
            {
                LblQuantidadeC.Text = TxtComentario.Text.Length.ToString();
            };
                
        }
    }
}