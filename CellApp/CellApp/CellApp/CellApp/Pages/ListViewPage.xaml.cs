using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using CellApp.Modelo;
using CellApp.Detalhe;

namespace CellApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewPage : ContentPage
    {
        public ListViewPage()
        {
            InitializeComponent();
            List<Funcionario> lista = new List<Funcionario>
            {
                new Funcionario() { Nome = "Rogério Santos", Cargo = "Presidente", Foto = ImageSource.FromFile("perfil.jpg") },
                new Funcionario() { Nome = "Marta Nunes", Cargo = "Vice-Presidente", Foto = ImageSource.FromFile("perfil2.jpg") },
                new Funcionario() { Nome = "Bolo Comunista", Cargo = "Técnico", Foto = ImageSource.FromFile("perfil3.jpg") },
                new Funcionario() { Nome = "André Pascoal", Cargo = "Zelador", Foto = ImageSource.FromFile("perfil4.jpg") }
            };

            ListaFuncionario.ItemsSource = lista;
        }

        private void ListaFuncionario_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Funcionario funcionario = (Funcionario)e.SelectedItem;

            Navigation.PushAsync(new DetailPage(funcionario));

        }

        private void FeriasAction(object sender, EventArgs e)
        {
            MenuItem botao = (MenuItem)sender;
            Funcionario func = (Funcionario)botao.CommandParameter;

            DisplayAlert(func.Nome, func.Cargo + " Tirou Ferias", "OK");
        }

        private void AbonoAction(object sender, EventArgs e)
        {
            MenuItem botao = (MenuItem)sender;
            Funcionario func = (Funcionario)botao.CommandParameter;

            DisplayAlert(func.Nome, func.Cargo + " Abonado", "OK");
        }
    }
}