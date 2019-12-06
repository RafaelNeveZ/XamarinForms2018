using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TaregaApp.Modelo;

namespace TaregaApp.Telas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Inicio : ContentPage
    {
        public Inicio()
        {
            InitializeComponent();
            CultureInfo culture = new CultureInfo("pt-BR");
            string data = DateTime.Now.ToString("dddd, dd {0} MMMM {0} yyyy", culture);

            DataHoje.Text = string.Format(data,"de");
            CarregarLista();
        }

        private void CarregarLista()
        {
            SLTarefas.Children.Clear();
            List<Tarefa> tarefas = new List<Tarefa>();
            tarefas = new GerenciadorTarefas().ListagemNoProperties();
            int i = 0;
            foreach (Tarefa tarefa in tarefas)
            {
                LinhaStackLayout(tarefa, i);
                i++;
            }
        }

        public void LinhaStackLayout(Tarefa tarefa, int index)
        {
            
            StackLayout stacklayout = new StackLayout() { 
                Orientation = StackOrientation.Horizontal, 
                Spacing = 15 
            };

            Image check = new Image()
            {
                Source = ImageSource.FromFile("CheckOff.png"),
                VerticalOptions = LayoutOptions.Center,
            };

            TapGestureRecognizer checkTap = new TapGestureRecognizer();
            checkTap.Tapped += delegate
            {
                new GerenciadorTarefas().Finalizar(index, tarefa);
                CarregarLista();
            };
            check.GestureRecognizers.Add(checkTap);

            View Information = null;
            if(tarefa.Quando == null)
            {
                Information = new Label()
                {
                    VerticalOptions = LayoutOptions.Center,
                    HorizontalOptions = LayoutOptions.FillAndExpand,
                    Text = tarefa.Nome,
                    FontSize = 16
                };
            }
            else
            {
                Label nome = new Label()
                {
                    Text = tarefa.Nome,
                    TextColor = Color.LightGray,
                    FontSize = 16
                };

                Label data = new Label()
                {
                    Text = "Finalizado em " + tarefa.Quando.Value.ToString("dd/MM/yyyy") + " - " + tarefa.Quando.Value.ToString("hh:mm") + "h",
                    TextColor = Color.LightGray,
                    FontSize = 14
                };

                StackLayout centerStack = new StackLayout()
                {
                    VerticalOptions = LayoutOptions.Center,
                    HorizontalOptions = LayoutOptions.FillAndExpand,
                };

                centerStack.Children.Add(nome);
                centerStack.Children.Add(data);

                Information = centerStack;
            }

            Image prioridade = new Image()
            {
                Source = ImageSource.FromFile("p"+tarefa.Prioridade + ".png"),
                VerticalOptions = LayoutOptions.Center
            };

            Image Delete = new Image()
            {
                Source = ImageSource.FromFile("Delete.png"),
                VerticalOptions = LayoutOptions.Center
            };

            TapGestureRecognizer deleteTap = new TapGestureRecognizer();
            deleteTap.Tapped += delegate
            {
                new GerenciadorTarefas().Remover(index);
                CarregarLista();
            };
            Delete.GestureRecognizers.Add(deleteTap);

            if(tarefa.Quando != null)
            {
                check.Source = ImageSource.FromFile("CheckOn.png");
            }

            stacklayout.Children.Add(check);
            stacklayout.Children.Add(Information);
            stacklayout.Children.Add(prioridade);
            stacklayout.Children.Add(Delete);

            SLTarefas.Children.Add(stacklayout);

        }

        private void Cadastrar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Cadastro());
        }
    }
}