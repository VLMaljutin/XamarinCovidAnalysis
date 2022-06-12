using Covid.Models_Forecast;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Covid.ForForecast.Russia_Forecast
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Infections_Russia_Chart_Day : ContentPage
    {
        public Infections_Russia_Chart_Day()
        {
            InitializeComponent();
        }
        private void picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            var name = picker.SelectedIndex;
            Infection_Forecast vm;
            switch (name)
            {
                case 0:
                    vm = new Infection_Forecast(7, 1, 2);
                    this.BindingContext = vm;
                    break;
                case 1:
                    vm = new Infection_Forecast(7, 2, 2);
                    this.BindingContext = vm;
                    break;
            }
        }
    }
}