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
    public partial class ListViewButtonPage : ContentPage
    {
        public ListViewButtonPage()
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

        private void Button_Clicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Funcionario func = (Funcionario)button.CommandParameter;

            DisplayAlert("Nome: " + func.Nome, "O seu cargo é: " + func.Cargo + ".", "OK");

        }
    }
}