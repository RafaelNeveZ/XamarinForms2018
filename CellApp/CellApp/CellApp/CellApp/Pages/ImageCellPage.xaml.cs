using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using CellApp.Modelo;
namespace CellApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ImageCellPage : ContentPage
    {
        public ImageCellPage()
        {
            InitializeComponent();
            List<Funcionario> lista = new List<Funcionario>();
            lista.Add(new Funcionario() { Nome = "Rogério Santos", Cargo = "Presidente", Foto = ImageSource.FromFile("perfil.jpg") });
            lista.Add(new Funcionario() { Nome = "Marta Nunes", Cargo = "Vice-Presidente", Foto = ImageSource.FromFile("perfil2.jpg") });
            lista.Add(new Funcionario() { Nome = "Bolo Comunista", Cargo = "Técnico", Foto = ImageSource.FromFile("perfil3.jpg") });
            lista.Add(new Funcionario() { Nome = "André Pascoal", Cargo = "Zelador", Foto = ImageSource.FromFile("perfil4.jpg") });

            ListaFuncionario.ItemsSource = lista;
        }
    }
}