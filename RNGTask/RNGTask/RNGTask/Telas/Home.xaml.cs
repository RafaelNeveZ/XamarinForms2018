using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using RNGTask.Modelo;

namespace RNGTask.Telas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Home : ContentPage
    {
        public Home()
        {
            InitializeComponent();
            List<Tarefa> lista = new List<Tarefa>()
            {
                new Tarefa(){ Nome = "Comprar pão", Detalhe = "Comprar 5 pães de sal e 1 de leite.", DataEstimada = DateTime.Now, DataFinalizada = DateTime.Now.AddDays(1) },
                new Tarefa(){ Nome = "Passear com cão", Detalhe = "Levar Latifa e Fofatoba pra passer no parque.", DataEstimada = DateTime.Now.AddDays(3), DataFinalizada = DateTime.Now.AddDays(3) },
                new Tarefa(){ Nome = "Pagar Contas", Detalhe = "Pagar contas de água, luz e gás.", DataEstimada = DateTime.Now, DataFinalizada = DateTime.Now.AddDays(10) },
            };

            ListaTasks.ItemsSource = lista;

        }
    }
}