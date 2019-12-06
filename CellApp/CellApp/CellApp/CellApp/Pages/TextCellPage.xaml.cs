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
    public partial class TextCellPage : ContentPage
    {
        public TextCellPage()
        {
            InitializeComponent();
            List<Funcionario> lista = new List<Funcionario>();
            lista.Add(new Funcionario() { Nome = "Rafael Neves", Cargo = "Pedreiro", Foto = "Foto" });
            ListaFuncionario.ItemsSource = lista;

        }
    }
}