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
        }
        private void GoProgressBar(object sender, EventArgs e)
        {
            Detail = new Controles.ProgressBarPage();
        }
        private void GoBoxView(object sender, EventArgs e)
        {
            Detail = new Controles.BoxViewPage();
        }
        private void GoLabel(object sender, EventArgs e)
        {
            Detail = new Controles.Label();
        }
        private void GoButton(object sender, EventArgs e)
        {
            Detail = new Controles.Buton();
        }
        private void GoEntryEditor(object sender, EventArgs e)
        {
            Detail = new Controles.GoEntryEditor();
        }
        private void GoDatePicker(object sender, EventArgs e)
        {
            Detail = new Controles.DatePickerPage();
        }
        private void GoTimePicker(object sender, EventArgs e)
        {
            Detail = new Controles.TimePickerPage();
        }
        private void GoPicker(object sender, EventArgs e)
        {
            Detail = new Controles.PickerPage();
        }
        private void GoSearchBar(object sender, EventArgs e)
        {
            Detail = new Controles.SearchBarPage();
        }
        private void GoSliderSteper(object sender, EventArgs e)
        {
            Detail = new Controles.SliderSteperPage();
        }
        private void GoSwitchPage(object sender, EventArgs e)
        {
            Detail = new Controles.SwitchPage();
        }
    }
}