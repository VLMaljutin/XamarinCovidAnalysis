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
    public partial class Infection_Russia_Chart : ContentPage
    {
        public Infection_Russia_Chart()
        {
            Infection_Forecast vm = new Infection_Forecast(7);
            InitializeComponent();
            this.BindingContext = vm;
        }
    }
}