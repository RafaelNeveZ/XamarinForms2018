using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TaregaApp.Modelo;
using TaregaApp.Telas;

namespace TaregaApp.Telas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Cadastro : ContentPage
    {
        private byte prioridade { get; set; }
        public Cadastro()
        {
            InitializeComponent();
        }

        private void OKBT_Clicked(object sender, EventArgs e)
        {
            bool erroExise = false;
            if (!(TxtNome.Text.Trim().Length > 0))
            {
                erroExise = true;
                DisplayAlert("ERRO", "POR FAVOR INSITA ALGUM TEXTO.", "OK");

            }

            if (!(this.prioridade > 0))
            {
                erroExise = true;
                DisplayAlert("ERRO", "POR FAVOR ESCOLHA A PRIORIDADE.", "OK");
            }

            if (!erroExise)
            {
                Tarefa tarefa = new Tarefa() { Nome = TxtNome.Text.Trim(), Prioridade = this.prioridade };
                new GerenciadorTarefas().Salvar(tarefa);

                App.Current.MainPage = new NavigationPage(new Inicio());
                
            }
                

        }

        private void PrioridadeSelecionada(object sender, EventArgs e)
        {
            var Stacks = SLPrioridades.Children;

            foreach(var Linha in Stacks)
            {
                Label LblPrioriddade = ((StackLayout)Linha).Children[1] as Label;
                LblPrioriddade.TextColor = Color.LightGray;
            }

            ((Label)((StackLayout)sender).Children[1]).TextColor = Color.Black;
            FileImageSource source = ((Image)((StackLayout)sender).Children[0]).Source as FileImageSource;
            String Prioridade = source.File.ToString().Replace("File:", "").Replace(".png", "").Replace("p","");

            this.prioridade = byte.Parse(Prioridade);

        }
    }
}