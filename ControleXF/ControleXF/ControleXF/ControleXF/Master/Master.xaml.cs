using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ControleXF.Master
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Master : MasterDetailPage
    {
        public Master()
        {
            InitializeComponent();
        }
        private void GoActivityIndicator(object sender, EventArgs e)
        {
            Detail = new Controles.ActivityLayoutPage();
            IsPresented = false;
        }
        private void GoProgressBar(object sender, EventArgs e)
        {
            Detail = new Controles.ProgressBarPage();
            IsPresented = false;
        }
        private void GoBoxView(object sender, EventArgs e)
        {
            Detail = new Controles.BoxViewPage();
            IsPresented = false;
        }
        private void GoLabel(object sender, EventArgs e)
        {
            Detail = new Controles.Label();
            IsPresented = false;
        }
        private void GoButton(object sender, EventArgs e)
        {
            Detail = new Controles.Buton();
            IsPresented = false;
        }
        private void GoEntryEditor(object sender, EventArgs e)
        {
            Detail = new Controles.GoEntryEditor();
            IsPresented = false;
        }
        private void GoDatePicker(object sender, EventArgs e)
        {
            Detail = new Controles.DatePickerPage();
            IsPresented = false;
        }
        private void GoTimePicker(object sender, EventArgs e)
        {
            Detail = new Controles.TimePickerPage();
            IsPresented = false;
        }
        private void GoPicker(object sender, EventArgs e)
        {
            Detail = new Controles.PickerPage();
            IsPresented = false;
        }
        private void GoSearchBar(object sender, EventArgs e)
        {
            Detail = new Controles.SearchBarPage();
            IsPresented = false;
        }
        private void GoSliderSteper(object sender, EventArgs e)
        {
            Detail = new Controles.SliderSteperPage();
            IsPresented = false;
        }
        private void GoSwitchPage(object sender, EventArgs e)
        {
            Detail = new Controles.SwitchPage();
            IsPresented = false;
        }
        private void GoImagePage(object sender, EventArgs e)
        {
            Detail = new Controles.ImagePage();
            IsPresented = false;
        }
        private void GoListView(object sender, EventArgs e)
        {
            Detail = new Controles.ListViewPage();
            IsPresented = false;
        }
        private void GoTableView(object sender, EventArgs e)
        {
            Detail = new Controles.TableViewPage();
            IsPresented = false;
        }
        private void GoWebView(object sender, EventArgs e)
        {
            Detail = new Controles.WebViewPage();
            IsPresented = false;
        }
    }
}
