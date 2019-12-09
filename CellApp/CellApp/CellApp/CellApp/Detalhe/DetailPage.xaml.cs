using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using CellApp.Modelo;
namespace CellApp.Detalhe
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailPage : ContentPage
    {
       
        public DetailPage(Funcionario funcionario)
        {
            InitializeComponent();
            Foto.Source = funcionario.Foto;
            Nome.Text = funcionario.Nome;
            Cargo.Text = funcionario.Cargo;
        }
    }
}