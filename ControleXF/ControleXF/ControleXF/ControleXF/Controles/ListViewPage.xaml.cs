using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ControleXF.Modelo;

namespace ControleXF.Controles
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewPage : ContentPage
    {
        public ListViewPage()
        {
            InitializeComponent();
            List<Pessoa> lista = new List<Pessoa>();
            lista.Add(new Pessoa() { Nome = "José", Idade = 08 });
            lista.Add(new Pessoa() { Nome = "Maria", Idade = 32 });
            lista.Add(new Pessoa() { Nome = "Felipe", Idade = 15 });
            lista.Add(new Pessoa() { Nome = "João", Idade = 82 });
            lista.Add(new Pessoa() { Nome = "Roberto", Idade = 25 });

            ListaPessoas.ItemsSource = lista ;

        }

        private void ListaPessoas_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Pessoa pessoaClicada = (Pessoa) e.SelectedItem;
            DisplayAlert(pessoaClicada.Nome,"Sua idade é: " + pessoaClicada.Idade + ".","OK");
        }
    }
}