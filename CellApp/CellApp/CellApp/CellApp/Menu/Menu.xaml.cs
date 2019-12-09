using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using CellApp.Pages;
namespace CellApp.Menu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu : MasterDetailPage
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void GoTextCell(object sender, EventArgs e)
        {

            Detail = new NavigationPage(new TextCellPage());
            IsPresented = false;
        }

        private void GoImageCell(object sender, EventArgs e)
        {

            Detail = new NavigationPage(new ImageCellPage());
            IsPresented = false;
        }

        private void GoEntryCell(object sender, EventArgs e)
        {

            Detail = new NavigationPage(new EntryCellPage());
            IsPresented = false;
        }

        private void GoSwitchCell(object sender, EventArgs e)
        {

            Detail = new NavigationPage(new SwitchCellPage());
            IsPresented = false;
        }

        private void GoViewCell(object sender, EventArgs e)
        {

            Detail = new NavigationPage(new ViewCellPage());
            IsPresented = false;
        }

        private void GoListView(object sender, EventArgs e)
        {

            Detail = new NavigationPage(new ListViewPage());
            IsPresented = false;
        }

        private void GoListViewButton(object sender, EventArgs e)
        {

            Detail = new NavigationPage(new ListViewButtonPage());
            IsPresented = false;
        }
    }
}